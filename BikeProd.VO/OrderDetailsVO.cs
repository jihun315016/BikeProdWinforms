using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class OrderDetailsVO
    {
        public int OrderNo { get; set; }
        public string ProdCode { get; set; }
        public int Qty { get; set; }

        //주문리스트용 
        public string Category { get; set; }
        public string ProdName { get; set; }
    }
}
