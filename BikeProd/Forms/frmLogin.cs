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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmpNo.PlaceHolder = "사번";
            txtEmpNo.SetPlaceHolder();
            txtEmpNo.isNumeric = true;            
            
            txtPwd.PlaceHolder = "비밀번호";            
            txtPwd.SetPlaceHolder();

            txtPwd.LostFocus += TxtPwd_LostFocus;
            txtPwd.GotFocus += TxtPwd_GotFocus;
        }

        private void TxtPwd_GotFocus(object sender, EventArgs e)
        {
            ccTextBox txt = (ccTextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (txt == txtPwd)
                    txtPwd.PasswordChar = '*';
            }
        }

        private void TxtPwd_LostFocus(object sender, EventArgs e)
        {
            ccTextBox txt = (ccTextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {                
                if (txt == txtPwd)
                    txtPwd.PasswordChar = default;
            }
        }

        // 로그인 버튼
        private void btnLogin_Click(object sender, EventArgs e)
        {            
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtEmpNo, txtPwd });
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
                return;
            }

            LoginService LoginSrv = new LoginService();

            if (LoginSrv.GetLoginInfo(txtEmpNo.Text.Trim(), txtPwd.Text.Trim()))
            {
                //((frmMenu)this.Owner).empNo = int.Parse(txtEmpNo.Text);
                //this.DialogResult = DialogResult.OK;
                //this.Close();
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
    }
}
