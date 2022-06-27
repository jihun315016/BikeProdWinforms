using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class CommonCodeVO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        // 추가된 멤버
        public int LastNum { get; set; }
    }
}
