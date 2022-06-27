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

        public EmployeeVO GetEmpInfo(int empNo, string pwd)
        {
            LoginDAC dac = new LoginDAC();
            EmployeeVO empVO = dac.GetEmpInfo(empNo, pwd);
            dac.Dispose();
            return empVO;
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
                
    }
}
