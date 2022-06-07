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
            ccTextBox1.PlaceHolder = "사번";
            ccTextBox1.SetPlaceHolder();
            ccTextBox1.isNumeric = true;            
            
            ccTextBox2.PlaceHolder = "비밀번호";            
            ccTextBox2.SetPlaceHolder();           

        }        

        private void btnLogin_Click(object sender, EventArgs e)
        {           
            LoginService login = new LoginService();                  
                                    
            //if (login.GetLoginInfo(ccTextBox1.Text.Trim(), ccTextBox2.Text.Trim()))
            //{               
            //    ((frmMenu)this.Owner).empNo = int.Parse(ccTextBox1.Text);  
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("사번과 비밀번호를 확인해 주세요");
            //}
        }

        private void lblFPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //popFindPwd pop = new popFindPwd();
            //pop.ShowDialog();
        }
    }
}
