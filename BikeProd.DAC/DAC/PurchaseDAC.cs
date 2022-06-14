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
        /// Author :Author :류경석
        /// 발주서 리스트 가져오기
        /// </summary>
        /// <returns></returns>
        public List<PurchaseVO> GetPurchase()
        {
            List<PurchaseVO> list = new List<PurchaseVO>();

            string sql = @"select PurchaseNo, PurchaseName, BusinessNo, Manager, PurchaseDate, ArriveDate, State
                            from TB_Purchase";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<PurchaseVO>(cmd.ExecuteReader());
            }
            return list;
        }
        /// <summary>
        /// Author : Author :류경석
        /// 발주서 등록
        /// </summary>
        /// <param name="pur"></param>
        /// <returns></returns>

        public bool SavePurchase(PurchaseVO pur, List<PurchaseListVO> purchaseDetailsList)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    cmd.CommandText = @"insert into  TB_Purchase
			                        (PurchaseName, BusinessNo, Manager, PurchaseDate, ArriveDate, State)
			                        values (@PurchaseName, @BusinessNo, @Manager, @PurchaseDate, @ArriveDate, @State);
                                    select @@IDENTITY from TB_Purchase";
                    cmd.Connection = conn;
                    cmd.Transaction = trans;

                    cmd.Parameters.AddWithValue("@PurchaseName", pur.PurchaseName);
                    cmd.Parameters.AddWithValue("@BusinessNo", pur.BusinessNo);
                    cmd.Parameters.AddWithValue("@Manager", pur.Manager);
                    cmd.Parameters.AddWithValue("@PurchaseDate", pur.PurchaseDate);
                    cmd.Parameters.AddWithValue("@ArriveDate", pur.ArriveDate);
                    cmd.Parameters.AddWithValue("@State", pur.State);

                    int newPurchaseNO = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.Parameters.Clear();
                    cmd.CommandText = @"insert into TB_PurchaseDetails
			                             (PurchaseNo, PartCode, Qty)
			                            values (@PurchaseNO,@PartCode, @Qty)";

                    cmd.Parameters.AddWithValue("@PurchaseNO", newPurchaseNO);
                    cmd.Parameters.Add("@PartCode", System.Data.SqlDbType.NVarChar, 10);
                    cmd.Parameters.Add("@Qty", System.Data.SqlDbType.Int);
                    foreach (PurchaseListVO item in purchaseDetailsList)
                    {
                        cmd.Parameters["@PartCode"].Value = item.PartCode;
                        cmd.Parameters["@Qty"].Value = item.Qty;
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                    return true;                    
                }
                catch(Exception err)
                {
                    trans.Rollback();
                    return false;
                }
            }
        }

        /// <summary>
        /// Author :류경석
        /// 발주서에 해당하는 거래처정보 가져오기
        /// </summary>
        /// <returns></returns>
        public List<ClientVO> GetClientName(string BusiniessNo)
        {
            List<ClientVO> list = new List<ClientVO>();

            string sql = @"  select c.BusinessNo, ClientName, Type, CompanyPhone, Email, Address
                          from TB_Client c join TB_Purchase p on c.BusinessNo = p.BusinessNo
                          where p.BusinessNo = @BusinessNo";
            
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("BusinessNo", BusiniessNo);
                list = DBConverter.DataReaderToList<ClientVO>(cmd.ExecuteReader());
            }
            return list;
        }
        /// <summary>
        /// Author :류경석
        /// 발주상태 콤보리스트 가져오기
        /// </summary>
        /// <returns></returns>
        public List<CommonCodeVO> GetStateCommon()
        {
            List<CommonCodeVO> list = new List<CommonCodeVO>();

            string sql = @"select Code, Category, Name 
                            from TB_CommonCode
                            where Category = '발주상태'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<CommonCodeVO>(cmd.ExecuteReader());
            }
            return list;
        }
        /// <summary>
        /// Author :류경석
        /// 
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        public List<CommonCodeVO> GetStateDetail(string Code)
        {
            List<CommonCodeVO> list = new List<CommonCodeVO>();

            string sql = @"  select Code, Category, Name
                              from TB_CommonCode c
                              left join TB_Purchase p on c.Code = p.State
                              where c.Code = @Code";


            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Code", Code);
                list = DBConverter.DataReaderToList<CommonCodeVO>(cmd.ExecuteReader());
            }
            return list;
        }

        /// <summary>
        /// Author :류경석
        /// 발주 상태 업데이트
        /// </summary>
        /// <param name="pur"></param>
        /// <returns></returns>
        public bool UpdateState(PurchaseVO pur)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_UpdatePurchaseState";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@State", pur.State);
                cmd.Parameters.AddWithValue("@PurchaseNo", pur.PurchaseNo);


                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
        }
        
        /// <summary>
        /// Author :류경석
        /// 
        /// </summary>
        /// <param name="ClientName"></param>
        /// <param name="State"></param>
        /// <param name="purDT"></param>
        /// <param name="AliveDate"></param>
        /// <returns></returns>
        public List<PurchaseVO> getSearchList(string ClientName, string State, DateTime purDT, DateTime AliveDate)
        {
            List<PurchaseVO> list = new List<PurchaseVO>();
            using (SqlCommand cmd = new SqlCommand())
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(@"  select PurchaseNo, PurchaseName, p.BusinessNo,c.ClientName, Manager, PurchaseDate, ArriveDate, State
                              from TB_Purchase p
                              join TB_Client c on p.BusinessNo = c.BusinessNo
                              where PurchaseDate >= @purDT and ArriveDate <= @AliveDate");
                if (!string.IsNullOrWhiteSpace(ClientName))
                {
                    sb.Append(" and c.ClientName = @ClientName");
                    cmd.Parameters.AddWithValue("@ClientName", ClientName);
                }
                if (!string.IsNullOrWhiteSpace(State))
                {
                    sb.Append(" and State = @State");
                    cmd.Parameters.AddWithValue("@State", State);
                }
                cmd.Parameters.AddWithValue("@purDT", purDT);
                cmd.Parameters.AddWithValue("@AliveDate", AliveDate);

                cmd.CommandText = sb.ToString();
                cmd.Connection = conn;

                return DBConverter.DataReaderToList<PurchaseVO>(cmd.ExecuteReader());
            }
        }

        public List<CommonCodeVO> getCategory()
        {
            List<CommonCodeVO> list = new List<CommonCodeVO>();

            string sql = @"select DISTINCT(Category)
                             from TB_CommonCode
                             where Category in ('부품','제품')";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<CommonCodeVO>(cmd.ExecuteReader());
            }
            return list;
        }

        public List<PartVO> GetPartsInfo()
        {
            List<PartVO> list = new List<PartVO>();

            string sql = "select PartCode, PartName, Category from TB_Parts where Dealing = 0";


            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<PartVO>(cmd.ExecuteReader());
            }
            return list;
        }

        public List<PurchaseListVO> GetPurchaseList(int purchaseNo)
        {
            List<PurchaseListVO> list = new List<PurchaseListVO>();

            string sql = @"select d.PurchaseNo, d.PartCode,Concat(prod.Category, part.Category)Category, 
                            Concat(ProdName, PartName) Name, Qty
                            from TB_Purchase p
                            join TB_PurchaseDetails d on p.PurchaseNo = d.PurchaseNo
                            left join TB_Products prod on d.PartCode = prod.ProdCode
                            left join TB_Parts part on d.PartCode = part.PartCode
                            where d.PurchaseNo = @PurchaseNo";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@PurchaseNo", purchaseNo);
                list = DBConverter.DataReaderToList<PurchaseListVO>(cmd.ExecuteReader());
            }
            return list;
        }
    }
}
