using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class ProdPartVO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
        public int Dealing { get; set; }
        public int Image { get; set; }
    }
}
