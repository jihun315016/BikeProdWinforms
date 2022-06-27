using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeProd
{
    public partial class frmMenu : baseCommon
    {        
        List<bool> pos; // ucFormController가 위치할 인덱스 번호

        LoginService loginService;
        List<MenuVO> menuList;
        TreeView menuTree;

        public EmployeeVO EmpInfo { get; set; }

        public frmMenu()
        {
            InitializeComponent();           
        }

        /// <summary>
        /// Author : 강지훈
        /// menuTree, menuList 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin pop = new frmLogin();
            if (pop.ShowDialog() != DialogResult.OK)
            {
                this.Close();
                return;
            }
            else
            {
                this.Show();
                this.EmpInfo = pop.empVO;

                lblUserInfo.Text = $"[{pop.empVO.DeptName}] {pop.empVO.EmpName}님 안녕하세요.";
                lblUserInfo.Left = btnChangePwd.Left - lblUserInfo.Width - 20;
                lblUserInfo.Tag = pop.empVO.EmpNo; // 사번
                loginService = new LoginService();
                menuList = loginService.GetMenuList(Convert.ToInt32(pop.empVO.EmpNo));
            }
            
            base.IsNotVisibleLabel();            

            // 최상위 메뉴 버튼 초기화
            var list = menuList.FindAll(m => string.IsNullOrWhiteSpace(m.FrmName));
            for (int i = 0; i < list.Count; i++)            
            {
                Button btn = new Button();
                btn.Text = list[i].MenuName;
                btn.Size = new Size(175, 30);
                btn.Tag = new int[2] { list[i].PntID, i }; // [상위 메뉴 ID, FlowLayoutPanel 인덱스 번호]
                btn.Click += MenuButtonClick;
                flowLayoutPanel1.Controls.Add(btn);
            }

            // menuTree 초기화
            menuTree = new TreeView();
            menuTree.Size = new Size(175, 10);
            menuTree.NodeMouseDoubleClick += MenuTree_NodeMouseDoubleClick;
            menuTree.BackColor = SystemColors.Control;
            menuTree.BorderStyle = BorderStyle.None;
            flowLayoutPanel1.Controls.Add(menuTree);

            // pos 초기화
            pos = new List<bool>();
            for (int i = 0; i < menuList.Count; i++)
                pos.Add(false);
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            int empNo = Convert.ToInt32(lblUserInfo.Tag);
            popChangePwd pop = new popChangePwd(empNo);
            pop.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Author : 강지훈
        /// 클릭된 버튼에 대한 하위 메뉴 조회
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuButtonClick(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            menuTree.Nodes.Clear();

            var list = menuList.FindAll(m => m.PntID == ((int[])clickedBtn.Tag)[0] && !string.IsNullOrWhiteSpace(m.FrmName));
            foreach (MenuVO item in list)
            {
                TreeNode node = new TreeNode(item.MenuName);
                node.Tag = new string[] { item.FrmName, item.MenuName }; // [폼 클래스 이름, 폼 한글 이름]
                menuTree.Nodes.Add(node);
            }

            // menuTree 높이 동적으로 설정
            menuTree.ItemHeight = 25;
            menuTree.Height = menuTree.Nodes.Count * menuTree.ItemHeight + 4;

            flowLayoutPanel1.Controls.SetChildIndex(menuTree, ((int[])clickedBtn.Tag)[1] + 1);
            flowLayoutPanel1.Invalidate();
        }

        private void MenuTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                OpenCreateForm(((string[])e.Node.Tag)[0], ((string[])e.Node.Tag)[1]);            
            }
            catch
            {
                MessageBox.Show("중비중입니다.");
            }
        }

        /// <summary>
        /// Author : 강지훈
        /// menuTree에서 더블클릭된 메뉴 조회
        /// 프로그램당 하나의 페이지만 열린다.
        /// </summary>
        /// <param name="fomClassName">활성화시킬 폼 클래스 이름</param>
        /// <param name="frmKorName">활성화시킬 폼 한글 이름</param>
        void OpenCreateForm(string fomClassName, string frmKorName)
        {
            string appName = Assembly.GetEntryAssembly().GetName().Name;           
            Type type = Type.GetType($"{appName}.{fomClassName}");
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == type)
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = (Form)Activator.CreateInstance(type);
            frm.MdiParent = this;
            CreateUcFormControl(frm, frmKorName);
            frm.Show();
        }

        /// <summary>
        /// Author : 강지훈
        /// 새로 생성되는 폼에 대한 ucFormController 생성
        /// </summary>
        /// <param name="frm">새로 생성되는 폼</param>
        void CreateUcFormControl(Form frm, string name)
        {
            ucFormController formControl = new ucFormController();
            int cnt = GetPosition();
            panel1.Controls.Add(formControl);
            formControl.Location = new Point(210 + 170 * cnt, 40);
            formControl.FormControlText = name; // 폼 이름
            formControl.SetButtonPosition();
            
            frm.Tag = formControl;

            frm.FormClosed += (object obj, FormClosedEventArgs e) =>
            {
                ucFormController selected = ((Form)obj).Tag as ucFormController;
                RemoveUcFormControl(selected.FormControlText);                
            };

            formControl.ButtonClick += (object obj, EventArgs eArgs) =>
            {
                ucFormController selected = obj as ucFormController;
                RemoveUcFormControl(selected.FormControlText);
                frm.Close();
            };
            panel1.Controls.Add(formControl);
        }

        /// <summary>
        /// Author : 강지훈
        /// ucFormControl이 생성될 위치 찾기
        /// </summary>
        /// <returns></returns>
        int GetPosition()
        {
            for (int i = 0; i < pos.Count; i++)
            {
                if (pos[i].Equals(false))
                {
                    pos[i] = true;
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Author : 강지훈
        //  ucFormControl 제거
        /// </summary>
        /// <param name="text"></param>
        void RemoveUcFormControl(string text)
        {
            int index = -1;
            foreach (Control control in panel1.Controls)
            {
                if (control is ucFormController item)
                {
                    index++;
                    if (item.FormControlText.Equals(text))
                    {
                        pos.RemoveAt(index);
                        pos.Add(false);
                        panel1.Controls.Remove(item);
                        UpdateUcFormControl();
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Author : 강지훈
        /// ucFormControl이 제거될 때, 나머지 ucFormControl 위치 조정
        /// </summary>
        void UpdateUcFormControl()
        {
            int cnt = 0;
            foreach (Control con in panel1.Controls)
            {
                if (con is ucFormController item)
                {
                    item.Location = new Point(210 + 170 * cnt, 40);
                    cnt++;
                }
            }
        }
    }
}
