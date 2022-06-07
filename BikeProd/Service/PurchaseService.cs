using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd
{
    public class PurchaseService
    {
        public List<PurchaseVO> GetPurchase()
        {
            PurchaseDAC dac = new PurchaseDAC();
            List<PurchaseVO> result = dac.GetPurchase();
            dac.Dispose();

            return result;
        }

        public bool AddBalJu(PurchaseVO pur)
        {
            PurchaseDAC dac = new PurchaseDAC();
            bool result = dac.AddBalJu(pur);
            dac.Dispose();

            return result;
        }
    }
}
