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
    public partial class popSaveClient : bPopCommon
    {
        public popSaveClient()
        {
            InitializeComponent();
        }

        private void btnZipCodeSearch_Click(object sender, EventArgs e)
        {
            popSaveZipCode pop = new popSaveZipCode();
            pop.ShowDialog();
        }
    }
}
