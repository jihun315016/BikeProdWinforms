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
    public partial class frmEmployee : bFrmList
    {
        EmployeeService employeeSrv = new EmployeeService();
        DepartmentService departmentSrv = new DepartmentService();
        List<EmployeeVO> empList = null;

        

        public frmEmployee()
        {
            InitializeComponent();

        }


        private void frmEmployee_Load(object sender, EventArgs e)
        {
            
            txtEmpName.PlaceHolder = "사원선택";
            txtEmpName.SetPlaceHolder();
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "사원번호", "EmpNo",colWidth : 150, alignContent : DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "사원명", "EmpName",colWidth : 150);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "부서", "DeptName", colWidth: 150);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "팀", "TeamName", colWidth: 150);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "전화번호", "Phone", colWidth: 150);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이메일", "Email", colWidth: 150);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "비밀번호", "Pwd", colWidth: 150);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "입사일자", "FromDate", colWidth: 150, alignContent : DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "퇴사일자", "ToDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "부서번호", "DeptNo", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "팀번호", "TeamNo", isVisible: false);

            GetAllList();
            ComboBinding();
        }
        public void GetAllList()
        {
            employeeSrv = new EmployeeService();
            empList = employeeSrv.GetEmployeesAllList();
            dgvList.DataSource = null;
            dgvList.DataSource = empList;
        }

        public void ComboBinding()
        {
            List<DepartmentVO> deptList = employeeSrv.GetCodeByDept();

            cboDept.Items.Add("선택");
            cboDept.SelectedIndex = 0;
            foreach(var lst in deptList)
            {
                cboDept.Items.Add(lst.DeptName);
            }
        }

        private void rdWorking_CheckedChanged(object sender, EventArgs e)
        {
            List<EmployeeVO> workList = empList.FindAll((emp) => emp.ToDate.Year == 1).ToList();
            btnResign.Text = "퇴사";
            dgvList.DataSource = workList;
        }

        private void rdOut_CheckedChanged(object sender, EventArgs e)
        {
            List<EmployeeVO> workList = empList.FindAll((emp) => emp.ToDate.Year != 1).ToList();
            btnResign.Text = "재입사";
            dgvList.DataSource = workList;
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (empList == null)
            {
                empList = employeeSrv.GetEmployeesAllList();
            }
            if(cboDept.SelectedIndex == 0 && string.IsNullOrWhiteSpace(txtEmpName.Text))
            {
                MessageBox.Show("검색조건을 선택하여 주세요");
                return;
            }
            

            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] {txtEmpName});
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
            }
            if (string.IsNullOrWhiteSpace(txtEmpName.Text))
            {
                MessageBox.Show("사원이름을 입력해주세요");
            }

            var SearchList = empList.FindAll((emp) => emp.EmpName == txtEmpName.Text);
            
            
            if (SearchList.Count < 1)
            {
                MessageBox.Show("검색결과가 없습니다");
                cboDept.SelectedIndex = 0;
                txtEmpName.Text = "";
                
                txtEmpName.PlaceHolder = "사원선택";
                GetAllList();
                return;
            }
            txtEmpName.Text = string.Empty;
            dgvList.DataSource = SearchList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            popSaveEmployee frm = new popSaveEmployee();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                GetAllList();
            }
        }

        private void btnResign_Click(object sender, EventArgs e)
        {

            if (dgvList.SelectedRows.Count < 1)
            {
                MessageBox.Show("사원을 선택하여 주십시오.");
                return;
            }
            int EmpNo = Convert.ToInt32(dgvList.SelectedRows[0].Cells["EmpNo"].Value);
            string Name = (dgvList.SelectedRows[0].Cells["EmpName"].Value).ToString();

            popResign frm = new popResign(EmpNo, Name, btnResign.Text);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    GetAllList();
                }
            
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdOut.Checked = false;
            rdWorking.Checked = false;
            cboDept.SelectedIndex = 0;
            txtEmpName.Text = "";
            txtEmpName.SetPlaceHolder();
            txtEmpName.PlaceHolder = "사원선택";
            GetAllList();
        }

        private void cboDept_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GetAllList();
            if(cboDept.SelectedIndex != 0)
            {
                empList = empList.FindAll((emp) => emp.DeptName == cboDept.Text); 
            }
            
            dgvList.DataSource = empList;

        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToDateTime(dgvList.SelectedRows[0].Cells["ToDate"].Value).Year != 1)
            {
                btnResign.Text = "재입사";
            }
            else
            {
                btnResign.Text = "퇴사";
            }
        }

        private void frmEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }
    }
}
