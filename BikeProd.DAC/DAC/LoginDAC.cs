using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.DAC
{
    public class LoginDAC : IDisposable
    {
        SqlConnection conn;

        public LoginDAC()
        {
            string connStr = ConfigurationManager.ConnectionStrings["bike"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        /// <summary>
        /// Author : 강지훈
        /// 입력 받은 직원 권한에 맞는 메뉴 조회
        /// </summary>
        /// <param name="empNo">직원 번호</param>
        /// <returns>직원이 사용할 수 있는 메뉴 리스트</returns>
        public List<MenuVO> GetMenuList(int empNo)
        {
            SqlCommand cmd = new SqlCommand("SP_GetMenuList", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empNo", empNo);
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<MenuVO>(reader);
        }

        /// <summary>
        /// Author : 강지훈
        /// 로그인 정보 조회
        /// 로그인 실패시 null 리턴
        /// </summary>
        /// <param name="empNo">로그인에 사용되는 사번</param>
        /// <param name="pwd">비밀번호</param>
        /// <returns></returns>
        public EmployeeVO GetEmpInfo(int empNo, string pwd)
        {
            string sql = @"SELECT EmpNo, EmpName, DeptName
                            FROM TB_Employees e
                            JOIN TB_Department d ON e.DeptNo = d.DeptNo
                            WHERE EmpNo = @EmpNo 
                            AND Pwd = @Pwd 
                            AND ToDate is null or ToDate = '9998-12-31'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmpNo", empNo);
            cmd.Parameters.AddWithValue("@Pwd", pwd);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                EmployeeVO empVO = new EmployeeVO()
                {
                    EmpNo = Convert.ToInt32(reader["EmpNo"]),
                    EmpName = reader["EmpName"].ToString(),
                    DeptName = reader["DeptName"].ToString()
                };

                return empVO;
            }
            return null;
        }        

        /// <summary>
        /// /// Authur: 이진형
        /// 사번, 이름, 이메일로 현재 근무중인 사원 조회
        /// </summary>
        /// <param name="EmpNo">사번</param>
        /// <param name="EmpName">이름</param>
        /// /// <param name="Email">이메일</param>
        /// <returns></returns>
        public EmployeeVO GetEmployeeInfo(int EmpNo, string EmpName, string Email)
        {
            string sql = @"select EmpNo, EmpName, Email, Pwd, ToDate
                            from TB_Employees
                            where EmpNo = @EmpNo and EmpName = @EmpName and Email = @Email and ToDate is null";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                cmd.Parameters.AddWithValue("@EmpName", EmpName);
                cmd.Parameters.AddWithValue("@Email", Email);

                List<EmployeeVO> list = DBConverter.DataReaderToList<EmployeeVO>(cmd.ExecuteReader());

                if (list != null && list.Count > 0)
                    return list[0];
                else
                    return null;
            }
        }


        /// <summary>
        /// /// Authur: 이진형
        /// 신규 비밀번호 업데이트
        /// </summary>
        /// <param name="empNo">사번</param>
        /// <param name="newPwd">신규 비밀번호</param>
        /// <returns></returns>
        public bool ChangePassword(int empNo, string newPwd)
        {
            string sql = @"UPDATE TB_Employees 
                           SET Pwd = @Pwd 
                           WHERE EmpNo = @EmpNo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@EmpNo", empNo);
            cmd.Parameters.AddWithValue("@Pwd", newPwd);

            int iRowAffect;
            try
            {
                iRowAffect = cmd.ExecuteNonQuery();

                if (iRowAffect > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception err)
            {
                //Debug.WriteLine(err.Message);
                return false;
            }
        }
    }
}
