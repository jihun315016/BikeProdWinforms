using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd
{
    public class EmployeeService
    {
        public bool InsertEmployee(EmployeeVO emp)
        {

            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.AddEmployees(emp);
            dac.Dispose();

            return result;
        }

        public bool UpdateOut(int EmpNo, string ToDate)
        {

            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.UpdateOut(EmpNo, ToDate);
            dac.Dispose();

            return result;
        }

        public List<EmployeeVO> GetEmployeesAllList()
        {
            EmployeeDAC dac = new EmployeeDAC();
            List<EmployeeVO> result = dac.GetEmployeesAllList();
            dac.Dispose();

            return result;
        }
        public List<EmployeeVO> GetWorkingList()
        {
            EmployeeDAC dac = new EmployeeDAC();
            List<EmployeeVO> result = dac.GetWorkingList();
            dac.Dispose();

            return result;
        }

        public List<EmployeeVO> GetOutList()
        {
            EmployeeDAC dac = new EmployeeDAC();
            List<EmployeeVO> result = dac.GetOutList();
            dac.Dispose();

            return result;
        }
        public List<DepartmentVO> GetCodeByDept()
        {
            EmployeeDAC dac = new EmployeeDAC();
            List<DepartmentVO> result = dac.GetCodeByDept();
            dac.Dispose();

            return result;
        }

        public List<TeamVO> GetCodeByTeam(int DeptNo)
        {
            EmployeeDAC dac = new EmployeeDAC();
            List<TeamVO> result = dac.GetCodeByTeam(DeptNo);
            dac.Dispose();

            return result;
        }
        public List<EmployeeVO> GetSearchList(int dept, string name)
        {
            EmployeeDAC dac = new EmployeeDAC();
            List<EmployeeVO> result = dac.GetSearchList(dept, name);
            dac.Dispose();

            return result;
        }

        public List<EmployeeVO> GetEmpInfo(int DeptNo)
        {
            EmployeeDAC dac = new EmployeeDAC();
            List<EmployeeVO> result = dac.GetEmpInfo(DeptNo);
            dac.Dispose();

            return result;
        }

        public EmployeeVO searchEmpInfo(int TeamNo, string EmpName)
        {
            EmployeeDAC dac = new EmployeeDAC();
            EmployeeVO result = dac.searchEmpInfo(TeamNo, EmpName);
            dac.Dispose();

            return result;
        }
    }
}
