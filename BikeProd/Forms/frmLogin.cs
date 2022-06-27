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
    public partial class frmLogin : bPopCommon
    {
        public EmployeeVO empVO { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmpNo.isNumeric = true;
            txtPwd.PasswordChar = '*';
            
#if DEBUG
            txtEmpNo.Text = "10001";
            txtPwd.Text = "1234";
#endif
        }        
        
        private void btnLogin_Click(object sender, EventArgs e)
        {            
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtEmpNo, txtPwd });
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
                return;
            }

            LoginService LoginSrv = new LoginService();
            empVO = LoginSrv.GetEmpInfo(Convert.ToInt32(txtEmpNo.Text.Trim()), txtPwd.Text.Trim());
           
            if (empVO != null)
            {
                this.DialogResult = DialogResult.OK;
                
            }
            else
            {
                MessageBox.Show("사원 정보를 확인해 주세요.");
            }
        }      

        // 비밀번호 찾기
        private void lblFPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            popFindPwd pop = new popFindPwd();
            pop.ShowDialog();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(this, null);
            }
        }
    }
}
