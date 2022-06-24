using BikeProd;
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
    public partial class popSavePur : bPopCommon
    {

        List<ProdPartVO> prodPartList;
        List<PurchaseListVO> purchaseList;
        List<PartVO> partList;
        PurchaseService purchaseSrv;
        ModelService modelSrv;
        ClientService clientSrv;
        public popSavePur()
        {
            InitializeComponent();
        }
        private void popSavePur_Load(object sender, EventArgs e)
        {
            modelSrv = new ModelService();
            purchaseSrv = new PurchaseService();
            prodPartList = modelSrv.GetModelList();
            
            var categoryes = (from model in prodPartList
                    where model.Kind.Equals("부품")
                    group model by model.Category);

            List<CommonCodeVO> list = new List<CommonCodeVO>();            
            foreach (var cate in categoryes)
            {
                list.Add(new CommonCodeVO() { Code = cate.Key, Name = cate.Key, Category = "Category" });
            }

            list.Insert(0, new CommonCodeVO()
            {
                Category = "Category",
                Code = String.Empty,
                Name = "선택"
            });

            ComboBoxUtil.SetComboBoxByList<CommonCodeVO>(cboModel, list, "Name", "Code");

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주번호", "PurchaseNo", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "코드", "PartCode", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "모델명", "Name", colWidth: 170);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "품목", "Category", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "수량", "Qty", colWidth: 60);
        }

        private void chkNull_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNull.Checked)
            {
                dtpAliveDate.Value = new DateTime(9998, 12, 31);
                dtpAliveDate.Enabled = false;
            }
            else
            {
                dtpAliveDate.Value = DateTime.Today;
                dtpAliveDate.Enabled = true;
            }
        }
        private void txtBusiness_Enter(object sender, EventArgs e)
        {
            popSearchClient pop = new popSearchClient(false);
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtSubManager.Text = pop.selectedClient.Manager;
                txtSubManager.Tag = pop.selectedClient.BusinessNo;
                txtBusiness.Text = pop.selectedClient.ClientName;
                txtBusiness.Tag = pop.selectedClient.BusinessNo;
            }
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
                /*cboName.DataSource = null;
                cboName.Items.Add("부품명");
                cboName.SelectedIndex = 0;*/
            
                List<ProdPartVO> list;
                list = modelSrv.GetModelList();
                list = prodPartList.FindAll(c => c.Category == cboModel.Text);
                list.Insert(0, new ProdPartVO()
                {
                    Name = "부품명",
                    Code = String.Empty
                });
                ComboBoxUtil.SetComboBoxByList<ProdPartVO>(cboName, list, "Name", "Code");
        }
        /// <summary>
        /// Auther : 류경석
        /// 발주 품목 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboModel.SelectedIndex < 1 || numQty.Value < 1)
            {
                MessageBox.Show("추가할 부품을 선택해 주세요");
                return;
            }

            if (purchaseList == null)
            {
                purchaseList = new List<PurchaseListVO>();
            }

            int idx = purchaseList.FindIndex((p) => p.PartCode == prodPartList.Find((c) => c.Name == cboName.Text).Code);
            if (idx >= 0)
            {
                purchaseList[idx].Qty += (int)numQty.Value;
            }
            else
            {
                PurchaseListVO newItem = new PurchaseListVO
                {
                    Category = cboModel.Text,
                    Name = cboName.Text,
                    PartCode = prodPartList.Find((p) => p.Name == cboName.Text).Code,
                    Qty = (int)numQty.Value
                };
                purchaseList.Add(newItem);
            }

            cboModel.SelectedIndex = cboName.SelectedIndex = 0;
            numQty.Value = 0;

            dgvList.DataSource = null;
            dgvList.DataSource = purchaseList;
            //dgvList.ClearSelection();
        }
        
        /// <summary>
        /// Auther : 류경석
        /// 발주서 등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(purchaseList == null)
            {
                MessageBox.Show("발주할 부품이 없습니다");
                return;
            }
            txtPurName.isRequired = txtBusiness.isRequired = txtBusinessID.isRequired = txtManager.isRequired = txtSubManager.isRequired = true;
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtPurName, txtBusiness, txtBusinessID, txtManager, txtSubManager });

            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
                return;
            }
            PurchaseVO purlist = new PurchaseVO()
            {
                PurchaseName = txtPurName.Text,
                BusinessNo = txtBusinessID.Text,
                PManager = txtManager.Text,
                PurchaseDate = dtpPurDate.Value,
                ArriveDate = dtpAliveDate.Value,
                State = "In"
            };

            bool result = purchaseSrv.SavePurchase(purlist, purchaseList);
            if (result)
            {
                purchaseList.Clear();
                dgvList.DataSource = null;
                MessageBox.Show("등록이 완료되었습니다","확인",MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("등록 중 오류가 발생하였습니다.");
                return;
            }
        }
        /// <summary>
        /// 류경석
        /// 거래처명 선택 시 사업자번호 자동 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBusiness_TextChanged(object sender, EventArgs e)
        {
            clientSrv = new ClientService();
            List<ClientVO> clientList = clientSrv.GetClientNameByType(false);

            txtBusinessID.Text = clientList.Find((c) => c.ClientName == txtBusiness.Text).BusinessNo.ToString();

        }
        /// <summary>
        /// Author : 류경석
        /// 취소버튼 클릭 -> 팝업창 닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 부품을 선택해 주세요");
                return;
            }
            if (purchaseList == null)
            {
                purchaseList = new List<PurchaseListVO>();
            }

            string ptCode = dgvList.SelectedRows[0].Cells["PartCode"].Value.ToString();

            PurchaseListVO itemList = purchaseList.Find((p) => p.PartCode == ptCode);
            purchaseList.Remove(itemList);

            dgvList.DataSource = null;
            dgvList.DataSource = purchaseList;
            dgvList.ClearSelection();
        }

        private void popSavePur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            partList = purchaseSrv.GetUnit();

            PartVO partUnit = partList.FindAll((p) => p.PartName.Equals(cboName.Text)).FirstOrDefault();

            if (partUnit != null)
            {
                numQty.Value = partUnit.Unit;
                numQty.Increment = (partUnit.Unit > 0)? partUnit.Unit : 1;
            }
            else
            {
                numQty.Value = 0;
            }


        }
    }
}
