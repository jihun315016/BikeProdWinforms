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
    public partial class popEmpReg : bPopCommon
    {
        EmployeeService employeeSrv = null;

        //List<EmployeeVO> empList = null;
        //List<TeamVO> teamList = null;
        int deptCode = 0;
        int TeamCode = 0;
        public popEmpReg()
        {
            InitializeComponent();
        }

        bool IsRequiredTextBox(Func<string> func)
        {
            string textBoxMsg = func();
            if (textBoxMsg.Length > 0)
            {
                MessageBox.Show(textBoxMsg);
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isRequired = IsRequiredTextBox(() => TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtName, txtPhone, txtEmail }));
            if (!isRequired) return;
            if(cboDept.Text.Equals("선택"))
            {
                MessageBox.Show("부서를 선택해주세요");
                return;
            }

            
            string Email;

            if (cboDept.Text.Equals("생산부서"))
                deptCode = 1002;
            else if (cboDept.Text.Equals("영업부서"))
                deptCode = 1003;
            else if (cboDept.Text.Equals("인사부서"))
                deptCode = 1004;

            if (cboTeam.Text.Equals("생산 1팀"))
                TeamCode = 2001;
            else if (cboTeam.Text.Equals("생산 2팀"))
                TeamCode = 2002;

            
            if(txtDomain.Visible)
            {
                
                Email = string.Concat(txtEmail.Text, "@", txtDomain.Text);
            }
            else
            {
                Email = string.Concat(txtEmail.Text, "@", cboDomain.Text);
            }

            EmployeeVO emp = new EmployeeVO
            {
                EmpName = txtName.Text,
                DeptNo = deptCode,
                TeamNo = TeamCode,
                Phone = txtPhone.Text,
                Email = Email,
                Pwd = "1234",
                FromDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
            };
            bool result = employeeSrv.InsertEmployee(emp);

            if (result)
                MessageBox.Show("등록되었습니다.");
            else
                MessageBox.Show("등록 중 오류가 발생했습니다.");


        }

        private void popEmployee_Load(object sender, EventArgs e)
        {
            ComboBinding();
            txtEmail.isRequired = true;
            txtPhone.isRequired = true;
            txtEmail.isRequired = true;

            DomainListBinding();
        }

        public void DomainListBinding()
        {
            cboDomain.Items.Add("선택");
            cboDomain.SelectedIndex = 0;


            string[] domain = {"직접입력", "naver.com", "gmail.com", "kakao.com", "daum.net" };
            foreach(string dom in domain)
            {
                cboDomain.Items.Add(dom);
            }
        }


        public void ComboBinding()
        {
            employeeSrv = new EmployeeService();
            List<DepartmentVO> deptList = employeeSrv.GetCodeByDept();
            cboDept.Items.Add("선택");
            cboDept.SelectedIndex = 0;

            foreach (var lst in deptList)
            {
                cboDept.Items.Add(lst.DeptName);
            }

            /*List<TeamVO> TeamList = employeeSrv.GetCodeByTeam();
            cboTeam.Items.Add("선택");
            cboTeam.SelectedIndex = 0;

            foreach (var lst in TeamList)
            {
                cboTeam.Items.Add(lst.TeamName);
            }*/


        }


        private void popEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

     

        private void txtPhone_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length == 3 || txtPhone.Text.Length == 8)
            {
                txtPhone.Text += "-";
                txtPhone.Select(txtPhone.Text.Length, 0);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cboDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDomain.Text.Equals("직접입력"))
            {
                cboDomain.Visible = false;
                txtDomain.Visible = true;

                txtDomain.Location = cboDomain.Location;
            }
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDept.SelectedIndex != 0)
            {
                cboTeam.Items.Clear();
                if (cboDept.Text.Equals("생산부서"))
                    deptCode = 1002;
                else if (cboDept.Text.Equals("영업부서"))
                    deptCode = 1003;
                else if (cboDept.Text.Equals("인사부서"))
                    deptCode = 1004;


                //cboTeam.Enabled = false;

                List<TeamVO> TeamList = employeeSrv.GetCodeByTeam(deptCode);

                if (TeamList == null)
                {
                    
                }
                else
                {
                    //cboTeam.Enabled = true;
                    cboTeam.Items.Add("선택");
                    cboTeam.SelectedIndex = 0;

                    foreach (var lst in TeamList)
                    {
                        cboTeam.Items.Add(lst.TeamName);
                    }
                }
            }
        }
    }
}
