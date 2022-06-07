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
        /// 정희록
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
        /// 정희록
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
        /// 정희록
        /// 부서별 팀관련 데이터 가져오기
        /// </summary>
        /// <param name="DeptNo">부서번호</param>
        /// <returns></returns>
        public List<TeamVO> GetAllTeamInfo(int DeptNo)
        {
            string sql = @"select DeptNo, TeamName, TeamNo from TB_Team where DeptNo = @DeptNo";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@DeptNo", DeptNo);

                return DBConverter.DataReaderToList<TeamVO>(cmd.ExecuteReader());
            }
        }

        ///// <summary>
        ///// 정희록
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
        /// 정희록
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
        /// 정희록
        /// 부서별 권한메뉴 가져오기
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
    }
}
