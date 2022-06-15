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
        public List<OrderVO> GetOrderAllList()
        {
            OrderDAC dac = new OrderDAC();
            List<OrderVO> result = dac.GetOrderAllList();
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

    }
}
