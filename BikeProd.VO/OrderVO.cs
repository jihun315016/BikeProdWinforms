using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class OrderVO
    {
        public int OrderNo { get; set; }
        public string OrderName { get; set; }
        public string BusinessNo { get; set; }
        public string PManager { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Address { get; set; }
        public string State { get; set; }

        //추가용
        public string ClientName { get; set; }
        public string clientManager { get; set; }
        public string StateName { get; set; }
    }
}
