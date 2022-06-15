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
    public class OrderDAC :IDisposable
    {

        SqlConnection conn;

        public OrderDAC()
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

        public List<OrderVO> GetOrderAllList()
        {
            List<OrderVO> list = new List<OrderVO>();
            string sql = @"select OrderNo, OrderName, BusinessNo, Manager, OrderDate, DeliveryDate, Address, State from TB_Order";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<OrderVO>(cmd.ExecuteReader());
            }
            return list;
        }

        public List<CommonCodeVO> GetStateCommon()
        {
            List<CommonCodeVO> list = new List<CommonCodeVO>();

            string sql = @"select Code, Category, Name 
                            from TB_CommonCode
                            where Category = '주문상태'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<CommonCodeVO>(cmd.ExecuteReader());
            }
            return list;
        }

    }

}
