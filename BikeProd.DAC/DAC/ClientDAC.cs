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
    public class ClientDAC : IDisposable
    {
        SqlConnection conn;

        public ClientDAC()
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
        /// 거래처 타입(입고처 or 출고처)에 따라 사업자 번호와 거래처 이름 정보 조회
        /// </summary>
        /// <param name="type">거래처 타입(입고처 or 출고처)</param>
        /// <returns></returns>
        public List<ClientVO> GetClientNameByType(string clientType)
        {
            string sql = @"SELECT BusinessNo, ClientName, Manager, Address
	                        FROM TB_Client
	                        WHERE TYPE = @TYPE";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TYPE", clientType);
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<ClientVO>(reader);
        }

        public List<ClientVO> GetClientList()
        {
            List<ClientVO> list = new List<ClientVO>();

            string sql = @"select BusinessNo, ClientName, Type, Email, Address, Manager, ManagerPhone 
                           from TB_Client";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                list = DBConverter.DataReaderToList<ClientVO>(cmd.ExecuteReader());
            }
            return list;
        }

        public bool SaveClient(ClientVO client)
        {            
            string sql = @"insert into TB_Client (BusinessNo, ClientName, Type, Email, Address, Manager, ManagerPhone)
                                  values (@BusinessNo, @ClientName, @Type, @Email, @Address, @Manager, @ManagerPhone)";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@BusinessNo", client.BusinessNo);
                cmd.Parameters.AddWithValue("@ClientName", client.ClientName);
                cmd.Parameters.AddWithValue("@Type", client.Type);           
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@Address", client.Address);
                cmd.Parameters.AddWithValue("@Manager", client.Manager);
                cmd.Parameters.AddWithValue("@ManagerPhone", client.ManagerPhone);

                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
        }

        public bool DeleteClient(string clientName)
        {
            string sql = "delete from TB_Client where ClientName = @ClientName";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ClientName", clientName);

                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
        }

        public ClientVO GetBusinessNo(string BusinessNo)
        {
            string sql = @"select BusinessNo
                          from TB_Client
                           where BusinessNo = @BusinessNo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@BusinessNo", BusinessNo);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ClientVO empVO = new ClientVO()
                {
                    BusinessNo = reader["BusinessNo"].ToString()
                };

                return empVO;
            }
            return null;
        }
    }
}
