using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd
{
    class DepartmentService
    {
        public List<DepartmentVO> GetAllDeptInfo()
        {
            DepartmentDAC dac = new DepartmentDAC();
            List<DepartmentVO> result = dac.GetAllDeptInfo();
            dac.Dispose();

            return result;
        }
        public List<TeamVO> GetAllTeamInfo(int DeptNo)
        {
            DepartmentDAC dac = new DepartmentDAC();
            List<TeamVO> result = dac.GetAllTeamInfo(DeptNo);
            dac.Dispose();

            return result;
        }

        public DataTable GetTeamInfoTable(int DeptNo)
        {
            DepartmentDAC dac = new DepartmentDAC();
            DataTable result = dac.GetTeamInfoTable(DeptNo);
            dac.Dispose();

            return result;
        }
        public DeptMenuVO GetAuthMenuInfo(int DeptNo)
        {
            DepartmentDAC dac = new DepartmentDAC();
            DeptMenuVO result = dac.GetAuthMenuInfo(DeptNo);
            dac.Dispose();

            return result;
        }
    }
}
