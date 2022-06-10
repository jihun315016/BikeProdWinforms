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
    public class ModelDAC : IDisposable
    {
        SqlConnection conn;

        public ModelDAC()
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
        /// 제품과 부품에 대한 카테고리 목록 조회
        /// 조회된 데이터는 제품 / 부품 등록 팝업에서 데이터 초기화에 사용된다.
        /// </summary>
        /// <returns>조회된 카테고리 리스트</returns>
        public List<CommonCodeVO> GetCategory()
        {
            string sql = @"SELECT Code, Name, Category, cc.LastNum
	                        FROM TB_CommonCode c
	                        JOIN TB_CodeCnt cc ON c.Code = cc.StartCode
	                        WHERE c.Category in ('제품', '부품')";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<CommonCodeVO>(reader);
        }

        /// <summary>
        /// Author : 강지훈
        /// 제품과 부품에 대한 기본적인 정보 조회
        /// </summary>
        /// <returns></returns>
        public List<ProdPartVO> GetModelList()
        {
            string sql = @"SELECT ProdCode Code, ProdName Name, 
	                            CASE WHEN IsFinished = 1 THEN '완제품' ELSE '반제품' END Kind, 
	                            Category, Price, Inventory, Dealing
                            FROM TB_Products
                            UNION
                            SELECT 
	                            PartCode Code, PartName Name, '부품' Kind, Category, 
	                            Price, Inventory, Dealing
                            FROM TB_Parts";

            SqlCommand cmd = new SqlCommand(sql, conn);            
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<ProdPartVO>(reader);
        }

        /// <summary>
        /// Author : 강지훈
        /// 제품 또는 부품 등록
        /// 등록된 모델의 코드에 따라 CodeCnt도 1씩 증가한다.
        /// </summary>
        /// <param name="product">등록할 제품 정보</param>
        /// <param name="startCode">등록할 제품 코드(BRK, VEL, MTB ...)</param>
        /// <returns>제품 등록 성공 여부</returns>
        /// <exception cref="Exception"></exception>
        public bool SaveModel(ProductVO product, PartVO part, string startCode)
        {
            string sql = "SP_SaveModel";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // 제품 등록
            if (part == null)
            {
                cmd.Parameters.AddWithValue("@Code", product.ProdCode);
                cmd.Parameters.AddWithValue("@Name", product.ProdName);
                cmd.Parameters.AddWithValue("@IsFinished", product.IsFinished);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@LeadTime", product.LeadTime);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Image", product.Image);
                cmd.Parameters.AddWithValue("@StartCode", startCode);
                cmd.Parameters.AddWithValue("@BusinessNo", string.Empty);
                cmd.Parameters.AddWithValue("@SfInvn", 0);
                cmd.Parameters.AddWithValue("@Unit", 0);
            }

            // 부품 등록
            else
            {
                cmd.Parameters.AddWithValue("@Code", part.PartCode);
                cmd.Parameters.AddWithValue("@Name", part.PartName);
                cmd.Parameters.AddWithValue("@IsFinished", 0);
                cmd.Parameters.AddWithValue("@Category", part.Category);
                cmd.Parameters.AddWithValue("@LeadTime", 0);
                cmd.Parameters.AddWithValue("@Price", part.Price);
                cmd.Parameters.AddWithValue("@Image", part.Image);
                cmd.Parameters.AddWithValue("@StartCode", startCode);
                cmd.Parameters.AddWithValue("@BusinessNo", part.BusinessNo);
                cmd.Parameters.AddWithValue("@SfInvn", part.SfInvn);
                cmd.Parameters.AddWithValue("@Unit", part.Unit);
            }

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
