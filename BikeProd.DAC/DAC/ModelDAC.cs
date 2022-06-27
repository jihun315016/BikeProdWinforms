using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

            //Console.WriteLine($"FieldCount : {reader.FieldCount}");
            //while (reader.Read())
            //{
            //    Console.WriteLine("!!!");
            //}
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
	                        Category, Price, Inventory, -1 SfInvn, Dealing, Image, TotInvn
                        FROM TB_Products
                        UNION
                        SELECT 
	                        PartCode Code, PartName Name, '부품' Kind, Category, 
	                        Price, Inventory, SfInvn, Dealing, Image, TotInvn
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
        /// 특정 제품에 대한 LeadTime 조회
        /// </summary>
        /// <param name="ProdCode"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int GetProdLeadTime(string ProdCode)
        {
            string sql = @"SELECT LeadTime FROM TB_Products WHERE ProdCode=@ProdCode";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ProdCode", ProdCode);

            try
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }

            return 0;
        }

        /// <summary>
        /// Author : 강지훈
        /// 전체 BOM 관계 조회
        /// </summary>
        /// <returns></returns>
        public List<BomRelationVO> GetAllBomRelation()
        {
            string sql = @"WITH ProdPartCTE AS
                            (
	                            SELECT ProdCode Code, ProdName Name, 1 Kind FROM TB_Products
	                            UNION
	                            SELECT PartCode Code, PartName Name, 2 Kind FROM TB_Parts
                            )
                            , BomCTE AS
                            (
	                            SELECT ParentCode, ChildCode, 1 Level
	                            FROM TB_BOM 
	                            WHERE ParentCode = ChildCode

	                            UNION ALL

	                            SELECT b.ParentCode, b.ChildCode, c.Level + 1 Level
	                            FROM TB_BOM b
	                            JOIN BomCTE c ON b.ParentCode = c.ChildCode
	                            WHERE b.ParentCode <> b.ChildCode
                            )
                            SELECT ParentCode, p1.Name ParentName, ChildCode, p2.Name ChildName, Level, p2.Kind 
                            FROM BomCTE b
                            JOIN ProdPartCTE p1 ON b.ParentCode = p1.Code
                            JOIN ProdPartCTE p2 ON b.ChildCode = p2.Code
                            ORDER BY Level, p2.Kind";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<BomRelationVO>(reader);
        }

        /// <summary>
        /// Author : 강지훈
        /// BOM 등록되었거나 등록 되지 않은 제품 조회
        /// </summary>
        /// <returns></returns>
        public List<ProdPartVO> GetBomProd(bool isBom)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"SELECT ProdCode Code, ProdName Name, Category,
	                        CASE WHEN IsFinished = 1 THEN '완제품' ELSE '반제품' END Kind
                        FROM TB_Products ");

            if (isBom)            
                sb.Append(@"WHERE ProdCode IN (SELECT ParentCode FROM TB_BOM)
                            AND Dealing = 1
                            UNION
                            SELECT PartCode Code, PartName Name, Category, '부품' Kind 
                            FROM TB_Parts
                            WHERE PartCode IN (SELECT ChildCode FROM TB_BOM GROUP BY ChildCode)");
            else            
                sb.Append(@"WHERE ProdCode NOT IN (SELECT ParentCode FROM TB_BOM)
                            AND Dealing = 1");
            
            string sql = sb.ToString();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<ProdPartVO>(reader);
        }

        /// <summary>
        /// Author : 강지훈
        /// 특정 제품에 대한 모품목과 자품목 조회
        /// </summary>
        /// <param name="code">BOM 조회할 기준이 되는 제품 코드</param>
        /// <returns></returns>
        public List<BomInfoVO> GetBomRelation(string code)
        {
            string sql = "SP_GetBomRelation";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Code", code);
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<BomInfoVO>(reader);
        }

        /// <summary>
        /// Author : 강지훈
        /// BOM 등록을 위해 부품과 반제품 정보를 가져온다.
        /// 만약 등록할 모델이 반제품이면 부품 정보만 가져오고,
        /// 완제품이라면 반제품과 부품 정보 모두 가져온다.
        /// </summary>
        /// <param name="isGetSemiProd">반제품 정보가 필요한지 여부</param>
        /// <returns></returns>
        public List<ProdPartVO> GetPartAndSemiProd(bool isGetSemiProd)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"SELECT PartCode Code, PartName Name, '부품' Kind, Category FROM TB_Parts ");

            // 반제품 정보까지 필요하다면
            if (isGetSemiProd)
            {
                sb.Append(@"UNION
                            SELECT ProdCode Code, ProdName Name, '반제품' Kind, Category
                            FROM TB_Products
                            WHERE IsFinished = 0 ");
            }

            string sql = sb.ToString();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<ProdPartVO>(reader);
        }

        /// <summary>
        /// Author : 강지훈
        /// BOM 등록 메서드
        /// </summary>
        /// <param name="parentCode">등록될 상위 항목</param>
        /// <param name="list">하위 항목 리스트</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool SaveBom(string parentCode, List<BomInfoVO> list)
        {
            string sql = @"INSERT INTO TB_BOM
                            (ParentCode, ChildCode, Requirement)
                            VALUES
                            (@ParentCode, @ChildCode, @Requirement)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlTransaction tran = conn.BeginTransaction();

            cmd.Transaction = tran;
            cmd.Parameters.AddWithValue("@ParentCode", parentCode);
            cmd.Parameters.Add("@ChildCode", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Requirement", SqlDbType.Int);

            try
            {
                foreach (var item in list)
                {
                    cmd.Parameters["@ChildCode"].Value = item.Code;
                    cmd.Parameters["@Requirement"].Value = item.Requirement;
                    cmd.ExecuteNonQuery();
                }
                
                cmd.Parameters["@ChildCode"].Value = cmd.Parameters["@ParentCode"].Value;
                cmd.Parameters["@Requirement"].Value = -1;
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"DELETE FROM TB_BOM 
                                    WHERE ChildCode = @ChildCode AND ParentCode = ChildCode";

                foreach (var item in list)
                {
                    cmd.Parameters["@ChildCode"].Value = item.Code;
                    cmd.ExecuteNonQuery();
                }

                tran.Commit();
                return true;
            }
            catch (Exception err)
            {
                tran.Rollback();
                throw new Exception(err.Message);
            }
        }

        /// <summary>
        /// Author : 강지훈
        /// BOM 삭제 메서드
        /// </summary>
        /// <param name="code">삭제할 상위 항목 코드</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool DeleteBOM(string code)
        {
            string sql = @"DELETE FROM TB_BOM WHERE ParentCode = @ParentCode";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ParentCode", code);

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
                cmd.Parameters.AddWithValue("@Category", part.Category);
                cmd.Parameters.AddWithValue("@Price", part.Price);
                cmd.Parameters.AddWithValue("@Image", part.Image);
                cmd.Parameters.AddWithValue("@BusinessNo", part.BusinessNo);
                cmd.Parameters.AddWithValue("@SfInvn", part.SfInvn);
                cmd.Parameters.AddWithValue("@Unit", part.Unit);
                cmd.Parameters.AddWithValue("@IsFinished", 0);
                cmd.Parameters.AddWithValue("@LeadTime", 0);
                cmd.Parameters.AddWithValue("@StartCode", startCode);
            }

            try
            {
                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
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