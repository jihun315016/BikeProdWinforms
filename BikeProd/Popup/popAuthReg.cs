using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeProd
{
    public partial class popAuthReg : Form
    {
        DepartmentService departmentSrv = new DepartmentService();
        List<DeptMenuVO> authlist = null;
        List<MenuVO> mlist = null;
        List<DepartmentVO> deptList = null;
        int DeptNo;
        public string deptName { get; set; }
        public popAuthReg()
        {
            InitializeComponent();
        }
        public popAuthReg(string deptName)
        {
            InitializeComponent();
            this.deptName = deptName;
        }

        private void frmAuthRegPopUp_Load(object sender, EventArgs e)
        {
            MenuBinding();
            DeptBinding();
            DeptAuthBinding();
            AllMenuBinding();
        }

        private void MenuBinding()
        {
            mlist = departmentSrv.GetMenuList();
            foreach (MenuVO menu in mlist)
            {
                lstMenu.Items.Add(menu.MenuName);
            }
        }


        private void DeptBinding()
        {

            deptList = departmentSrv.GetAllDeptInfo();

            foreach (DepartmentVO dept in deptList)
            {
                lstDept.Items.Add($"{dept.DeptNo} | {dept.DeptName}");
            }
        }

        private void DeptAuthBinding()
        {
            authlist = departmentSrv.GetAllDeptMenuInfo();
        }
        private void AllMenuBinding()
        {
            //menulist = departmentSrv.GetAllMenuList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //이미있으면 무시,아니면 리스트에 추가
            if (lstDept.SelectedIndex < 0)
            {
                MessageBox.Show("부서를 선택하세요.");
                return;
            }
            else if (lstMenu.SelectedIndex < 0)
            {
                MessageBox.Show("부여할 권한을 선택하세요.");
                return;
            }
            else
            {
                foreach (var item in lstMenu.SelectedItems)
                {
                    if (lstSelect.Items.IndexOf(item.ToString()) < 0)
                    {
                        lstSelect.Items.Add(item.ToString());
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //선택된 권한을 lstSelect에서 삭제
            if (lstSelect.SelectedIndex < 0)
            {
                MessageBox.Show("삭제할 권한을 선택하세요.");
                return;
            }
            else
            {
                lstSelect.Items.Remove(lstSelect.SelectedItem);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lstDept_MouseClick(object sender, MouseEventArgs e)
        {
            lstSelect.Items.Clear();
            DeptNo = Convert.ToInt32(lstDept.SelectedItem.ToString().Split('|')[0].Trim());

            var selList = authlist.FindAll((m) => m.DeptNo == DeptNo);
            foreach (DeptMenuVO item in selList)
            {
                lstSelect.Items.Add(item.MenuName);
            }
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            //현재 선택된 권한ID목록을 DB에 저장
            
            List<int> selAuthList = new List<int>();
            foreach (var item in lstSelect.Items)
            {
                int menu_id = mlist.Find((m) => m.MenuName.Equals(item)).MenuID;
                selAuthList.Add(menu_id);
            }
            deptList = departmentSrv.GetAllDeptInfo();

            //var list = (from dept in deptList
            //           where dept.DeptName == deptName
            //           select new DepartmentVO
            //           {
            //               DeptName = dept.DeptName,
            //               DeptNo = dept.DeptNo
            //           }).ToList();

            //if(list == null)
            //{
            //    MessageBox.Show("중복된 부서 입니다");
            //}
            ///*deptList((d) => d.DeptName == deptName).DeptNo != null)*/
                
            

            departmentSrv.SaveMenuAuth(selAuthList, DeptNo);
            MessageBox.Show("저장완료");
            DeptAuthBinding();
        }
    }
}
