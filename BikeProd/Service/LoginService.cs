using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd
{
    public class LoginService
    {
        /// <summary>
        /// Author : 강지훈
        /// 특정 직원에 대해서 권한 있는 메뉴를 가져와 폼에 전달
        /// </summary>
        /// <param name="empNo">직원 번호</param>
        /// <returns>폼에 전달할 메뉴 리스트</returns>
        public List<MenuVO> GetMenuList(int empNo)
        {
            LoginDAC dac = new LoginDAC();
            List<MenuVO> list = dac.GetMenuList(empNo);
            dac.Dispose();
            return list;
        }
    }
}
