using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class BomRelationVO
    {
        public string ParentCode { get; set; }
        public string ParentName { get; set; }
        public string ChildCode { get; set; }
        public string ChildName { get; set; }
        public int Level { get; set; }
    }
}
