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

namespace BikeProd
{
    public partial class popFindPwd : bPopCommon
    {       
        public popFindPwd()
        {
            InitializeComponent();
        }

        private void popFindPwd_Load(object sender, EventArgs e)
        {
            txtName.isRequired = true;
            txtEmail.isRequired = true;

            txtEmpNo.isRequired = true;
            txtEmpNo.isNumeric = true;

            cboDomain.DropDownStyle = ComboBoxStyle.DropDownList;

            DomainListBinding();
            
        }


        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtName, txtEmpNo, txtEmail, txtDomain });
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
                return;
            }

            if (cboDomain.SelectedIndex < 2) // 선택, 직접입력
            {
                MessageBox.Show("이메일 형식에 맞게 입력해주세요");
                return;
            }           

            int empNo = int.Parse(txtEmpNo.Text);
            string empName = txtName.Text;
            string eMail = string.Concat(txtEmail.Text, "@", txtDomain.Text);

            LoginService logingSrv = new LoginService();
            EmployeeVO empVo = logingSrv.GetEmployeeInfo(empNo, empName, eMail);

            if (empVo != null)
            {
                logingSrv = new LoginService();

                string newPwd = logingSrv.CreatePassword();

                if (txtName.Text == empVo.EmpName && int.Parse(txtEmpNo.Text) == empVo.EmpNo && string.Concat(txtEmail.Text, "@", txtDomain.Text) == empVo.Email)
                {
                    if (logingSrv.SendEmail(empVo.EmpName, empVo.Email, newPwd) && logingSrv.ChangePassword(empNo, newPwd))
                    {
                        MessageBox.Show("메일이 발송 되었습니다.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("메일 발송에 실패했습니다.");
                        return;
                    }
                }
            }
            MessageBox.Show("사원 정보를 확인해주세요.");
        }

        private void cboDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDomain.SelectedIndex == 0) // 선택 타이틀
            {
                txtDomain.Clear();
            }
            else if (cboDomain.SelectedIndex == 1) // 직접 입력
            {    
                txtDomain.Focus();                
            }
            else if (cboDomain.SelectedIndex > 1) // 도메인 선택
            {
                txtDomain.Text = cboDomain.Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DomainListBinding()
        {
            cboDomain.Items.Add("선택");
            cboDomain.SelectedIndex = 0;


            string[] domain = { "직접입력", "naver.com", "gmail.com", "kakao.com", "daum.net" };
            foreach (string dom in domain)
            {
                cboDomain.Items.Add(dom);
            }
        }
    }
}
