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
    public partial class popSaveOrder : bPopCommon
    {
        List<ProductVO> prodList;
        List<CommonCodeVO> commonList;
        List<OrderVO> orderList;
        List<OrderDetailsVO> orderDetailsList;
        OrderService orderSrv;

        string Addr;
        public popSaveOrder()
        {
            InitializeComponent();
        }

        private void popSaveOrder_Load(object sender, EventArgs e)
        {
            commonList = new List<CommonCodeVO>();
            orderSrv = new OrderService();
            commonList = orderSrv.GetProdCommon();

            commonList.Insert(0, new CommonCodeVO()
            {
                Category = "Category",
                Code = String.Empty,
                Name = "선택"
            });
            ComboBoxUtil.SetComboBoxByList<CommonCodeVO>(cboModel, commonList, "Name", "Code");

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주문번호", "OrderNo",isVisible:false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "제폼코드", "ProdCode");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "품목", "Category");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "제품명", "ProdName");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "수량", "Qty");


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtOrderName.isRequired = txtManager.isRequired = txtClientManager.isRequired = txtClient.isRequired = txtBusinessID.isRequired = txtAddr.isRequired = true;
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtOrderName, txtManager, txtClientManager, txtClient, txtBusinessID, txtAddr });
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
                return;
            }

            if(orderDetailsList == null)
            {
                MessageBox.Show("주문할 제품이 없습니다");
                return;
            }

            OrderVO orderList = new OrderVO()
            {
                OrderName = txtOrderName.Text,
                BusinessNo = txtBusinessID.Text,
                PManager = txtManager.Text,
                OrderDate = dtpOrderDate.Value,
                DeliveryDate = dtpdeliverDate.Value,
                Address = txtAddr.Text,
                State = "Out"
            };

            bool result = orderSrv.SaveOrders(orderList, orderDetailsList);
            if (result)
            {
                orderDetailsList.Clear();
                dgvList.DataSource = null;
                MessageBox.Show("등록이 완료되었습니다", "확인", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("등록 중 오류가 발생하였습니다.");         
                return;
            }



            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtClient_Enter(object sender, EventArgs e)
        {
            popSearchClient pop = new popSearchClient(true);
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtClientManager.Text = pop.selectedClient.Manager;
                txtClientManager.Tag = pop.selectedClient.BusinessNo;
                txtClient.Text = pop.selectedClient.ClientName;
                txtClient.Tag = pop.selectedClient.BusinessNo;
                txtBusinessID.Text = pop.selectedClient.BusinessNo;
                txtBusinessID.Tag = pop.selectedClient.BusinessNo;
                txtAddr.Text = pop.selectedClient.Address;
                txtAddr.Tag = pop.selectedClient.BusinessNo;
            }
        }

        private void btnAddr_Click(object sender, EventArgs e)
        {
            popSaveAddress pop = new popSaveAddress();
            if(pop.ShowDialog() == DialogResult.OK)
            {
                txtAddr.Text = pop.Address1;

                Addr = pop.Address1 + " " + pop.Address2;
            }
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ProductVO> list;
            prodList = orderSrv.GetProdList();
            list = prodList.FindAll(c => c.Category == cboModel.Text);
            list.Insert(0, new ProductVO()
            {
                ProdName = "제품명",
                ProdCode = String.Empty
            });
            ComboBoxUtil.SetComboBoxByList<ProductVO>(cboName, list, "ProdName", "ProdCode");
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void chkNull_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNull.Checked)
            {
                dtpdeliverDate.Value = new DateTime(9998, 12, 31);
                dtpdeliverDate.Enabled = false;
            }
            else
            {
                dtpdeliverDate.Value = DateTime.Today;
                dtpdeliverDate.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboModel.SelectedIndex < 1 || numQty.Value < 1)
            {
                MessageBox.Show("추가할 제품을 선택해 주세요");
                return;
            }

            if (orderDetailsList == null)
            {
                orderDetailsList = new List<OrderDetailsVO>();
            }

            int idx = orderDetailsList.FindIndex((p) => p.ProdCode == prodList.Find((c) => c.ProdName == cboName.Text).ProdCode);
            if (idx >= 0)
            {
                orderDetailsList[idx].Qty += (int)numQty.Value;
            }
            else
            {
                OrderDetailsVO newItem = new OrderDetailsVO
                {
                    Category = cboModel.Text,
                    ProdName = cboName.Text,
                    ProdCode = prodList.Find((p) => p.ProdName == cboName.Text).ProdCode,
                    Qty = (int)numQty.Value
                };
                orderDetailsList.Add(newItem);
            }

            cboModel.SelectedIndex = cboName.SelectedIndex = 0;
            numQty.Value = 0;

            dgvList.DataSource = null;
            dgvList.DataSource = orderDetailsList;
            dgvList.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 제품을 선택해 주세요");
                return;
            }
            if (orderDetailsList == null)
            {
                orderDetailsList = new List<OrderDetailsVO>();
            }

            string ptCode = dgvList.SelectedRows[0].Cells["ProdCode"].Value.ToString();

            OrderDetailsVO itemList = orderDetailsList.Find((p) => p.ProdCode == ptCode);
            orderDetailsList.Remove(itemList);
            dgvList.DataSource = null;
            dgvList.DataSource = orderDetailsList;
            dgvList.ClearSelection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
