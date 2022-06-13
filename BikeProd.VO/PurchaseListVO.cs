using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class PurchaseListVO
    {
        public int PurchaseNo { get; set; }
        public string PartCode { get; set; }
        public int Qty { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
}

