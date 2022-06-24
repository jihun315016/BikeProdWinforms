using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        public void LoadSendMail()
        {
            // System.Threading.Thread.Sleep(1500);
            MessageBox.Show("메일전송이 완료되었습니다.");
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


                string newPwd = CreatePwd();

                if (txtName.Text == empVo.EmpName && int.Parse(txtEmpNo.Text) == empVo.EmpNo && string.Concat(txtEmail.Text, "@", txtDomain.Text) == empVo.Email)
                {
                    SendEmail(empVo.EmpName, empVo.Email, newPwd);
                    bool result1 = logingSrv.ChangePassword(empNo, newPwd);
                    if (result1)
                    {
                        // 로딩폼
                        popLoading pop = new popLoading(LoadSendMail);
                        pop.ShowDialog();

                        this.Close();
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
                txtDomain.Enabled = false;
                txtDomain.Clear();
            }
            else if (cboDomain.SelectedIndex == 1) // 직접입력
            {
                txtDomain.Enabled = true;
                txtDomain.Focus();
                txtDomain.Clear();
            }
            else // 도메인 주소
            {
                txtDomain.Enabled = false;
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
            Boolean ismatch = IsMatch(@"^[0-9a-zA-Z]{1,50}$", txtEmail.Text);
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

        /// <summary>
        /// Author : 이진형
        /// 메일 발송
        /// </summary>
        /// <param name="name"></param>
        /// <param name="recipient"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public bool SendEmail(string name, string recipient, string newPwd)
        {
            string sender = ConfigurationManager.AppSettings["mailId"]; // 보내는 메일
            string password = ConfigurationManager.AppSettings["pwd"]; // 메일 비밀번호

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(sender, "신규 비밀번호 안내 메일", Encoding.UTF8);

            mail.To.Add(recipient);

            mail.Subject = "신규 비밀번호 안내";
            mail.Body = GetPwdMessage(name, newPwd);
            mail.IsBodyHtml = true;

            mail.SubjectEncoding = Encoding.UTF8;
            mail.BodyEncoding = Encoding.UTF8;

            SmtpClient SmtpServer = new SmtpClient("smtp.naver.com", 587);
            SmtpServer.Credentials = new NetworkCredential(sender, password);
            SmtpServer.EnableSsl = true;

            try
            {
                
               SmtpServer.Send(mail);
                return true;
            }
            catch (Exception err)
            {
                Debug.WriteLine(sender);
                Debug.WriteLine(password);
                Debug.WriteLine(recipient);
                Debug.WriteLine(err.Message);
                return false;
            }
            //return true;
        }

        /// <summary>
        /// Author : 이진형
        /// 메일 전송 내용
        /// </summary>
        /// <param name="name">사원 이름</param>
        /// <param name="password">신규 비밀번호</param>
        /// <returns></returns>
        string GetPwdMessage(string name, string password)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<strong>{name}님.</strong><br>");
            sb.Append("<hr/>");
            sb.Append("신규 비밀번호 발급 안내입니다.<br>");
            sb.Append("로그인 후, 비밀번호를 변경하여 주십시오.");
            sb.Append("<hr/>");
            sb.Append($"<h1>신규 비밀번호 : {password}</h1>");

            return sb.ToString();
        }

        /// <summary>
        /// Author : 이진형
        /// 신규 비밀번호 생성
        /// 0~35난수 0~9(숫자) 10~35(영어대문자 , A:65)
        /// </summary>
        /// <returns></returns>
        public string CreatePwd()
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                int temp = rnd.Next(0, 36);
                if (temp < 10)
                    sb.Append(temp);
                else
                    sb.Append((char)(temp + 55));
            }
            return sb.ToString();
        }

    }
}
