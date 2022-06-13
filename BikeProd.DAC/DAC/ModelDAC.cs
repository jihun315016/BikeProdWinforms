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
	                            Category, Price, Inventory, Dealing, Image
                            FROM TB_Products
                            UNION
                            SELECT 
	                            PartCode Code, PartName Name, '부품' Kind, Category, 
	                            Price, Inventory, Dealing, Image
                            FROM TB_Parts";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<ProdPartVO>(reader);
        }

        /// <summary>
        /// Author : 강지훈
        /// 특정 부품에 대한 거래처명과 재고 정보 조회
        /// </summary>
        /// <param name="PartCode"></param>
        /// <returns></returns>
        public PartVO GetPartClientAndQtyInfo(string PartCode)
        {
            string sql = @"WITH partCTE AS
                        (
	                        SELECT Image, BusinessNo, SfInvn, TotInvn, Unit
	                        FROM TB_Parts
	                        WHERE PartCode = @PartCode
                        )
                        SELECT Image, ClientName, SfInvn, TotInvn, Unit, p.BusinessNo
                        FROM partCTE p
                        JOIN TB_Client c ON p.BusinessNo = c.BusinessNo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@PartCode", PartCode);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    return new PartVO()
                    {
                        Image = Convert.ToInt32(reader["Image"]),
                        ClientName = reader["ClientName"].ToString(),
                        SfInvn = Convert.ToInt32(reader["SfInvn"]),
                        TotInvn = Convert.ToInt32(reader["TotInvn"]),
                        Unit = Convert.ToInt32(reader["Unit"]),
                        BusinessNo = reader["BusinessNo"].ToString()
                    };
                }
                catch (Exception err)
                {               
                    throw new Exception(err.Message);
                }
            }
            return null;
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

        /// <summary>
        /// Author : 강지훈
        /// 제품 또는 부품 수정
        /// leadTime이 -1이면 부품, 아니면 제품이라고 판단하여 수정한다.
        /// </summary>
        /// <param name="code">수정할 모델 코드</param>
        /// <param name="price">수정 가격</param>
        /// <param name="leadTime">수정 Lead Time</param>
        /// <param name="part">부품일 경우 수정할 재고 정보</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool UpdateProdPart(string code, int price, int leadTime, PartVO part, int isImage)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            // 부품 Update
            if (leadTime < 0)
            {
                cmd.CommandText = @"UPDATE TB_Parts 
                                    SET Price = @price, SfInvn = @SfInvn, Unit = @Unit, BusinessNo = @BusinessNo, Image = @Image
                                    WHERE PartCode = @Code";
                cmd.Parameters.AddWithValue("@SfInvn", part.SfInvn);
                cmd.Parameters.AddWithValue("@Unit", part.Unit);
                cmd.Parameters.AddWithValue("@BusinessNo", part.BusinessNo);
            }
            // 제품 Update
            else
            {
                cmd.CommandText = @"UPDATE TB_Products 
                                    SET Price = @price, LeadTime = @LeadTime, Image = @Image
                                    WHERE ProdCode = @Code";
                cmd.Parameters.AddWithValue("@LeadTime", leadTime);
            }
            cmd.Parameters.AddWithValue("@Code", code);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@Image", isImage);


            try
            {
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        /// <summary>
        /// Author : 강지훈
        /// 제품 및 부품 폐기 처리 및 재등록 처리
        /// </summary>
        /// <param name="code">작업 모델 코드</param>
        /// <param name="isProd">제품인지 부품인지 여부</param>
        /// <param name="changedValue">수정할 Dealing 값</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool UpdateModelDealing(string code, bool isProd, int changedValue)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            if (isProd) // 제품
            {
                cmd.CommandText = @"UPDATE TB_Products SET DEALING = @DEALING WHERE ProdCode = @CODE";
            }
            else // 부품
            {
                cmd.CommandText = @"UPDATE TB_Parts SET DEALING = @DEALING WHERE PartCode = @CODE";
            }

            cmd.Parameters.AddWithValue("@CODE", code);
            cmd.Parameters.AddWithValue("@DEALING", changedValue);

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