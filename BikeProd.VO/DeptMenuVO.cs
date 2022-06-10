using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.VO
{
    /// <summary>
    /// 정희록
    /// 권한관련 설정을 위하여 TB_DepartmentAuth와 TB_Menu를 join한 데이터
    /// </summary>
    public class DeptMenuVO
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public int MenuID { get; set; }
        public string MenuName { get; set; }
    }
}
