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
            //다음 컬럼들은 그리드뷰에서 보이지 않게 처리
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDetail, "부서번호", "DeptNo", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDetail, "팀 코드", "TeamNo", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDetail, "이메일", "Email", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDetail, "비밀번호", "Pwd", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvDetail, "퇴사날짜", "ToDate", isVisible: false);

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
            teamList = departmentSrv.GetTeamInfo(DeptNo);
            empList = employeeSrv.GetEmpInfo(DeptNo);
            List<TeamVO> teamlist = departmentSrv.GetTeamInfo(DeptNo);
            DeptMenuVO deptVO = departmentSrv.GetAuthMenuInfo(DeptNo);

            dgvTeam.DataSource = teamList;
            dgvTeam.Columns[0].Frozen = true;
            dgvTeam.Columns[1].Frozen = true;



            dgvDetail.DataSource = empList;

            txtDeptName.Text = dgvDept[1, e.RowIndex].Value.ToString();
            lblDept.Text = "[" + dgvDept[1, e.RowIndex].Value.ToString() + "]";

            //DataRow dr = dt.NewRow();
            //dr["TeamName"] = "---팀 선택---";
            //dt.Rows.InsertAt(dr, 0);
            //dt.AcceptChanges();

            teamlist.Insert(0, new TeamVO
            { TeamName = "---팀 선택---" });

            cboTeamselect.ValueMember = "TeamNo";
            cboTeamselect.DisplayMember = "TeamName";
            cboTeamselect.DataSource = teamlist;

            txtEmpSearch.Text = "사원 검색";

            txtDeptAuth.Text = deptVO.MenuName.ToString();
        }

        private void txtEmpSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblDept.Text))
            {
                MessageBox.Show("먼저 부서를 선택하십시오.");
                return;
            }
            else
            {
                txtEmpSearch.Clear();
            }

            //if (cboTeamselect.SelectedIndex != 0)
            //{
            //    txtEmpSearch.Clear();
            //}
            //else
            //{
            //    MessageBox.Show("먼저 팀을 선택하십시오.");
            //    return;
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if (cboTeamselect.SelectedIndex == 0)
            //{
            //    MessageBox.Show("팀선택은 필수 사항입니다.");
            //    return;
            //}
            if (string.IsNullOrWhiteSpace(lblDept.Text))
            {
                MessageBox.Show("먼저 부서를 선택하십시오.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmpSearch.Text) || txtEmpSearch.Text == "사원 검색")
            {
                MessageBox.Show("사원명은 필수 사항입니다.");
                return;
            }
            int TeamNo = Convert.ToInt32(cboTeamselect.SelectedIndex);
            string EmpName = txtEmpSearch.Text;
            EmployeeVO empVO = employeeSrv.searchEmpInfo(TeamNo, EmpName);

            dgvDetail.DataSource = empVO;
        }

        private void btnDeptInsert_Click(object sender, EventArgs e)
        {
            popAuthReg pop = new popAuthReg();
            pop.ShowDialog();
        }

        private void btnTeamInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeamName.Text))
            {
                MessageBox.Show("팀명은 필수 입력입니다.");
                return;
            }

        }




    }
}
