﻿using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.DAC.DAC
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
            string sql = "SP_GetClientNameByType";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TYPE", clientType);
            SqlDataReader reader = cmd.ExecuteReader();
            return DBConverter.DataReaderToList<ClientVO>(reader);
        }
    }
}
