using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.DAC
{
    public class ProductDAC : IDisposable
    {
        SqlConnection conn;

        public ProductDAC()
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
        /// 제품과 부품에 대한 카테고리 목록 조회
        /// 조회된 데이터는 제품 / 부품 등록 팝업에서 데이터 초기화에 사용된다.
        /// </summary>
        /// <returns>조회된 카테고리 리스트</returns>
        public List<CommonCodeVO> GetCategory()
        {
            string sql = "SP_GetModelCategoryInfo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<CommonCodeVO>(reader);
        }

        public void SaveProductOrPart()
        {

        }
    }
}
