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
    public class TradeDAC : IDisposable
    {
        SqlConnection conn;

        public TradeDAC()
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
        /// 완료된 매입현황을 볼 수 있도록 
        /// TB_Purchase, TB_PurchaseDetails, TB_Client, TB_Parts의 4개의 테이블을 Join하여 
        /// 관련정보를 가져오기
        /// </summary>
        /// <returns></returns>
        public List<PurchaseStateVO> GetAllPurchasedInfo()
        {
            List<PurchaseStateVO> list = new List<PurchaseStateVO>();

            string sql = @"select P.PurchaseNo, ClientName, PManager, C.Manager, ArriveDate, P.State, 
                                  PartName, Qty, Price, (Qty * Price) Amount
                           from TB_Purchase P
                           inner join TB_PurchaseDetails PD on P.PurchaseNo = PD.PurchaseNo
                           inner join TB_Client C on P.BusinessNo = C.BusinessNo
                           inner join TB_Parts PS on PD.PartCode = PS.PartCode
                           where P.PurchaseNo = PD.PurchaseNo 
                           and P.BusinessNo = C.BusinessNo
                           and PD.PartCode = PS.PartCode
                           and P.State = 'OK'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<PurchaseStateVO>(cmd.ExecuteReader());
            }
            return list;            
        }

        public List<PurchaseStateVO> GetSumInfo(string dateFrom, string dateTo)
        {            
            string sql = @"with purchased as
                           (
                           select P.PurchaseNo, ClientName, PManager, C.Manager, ArriveDate, P.State, PartName, Qty,       Price, (Qty * Price) Amount
                           from TB_Purchase P
                           inner join TB_PurchaseDetails PD on P.PurchaseNo = PD.PurchaseNo
                           inner join TB_Client C on P.BusinessNo = C.BusinessNo
                           inner join TB_Parts PS on PD.PartCode = PS.PartCode
                           where P.State = 'OK'
                           )
                           select PurchaseNo, ClientName, ArriveDate, sum(Amount) Sum                            
                           from purchased
                           where @dateFrom <= ArriveDate and ArriveDate <= @dateTo
                           group by PurchaseNo, ClientName, ArriveDate";                           

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dateFrom", dateFrom);
                cmd.Parameters.AddWithValue("@dateTo",dateTo);

                return DBConverter.DataReaderToList<PurchaseStateVO>(cmd.ExecuteReader());
            }
        }
    }
}
