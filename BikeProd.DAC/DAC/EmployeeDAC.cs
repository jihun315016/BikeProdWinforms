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
    public class EmployeeDAC : IDisposable
    {
        SqlConnection conn;

        public EmployeeDAC()
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
        /// Authur: 류경석
        /// 사원정보 등록
        /// </summary>
        /// <param name="emp">EmployeeVO</param>
        /// <returns></returns>
        public bool AddEmployees(EmployeeVO emp)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_Employee";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);
                cmd.Parameters.AddWithValue("@TeamNo", emp.TeamNo);
                cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Pwd", emp.Pwd);
                cmd.Parameters.AddWithValue("@FromDate", emp.FromDate);


                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
        }

        /// <summary>
        /// 류경석
        /// 사원 퇴사처리
        /// </summary>
        /// <param name="EmpNo"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public bool UpdateOut(int EmpNo, string ToDate)
        {
            //ToDate = '2022-06-05';
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_UpdateOutEmployees";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                cmd.Parameters.AddWithValue("@ToDate", ToDate);

                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
        }

        /// <summary>
        /// 류경석
        /// 사원정보 가져오기
        /// </summary>
        /// <returns></returns>
        public List<EmployeeVO> GetEmployeesAllList()
        {
            List<EmployeeVO> list = new List<EmployeeVO>();

            string sql = @"select EmpNo, EmpName, DeptNo, TeamNo, Phone, Email, Pwd, FromDate, ToDate 
                           from TB_Employees";


            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<EmployeeVO>(cmd.ExecuteReader());
            }

            return list;
        }

        /// <summary>
        /// 류경석
        /// 재직중인 사원 조회
        /// </summary>
        /// <returns></returns>
        public List<EmployeeVO> GetWorkingList()
        {
            List<EmployeeVO> list = new List<EmployeeVO>();

            string sql = @"select EmpNo, EmpName, DeptNo, TeamNo, Phone, Email, Pwd, FromDate, ToDate 
                           from TB_Employees
                           where ToDate Is null ";


            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<EmployeeVO>(cmd.ExecuteReader());
            }

            return list;
        }

        /// <summary>
        /// 퇴사한 사원 조회
        /// </summary>
        /// <returns></returns>
        public List<EmployeeVO> GetOutList()
        {
            List<EmployeeVO> list = new List<EmployeeVO>();

            string sql = @"select EmpNo, EmpName, DeptNo, TeamNo, Phone, Email, Pwd, FromDate, ToDate 
                           from TB_Employees
                           where ToDate Is not null ";


            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<EmployeeVO>(cmd.ExecuteReader());
            }
            return list;
        }

        /// <summary>
        /// 류경석
        /// 부서정보 가져오기
        /// </summary>
        /// <returns></returns>
        public List<DepartmentVO> GetCodeByDept()
        {
            try
            {
                string sql = @"select DeptName
                                from TB_Department
                                where DeptName <> 'Admin'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return DBConverter.DataReaderToList<DepartmentVO>(cmd.ExecuteReader());
            }
            catch (Exception err)
            {
                //string msg = $"{err.Message} ::=> GetCodeByDept() => {string.Join(",", Depts)}";
                return null;
            }
        }

        /// <summary>
        /// 류경석
        /// 팀 정보 가져오기
        /// </summary>
        /// <returns></returns>
        public List<TeamVO> GetCodeByTeam(int DeptNo)
        {
            try
            {
                string sql = @"select TeamName 
                                from TB_Team T inner join TB_Department d on t.DeptNo = d.DeptNo
                                where t.DeptNo = @DeptNo";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DeptNo", DeptNo);
                return DBConverter.DataReaderToList<TeamVO>(cmd.ExecuteReader());
            }
            catch (Exception err)
            {
                //string msg = $"{err.Message} ::=> GetCodeByDept() => {string.Join(",", Depts)}";
                return null;
            }
        }

        /// <summary>
        /// 류경석
        /// 검색정보가져오기
        /// </summary>
        /// <param name="dept"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<EmployeeVO> GetSearchList(int dept, string name)
        {
            string sql = @"select EmpNo, EmpName, DeptNo, TeamNo, Phone, Email, Pwd, FromDate, ToDate
                            from TB_Employees
                            where DeptNo = @DeptNo and EmpName = @EmpName ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@DeptNo", dept);
            cmd.Parameters.AddWithValue("@EmpName", name);

            return DBConverter.DataReaderToList<EmployeeVO>(cmd.ExecuteReader());
        }

        /// <summary>
        /// 정희록
        /// 부서별 사원정보 가져오기
        /// </summary>
        /// <param name="DeptNo">부서번호</param>
        /// <returns></returns>
        public List<EmployeeVO> GetEmpInfo(int DeptNo)
        {
            string sql = @"select EmpNo, EmpName, DeptNo, TeamNo, Phone, FromDate from TB_Employees where DeptNo = @DeptNo";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@DeptNo", DeptNo);

                return DBConverter.DataReaderToList<EmployeeVO>(cmd.ExecuteReader());
            }
        }

        /// <summary>
        /// 정희록
        /// 팀별 사원정보 가져오기
        /// </summary>
        /// <param name="TeamNo">팀번호</param>
        /// <param name="EmpName">사원이름</param>
        /// <returns></returns>
        public EmployeeVO searchEmpInfo(int TeamNo, string EmpName)
        {
            string sql = @"SP_GetEmpInfo";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TeamNo", TeamNo);
                cmd.Parameters.AddWithValue("@EmpName", EmpName);

                List<EmployeeVO> list = DBConverter.DataReaderToList<EmployeeVO>(cmd.ExecuteReader());

                if (list != null && list.Count > 0)
                    return list[0];
                else
                    return null;
            }
        }
    }
}
