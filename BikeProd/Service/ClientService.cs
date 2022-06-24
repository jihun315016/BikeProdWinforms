using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd
{
    public class ClientService
    {
        /// <summary>
        /// Author : 강지훈
        /// 입고 또는 출고 거래처의 사업자 번호와 이름을 가져와 폼에 전달
        /// </summary>
        /// <param name="isCustomer">출고처인지 여부</param>
        /// <returns></returns>
        public List<ClientVO> GetClientNameByType(bool isCustomer)
        {
            string clientType = (isCustomer) ? "출고" : "입고";
            ClientDAC dac = new ClientDAC();
            List<ClientVO> list = dac.GetClientNameByType(clientType);
            dac.Dispose();
            return list;
        }

        public List<ClientVO> GetClientList()
        {
            ClientDAC dac = new ClientDAC();
            List<ClientVO> result = dac.GetClientList();
            dac.Dispose();
            return result;
        }

        public bool SaveClient(ClientVO client)
        {
            ClientDAC dac = new ClientDAC();
            bool result = dac.SaveClient(client);
            dac.Dispose();
            return result;
        }

        public bool DeleteClient(string clientName)
        {
            ClientDAC dac = new ClientDAC();
            bool result = dac.DeleteClient(clientName);
            dac.Dispose();
            return result;
        }

        public ClientVO GetBusinessNo(string BusinessNo)
        {
            ClientDAC dac = new ClientDAC();
            ClientVO B_no = dac.GetBusinessNo(BusinessNo);
            dac.Dispose();
            return B_no;
        }
    }

}
