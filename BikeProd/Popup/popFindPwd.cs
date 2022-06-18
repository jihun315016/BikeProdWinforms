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
    public partial class popFindPwd : bPopCommon
    {       
        public popFindPwd()
        {
            InitializeComponent();
        }

        private void popFindPwd_Load(object sender, EventArgs e)
        {
            txtName.isRequired = txtEmpNo.isRequired = txtEmail.isRequired = txtDomain.isRequired = true;
                        
            txtEmpNo.isNumeric = true;

            cboDomain.DropDownStyle = ComboBoxStyle.DropDownList;

            DomainListBinding();
        }

        /// <summary>
        /// Author : 이진형
        /// 사원 정보 확인후 신규 비밀번호 업데이트, 메일 발송
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            // 유효성 검사
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtName, txtEmpNo, txtEmail, txtDomain });
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
                return;
            }            

            // 입력한 개인 정보를 넘겨주고 해당 사원 정보 확인, 유효한지 체크(퇴사자)
            int empNo = int.Parse(txtEmpNo.Text);
            string empName = txtName.Text;
            string eMail = string.Concat(txtEmail.Text, "@", txtDomain.Text);

            LoginService logingSrv = new LoginService();
            EmployeeVO empVo = logingSrv.GetEmployeeInfo(empNo, empName, eMail);

            // 처리
            // 신규 비밀번호 생성, 업데이트, 메일 발송            
            if (empVo != null)
            {
                logingSrv = new LoginService();
                string newPwd = logingSrv.CreatePassword();

                if (txtName.Text == empVo.EmpName && int.Parse(txtEmpNo.Text) == empVo.EmpNo && string.Concat(txtEmail.Text, "@", txtDomain.Text) == empVo.Email)
                {
                    if (logingSrv.SendEmail(empVo.EmpName, empVo.Email, newPwd) && logingSrv.ChangePassword(empNo, newPwd))
                    {
                        this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Author : 이진형
        /// 도메인 콤보박스 선택에 따른 처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDomain.SelectedIndex == 0) // 선택
            {                
                txtDomain.ReadOnly = true;
                txtDomain.Clear();
            }
            else if (cboDomain.SelectedIndex == 1) // 직접입력
            {
                txtDomain.ReadOnly = false;
                txtDomain.Focus();
                txtDomain.Clear();
            }
            else // 도메인 주소
            {
                txtDomain.ReadOnly = true;
                txtDomain.Text = cboDomain.Text;
                txtDomain.Focus();
            }
        }

        /// <summary>
        /// Author : 이진형
        /// 콤보박스 이메일 도메인 주소 바인딩
        /// </summary>
        private void DomainListBinding()
        {
            cboDomain.Items.AddRange(new string[] { "선택", "직접입력", "naver.com", "gmail.com", "kakao.com", "daum.net" });
            cboDomain.SelectedIndex = 0;            
        }

        private bool IsMatch(string regex, string value)
        {
            Regex reg = new Regex(regex);
            return reg.IsMatch(value);
        }

        /// <summary>
        /// Author : 이진형
        /// 공백없는 영문 소문자 숫자 형식 유효성 검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Boolean ismatch = IsMatch(@"^[0-9a-z]{1,50}$", txtEmail.Text);
            if (!ismatch)
            {
                lblMessage1.Text = "이메일 : 영문자와 숫자만 입력해 주세요.";
                lblMessage1.ForeColor = Color.Red;
                txtEmail.Clear();
            }
            else
                lblMessage1.Text = "";
        }

        /// <summary>
        /// Author : 이진형
        /// 공백없는 영문 소문자 도메인(xxx.com)형식 유효성 검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDomain_Leave(object sender, EventArgs e)
        {            
            Boolean ismatch = IsMatch(@"^[a-z]+\.[a-z]{1,50}$", txtDomain.Text);
            if (!ismatch)
            {
                lblMessage2.Text = "메일주소 : 형식에 맞춰 영문자만 입력해 주세요.";
                lblMessage2.ForeColor = Color.Red;
                txtDomain.Clear();               
            }
            else
                lblMessage2.Text = "";
        }
               
    }
}
