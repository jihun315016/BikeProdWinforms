using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;

namespace BikeProd
{
    public class LoginService
    {
        public List<MenuVO> GetMenuList(int empNo)
        {
            LoginDAC dac = new LoginDAC();
            List<MenuVO> list = dac.GetMenuList(empNo);
            dac.Dispose();
            return list;
        }

        /// <summary>
        /// Author : 이진형
        /// 로그인 체크 0 보다 크면 로그인 성공
        /// </summary>
        /// <param name="id">사번</param>
        /// <param name="pwd">비밀번호</param>
        /// <returns></returns>
        public bool GetLoginInfo(string id, string pwd)
        {
            int empNo;

            if (!int.TryParse(id, out empNo))
                return false;

            LoginDAC dac = new LoginDAC();
            bool result = dac.GetLoginInfo(empNo, pwd) > 0;
            dac.Dispose();

            return result;
        }       

        /// <summary>
        /// Author : 이진형
        /// 사번, 이름, 이메일로 해당 사원 조회
        /// </summary>
        /// <param name="EmpNo">사번</param>
        /// <param name="EmpName">사원 이름</param>
        /// /// <param name="Email">이메일</param>
        /// <returns></returns>
        public EmployeeVO GetEmployeeInfo(int EmpNo, string EmpName, string Email)
        {
            LoginDAC dac = new LoginDAC();
            EmployeeVO result = dac.GetEmployeeInfo(EmpNo, EmpName, Email);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author : 이진형
        /// 신규 비밀번호 생성
        /// </summary>
        /// <returns></returns>
        public string CreatePassword()
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                int temp = rnd.Next(0, 36); //0~35난수 0~9(숫자) 10~35(영어대문자 , A:65)
                if (temp < 10)
                    sb.Append(temp);
                else
                    sb.Append((char)(temp + 55));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Author : 이진형 
        /// 비밀번호 변경
        /// </summary>
        /// <param name="empNo">변경 사번</param>
        /// <param name="newPwd">신규 비밀번호</param>
        /// <returns></returns>
        public bool ChangePassword(int empNo, string newPwd)
        {
            LoginDAC dac = new LoginDAC();
            bool result = dac.ChangePassword(empNo, newPwd);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author : 이진형
        /// 메일 전송
        /// </summary>
        /// <param name="name">수신 사원</param>
        /// <param name="recipient">수신자 메일</param>
        /// <param name="newPwd">신규 비밀번호</param>
        /// <returns></returns>
        public bool SendEmail(string name, string recipient, string newPwd)
        {
            string sender = ConfigurationManager.AppSettings["mailId"]; // 보내는 메일
            string password = ConfigurationManager.AppSettings["pwd"]; // 메일 비밀번호

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(sender, "신규 비밀번호 안내 메일", Encoding.UTF8);

            mail.To.Add(recipient);

            mail.Subject = "신규 비밀번호 안내";
            mail.Body = GetPassworkMessage(name, newPwd);
            mail.IsBodyHtml = true;

            mail.SubjectEncoding = Encoding.UTF8;
            mail.BodyEncoding = Encoding.UTF8;

            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
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
        string GetPassworkMessage(string name, string password)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<strong>{name}</strong>님.<br>");
            sb.Append("신규 비밀번호 발급 안내입니다.<br>");
            sb.Append("로그인 후, 비밀번호를 변경하여 주십시오.");
            sb.Append($"<h1>신규 비밀번호 : {password}</h1>");

            return sb.ToString();
        }        
    }
}
