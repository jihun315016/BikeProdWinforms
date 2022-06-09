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

        List<EmployeeVO> empList = null; // null 필요 없음

        public frmEmployee()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            rdOut.Checked = false;
            rdWorking.Checked = false;
            cboDept.SelectedIndex = 0;
            ccTextBox1.Text = "";
            ccTextBox1.SetPlaceHolder();
            ccTextBox1.PlaceHolder = "직원선택";
            GetAllList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //popEmployee frm = new popEmployee();
            //frm.ShowDialog();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            ccTextBox1.PlaceHolder = "직원선택";
            ccTextBox1.SetPlaceHolder();
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "사원번호", "EmpNo");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "사원명", "EmpName");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "부서코드", "DeptNo");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "팀코드", "TeamNo");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "전화번호", "Phone");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이메일", "Email");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "비밀번호", "Pwd");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "입사일자", "FromDate");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "퇴사일자", "ToDate");
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
            int detpCode = 0;

            if(cboDept.SelectedIndex < 1 || string.IsNullOrWhiteSpace(ccTextBox1.Text)) 
            {
                MessageBox.Show("검색 조건을 입력하여 주세요");
                return;
            }

            if (cboDept.Text.Equals("생산부서"))
                detpCode = 1002;
            else if (cboDept.Text.Equals("영업부서"))
                detpCode = 1003;
            else if (cboDept.Text.Equals("인사부서"))
                detpCode = 1004;

            empList = employeeSrv.GetSearchList(detpCode, ccTextBox1.Text);        
            dgvList.DataSource = empList;

            if(empList.Count < 1)
            {
                MessageBox.Show("검색결과가 없습니다");
                cboDept.SelectedIndex = 0;
                ccTextBox1.Text = "";
                ccTextBox1.SetPlaceHolder();
                ccTextBox1.PlaceHolder = "직원선택";
                GetAllList();
                return;
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count < 1)
            {
                MessageBox.Show("퇴사할 사원을 선택하여 주십시오.");
                return;
            }

            //int EmpNo = Convert.ToInt32(dgvList.SelectedRows[0].Cells["EmpNo"].Value);
            //popleave frm = new popleave(EmpNo);
            //frm.Show();

        }
    }
}
