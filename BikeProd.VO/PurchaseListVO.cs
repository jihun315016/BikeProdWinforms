using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    /// <summary>
    /// A
    /// </summary>
    public class PurchaseListVO
    {
        
        public int PurchaseNo { get; set; }
        public string PartCode { get; set; }
        public int Qty { get; set; }

        // 제품테이블에 추가
        public string Name { get; set; }
        public string Category { get; set; }
    }
}

