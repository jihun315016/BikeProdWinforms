using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class ProductVO
    {
        public string ProdCode { get; set; }
        public string ProdName { get; set; }
        public int IsFinished { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Image { get; set; }
        public int Inventory { get; set; }
        public string State { get; set; }
        public int LeadTime { get; set; }
    }
}
