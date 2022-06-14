using BikeProd.VO;
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
        PurchaseService purchaseSrv;
        ClientService clientSrv;
        List<PurchaseVO> purchaseList;
        List<PurchaseListVO> purchaseLists;
        List<CommonCodeVO> StateList;
        List<ClientVO> clientList;

        public frmPurchase()
        {
            InitializeComponent();
        }

        private void frmBalJu_Load(object sender, EventArgs e)
        {
            txtBusinessNo.ReadOnly = txtAddress.ReadOnly = txtClient.ReadOnly = txtManager.ReadOnly =
                txtPurName.ReadOnly = txtState.ReadOnly = txtSubManager.ReadOnly = txtPurNo.ReadOnly = 
                txtAliveDate.ReadOnly = txtPurDate.ReadOnly = true;
           

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주번호", "PurchaseNo", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "입고처", "BusinessNo", colWidth : 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주서", "PurchaseName", colWidth : 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주일자", "PurchaseNo", isVisible : false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래처번호", "BusinessNo", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래처 담당자", "Manager", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주일자", "PurchaseDate", colWidth : 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "도착일자", "ArriveDate", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "상태", "State" , colWidth : 70);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주담당자", "SubManger", isVisible: false);
            LoadData();
            
            DataGridViewUtil.SetInitGridView(dgvList2);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "발주번호", "PurchaseNo", isVisible : false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "코드", "PartCode", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "모델명", "Name", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "품목", "Category", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "수량", "Qty", colWidth: 80);

            StateList = purchaseSrv.GetStateCommon();
            ComboBoxUtil.SetComboBoxByList(cboStateFilter, StateList, "Name", "Code");

            txtState.SetPlaceHolder();
            txtState.PlaceHolder = "상태";
        }

        /// <summary>
        /// Auther : 류경석
        /// 발주서 리스트
        /// </summary>
        public void LoadData()
        {
            purchaseSrv = new PurchaseService();
            purchaseList = purchaseSrv.GetPurchase();
            dgvList.DataSource = purchaseList;
        }
        /// <summary>
        /// Auther : 류경석
        /// 발주 품목 상세보기
        /// </summary>
        public void LoadData2()
        {
            int purNo = Convert.ToInt32(dgvList.SelectedRows[0].Cells["PurchaseNo"].Value);
            purchaseSrv = new PurchaseService();
            purchaseLists = purchaseSrv.GetPurchaseList(purNo); 
            dgvList2.DataSource = purchaseLists;
        }

        /// <summary>
        /// Auther : 류경석
        /// DataGridView 셀 더블클릭 -> 발주서 상세보기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clientSrv = new ClientService();
            string BusinessNo = (dgvList.SelectedRows[0].Cells["BusinessNo"].Value).ToString();
            string StateCode = (dgvList.SelectedRows[0].Cells["State"].Value).ToString();

            clientList = clientSrv.GetClientList();
            List<CommonCodeVO> state = purchaseSrv.GetStateDetail(StateCode);
            

            
            txtPurNo.Text = (dgvList.SelectedRows[0].Cells["PurchaseNo"].Value).ToString();
            txtBusinessNo.Text = BusinessNo;
            txtPurName.Text = (dgvList.SelectedRows[0].Cells["PurchaseName"].Value).ToString();
            txtState.Text = state.Find((s) => s.Code == StateCode).Name;
            txtPurDate.Text = ((DateTime)dgvList.SelectedRows[0].Cells["PurchaseDate"].Value).ToString("yyyy-MM-dd");
            txtAliveDate.Text = ((DateTime)dgvList.SelectedRows[0].Cells["ArriveDate"].Value).ToString("yyyy-MM-dd");
            txtManager.Text = (dgvList.SelectedRows[0].Cells["Manager"].Value).ToString();
            txtSubManager.Text = clientList.Find((c) => c.BusinessNo == BusinessNo).Manager;
            txtClient.Text = clientList.Find((c)=>c.BusinessNo == BusinessNo).ClientName;
            txtAddress.Text = clientList.Find((a) => a.BusinessNo == BusinessNo).Address;

            LoadData2();
        }
        /// <summary>
        /// Auther :  류경석
        /// 발주등록 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            popSavePur pop = new popSavePur();
            if(pop.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Auther : 류경석
        /// 거래처 TextBox 클릭 -> 거래처 선택 폼 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            popSearchClient pop = new popSearchClient(false);
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtSearch.Text = pop.selectedClient.ClientName;
                txtSearch.Tag = pop.selectedClient.BusinessNo;
            }
        }

        /// <summary>
        /// Auther : 류경석
        /// 상태에 따른 데이터그리드뷰 셀 색상 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].Cells["State"].Value == null)
                return;

            if (dgvList.Rows[e.RowIndex].Cells["State"].Value.ToString() == "Cancel")
            {
                e.CellStyle.BackColor = Color.Red;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (dgvList.Rows[e.RowIndex].Cells["State"].Value.ToString() == "OK")
            {
                e.CellStyle.BackColor = Color.Blue;
                e.CellStyle.ForeColor = Color.White;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
                e.CellStyle.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Auther : 류경석
        /// 입고완료 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseVO update = new PurchaseVO();
                string State = (dgvList.SelectedRows[0].Cells["State"].Value).ToString();

                if (State != "OK" && State == "In")
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
                else if (State == "OK")
                {
                    MessageBox.Show("이미 입고 완료된 발주서입니다");
                    return;
                }
                else if (State == "Cancel")
                {
                    MessageBox.Show("이미 취소된 발주서입니다");
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("오류발생");
            }
        }
        /// <summary>
        /// Auther : 류경석
        /// 검색버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime purDate = dtpFrom.Value;
            DateTime AliveDate = dtpTo.Value;
            string ClientName = txtSearch.Text;
            StateList = purchaseSrv.GetStateCommon();
            string State = StateList.Find((s) => s.Name == cboStateFilter.Text).Code;

            if (purchaseList == null)
            {
                purchaseList = purchaseSrv.GetPurchase();
            }

            purchaseList = purchaseSrv.getSearchList(ClientName, State, purDate, AliveDate);
            dgvList.DataSource = purchaseList;
        }
        /// <summary>
        /// Auther :류경석
        /// 발주취소 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string State = (dgvList.SelectedRows[0].Cells["State"].Value).ToString();
                if (State != "Cancel" && State == "In")
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
                else if (State == "Cancel")
                {
                    MessageBox.Show("이미 취소된 상품입니다");
                }
                else if (State == "OK")
                {
                    MessageBox.Show("이미 입고 완료된 상품입니다.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("오류가 발생하였습니다");
            }
        }
    }
}
