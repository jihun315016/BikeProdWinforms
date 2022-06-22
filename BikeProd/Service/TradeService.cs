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
        /// <summary>
        /// Author: 정희록
        /// 완료된 매입현황을 볼 수 있도록 
        /// TB_Purchase, TB_PurchaseDetails, TB_Client, TB_Parts의 4개의 테이블을 Join하여 
        /// 관련정보를 가져오기
        /// </summary>
        /// <returns></returns>
        public List<PurchaseStateVO> GetAllPurchasedInfo()
        {
            TradeDAC dac = new TradeDAC();
            List<PurchaseStateVO> result = dac.GetAllPurchasedInfo();
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 기간별 매입 현황 및 매입금액을 파악 
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public List<PurchaseStateVO> GetPurchaseSumInfo(string dateFrom, string dateTo)
        {
            TradeDAC dac = new TradeDAC();
            List<PurchaseStateVO> result = dac.GetPurchaseSumInfo(dateFrom, dateTo);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 완료된 매출현황을 볼 수 있도록 
        /// TB_Order, TB_OrderDetails, TB_Client, TB_Products 4개의 테이블을 Join하여 
        /// 관련정보를 가져오기
        /// </summary>
        /// <returns></returns>
        public List<SalesStateVO> GetAllSalesInfo()
        {
            TradeDAC dac = new TradeDAC();
            List<SalesStateVO> result = dac.GetAllSalesInfo();
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 기간별 매출 현황 및 매출금액을 파악 
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public List<SalesStateVO> GetSalesSumInfo(string dateFrom, string dateTo)
        {
            TradeDAC dac = new TradeDAC();
            List<SalesStateVO> result = dac.GetSalesSumInfo(dateFrom, dateTo);
            dac.Dispose();

            return result;
        }
    }
}
