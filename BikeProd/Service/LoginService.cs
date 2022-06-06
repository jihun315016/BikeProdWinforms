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
        public List<MenuVO> GetMenuList(int empNo)
        {
            LoginDAC dac = new LoginDAC();
            List<MenuVO> list = dac.GetMenuList(empNo);
            dac.Dispose();
            return list;
        }
    }
}
