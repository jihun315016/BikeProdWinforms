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

        public bool SavePurchase(PurchaseVO pur, List<PurchaseListVO> purchaseDetailsList)
        {
            PurchaseDAC dac = new PurchaseDAC();
            bool result = dac.SavePurchase(pur, purchaseDetailsList);
            dac.Dispose();

            return result;
        }

        public List<ClientVO> GetClientName(string BusiniessNo)
        {
            PurchaseDAC dac = new PurchaseDAC();
            List<ClientVO> result = dac.GetClientName(BusiniessNo);
            dac.Dispose();

            return result;
        }

        public List<CommonCodeVO> GetStateCommon()
        {
            PurchaseDAC dac = new PurchaseDAC();
            List<CommonCodeVO> result = dac.GetStateCommon();
            dac.Dispose();

            return result;
        }
        public List<CommonCodeVO> GetStateDetail(string Code)
        {
            PurchaseDAC dac = new PurchaseDAC();
            List<CommonCodeVO> result = dac.GetStateDetail(Code);
            dac.Dispose();

            return result;
        }

        public bool UpdateState(PurchaseVO pur)
        {
            PurchaseDAC dac = new PurchaseDAC();
            bool result = dac.UpdateState(pur);
            dac.Dispose();

            return result;
        }

        public List<CommonCodeVO> getCategory()
        {
            PurchaseDAC dac = new PurchaseDAC();
            List<CommonCodeVO> result = dac.getCategory();
            dac.Dispose();

            return result;
        }

        public List<PurchaseVO> getSearchList(string ClientName, string State, DateTime purDT, DateTime AliveDate)
        {
            PurchaseDAC dac = new PurchaseDAC();
            List<PurchaseVO> result = dac.getSearchList(ClientName, State,purDT,AliveDate);
            dac.Dispose();

            return result;

        }

        public List<PurchaseListVO> GetPurchaseList(int PurchaseNo)
        {
            PurchaseDAC dac = new PurchaseDAC();
            List<PurchaseListVO> result = dac.GetPurchaseList(PurchaseNo);
            dac.Dispose();

            return result;
        }

        public bool UpdateStateOK(int purchaseNo)
        {
            PurchaseDAC dac = new PurchaseDAC();
            bool result = dac.UpdateStateOK(purchaseNo);
            dac.Dispose();

            return result;
        }

        public bool UpdateStateCancel(int purchaseNo)
        {
            PurchaseDAC dac = new PurchaseDAC();
            bool result = dac.UpdateStateCancel(purchaseNo);
            dac.Dispose();

            return result;
        }

       /* public List<PartVO> GetUnit(string PartName)
        {
            PurchaseDAC dac = new PurchaseDAC();
            List<PartVO> result = dac.GetPurchaseList(PartName);
            dac.Dispose();

            return result;
        }*/
    }
}
