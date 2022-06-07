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
    public class MedelDAC : IDisposable
    {
        SqlConnection conn;

        public MedelDAC()
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

        /// <summary>
        /// 제품 등록
        /// 등록된 제품 코드에 따라 CodeCnt도 1씩 증가한다.
        /// </summary>
        /// <param name="product">등록할 제품 정보</param>
        /// <param name="startCode">등록할 제품 코드(BRK, VEL, MTB ...)</param>
        /// <returns>제품 등록 성공 여부</returns>
        /// <exception cref="Exception"></exception>
        public bool InsertProd(ProductVO product, string startCode)
        {
            string sql = "SP_SaveProd";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProdCode", product.ProdCode);
            cmd.Parameters.AddWithValue("@ProdName", product.ProdName);
            cmd.Parameters.AddWithValue("@IsFinished", product.IsFinished);
            cmd.Parameters.AddWithValue("@Category", product.Category);
            cmd.Parameters.AddWithValue("@LeadTime", product.LeadTime);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Image", product.Image);
            cmd.Parameters.AddWithValue("@StartCode", startCode);

            try
            {
                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
                return false;
            }
        }
    }
}
