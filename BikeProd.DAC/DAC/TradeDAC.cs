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
                           and P.State = 'OK'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<PurchaseStateVO>(cmd.ExecuteReader());
            }
            return list;            
        }
        /// <summary>
        /// Author: 정희록
        /// 기간별 매입 현황 및 매입금액을 파악 
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public List<PurchaseStateVO> GetPurchaseSumInfo(string dateFrom, string dateTo)
        {            
            string sql = @"with purchased as
                           (
                           select P.PurchaseNo, ClientName, PManager, C.Manager, ArriveDate, P.State, PartName, Qty, Price, (Qty * Price) Amount
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

        /// <summary>
        /// Author: 정희록
        /// 완료된 매출현황을 볼 수 있도록 
        /// TB_Order, TB_OrderDetails, TB_Client, TB_Products 4개의 테이블을 Join하여 
        /// 관련정보를 가져오기
        /// </summary>
        /// <returns></returns>
        public List<SalesStateVO> GetAllSalesInfo()
        {
            List<SalesStateVO> list = new List<SalesStateVO>();

            string sql = @"select O.OrderNo, ClientName, PManager, C.Manager, DeliveryDate, O.State, ProdName, Qty, Price, (Qty * Price) Amount
                           from TB_Order O
                           inner join TB_OrderDetails OD on O.OrderNo = OD.OrderNo
                           inner join TB_Client C on O.BusinessNo = C.BusinessNo
                           inner join TB_Products P on OD.ProdCode = P.ProdCode
                           where O.State = 'OK'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<SalesStateVO>(cmd.ExecuteReader());
            }
            return list;
        }

        /// <summary>
        /// Author: 정희록
        /// 기간별 매출 현황 및 매출금액을 파악 
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public List<SalesStateVO> GetSalesSumInfo(string dateFrom, string dateTo)
        {
            string sql = @"with Ordered as
                           (
                           select O.OrderNo, ClientName, PManager, C.Manager, DeliveryDate, O.State, ProdName, Qty, Price, (Qty * Price) Amount
                           from TB_Order O
                           inner join TB_OrderDetails OD on O.OrderNo = OD.OrderNo
                           inner join TB_Client C on O.BusinessNo = C.BusinessNo
                           inner join TB_Products P on OD.ProdCode = P.ProdCode
                           where O.State = 'OK'
                           )
                           select OrderNo, ClientName, DeliveryDate, sum(Amount) Sum                            
                           from Ordered
                           where @dateFrom <= DeliveryDate and DeliveryDate <= @dateTo
                           group by OrderNo, ClientName, DeliveryDate";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dateFrom", dateFrom);
                cmd.Parameters.AddWithValue("@dateTo", dateTo);

                return DBConverter.DataReaderToList<SalesStateVO>(cmd.ExecuteReader());
            }
        }
    }
}
