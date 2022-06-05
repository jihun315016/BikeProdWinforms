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
    }
}
