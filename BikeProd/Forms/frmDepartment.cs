﻿using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BikeProd
{
    public partial class frmDepartment : bFrmListAndDetail
    {
        // = null 필요 없음
        List<DepartmentVO> deptList = null;
        List<TeamVO> teamList = null;
        List<TeamEmpVO> teamempList = null;
        DepartmentService departmentSrv = new DepartmentService();

        EmployeeService employeeSrv = new EmployeeService();

        public frmDepartment()
        {
            InitializeComponent();
        }


        private void frmDeptMain_Load(object sender, EventArgs e)
        {
            txtDeptAuth.ReadOnly = true;
            txtNewTeam.SetPlaceHolder();
            txtNewDept.SetPlaceHolder();
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
            LoadcboDept();
            //txtDeptName.Enabled = false;
        }

        private void LoadcboDept()
        {
            deptList = departmentSrv.GetAllDeptInfo();
            deptList.Insert(0, new DepartmentVO { DeptName = "부서 선택" });

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
            cboTeamselect.Enabled = true;

            if (e.RowIndex < 0) return;

            int DeptNo = Convert.ToInt32(dgvDept[0, e.RowIndex].Value);
            teamList = departmentSrv.GetTeamInfo(DeptNo);
            teamempList = employeeSrv.GetEmpTeamInfo(DeptNo);
            List<TeamVO> teamlist = departmentSrv.GetTeamInfo(DeptNo);
            DeptMenuVO deptVO = departmentSrv.GetAuthMenuInfo(DeptNo);

            dgvTeam.DataSource = teamList;
            dgvTeam.Columns[0].Frozen = true;
            dgvTeam.Columns[1].Frozen = true;

            dgvDetail.DataSource = teamempList;

            txtDeptAuth.Clear();
            txtDeptName.Text = dgvDept[1, e.RowIndex].Value.ToString();
            lblDept.Text = "[" + dgvDept[1, e.RowIndex].Value.ToString() + "]";

            //cboTeamselect.DataSource = null;

            teamlist.Insert(0, new TeamVO
            { TeamName = "팀 선택" });

            cboTeamselect.ValueMember = "TeamNo";
            cboTeamselect.DisplayMember = "TeamName";
            cboTeamselect.DataSource = teamlist;

            txtEmpSearch.Text = "사원 검색";

            List<DeptMenuVO> authlist = departmentSrv.GetAllDeptMenuInfo();
            var selList = authlist.FindAll((m) => m.DeptNo == DeptNo);
            foreach (DeptMenuVO item in selList)
            {
                //lstSelect.Items.Add(item.MenuName);
                txtDeptAuth.AppendText(item.MenuName + Environment.NewLine);
            }
            txtDeptAuth.SelectionStart = 0;
            txtDeptAuth.ScrollToCaret();
            //txtDeptAuth.Select(txtDeptAuth.Text.Length, 0);

            //DataRow dr = dt.NewRow();
            //dr["TeamName"] = "---팀 선택---";
            //dt.Rows.InsertAt(dr, 0);
            //dt.AcceptChanges();

            //txtDeptAuth.Text = deptVO.MenuName.ToString();
        }

        private void txtEmpSearch_Click(object sender, EventArgs e)
        {
            txtEmpSearch.Clear();


            cboTeamselect.Enabled = false;
            lblDept.Text = "";

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
            if (string.IsNullOrWhiteSpace(txtEmpSearch.Text) || txtEmpSearch.Text == "사원 검색")
            {
                MessageBox.Show("사원명은 필수 사항입니다.");
                return;
            }
            else
            {
                string empName = txtEmpSearch.Text;
                List<TeamEmpVO> tEAllList = employeeSrv.GetAllEmpTeamInfo();

                TeamEmpVO result = tEAllList.Find((m) => m.EmpName == empName);
                if (result == null)
                {
                    MessageBox.Show("존재하지 않는 사원명입니다.");
                    txtNewDept.Clear();
                    return;
                }
                else
                {
                    //List<TeamEmpVO> tEAllList = employeeSrv.GetAllEmpTeamInfo();
                    var tEList = tEAllList.FindAll((m) => m.EmpName.Equals(empName));

                    dgvDetail.DataSource = null;
                    dgvDetail.DataSource = tEList;
                }
                cboTeamselect.Enabled = true;
                //cboTeamselect.SelectedIndex = 0;
            }
        }

        private void btnTeamInsert_Click(object sender, EventArgs e)
        {
            int deptNo = deptList.Find((m) => m.DeptName.Equals(cboDept.Text)).DeptNo;
            string teamName = txtNewTeam.Text;
            teamList = departmentSrv.GetTeamInfo(deptNo);
            //string inserted = teamList.FindAll((n) => n.TeamName == txtTeamName.Text);


            if (cboDept.SelectedIndex == 0)
            {
                MessageBox.Show("부서를 선택해 주십시오.");
                return;
            }
            else if (string.IsNullOrEmpty(txtNewTeam.Text))
            {
                MessageBox.Show("팀명은 필수 입력입니다.");
                return;
            }
            else if (txtNewTeam.Text.Contains("예)"))
            {
                MessageBox.Show("팀명을 확인해 주십시오.");
                txtNewTeam.Clear();
                return;
            }
            foreach (var a in teamList)
            {
                if (a.TeamName.Contains(teamName))
                {
                    MessageBox.Show("중복된 팀명입니다.");
                    txtNewTeam.Clear();
                    return;
                }
            }

            bool result = departmentSrv.SaveTeam(deptNo, teamName);
            if (result)
            {
                //MessageBox.Show("등록완료!");

                DialogResult result1 = MessageBox.Show("등록완료!", "", MessageBoxButtons.OK);
                if (result1 == DialogResult.OK)
                {
                    teamList = departmentSrv.GetTeamInfo(deptNo);

                    dgvTeam.DataSource = teamList;
                    dgvTeam.Columns[0].Frozen = true;
                    dgvTeam.Columns[1].Frozen = true;

                    txtNewTeam.Clear();
                }
            }
            else
            {
                MessageBox.Show("등록중 오류가 발생하였습니다.");
                return;
            }
        }

        //private void txtDeptName_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtDeptName.Text))
        //    {
        //        txtDeptAuth.Clear();
        //    }
        //}

        private void txtNewTeam_MouseClick(object sender, MouseEventArgs e)
        {
            if (cboDept.SelectedIndex == 0)
            {
                //MessageBox.Show("부서를 먼저 선택하십시오.");

                DialogResult result2 = MessageBox.Show("부서를 선택해 주십시오.", "", MessageBoxButtons.OK);
                if (result2 == DialogResult.OK)
                {
                    txtNewTeam.SetPlaceHolder();
                    return;
                }
            }
            //txtTeamName.SetPlaceHolder();
            //if (txtTeamName.Text == "예)생산 1팀")
            //{
            //    txtTeamName.Clear();
            //}
        }

        private void btnDeptInsert_Click(object sender, EventArgs e)
        {
            string deptName = txtNewDept.Text;
            List<DepartmentVO> deptList = departmentSrv.GetAllDeptInfo();

            if (string.IsNullOrWhiteSpace(txtNewDept.Text) || txtNewDept.Text.Contains("예)"))
            {
                MessageBox.Show("부서명을 확인해 주십시오.");
                return;
            }

            foreach (var a in deptList)
            {
                if (a.DeptName.Contains(deptName))
                {
                    MessageBox.Show("중복된 부서명입니다.");
                    txtNewDept.Clear();
                    return;
                }
            }

            bool result = departmentSrv.SaveDept(deptName);
            if (result)
            {
                DialogResult result1 = MessageBox.Show("등록완료!", "", MessageBoxButtons.OK);
                if (result1 == DialogResult.OK)
                {
                    deptList = departmentSrv.GetAllDeptInfo();

                    dgvDept.DataSource = deptList;
                    dgvTeam.Columns[0].Frozen = true;
                    dgvTeam.Columns[1].Frozen = true;

                    txtNewDept.Clear();
                    LoadcboDept();
                }
            }
            else
            {
                MessageBox.Show("등록중 오류가 발생하였습니다.");
                return;
            }
        }

        private void btnDeptDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewDept.Text) || txtNewDept.Text.Contains("예)"))
            {
                MessageBox.Show("부서명을 확인해 주십시오.");
                return;
            }
            else
            {
                string deptName = txtNewDept.Text;
                List<DepartmentVO> deptList = departmentSrv.GetAllDeptInfo();

                List<DepartmentVO> result = deptList.FindAll((r) => r.DeptName == deptName);
                if (result.Count <= 0)
                {
                    MessageBox.Show("존재하지 않는 부서명입니다.");
                    txtNewDept.Clear();
                    return;
                }
                else
                {
                    bool result2 = departmentSrv.DeleteDept(deptName);
                    if (result2)
                    {
                        DialogResult result1 = MessageBox.Show("삭제완료!", "", MessageBoxButtons.OK);
                        if (result1 == DialogResult.OK)
                        {
                            deptList = departmentSrv.GetAllDeptInfo();

                            dgvDept.DataSource = deptList;
                            dgvTeam.Columns[0].Frozen = true;
                            dgvTeam.Columns[1].Frozen = true;

                            txtNewDept.Clear();
                            LoadcboDept();
                        }
                    }
                    else
                    {
                        MessageBox.Show("삭제중 오류가 발생하였습니다.");
                        return;
                    }
                }
            }
        }

        private void txtDeptName_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("부서목록에서 부서를 선택해 주십시오.");
            return;
        }

        private void btnMenuInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeptName.Text))
            {
                MessageBox.Show("부서를 선택해 주십시오.");
                return;
            }
            else
            {
                popAuthReg pop = new popAuthReg(txtDeptName.Text);
                pop.ShowDialog();
            }
        }

        private void btnTeamDelete_Click(object sender, EventArgs e)
        {
            string teamName = txtNewTeam.Text;
            List<TeamVO> teamList = departmentSrv.GetAllTeamList();

            if (cboDept.SelectedIndex == 0)
            {
                MessageBox.Show("부서를 선택해 주십시오.");
                return;
            }
            else if (string.IsNullOrEmpty(txtNewTeam.Text))
            {
                MessageBox.Show("팀명은 필수 입력입니다.");
                return;
            }
            else if (txtNewTeam.Text.Contains("예)"))
            {
                MessageBox.Show("팀명을 확인해 주십시오.");
                txtNewTeam.Clear();
                return;
            }
            else
            {
                bool result = departmentSrv.DeleteTeam(teamName);
                if (result)
                {
                    DialogResult result1 = MessageBox.Show("삭제완료!", "", MessageBoxButtons.OK);
                    if (result1 == DialogResult.OK)
                    {
                        List<DepartmentVO> deptList = departmentSrv.GetAllDeptInfo();
                        int deptNo = deptList.Find((m) => m.DeptName.Equals(cboDept.Text)).DeptNo;

                        teamList = departmentSrv.GetTeamInfo(deptNo);

                        dgvTeam.DataSource = teamList;
                        dgvTeam.Columns[0].Frozen = true;
                        dgvTeam.Columns[1].Frozen = true;
                        
                        txtNewDept.Clear();
                    }
                    
                }
                else
                {
                    MessageBox.Show("삭제중 오류가 발생하였습니다.");
                    txtNewDept.Clear();
                    return;
                }
            }

        }

        private void cboTeamselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTeamselect.SelectedIndex == 0)
            {
                int DeptNo = Convert.ToInt32(dgvDept.SelectedCells[0].Value);
                List<TeamEmpVO> teamempList = employeeSrv.GetEmpTeamInfo(DeptNo);

                dgvDetail.DataSource = null;
                dgvDetail.DataSource = teamempList;
            }
            else
            {
                //cboTeamselect.DataSource = null;
                List<TeamVO> teamList = departmentSrv.GetAllTeamList();
                int teamNo = teamList.Find((m) => m.TeamName.Equals(cboTeamselect.Text.ToString())).TeamNo;

                List<TeamEmpVO> tEAllList = employeeSrv.GetAllEmpTeamInfo();
                var tEList = tEAllList.FindAll((m) => m.TeamNo.Equals(teamNo));

                dgvDetail.DataSource = null;
                dgvDetail.DataSource = tEList;
            }
            txtEmpSearch.Text = "사원 검색";
        }

        private void cboTeamselect_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblDept.Text))
            {
                MessageBox.Show("부서를 선택해 주십시오.");
                return;
            }
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
