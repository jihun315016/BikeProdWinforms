using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class ProductionVO
    {
        public int ID { get; set; }
        public string ProdCode { get; set; }
        public int Qty { get; set; }
        public int Loss { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReqDate { get; set; }
        public DateTime ComplateDate { get; set; }
        public string State { get; set; }
        public string Team { get; set; }

        public string ProdName { get; set; }
        public int LeadTime { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
    }
}
