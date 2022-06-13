﻿using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeProd
{
    public partial class frmPurchase : baseCommon
    {
        PurchaseService purchaseSrv = null;
        List<PurchaseVO> purchaseList = null;
        List<PurchaseDetailsVO> purDetailsList = null;
        List<PurchaseListVO> purchaseLists = null;

        public frmPurchase()
        {
            InitializeComponent();
        }

        private void frmBalJu_Load(object sender, EventArgs e)
        {
            
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주번호", "PurchaseNo", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "입고처", "BusinessNo", colWidth : 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주서", "PurchaseName", colWidth : 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주일자", "PurchaseNo", isVisible : false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래처번호", "BusinessNo", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래처 담당자", "Manager", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주일자", "PurchaseDate", colWidth : 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "도착일자", "ArriveDate", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "상태", "State" , colWidth : 70);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주담당자", "SubManger", isVisible: false);
            LoadData();
            List<CommonCodeVO> state = purchaseSrv.GetStateCommon();

            ComboBoxUtil.SetComboBoxByList(cboStateFilter, state, "Name", "Code");

            txtState.SetPlaceHolder();
            txtState.PlaceHolder = "상태";

            DataGridViewUtil.SetInitGridView(dgvList2);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "발주번호", "PurchaseNo", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "코드", "PartCode", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "모델명", "Name", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "수량", "Qty", colWidth: 80);

        }


        public void LoadData()
        {
            purchaseSrv = new PurchaseService();
            purchaseList = purchaseSrv.GetPurchase();
            dgvList.DataSource = purchaseList;
            
        }
        
        public void LoadData2()
        {
            /*int purNo = Convert.ToInt32(dgvList.SelectedRows[0].Cells["PurchaseNo"].Value);
            purchaseSrv = new PurchaseService();
            purchaseLists = purchaseSrv.GetPurchaseList(purNo);

            
            foreach(var list in purchaseLists)
            {
                //list.PurchaseNo.ToString;
            }

            dgvList2.DataSource = purchaseLists;*/
        }


        private void dgvList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string BusinessNo = (dgvList.SelectedRows[0].Cells["BusinessNo"].Value).ToString();
            string StateCode = (dgvList.SelectedRows[0].Cells["State"].Value).ToString();
            List<ClientVO> client = purchaseSrv.GetClientName(BusinessNo);
            List<CommonCodeVO> state = purchaseSrv.GetStateDetail(StateCode);
            
            DateTime dt = (DateTime)(dgvList.SelectedRows[0].Cells["ArriveDate"].Value);
            


            if (dt.ToString("yyyy-MM-dd").Equals("9998-12-31"))
            {
                dtpAliveDate.Enabled = false;
                dtpAliveDate.Text = dt.ToString("yyyy-MM-dd");
            }
            else
            {
                dtpAliveDate.Enabled = true;
                dtpAliveDate.Text = dt.ToString("yyyy-MM-dd");
            }
                

            txtPurNo.Text = (dgvList.SelectedRows[0].Cells["PurchaseNo"].Value).ToString();
            txtBusinessNo.Text = BusinessNo;
            txtPurName.Text = (dgvList.SelectedRows[0].Cells["PurchaseName"].Value).ToString();
            txtState.Text = state.Find((s) => s.Code == StateCode).Name;
            dtpPurDate.Text = (dgvList.SelectedRows[0].Cells["PurchaseDate"].Value).ToString();
            
            txtManager.Text = (dgvList.SelectedRows[0].Cells["Manager"].Value).ToString(); 
            txtSubManager.Text = (dgvList.SelectedRows[0].Cells["SubManger"].Value).ToString();
            txtClient.Text = client.Find((c)=>c.BusinessNo == BusinessNo).ClientName;
            txtAddress.Text = client.Find((a) => a.BusinessNo == BusinessNo).Address;

            
                LoadData2();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGetOK_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseVO update = new PurchaseVO();
                if ((dgvList.SelectedRows[0].Cells["State"].Value).ToString() != "OK")
                {
                    update.PurchaseNo = Convert.ToInt32(dgvList.SelectedRows[0].Cells["PurchaseNo"].Value);

                    update.State = "OK";
                    bool result = purchaseSrv.UpdateState(update);
                    if (!result)
                    {
                        MessageBox.Show("입고완료 되었습니다");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("오류가 발생하였습니다");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("이미 입고 완료된 발주서입니다");
                    return;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("오류발생");
            }
            
            
        }

        private void btnOrderCancle_Click(object sender, EventArgs e)
        {
            try
            {
                if ((dgvList.SelectedRows[0].Cells["State"].Value).ToString() != "Cancel")
                {
                    PurchaseVO update = new PurchaseVO();

                    update.PurchaseNo = Convert.ToInt32(dgvList.SelectedRows[0].Cells["PurchaseNo"].Value);
                    update.State = "Cancel";
                    bool result = purchaseSrv.UpdateState(update);
                    if (!result)
                    {
                        MessageBox.Show("취소되었습니다.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("오류가 발생하였습니다");
                    }
                }
                else
                {
                    MessageBox.Show("이미 취소된 상품입니다");
                }
            }catch(Exception err)
            {
                MessageBox.Show("오류가 발생하였습니다");
            }
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            popSavePur pop = new popSavePur();
            pop.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime purDate = dtpPurDate.Value;
            DateTime AliveDate = dtpAliveDate.Value;
            string ClientName = txtSearch.Text;
            string State = "";
            if (cboStateFilter.Text == "입고예정")
            {
                State = "In";
            }
            else if (cboStateFilter.Text == "입고완료") 
            {
                State = "OK";
            }else if (cboStateFilter.Text == "취소")
            {
                State = "Cancel";
            }
           
            
            purchaseList = purchaseSrv.getSearchList(ClientName,State,purDate,AliveDate);
            dgvList.DataSource = purchaseList;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            popSearchClient pop = new popSearchClient(false);
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtSearch.Text = pop.selectedClient.ClientName;
                txtSearch.Tag = pop.selectedClient.BusinessNo;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].Cells["State"].Value == null)
                return;

            // 데이터가 Red인 경우 배경색을 빨강으로 변경
            if (dgvList.Rows[e.RowIndex].Cells["State"].Value.ToString() == "Cancel")
            {
                e.CellStyle.BackColor = Color.Red;
                e.CellStyle.ForeColor = Color.White;
            }
            // 데이터가 Blue인 경우 배경색을 파랑으로 변경
            else if (dgvList.Rows[e.RowIndex].Cells["State"].Value.ToString() == "OK")
            {
                e.CellStyle.BackColor = Color.Blue;
                e.CellStyle.ForeColor = Color.White;
            }
            // 그 외의 경우 기본 디자인으로 보여준다
            else
            {
                e.CellStyle.BackColor = Color.White;
                e.CellStyle.ForeColor = Color.Black;
            }
           
        }
    }
}
