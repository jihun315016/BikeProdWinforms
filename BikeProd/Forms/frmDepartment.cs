using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BikeProd
{
    public partial class frmDepartment : bFrmListAndDetail
    {
        // = null 필요 없음
        List<DepartmentVO> deptList = null;
        List<TeamVO> teamList = null;
        List<EmployeeVO> empList = null;                
        DataTable dt = null;
        DepartmentService departmentSrv = new DepartmentService();
        EmployeeService employeeSrv = new EmployeeService();

        public frmDepartment()
        {
            InitializeComponent();
        }

        
        private void frmDeptMain_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvDept);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDept, "부서 코드", "DeptNo", colWidth: 139);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDept, "부서명", "DeptName", colWidth: 200);

            DataGridViewUtil.SetInitGridView(dgvTeam);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvTeam, "팀 코드", "TeamNo", colWidth: 139);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvTeam, "팀명", "TeamName", colWidth: 200);

            DataGridViewUtil.SetInitGridView(dgvDetail);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDetail, "사번", "EmpNo", colWidth: 100);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDetail, "이름", "EmpName", colWidth: 150);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDetail, "팀", "TeamName", colWidth: 150);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDetail, "연락처", "Phone", colWidth: 180);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDetail, "입사날짜", "FromDate", colWidth: 161);

            LoadData();
            LoadDeptCBO();
         }

        private void LoadDeptCBO()
        {
            deptList = departmentSrv.GetAllDeptInfo();

            cboDept.ValueMember = "DeptNo";
            cboDept.DisplayMember = "DeptName";
            cboDept.DataSource = deptList;
        }

        private void LoadData()
        {
            deptList = departmentSrv.GetAllDeptInfo();
            dgvDept.DataSource = deptList;

            dgvDept.Columns[0].Frozen = true;
            dgvDept.Columns[1].Frozen = true;    
        }

        private void dgvDept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            
            int DeptNo = Convert.ToInt32(dgvDept[0, e.RowIndex].Value);
            teamList = departmentSrv.GetAllTeamInfo(DeptNo);
            empList = employeeSrv.GetEmpInfo(DeptNo);
            dt = departmentSrv.GetTeamInfoTable(DeptNo);
            DeptMenuVO deptVO = departmentSrv.GetAuthMenuInfo(DeptNo);

            dgvTeam.DataSource = teamList;
            dgvTeam.Columns[0].Frozen = true;
            dgvTeam.Columns[1].Frozen = true;            

            dgvDetail.DataSource = empList;

            txtDeptName.Text = dgvDept[1, e.RowIndex].Value.ToString();
            lblDept.Text = "[" + dgvDept[1, e.RowIndex].Value.ToString() +"]";

            DataRow dr = dt.NewRow();
            dr["TeamName"] = "---팀 선택---";
            dt.Rows.InsertAt(dr, 0);
            dt.AcceptChanges();

            cboTeamselect.ValueMember = "TeamNo";
            cboTeamselect.DisplayMember = "TeamName";
            cboTeamselect.DataSource = dt;

            txtEmpSearch.Text = "사원 검색";

            txtDeptAuth.Text = deptVO.MenuName.ToString();
        }

        private void txtEmpSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpSearch.Text))
            {
                MessageBox.Show("먼저 부서를 선택하십시오.");
                return;
            }

            if (cboTeamselect.SelectedIndex != 0)
            {
                txtEmpSearch.Clear();
            }
            else
            {
                MessageBox.Show("먼저 팀을 선택하십시오.");
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int TeamNo = Convert.ToInt32(cboTeamselect.SelectedIndex);
            string EmpName = txtEmpSearch.Text;
            EmployeeVO empVO = employeeSrv.searchEmpInfo(TeamNo, EmpName);

            dgvDetail.DataSource = empVO;
        }

        private void btnDeptInsert_Click(object sender, EventArgs e)
        {
            //frmAuthRegPopUp pop = new frmAuthRegPopUp();
            //pop.ShowDialog();
        }

        private void btnTeamInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
