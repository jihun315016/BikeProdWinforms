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
    public partial class frmProduction : bFrmList
    {
        public frmProduction()
        {
            InitializeComponent();
        }

        private void frmProduction_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveProduction_Click(object sender, EventArgs e)
        {
            popSaveProduction pop = new popSaveProduction();
            pop.ShowDialog();
        }
    }
}
