using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class PurchaseVO
    {
        public int PurchaseNo { get; set; }
        public string PurchaseName { get; set; }
        public string BusinessNo { get; set; }
        public string Manager { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ArriveDate { get; set; }
        public string State { get; set; }
        public string ClientManger { get; set; }
    }
}
