using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class PurchaseStateVO
    {
        //P.PurchaseNo, ClientName, PManager, C.Manager, ArriveDate, P.State, PartName, Qty, Price, Amount
        public int PurchaseNo { get; set; }
        public string ClientName { get; set; }
        public string PManager { get; set; }
        public string Manager { get; set; }
        public DateTime ArriveDate { get; set; }
        public string State { get; set; }
        public string PartName { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public int Sum { get; set; }
    }
}
