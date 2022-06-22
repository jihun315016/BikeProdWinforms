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
    public partial class frmOrder : baseCommon
    {
        OrderService OrderSrv;
        ModelService modelSrv;
        List<OrderVO> OrderList;
        List<CommonCodeVO> StateList;
        List<ProductVO> prodList;
        List<OrderDetailsVO> orderDetailsList;
        List<BomInfoVO> bomList;

        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            txtBusinessNo.ReadOnly = txtAddress.ReadOnly = txtClient.ReadOnly = txtManager.ReadOnly =
                txtOrderName.ReadOnly = txtState.ReadOnly = txtSubManager.ReadOnly = txtOrderNo.ReadOnly =
                txtAliveDate.ReadOnly = txtOrderDate.ReadOnly = true;
            OrderSrv = new OrderService();
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주문번호", "OrderNo", colWidth: 80, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주문서이름", "OrderName", colWidth: 240);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래처번호", "BusinessNo", isVisible : false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래처명", "ClientName", colWidth: 220);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래처 담당자", "PManager", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주문일자", "OrderDate", colWidth: 110);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "출고일자", "DeliveryDate", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주소", "Address", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "상태", "StateName", colWidth: 70);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "상태", "State", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주문 담당자", "clientManager", isVisible: false);


            DataGridViewUtil.SetInitGridView(dgvList2);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "발주번호", "OrderNo", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "코드", "ProdCode", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "모델명", "ProdName", colWidth: 170);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "품목", "Category", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList2, "수량", "Qty", colWidth: 40);
            DataGridViewUtil.SetInitGridView(dgvList3);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList3, "발주번호", "OrderNo", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList3, "코드", "ProdCode", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList3, "모델명", "ProdName", colWidth: 170);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList3, "품목", "Category", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList3, "수량", "Qty", colWidth: 40);

            DataGridViewUtil.SetInitGridView(dgvList4);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList4, "제품코드", "Code", isVisible:false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList4, "부품코드", "Name", colWidth : 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList4, "부품명", "Name", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList4, "품목", "Category", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList4, "가격", "Price", isVisible : false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList4, "수량", "Requirement", colWidth: 60);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList4, "가격", "Total", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList4, "재고", "Relation", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList4, "재고", "Inventory", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList4, "재고", "LeadTime", isVisible: false);

            LoadData();

            StateList = OrderSrv.GetStateCommon();
            StateList.Insert(0, new CommonCodeVO
            { Name = "상태" });
            ComboBoxUtil.SetComboBoxByList(cboStateFilter, StateList, "Name", "Code");

            txtState.SetPlaceHolder();
            txtState.PlaceHolder = "상태";

            dtpFrom.Value = dtpTo.Value.AddDays(-7);
        }
        
        private void LoadData()
        {
            OrderList = null; 
            OrderList = OrderSrv.GetOrderList();
            dgvList.DataSource = OrderList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            popSaveOrder pop = new popSaveOrder();
            if(pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("등록이 완료되었습니다.");
                LoadData();
            }
        }

        private void dgvList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int OrderNo = Convert.ToInt32(dgvList.SelectedRows[0].Cells["OrderNo"].Value);
            
            txtOrderNo.Text = OrderNo.ToString();
            txtOrderName.Text = (dgvList.SelectedRows[0].Cells["OrderName"].Value).ToString();
            txtBusinessNo.Text = (dgvList.SelectedRows[0].Cells["BusinessNo"].Value).ToString();
            txtManager.Text = (dgvList.SelectedRows[0].Cells["PManager"].Value).ToString();
            txtOrderDate.Text = ((DateTime)dgvList.SelectedRows[0].Cells["OrderDate"].Value).ToShortDateString();
            //txtAliveDate.Text = ((DateTime)dgvList.SelectedRows[0].Cells["DeliveryDate"].Value).ToShortDateString();

            if (((DateTime)dgvList.SelectedRows[0].Cells["DeliveryDate"].Value).ToString("yyyy-MM-dd") == "9998-12-31")
            {
                txtAliveDate.Text = "";
                txtAliveDate.Enabled = true;
            }
            else
            {
                txtAliveDate.Text = ((DateTime)dgvList.SelectedRows[0].Cells["DeliveryDate"].Value).ToString("yyyy-MM-dd");
            }
            txtAddress.Text = (dgvList.SelectedRows[0].Cells["Address"].Value).ToString();
            txtState.Text = (dgvList.SelectedRows[0].Cells["StateName"].Value).ToString();
            txtClient.Text = (dgvList.SelectedRows[0].Cells["clientName"].Value).ToString();
            txtSubManager.Text = (dgvList.SelectedRows[0].Cells["clientManager"].Value).ToString();


            orderDetailsList = OrderSrv.GetOrderDetails();
            orderDetailsList = orderDetailsList.FindAll((d) => d.OrderNo == OrderNo).ToList();

            dgvList2.DataSource = dgvList3.DataSource = orderDetailsList;


            dgvList4.DataSource = null;

        }

        private void dgvList_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].Cells["State"].Value == null)
                return;

            else if (dgvList.Rows[e.RowIndex].Cells["State"].Value.ToString() == "Out")
            {
                e.CellStyle.ForeColor = Color.Blue;

            }
            else
            {
                e.CellStyle.BackColor = Color.White;
                e.CellStyle.ForeColor = Color.Black;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            popSaveOrder pop = new popSaveOrder();
            if(pop.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBusinessNo.Text = txtAddress.Text = txtClient.Text = txtManager.Text =
                txtOrderName.Text = txtState.Text = txtSubManager.Text = txtOrderNo.Text =
                txtAliveDate.Text = txtOrderDate.Text = "";



            dtpTo.Value = DateTime.Now;
            dtpFrom.Value = dtpTo.Value.AddDays(-7);
            cboStateFilter.SelectedIndex = 0;

            LoadData();
            dgvList2.DataSource = dgvList3.DataSource = dgvList4.DataSource = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<OrderVO> list = OrderSrv.GetSearchOrderList(dtpFrom.Value, dtpTo.Value);

            if (cboStateFilter.SelectedIndex > 0)
                list = list.FindAll(p => p.StateName == cboStateFilter.Text);

            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text != txtSearch.PlaceHolder)
                list = list.FindAll(p => p.ClientName.ToLower().Contains(txtSearch.Text.ToLower()));

            
            dgvList.DataSource = null;
            dgvList.DataSource = list;
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                OrderVO update = new OrderVO();
                String State = (dgvList.SelectedRows[0].Cells["State"].Value).ToString();

                if (State != "OK" && State == "Out")
                {
                    update.OrderNo = Convert.ToInt32(dgvList.SelectedRows[0].Cells["OrderNo"].Value);
                    update.State = "OK";
                    
                    bool result = OrderSrv.UpdateState(update);

                    if (result)
                    {
                        OrderSrv.UpdateStateOK(update.OrderNo);
                        MessageBox.Show("출고완료 되었습니다");
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
                    MessageBox.Show("이미 출고 완료된 발주서입니다");
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string State = (dgvList.SelectedRows[0].Cells["State"].Value).ToString();
                if (State != "Cancel" && State == "Out")
                {
                    OrderVO update = new OrderVO();

                    update.OrderNo = Convert.ToInt32(dgvList.SelectedRows[0].Cells["OrderNo"].Value);
                    update.State = "Cancel";
                    bool result = OrderSrv.UpdateState(update);
                    if (result)
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
                    MessageBox.Show("이미 출고 완료된 상품입니다.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("오류가 발생하였습니다");
            }
        }

        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].Cells["State"].Value == null)
                return;

            else if (dgvList.Rows[e.RowIndex].Cells["State"].Value.ToString() == "Out")
            {
                //e.CellStyle.BackColor = Color.Blue;
                e.CellStyle.ForeColor = Color.Blue;

            }
            else
            {
                e.CellStyle.BackColor = Color.White;
                e.CellStyle.ForeColor = Color.Black;
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvList3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modelSrv = new ModelService();
            string pcode = (dgvList3.SelectedRows[0].Cells["ProdCode"].Value).ToString();
            List<BomInfoVO> list = modelSrv.GetBomRelation(pcode);
            dgvList4.DataSource = null;
            dgvList4.DataSource = list;
            
        }
    }
}
