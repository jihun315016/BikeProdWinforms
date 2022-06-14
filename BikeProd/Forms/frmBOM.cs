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
    public partial class frmBOM : baseCommon
    {
        public frmBOM()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            popSelectSaveBOM pop1 = new popSelectSaveBOM();
            if (pop1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(pop1.selectedCode);
                //popSaveBOM pop2 = new popSaveBOM();
                //pop2.ShowDialog();
            }
        }
    }
}
