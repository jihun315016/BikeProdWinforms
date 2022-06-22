using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class SalesStateVO
    {
        //OrderNo, ClientName, Manager, PManager, DeliveryDate, ProdName, Price, Qty, Sum, State, Amount
        public int OrderNo { get; set; }
        public string ClientName { get; set; }
        public string Manager { get; set; }
        public string PManager { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string ProdName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public int Sum { get; set; }
        public int Amount { get; set; }
        public string State { get; set; }
    }
}
