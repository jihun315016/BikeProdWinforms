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
        /// <summary>
        /// Author: 정희록
        /// TB_Department의 전체데이터가져오기
        /// </summary>
        /// <returns></returns>
        public List<DepartmentVO> GetAllDeptInfo()
        {
            DepartmentDAC dac = new DepartmentDAC();
            List<DepartmentVO> result = dac.GetAllDeptInfo();
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 부서별 팀관련 데이터 가져오기
        /// </summary>
        /// <param name="DeptNo">부서번호</param>
        /// <returns></returns>
        public List<TeamVO> GetTeamInfo(int DeptNo)
        {
            DepartmentDAC dac = new DepartmentDAC();
            List<TeamVO> result = dac.GetTeamInfo(DeptNo);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 부서별 팀정보 데이터테이블로 가져오기 
        /// </summary>
        /// <param name="DeptNo"></param>
        /// <returns></returns>
        public DataTable GetTeamInfoTable(int DeptNo)
        {
            DepartmentDAC dac = new DepartmentDAC();
            DataTable result = dac.GetTeamInfoTable(DeptNo);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 부서별 권한정보중 이름만 가져오기
        /// </summary>
        /// <param name="DeptNo">부서번호</param>
        /// <returns></returns>
        public DeptMenuVO GetAuthMenuInfo(int DeptNo)
        {
            DepartmentDAC dac = new DepartmentDAC();
            DeptMenuVO result = dac.GetAuthMenuInfo(DeptNo);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 권한설정관련 부서 및 메뉴 join데이터 가져오기
        /// </summary>
        /// <returns></returns>
        public List<DeptMenuVO> GetAllDeptMenuInfo()
        {
            DepartmentDAC dac = new DepartmentDAC();
            List<DeptMenuVO> result = dac.GetAllDeptMenuInfo();
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 부서별 권한메뉴 가져오기
        /// </summary>
        /// <param name="DeptNo">부서번호</param>
        /// <returns></returns>
        public List<DeptMenuVO> GetAuthMenu(int DeptNo)
        {
            DepartmentDAC dac = new DepartmentDAC();
            List<DeptMenuVO> result = dac.GetAuthMenu(DeptNo);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 전체 메뉴 데이터 가져오기
        /// </summary>
        /// <returns></returns>
        public List<MenuVO> GetAllMenuList()
        {
            DepartmentDAC dac = new DepartmentDAC();
            List<MenuVO> result = dac.GetAllMenuList();
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// TB_Menu의 데이터 중 권한메뉴(lvl.2)만 가져오기
        /// </summary>
        /// <returns></returns>
        public List<MenuVO> GetMenuList()
        {
            DepartmentDAC dac = new DepartmentDAC();
            List<MenuVO> result = dac.GetMenuList();
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 부서별 메뉴 권한 등록
        /// </summary>
        /// <param name="authList">권한메뉴리스트</param>
        /// <param name="DeptNo">부서 번호</param>
        public bool SaveMenuAuth(List<int> authList, int DeptNo)
        {
            DepartmentDAC dac = new DepartmentDAC();
            bool result = dac.SaveMenuAuth(authList, DeptNo);
            dac.Dispose();

            return result;
        }
        /// <summary>
        /// Author: 정희록
        /// 새로운 팀이름 등록
        /// </summary>
        /// <param name="deptNo"></param>
        /// <param name="teamName"></param>
        /// <returns></returns>
        public bool SaveTeam(int deptNo, string teamName)
        {
            DepartmentDAC dac = new DepartmentDAC();
            bool result = dac.SaveTeam(deptNo, teamName);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 새로운 부서 등록하기
        /// </summary>
        /// <param name="deptName"></param>
        /// <returns></returns>
        public bool SaveDept(string deptName)
        {
            DepartmentDAC dac = new DepartmentDAC();
            bool result = dac.SaveDept(deptName);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 부서삭제하기
        /// </summary>
        /// <param name="deptName"></param>
        /// <returns></returns>
        public bool DeleteDept(int deptCode)
        {
            DepartmentDAC dac = new DepartmentDAC();
            bool result = dac.DeleteDept(deptCode);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 팀삭제
        /// </summary>
        /// <param name="teamCode"></param>
        /// <returns></returns>
        public bool DeleteTeam(int teamCode)
        {
            DepartmentDAC dac = new DepartmentDAC();
            bool result = dac.DeleteTeam(teamCode);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// Author: 정희록
        /// 전체 팀정보 가져오기
        /// </summary>
        /// <returns></returns>
        public List<TeamVO> GetAllTeamList()
        {
            DepartmentDAC dac = new DepartmentDAC();
            List<TeamVO> result = dac.GetAllTeamList();
            dac.Dispose();

            return result;
        }


    }
}
