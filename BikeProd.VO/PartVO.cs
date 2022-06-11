using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class PartVO
    {
        public string PartCode { get; set; }
        public string PartName { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Image { get; set; }
        public int Inventory { get; set; }
        public string BusinessNo { get; set; }
        public int SfInvn { get; set; }
        public int TotInvn { get; set; }
        public int Unit { get; set; }
        public string State { get; set; }
        public int LeadTime { get; set; }

        // 추가 칼럼
        public string ClientName { get; set; }
    }
}
