using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeProd.VO;
//using System.Windows.Forms.DataVisualization.Charting; // Series

namespace BikeProd
{
    public partial class frmTotalChart : bFrmList
    {
        PurchaseService purchaseSrv;
        //List<PurchaseStateVO> purchaseChart;        

        public frmTotalChart()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            purchaseSrv = new PurchaseService();
            DataTable dtChart = purchaseSrv.GetTopChart();

            chart1.DataSource = dtChart; //.Rows[0];
            chart1.Series[0].XValueMember = "PartCode";
            chart1.Series[0].YValueMembers = "Qty";
            chart1.DataBind();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
