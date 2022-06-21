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
    public class ProductionDAC : IDisposable
    {
        SqlConnection conn;

        public ProductionDAC()
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
        /// 주문되어 생산해야 하는 제품 리스트 조회
        /// 총 주문 수량이 논리재고보다 큰 제품만 조회된다.
        /// </summary>
        /// <returns></returns>
        public List<BomInfoVO> GetOrderedProd()
        {
            string sql = @"SELECT 
	                            p.ProdCode Code, p.ProdName Name,
	                            CASE WHEN p.IsFinished = 1 THEN '완제품' ELSE '반제품' END Kind,
	                            p.Category, SUM(Qty) Requirement, p.Inventory, LeadTime, TotInvn
                            FROM TB_OrderDetails o
                            JOIN TB_Products p ON o.ProdCode = p.ProdCode
                            GROUP BY p.ProdCode, ProdName, p.IsFinished, Category, Inventory, LeadTime, TotInvn
                            HAVING SUM(Qty) > TotInvn";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<BomInfoVO>(reader);
        }

        /// <summary>
        /// Author : 강지훈
        /// 특정 제품에 대한 정전개를 부품 단위로 조회
        /// 반제품도 부품 단위로 나누어져 조회된다.
        /// </summary>
        /// <param name="code">조회할 제품 코드</param>
        /// <returns></returns>
        public List<BomInfoVO> GetPartsByProd(string code)
        {
            SqlCommand cmd = new SqlCommand("SP_GetPartsByProd", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Code", code);
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<BomInfoVO>(reader);
        }

        /// <summary>
        /// Author : 강지훈
        /// 생산 지시 등록(저장) 후 등록한 만큼 부품 재고 수정
        /// </summary>
        /// <param name="production">저장할 생산 정보</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool SaveProduction(ProductionVO production, List<BomInfoVO> partList)
        {
            SqlTransaction tran = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Transaction = tran;
                cmd.Connection = conn;

                // 생산 등록 INSERT
                cmd.CommandText = @"INSERT INTO TB_Production
                            (ProdCode, Qty, ReqDate, State, Team)
                            VALUES
                            (@ProdCode, @Qty, @ReqDate, '생산 진행 중', @Team)";

                cmd.Parameters.AddWithValue("@ProdCode", production.ProdCode);
                cmd.Parameters.AddWithValue("@Qty", production.Qty);
                cmd.Parameters.AddWithValue("@ReqDate", production.ReqDate);
                cmd.Parameters.AddWithValue("@Team", production.Team);

                cmd.ExecuteNonQuery();

                // 제품 논리 재고 UPDATE
                cmd.CommandText = @"UPDATE TB_Products 
                                    SET TotInvn = TotInvn + @qty
                                    WHERE ProdCode = @ProdCode";

                cmd.ExecuteNonQuery();

                // 부품 논리 재고 UPDATE
                cmd.CommandText = @"UPDATE TB_Parts 
                                    SET TotInvn = TotInvn - @Cnt 
                                    WHERE PartCode = @PartCode";

                cmd.Parameters.Add("@Cnt", SqlDbType.Int);
                cmd.Parameters.Add("@PartCode", SqlDbType.VarChar);
                foreach (BomInfoVO part in partList)
                {
                    cmd.Parameters["@Cnt"].Value = part.Requirement;
                    cmd.Parameters["@PartCode"].Value = part.Code;
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
    }
}
