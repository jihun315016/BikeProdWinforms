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
        PurchaseService purchaseSrv;
        List<OrderVO> OrderList;
        List<CommonCodeVO> StateList;
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
            OrderList = OrderSrv.GetOrderAllList();


            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주문번호", "OrderNo", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주문서이름", "OrderName", colWidth: 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래처번호", "BusinessNo", colWidth: 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "고객 담당자", "Manager", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주문일자", "OrderDate", colWidth: 100);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "출고일자", "DeliveryDate", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주소", "Address", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "상태", "State", colWidth: 90);
            LoadData();

            StateList = OrderSrv.GetStateCommon();
            StateList.Insert(0, new CommonCodeVO
            { Name = "상태" });
            ComboBoxUtil.SetComboBoxByList(cboStateFilter, StateList, "Name", "Code");

            txtState.SetPlaceHolder();
            txtState.PlaceHolder = "상태";

            dtpTo.Value = dtpFrom.Value.AddDays(7);
        }
        
        private void LoadData()
        {
            dgvList.DataSource = OrderList;
        }
    }
}
