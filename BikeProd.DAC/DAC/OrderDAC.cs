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

        public List<OrderVO> GetOrderList()
        {
            List<OrderVO> list = new List<OrderVO>();
            string sql = @"select OrderNo, OrderName, o.BusinessNo,c.Manager clientManager, 
                            o.PManager, OrderDate, DeliveryDate, o.Address, State, cc.Name StateName, c.ClientName
                            from TB_Order o join TB_CommonCode cc on o.State = cc.Code
                            join TB_Client c on o.BusinessNo = c.BusinessNo
                            where cc.Category = '주문상태'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<OrderVO>(cmd.ExecuteReader());
            }
            return list;
        }

        public List<OrderVO> GetSearchOrderList(DateTime purDT, DateTime AliveDate)
        {
            List<OrderVO> list = new List<OrderVO>();
            string sql = @"select OrderNo, OrderName, o.BusinessNo,c.Manager clientManager, 
                        o.PManager, OrderDate, DeliveryDate, o.Address, State, cc.Name StateName, c.ClientName
                            from TB_Order o join TB_CommonCode cc on o.State = cc.Code
                            join TB_Client c on o.BusinessNo = c.BusinessNo
                            where  OrderDate  Between @purDT and @AliveDate";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@purDT", purDT);
                cmd.Parameters.AddWithValue("@AliveDate", AliveDate);
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

        public List<ProductVO> GetProdList()
        {
            List<ProductVO> list = new List<ProductVO>();
            string sql = @"select ProdCode, ProdName, IsFinished, Category, Price, Image, Inventory, State, LeadTime, Dealing 
                           from TB_Products";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<ProductVO>(cmd.ExecuteReader());
            }
            return list;
        }
        public List<CommonCodeVO> GetProdCommon()
        {
            List<CommonCodeVO> list = new List<CommonCodeVO>();
            string sql = @"select Code, Category, Name from TB_CommonCode where Category = '제품'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<CommonCodeVO>(cmd.ExecuteReader());
            }
            return list;
        }

        public List<OrderDetailsVO> GetOrderDetails()
        {
            List<OrderDetailsVO> list = new List<OrderDetailsVO>();
            string sql = @"select OrderNo, od.ProdCode, Qty, ProdName, Category from TB_OrderDetails od
                            join TB_Products pd on od.ProdCode = pd.ProdCode";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<OrderDetailsVO>(cmd.ExecuteReader());
            }
            return list;
        }

        public List<OrderDetailsVO> GetOrderDetailList(int OrderNo)
        {
            List<OrderDetailsVO> list = new List<OrderDetailsVO>();
            string sql = @"select OrderNo, Category, ProdName, Qty
                            from TB_OrderDetails od join TB_Products p 
                            on od.ProdCode = p.ProdCode
                            where OrderNo = @OrderNo";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@OrderNo", OrderNo);
                list = DBConverter.DataReaderToList<OrderDetailsVO>(cmd.ExecuteReader());
            }
            return list;
        }

        public List<BomInfoVO> GetBomList()
        {
            List<BomInfoVO> list = new List<BomInfoVO>();
            string sql = @"select ParentCode, ChildCode Code, Requirement, PartName Name, Category 
                            from TB_BOM b join TB_Parts p on b.ChildCode = p.PartCode";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<BomInfoVO>(cmd.ExecuteReader());
            }
            return list;
        }



        public bool SaveOrders(OrderVO order, List<OrderDetailsVO> orderProd)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    //주문등록 -> 주문서 등록
                    cmd.CommandText = @"insert into  TB_Order
                                        (OrderName, BusinessNo, PManager, OrderDate, DeliveryDate, Address, State)
                                        values  (@OrderName, @BusinessNo, @PManager, @OrderDate, @DeliveryDate, @Address, @State);
                                        select @@IDENTITY from TB_Order";
                    cmd.Connection = conn;
                    cmd.Transaction = trans;

                    cmd.Parameters.AddWithValue("@OrderNo", order.OrderNo);
                    cmd.Parameters.AddWithValue("@OrderName", order.OrderName);
                    cmd.Parameters.AddWithValue("@BusinessNo", order.BusinessNo);
                    cmd.Parameters.AddWithValue("@PManager", order.PManager);
                    cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    cmd.Parameters.AddWithValue("@DeliveryDate", order.DeliveryDate);
                    cmd.Parameters.AddWithValue("@Address", order.Address);
                    cmd.Parameters.AddWithValue("@State", order.State);

                    //주문등록 -> 주문할 제품 수량 증가
                    int newOrderNO = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.Parameters.Clear();
                    cmd.CommandText = @"insert into TB_OrderDetails
                                        (OrderNo, ProdCode, Qty)
                                        values (@OrderNo, @ProdCode, @Qty)";

                    cmd.Parameters.AddWithValue("@OrderNo", newOrderNO);
                    cmd.Parameters.Add("@ProdCode", System.Data.SqlDbType.NVarChar, 10);
                    cmd.Parameters.Add("@Qty", System.Data.SqlDbType.Int);
                    foreach (OrderDetailsVO item in orderProd)
                    {
                        cmd.Parameters["@ProdCode"].Value = item.ProdCode;
                        cmd.Parameters["@Qty"].Value = item.Qty;
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception err)
                {
                    trans.Rollback();
                    return false;
                }
            }
        }

        public bool UpdateState(OrderVO order)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    cmd.Transaction = trans;
                    cmd.CommandText = @"update TB_Order
                                        set State = @State, DeliveryDate = @DeliveryDate
                                        where OrderNo = @OrderNo";
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@OrderNo", order.OrderNo);
                    cmd.Parameters.AddWithValue("@State", order.State);
                    cmd.Parameters.AddWithValue("@DeliveryDate", DateTime.Now.ToShortDateString());
                    int iRowAffect = cmd.ExecuteNonQuery();
                    trans.Commit();
                    return (iRowAffect > 0);
                }
                catch (Exception err)
                {
                    trans.Rollback();
                    return false;
                }
            }
        }


    }

}
