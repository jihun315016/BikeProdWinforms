using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeProd.DAC;
using BikeProd.VO;

namespace BikeProd
{
    public partial class popAuthReg : Form
    {
        List<DeptMenuVO> authlist = null;
        int MenuID;
        public popAuthReg()
        {
            InitializeComponent();
        }

        private void frmAuthRegPopUp_Load(object sender, EventArgs e)
        {
            MenuBinding();         
            DeptBinding();         
            DeptAuthBinding();  
        }

        private void MenuBinding()
        {
            //MenuID, MenuName, PntID, FrmName
            //MenuDAC db = new MenuDAC();
            //List<MenuVO> list = db.GetAllMenuList();
            //db.Dispose();

            //var menu1 = list.FindAll((m) => m.PntID == null).OrderBy((m) => m.MenuID);
            //foreach (MenuVO menu in menu1)
            //{ 
            //    TreeNode node = new TreeNode(menu.MenuName);
            //    node.Tag = menu.MenuID;
            //    treeView1.Nodes.Add(node); //루트노드

            //    var menu2 = list.FindAll((m) => m.PntID != null && m.PntID == menu.MenuID
            //    ).OrderBy((m) => m.MenuID);

            //    foreach (MenuVO c_menu in menu2)
            //    {
            //        TreeNode c_node = new TreeNode(c_menu.MenuName); 
            //        c_node.Tag = c_menu.MenuID;
            //        node.Nodes.Add(c_node); //루트노드의 자식노드
            //    }
            //}
            //treeView1.ExpandAll();
        }

        
        private void DeptBinding()
        {
            DepartmentDAC db = new DepartmentDAC();
            List<DepartmentVO> list = db.GetAllDeptInfo();
            db.Dispose();

            foreach (DepartmentVO dept in list)
            {
                lstAll.Items.Add($"{dept.DeptNo} | {dept.DeptName}");
            }
        }

        private void DeptAuthBinding()
        {
            DepartmentDAC dac = new DepartmentDAC();
            authlist = dac.GetAllDeptMenuInfo();
            dac.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //이미있으면 무시,아니면 리스트에 추가
            foreach (var item in lstAll.SelectedItems)
            {
                if (lstSelect.Items.IndexOf(item.ToString()) < 0)
                {
                    lstSelect.Items.Add(item.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //선택된 부서를 lstSelect에서 삭제
            lstSelect.Items.Remove(lstSelect.SelectedItem);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //대메뉴에는 권한을 부여하지 않고 중메뉴에만 권한을 부여한다.
            string[] arr = e.Node.Tag.ToString().Split('|');
            if (arr.Length != 2) return;

            MenuID = Convert.ToInt32(arr[0]);

            lblPath.Text = "";
            lstSelect.Items.Clear();
            

            if (MenuID <= 3)
            {
                lstSelect.Enabled = lstAll.Enabled = false;
            }
            else
            {
                lblPath.Text = $"[{e.Node.Parent.Text}>{e.Node.Text}]";
                e.Node.BackColor = Color.Yellow;
                lstSelect.Enabled = lstAll.Enabled = true;

                var selList = authlist.FindAll((m) => m.MenuID == MenuID);
                foreach (DeptMenuVO item in selList)
                {
                    lstSelect.Items.Add($"{item.DeptNo} | {item.DeptName}");
                }
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            foreach (TreeNode n in treeView1.Nodes)
            {
                ClearRecursive(n);
            }
        }

        private void ClearRecursive(TreeNode node)
        {
            foreach (TreeNode n in node.Nodes)
            {
                n.BackColor = Color.White;
                ClearRecursive(n);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            ////현재 선택된 권한ID목록과 메뉴ID를 DB에 저장
            //List<int> authList = new List<int>();
            //foreach (var item in lstSelect.Items)
            //{
            //    authList.Add(int.Parse(item.ToString().Split('|')[0]));
            //}
            //MenuDAC db = new MenuDAC();
            ////db.SaveMenuAuth(authList, menu_id);
            //MessageBox.Show("저장완료");
        }
    }
}
