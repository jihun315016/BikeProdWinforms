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
        PurchaseService srv = null;
        List<PurchaseVO> purList = null;

        public frmPurchase()
        {
            InitializeComponent();
        }

        private void frmBalJu_Load(object sender, EventArgs e)
        {
            
            DataGridViewUtil.SetInitGridView(dgvBaljuSeo);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBaljuSeo, "입고처", "BusinessNo", colWidth : 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBaljuSeo, "발주서", "PurchaseName", colWidth : 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBaljuSeo, "발주일자", "PurchaseNo", isVisible : false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBaljuSeo, "거래처번호", "BusinessNo", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBaljuSeo, "거래처 담당자", "Manager", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBaljuSeo, "발주일자", "PurchaseDate", colWidth : 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBaljuSeo, "도착일자", "ArriveDate", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBaljuSeo, "상태", "State" , colWidth : 70);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBaljuSeo, "도착일자", "SubManger", isVisible: false);
            LoadData();
        }
        public void LoadData()
        {
            srv = new PurchaseService();
            purList = srv.GetPurchase();
            dgvBaljuSeo.DataSource = purList;
            
        }


        private void ccTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
