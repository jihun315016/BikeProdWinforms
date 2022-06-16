using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeProd.VO;

namespace BikeProd
{
    public partial class popSaveClient : bPopCommon
    {
        ClientService clientSrv = new ClientService();
        public popSaveClient()
        {
            InitializeComponent();
        }

        private void btnZipCodeSearch_Click(object sender, EventArgs e)
        {
            popSaveAddress pop = new popSaveAddress();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtClientName, txtAddr1, txtManager, txtMPhone, txtCPhone, txtEmail });
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
                return;
            }

            if (cboType.SelectedIndex == 0)
            {
                MessageBox.Show("분류를 선택해주세요");
                return;
            }
            
            ClientVO client = new ClientVO
            {
                ClientName = txtClientName.Text,
                BusinessNo = txtBusinessNo.Text,
                Type = cboType.Text,
                Address = string.Concat(txtAddr1.Text, txtAddr2.Text),
                Manager = txtManager.Text,
                ManagerPhone = txtMPhone.Text,
                CompanyPhone = txtMPhone.Text,
                Email = string.Concat(txtEmail.Text, "@", txtDomain.Text)            
            };
            bool result = clientSrv.SaveClient(client);

            if (result)
            {
                MessageBox.Show($"[{client.ClientName}] : 등록완료.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("등록 중 오류가 발생했습니다.");
                return;
            }


        }

        private void popSaveClient_Load(object sender, EventArgs e)
        {
            cboType.Items.AddRange(new string[] { "구분", "입고", "출고" });
            cboType.SelectedIndex = 0;

            txtAddrCode.ReadOnly = txtAddr1.ReadOnly = txtAddr2.ReadOnly = true;

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
