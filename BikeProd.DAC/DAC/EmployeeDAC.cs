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
                cmd.CommandText = "SP_SaveEmployee";
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
        public bool UpdateOut(int EmpNo, string ToDate,string Return)
        {
            //ToDate = '2022-06-05';
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_UpdateOutEmployees";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                cmd.Parameters.AddWithValue("@ToDate", ToDate);
                cmd.Parameters.AddWithValue("@Return", Return);
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
        }

        

        /// <summary>
        /// 류경석
        /// 사원전체정보 가져오기
        /// </summary>
        /// <returns></returns>
        public List<EmployeeVO> GetEmployeesAllList()
        {
            List<EmployeeVO> list = new List<EmployeeVO>();

            string sql = @"select EmpNo, EmpName, emp.DeptNo as DeptNo,DeptName, emp.TeamNo as TeamNo,TeamName, Phone, Email, Pwd, FromDate, ToDate 
                            from TB_Employees emp join TB_Department dept on emp.DeptNo = dept.DeptNo
                            join TB_Team t on emp.TeamNo = t.TeamNo";
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
                string sql = @"select DeptName, DeptNo
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
                string sql = @"select TeamName, TeamNo
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
        /// Author: 정희록
        /// 전체 팀정보 및 사원정보 가져오기
        /// </summary>
        /// <returns></returns>
        public List<TeamEmpVO> GetAllEmpTeamInfo()
        {
            string sql = @"select EmpNo, EmpName, E.DeptNo, E.TeamNo, TeamName ,Phone, FromDate 
                            from TB_Employees E inner join TB_Team T on E.DeptNo = T.DeptNo
                            where E.DeptNo = T.DeptNo
                            and E.TeamNo = T.TeamNo";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {                
                return DBConverter.DataReaderToList<TeamEmpVO>(cmd.ExecuteReader());
            }
        }

        /// <summary>
        /// 정희록
        /// 부서별 팀정보 및 사원정보 가져오기
        /// </summary>
        /// <param name="DeptNo">부서번호</param>
        /// <returns></returns>
        public List<TeamEmpVO> GetEmpTeamInfo(int DeptNo)
        {
            string sql = @"select EmpNo, EmpName, E.DeptNo, E.TeamNo, TeamName ,Phone, FromDate 
                             from TB_Employees E inner join TB_Team T on E.DeptNo = T.DeptNo
                            where E.DeptNo = T.DeptNo
                            and E.TeamNo = T.TeamNo
                            and E.DeptNo = @DeptNo";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@DeptNo", DeptNo);

                return DBConverter.DataReaderToList<TeamEmpVO>(cmd.ExecuteReader());
            }
        }

        /// <summary>
        /// 정희록
        /// 검색조건(팀번호, 사원이름) 사원정보 가져오기
        /// </summary>
        /// <param name="TeamNo">팀번호</param>
        /// <param name="EmpName">사원이름</param>
        /// <returns></returns>
        public EmployeeVO searchEmpInfo(int TeamNo, string EmpName)
        {
            string sql = @"SP_GetEmpInfo";

            //WITH teamnoCTE AS
            //(
            //    SELECT EmpNo, EmpName, DeptNo, TeamNo, Phone, FromDate

            //    FROM TB_Employees

            //    WHERE TeamNo = @TeamNo
            //)
            //SELECT EmpNo, EmpName, DeptNo, TeamNo, Phone, FromDate
            //FROM TB_Employees
            //WHERE EmpName = @EmpName

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

        /// <summary>
        /// Author : 강지훈
        /// 사용자 비밀번호 변경
        /// </summary>
        /// <param name="empNo"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool UpdateEmpPwd(int empNo, string pwd)
        {
            string sql = @"UPDATE TB_Employees 
                            SET Pwd = @Pwd
                            WHERE EmpNo = @EmpNo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Pwd", pwd);
            cmd.Parameters.AddWithValue("@EmpNo", empNo);

            try
            {
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
