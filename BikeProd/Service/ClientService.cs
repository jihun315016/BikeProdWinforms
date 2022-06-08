using BikeProd.DAC.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.Service
{
    public class ClientService
    {
        public List<ClientVO> GetClientNameByType(bool isCustomer)
        {
            string clientType = (isCustomer) ? "출고" : "입고";
            ClientDAC dac = new ClientDAC();
            List<ClientVO> list = dac.GetClientNameByType(clientType);
            dac.Dispose();
            return list;
        }
    }
}
