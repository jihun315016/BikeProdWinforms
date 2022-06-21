using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd
{
    public class OrderService
    {
        public List<OrderVO> GetOrderList()
        {
            OrderDAC dac = new OrderDAC();
            List<OrderVO> result = dac.GetOrderList();
            dac.Dispose();
            return result;
        }

        public List<CommonCodeVO> GetStateCommon()
        {
            OrderDAC dac = new OrderDAC();
            List<CommonCodeVO> result = dac.GetStateCommon();
            dac.Dispose();
            return result;
        }

        public List<BomInfoVO> GetBomList()
        {
            OrderDAC dac = new OrderDAC();
            List<BomInfoVO> result = dac.GetBomList();
            dac.Dispose();
            return result;
        }

        public List<ProductVO> GetProdList()
        {
            OrderDAC dac = new OrderDAC();
            List<ProductVO> result = dac.GetProdList();
            dac.Dispose();
            return result;
        }
        public List<CommonCodeVO> GetProdCommon()
        {
            OrderDAC dac = new OrderDAC();
            List<CommonCodeVO> result = dac.GetProdCommon();
            dac.Dispose();
            return result;
        }

        public bool SaveOrders(OrderVO order, List<OrderDetailsVO> orderProd)
        {
            OrderDAC dac = new OrderDAC();
            bool result = dac.SaveOrders(order, orderProd);
            dac.Dispose();

            return result;
        }
        public List<OrderDetailsVO> GetOrderDetails()
        {
            OrderDAC dac = new OrderDAC();
            List<OrderDetailsVO> result = dac.GetOrderDetails();
            dac.Dispose();
            return result;
        }

        public List<OrderDetailsVO> GetOrderDetailList(int OrderNo)
        {
            OrderDAC dac = new OrderDAC();
            List<OrderDetailsVO> result = dac.GetOrderDetailList(OrderNo);
            dac.Dispose();
            return result;
        }
        public List<OrderVO> GetSearchOrderList(DateTime purDT, DateTime AliveDate)
        {
            OrderDAC dac = new OrderDAC();
            List<OrderVO> result = dac.GetSearchOrderList(purDT, AliveDate);
            dac.Dispose();
            return result;
        }

        public bool UpdateState(OrderVO order)
        {
            OrderDAC dac = new OrderDAC();
            bool result = dac.UpdateState(order);
            dac.Dispose();

            return result;
        }


    }
}
