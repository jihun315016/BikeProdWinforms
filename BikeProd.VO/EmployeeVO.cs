using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class EmployeeVO
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int DeptNo { get; set; }
        public int? TeamNo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
