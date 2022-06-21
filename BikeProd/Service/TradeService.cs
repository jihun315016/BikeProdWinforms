using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd
{
    public class TradeService
    {
        public List<PurchaseStateVO> GetAllPurchasedInfo()
        {
            TradeDAC dac = new TradeDAC();
            List<PurchaseStateVO> result = dac.GetAllPurchasedInfo();
            dac.Dispose();

            return result;
        }

        public List<PurchaseStateVO> GetSumInfo(string dateFrom, string dateTo)
        {
            TradeDAC dac = new TradeDAC();
            List<PurchaseStateVO> result = dac.GetSumInfo(dateFrom, dateTo);
            dac.Dispose();

            return result;
        }
    }
}
