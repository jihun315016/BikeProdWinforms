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
    public partial class frmProduct : bFrmListAndDetail
    {       
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            popSaveModel pop = new popSaveModel();
            pop.ShowDialog();
        }
    }
}
