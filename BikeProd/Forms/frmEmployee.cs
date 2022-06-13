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
        List<EmployeeVO> empList;
        List<DepartmentVO> deptList;
        public frmEmployee()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            rdOut.Checked = false;
            rdWorking.Checked = false;
            cboDept.SelectedIndex = 0;
            txtEmpName.Text = "";
            txtEmpName.SetPlaceHolder();
            txtEmpName.PlaceHolder = "사원선택";
            GetAllList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            txtEmpName.PlaceHolder = "직원선택";
            txtEmpName.SetPlaceHolder();
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "사원번호", "EmpNo",colWidth : 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "사원명", "EmpName",colWidth : 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "부서코드", "DeptNo", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "팀코드", "TeamNo", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "전화번호", "Phone", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이메일", "Email", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "비밀번호", "Pwd", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "입사일자", "FromDate", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "퇴사일자", "ToDate", colWidth: 120);
            GetAllList();
            ComboBinding();
        }
        public void GetAllList()
        {
            empList = employeeSrv.GetEmployeesAllList();
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
            dgvList.DataSource = employeeSrv.GetWorkingList();
        }

        private void rdOut_CheckedChanged(object sender, EventArgs e)
        {
            dgvList.DataSource = employeeSrv.GetOutList();
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] {txtEmpName});
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
            }

                deptList = departmentSrv.GetAllDeptInfo();

            int detpCode = deptList.Find((d) => d.DeptName == cboDept.Text).DeptNo;

            if (empList == null)
            {
                empList = employeeSrv.GetEmployeesAllList();
            }

            var SearchList = (from emp in empList
                             where emp.EmpName == txtEmpName.Text && emp.DeptNo == detpCode
                             select new EmployeeVO
                             {
                                 EmpName = emp.EmpName,
                                 DeptNo = emp.DeptNo,
                                 Email = emp.Email,
                                 EmpNo = emp.EmpNo,
                                 TeamNo = emp.TeamNo,
                                 Phone = emp.Phone,
                                 Pwd = emp.Pwd,
                                 FromDate = emp.FromDate,
                                 ToDate = emp.ToDate
                             }).ToList();

            dgvList.DataSource = SearchList;

            if(SearchList == null)
            {
                MessageBox.Show("검색결과가 없습니다");
                cboDept.SelectedIndex = 0;
                txtEmpName.Text = "";
                txtEmpName.SetPlaceHolder();
                txtEmpName.PlaceHolder = "직원선택";
                GetAllList();
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            popSaveEmployee frm = new popSaveEmployee();
            frm.ShowDialog();
        }

        private void btnResign_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count < 1)
            {
                MessageBox.Show("퇴사할 사원을 선택하여 주십시오.");
                return;
            }

            int EmpNo = Convert.ToInt32(dgvList.SelectedRows[0].Cells["EmpNo"].Value);
            string Name = (dgvList.SelectedRows[0].Cells["EmpName"].Value).ToString();
            //popResign frm = new popResign(EmpNo, Name);
            //frm.Show();
        }
    }
}
