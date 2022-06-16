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
        public popSaveOrder()
        {
            InitializeComponent();
        }

        private void popSaveOrder_Load(object sender, EventArgs e)
        {
            

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
            }
        }
    }
}
