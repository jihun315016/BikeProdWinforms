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
        public string PManager { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ArriveDate { get; set; }
        public string State { get; set; }

        //새로 추가된 VO
        public string Name { get; set; }
        public string ClientName { get; set; }
        public string StateName { get; set; }
        public string ClientManager { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }

    }
}
