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
    public class DepartmentDAC : IDisposable
    {
        SqlConnection conn;
        public DepartmentDAC()
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
        /// Author: 정희록
        /// TB_Department의 전체데이터가져오기
        /// </summary>
        /// <returns></returns>
        public List<DepartmentVO> GetAllDeptInfo()
        {
            string sql = @"select DeptNo, DeptName from TB_Department";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return DBConverter.DataReaderToList<DepartmentVO>(cmd.ExecuteReader());
            }
        }


        /// <summary>
        /// Author: 정희록
        /// TB_Menu의 데이터 중 권한메뉴(lvl.2)만 가져오기
        /// </summary>
        /// <returns></returns>
        public List<MenuVO> GetMenuList()
        {
            string sql = @"select MenuID, MenuName, PntID, FrmName from TB_Menu where PntID is not null";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return DBConverter.DataReaderToList<MenuVO>(cmd.ExecuteReader());
            }
        }

        /// <summary>
        /// Author: 정희록
        /// 권한설정관련 부서 및 메뉴 join데이터 가져오기
        /// </summary>
        /// <returns></returns>
        public List<DeptMenuVO> GetAllDeptMenuInfo()
        {
            string sql = @"select D.DeptNo, D.MenuID, M.MenuName
                            from TB_DepartmentAuth D inner
                            join TB_Menu M on D.MenuID = M.MenuID";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return DBConverter.DataReaderToList<DeptMenuVO>(cmd.ExecuteReader());
            }
        }


        /// <summary>
        /// Author: 정희록
        /// 전체 메뉴 데이터 가져오기
        /// </summary>
        /// <returns></returns>
        public List<MenuVO> GetAllMenuList()
        {
            string sql = @"select MenuID, MenuName, PntID, FrmName from TB_Menu";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return DBConverter.DataReaderToList<MenuVO>(cmd.ExecuteReader());
            }
        }
        /// <summary>
        /// Author: 정희록
        /// 부서별 팀관련 데이터 가져오기
        /// </summary>
        /// <param name="DeptNo">부서번호</param>
        /// <returns></returns>
        public List<TeamVO> GetTeamInfo(int DeptNo)
        {
            string sql = @"select DeptNo, TeamName, TeamNo from TB_Team where DeptNo = @DeptNo";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@DeptNo", DeptNo);

                return DBConverter.DataReaderToList<TeamVO>(cmd.ExecuteReader());
            }
        }

        ///// <summary>
        ///// Author: 정희록
        ///// </summary>
        ///// <param name="DeptNo">부서번호</param>
        ///// <returns></returns>
        //public TeamVO GetTeamInfo(int DeptNo)
        //{            
        //    string sql = "select TeamName, DeptNo from TB_Team where DeptNo = @DeptNo";

        //    using (SqlCommand cmd = new SqlCommand(sql, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@DeptNo", DeptNo);

        //        List<TeamVO> list = Helper.DataReaderMapToList<TeamVO>(cmd.ExecuteReader());

        //        if (list != null && list.Count > 0)
        //            return list[0];
        //        else
        //            return null;
        //    }
        //}

        /// <summary>
        /// Author: 정희록
        /// 부서별 팀정보 데이터테이블로 가져오기 
        /// </summary>
        /// <param name="DeptNo"></param>
        /// <returns></returns>
        public DataTable GetTeamInfoTable(int DeptNo)
        {
            string sql = "select DeptNo, TeamName, TeamNo from TB_Team where DeptNo = @DeptNo";

            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@DeptNo", DeptNo);

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();

                return dt;
            }
        }

        /// <summary>
        /// Author: 정희록
        /// 부서별 권한정보중 이름만 가져오기
        /// </summary>
        /// <param name="DeptNo">부서번호</param>
        /// <returns></returns>
        public DeptMenuVO GetAuthMenuInfo(int DeptNo)
        {
            string sql = @"select D.DeptNo, D.MenuID, M.MenuName
                            from TB_DepartmentAuth D inner
                            join TB_Menu M on D.MenuID = M.MenuID
                            where DeptNo = @DeptNo";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@DeptNo", DeptNo);

                List<DeptMenuVO> list = DBConverter.DataReaderToList<DeptMenuVO>(cmd.ExecuteReader());

                if (list != null && list.Count > 0)
                    return list[0];
                else
                    return null;
            }
        }
        /// <summary>
        /// Author: 정희록
        /// 부서별 권한메뉴 가져오기
        /// </summary>
        /// <param name="DeptNo">부서번호</param>
        /// <returns></returns>
        public List<DeptMenuVO> GetAuthMenu(int DeptNo)
        {
            string sql = @"select D.DeptNo, D.MenuID, M.MenuName
                            from TB_DepartmentAuth D inner
                            join TB_Menu M on D.MenuID = M.MenuID
                            where DeptNo = @DeptNo";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@DeptNo", DeptNo);

                return DBConverter.DataReaderToList<DeptMenuVO>(cmd.ExecuteReader());
            }
        }

        /// <summary>
        /// Author: 강지훈
        /// 생산팀 번호와 이름 조회
        /// </summary>
        /// <returns></returns>
        public List<TeamVO> GetProductionTeeamList()
        {
            string sql = @"SELECT TeamNo, TeamName FROM TB_Team WHERE DeptNo = 1002";
            SqlCommand cmd = new SqlCommand(sql, conn);
            return DBConverter.DataReaderToList<TeamVO>(cmd.ExecuteReader());
        }


        /// <summary>
        /// Author: 정희록
        /// 부서별 메뉴 권한 등록
        /// </summary>
        /// <param name="authList">권한메뉴리스트</param>
        /// <param name="DeptNo">부서 번호</param>
        public bool SaveMenuAuth(List<int> authList, int DeptNo)
        {
            //using (SqlCommand cmd = new SqlCommand("SP_UpdateMenuAuth", conn))
            //{
            //    //@P_DeptNo int,
            //    //@P_auth_list nvarchar(max)
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    cmd.Parameters.AddWithValue("@P_DeptNo", DeptNo);
            //    cmd.Parameters.AddWithValue("@P_auth_list", string.Join(",", authList));                
            //}

            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"delete from TB_DepartmentAuth where DeptNo = @DeptNo";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DeptNo", DeptNo);
                    cmd.Transaction = trans;
                    cmd.ExecuteNonQuery();

                    sql = @"insert into TB_DepartmentAuth(DeptNo, MenuID)
                         values (@DeptNo, @MenuID)";

                    cmd.CommandText = sql;
                    cmd.Parameters.Add("@MenuID", SqlDbType.Int);

                    foreach (int MenuID in authList)
                    {
                        cmd.Parameters["@MenuID"].Value = MenuID;
                        cmd.ExecuteNonQuery();

                    }
                }
                trans.Commit();
                return true;

            }
            catch
            {
                trans.Rollback();
                return false;
            }

        }

        /// <summary>
        /// Author: 정희록
        /// 새로운 팀 등록
        /// </summary>
        /// <param name="deptNo"></param>
        /// <param name="teamName"></param>
        /// <returns></returns>
        public bool SaveTeam(int deptNo, string teamName)
        {
            using (SqlCommand cmd = new SqlCommand("SP_SaveTeam", conn))
            {                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PI_DEPTNO", deptNo);
                cmd.Parameters.AddWithValue("@PI_TeamName", teamName);

                int iRowAffect = cmd.ExecuteNonQuery();

                if (iRowAffect > 0)
                    return true;
                else
                    return false;
            }            
        }

        /// <summary>
        /// Author: 정희록
        /// 새로운 부서 등록하기
        /// </summary>
        /// <param name="deptName"></param>
        /// <returns></returns>
        public bool SaveDept(string deptName)
        {
            using (SqlCommand cmd = new SqlCommand("SP_SaveDept", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PI_DeptName", deptName);

                int iRowAffect = cmd.ExecuteNonQuery();

                if (iRowAffect > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Author: 정희록
        /// 부서삭제하기
        /// </summary>
        /// <param name="deptName"></param>
        /// <returns></returns>
        public bool DeleteDept(string deptName)
        {
            string sql = @"delete from TB_department where deptname = @deptname";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@deptname", deptName);

                int iRowAffect = cmd.ExecuteNonQuery();

                if (iRowAffect > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Author: 정희록
        /// 팀삭제
        /// </summary>
        /// <param name="teamName"></param>
        /// <returns></returns>
        public bool DeleteTeam(string teamName)
        {
            string sql = @"delete from TB_Team where teamname = @teamname";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@teamname", teamName);

                int iRowAffect = cmd.ExecuteNonQuery();

                if (iRowAffect > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Author: 정희록
        /// 전체 팀정보 가져오기
        /// </summary>
        /// <returns></returns>
        public List<TeamVO> GetAllTeamList()
        {
            string sql = @"select TeamNo, TeamName, DeptNo from TB_Team";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return DBConverter.DataReaderToList<TeamVO>(cmd.ExecuteReader());
            }
        }

        //private void GetTeamEmpInfo()
        //{
        //    string sql = @"select TeamNo from TB_Team where TeamName = @TeamName";

        //    using (SqlCommand cmd = new SqlCommand(sql, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@DeptNo", DeptNo);
        //        cmd.Transaction = trans;
        //        cmd.ExecuteNonQuery();

        //        sql = @"insert into TB_DepartmentAuth(DeptNo, MenuID)
        //                 values (@DeptNo, @MenuID)";

        //        cmd.CommandText = sql;
        //        cmd.Parameters.Add("@MenuID", SqlDbType.Int);

        //        foreach (int MenuID in authList)
        //        {
        //            cmd.Parameters["@MenuID"].Value = MenuID;
        //            cmd.ExecuteNonQuery();

        //        }
        //    }
        //}
    }
}
