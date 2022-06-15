using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    public class TeamEmpVO
    {
        //EmpNo, EmpName, E.DeptNo, E.TeamNo, TeamName ,Phone, FromDate
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int DeptNo { get; set; }
        public int TeamNo { get; set; }
        public string TeamName { get; set; }
        public string Phone { get; set; }
        public DateTime FromDate { get; set; }
    }
}
