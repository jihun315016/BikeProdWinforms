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

    public class PurchaseDAC : IDisposable
    {
        SqlConnection conn;

        public PurchaseDAC()
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
        /// 류경석
        /// 발주서 리스트 가져오기
        /// </summary>
        /// <returns></returns>
        public List<PurchaseVO> GetPurchase()
        {
            List<PurchaseVO> list = new List<PurchaseVO>();

            string sql = @"select PurchaseNo, PurchaseName, BusinessNo, Manager, PurchaseDate, ArriveDate, State, SubManger
                            from TB_Purchase";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<PurchaseVO>(cmd.ExecuteReader());
            }
            return list;
        }
        /// <summary>
        /// 류경석
        /// 발주서 등록
        /// </summary>
        /// <param name="pur"></param>
        /// <returns></returns>

        public bool AddBalJu(PurchaseVO pur)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_InsertPurchase";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PurchaseName", pur.PurchaseName);
                cmd.Parameters.AddWithValue("@BusinessNo", pur.BusinessNo);
                cmd.Parameters.AddWithValue("@Manager", pur.Manager);
                cmd.Parameters.AddWithValue("@PurchaseDate", pur.PurchaseDate);
                cmd.Parameters.AddWithValue("@ArriveDate", pur.ArriveDate);
                cmd.Parameters.AddWithValue("@State", pur.State);
                cmd.Parameters.AddWithValue("@SubManger", pur.SubManger);


                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
        }
        
    }
}
