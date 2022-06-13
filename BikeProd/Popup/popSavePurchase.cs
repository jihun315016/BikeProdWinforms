using BikeProd.Service;
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

        List<ProdPartVO> prodPartList = null;
        List<CommonCodeVO> commonList = null;
        List<PurchaseDetailsVO> purchaseDetailsList = null;
        List<PurchaseListVO> purchaseList = null;
        PurchaseService purchaseSrv = null;
        ModelService modelSrv = null;
        ClientService clientSrv = null;
        public popSavePur()
        {
            InitializeComponent();
        }

        private void popAddBalJu_Load(object sender, EventArgs e)
        {
            modelSrv = new ModelService();
            purchaseSrv = new PurchaseService();
            commonList = purchaseSrv.getCategory();
            prodPartList = modelSrv.GetModelList();
            commonList.Insert(0, new CommonCodeVO()
            {
                Category = "선택",
            });
            ComboBoxUtil.SetComboBoxByList(cboCate, commonList, "Category", "Category");
            cboCate.SelectedIndex = 0;
        }
        public void DataGirdView()
        {
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "발주서", "PurchaseNo", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "제품명", "PartCode");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "수량", "Qty");
        }

        private void cboCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelSrv = new ModelService();
            commonList = modelSrv.GetCategory();
            if (cboCate.SelectedIndex == 0)
            {
                cboModel.DataSource = null;
                cboModel.Items.Add("품목");
                cboModel.SelectedIndex = 0;
            }
            else
            {
                List<CommonCodeVO> list;
                if (cboCate.Text == "제품")
                    list = commonList.FindAll(c => c.Category == "제품");
                else
                    list = commonList.FindAll(c => c.Category == "부품");

                list.Insert(0, new CommonCodeVO()
                {
                    Name = "품목",
                    Code = String.Empty
                });
                ComboBoxUtil.SetComboBoxByList<CommonCodeVO>(cboModel, list, "Name", "Code");
            }
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
                txtBusiness.Text = pop.selectedClient.ClientName;
                txtBusiness.Tag = pop.selectedClient.BusinessNo;
            }
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (cboCate.SelectedIndex == 0)
            {
                cboName.DataSource = null;
                cboName.Items.Add("제품명");
                cboName.SelectedIndex = 0;
            }
            else
            {
                List<ProdPartVO> list;
                
                list = prodPartList.FindAll(c => c.Category == cboModel.Text);
                list.Insert(0, new ProdPartVO()
                {
                    Name = "제품명",
                    Code = String.Empty
                });
                ComboBoxUtil.SetComboBoxByList<ProdPartVO>(cboName, list, "Name", "Code");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboName.SelectedIndex < 1 || numQty.Value < 1)
            {
                MessageBox.Show("추가할 제품을 선택해 주세요");
                return;
            }

            if (purchaseDetailsList == null)
            {
                purchaseDetailsList = new List<PurchaseDetailsVO>();
            }

            int idx = purchaseDetailsList.FindIndex((p) => p.PartCode == prodPartList.Find((c) => c.Name == cboName.Text).Code);
            if (idx >= 0)
            {
                purchaseDetailsList[idx].Qty += (int)numQty.Value;
            }
            else
            {
                PurchaseDetailsVO newItem = new PurchaseDetailsVO
                {

                    PartCode = prodPartList.Find((p) => p.Name == cboName.Text).Code,
                    Qty = (int)numQty.Value
                };
                purchaseDetailsList.Add(newItem);
            }
            dgvList.DataSource = null;
            DataGirdView();
            dgvList.DataSource = purchaseDetailsList;
            dgvList.ClearSelection();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            
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
                Manager = txtManager.Text,
                SubManger = txtSubManager.Text,
                PurchaseDate = dtpPurDate.Value,
                ArriveDate = dtpAliveDate.Value,
                State = "In"
            };

            bool result = purchaseSrv.SavePurchase(purlist, purchaseDetailsList);
            if (result)
            {
                purchaseDetailsList.Clear();
                dgvList.DataSource = null;
                MessageBox.Show("등록이 완료되었습니다");
            }
            else
            {
                MessageBox.Show("등록 중 오류가 발생하였습니다.");         
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

    }
}
