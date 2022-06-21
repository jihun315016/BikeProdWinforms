using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BikeProd
{
    public partial class popSaveEmployee : bPopCommon
    {
        EmployeeService employeeSrv;
        List<TeamVO> TeamList;
        List<DepartmentVO> deptList;
        int deptCode = 0;
        int TeamCode = 0;
        string domain;
        public popSaveEmployee()
        {
            InitializeComponent();
        }

        private void popEmployee_Load(object sender, EventArgs e)
        {
            txtEmail.isRequired = txtPhone.isRequired = txtEmail.isRequired = txtPhone.isNumeric = true;
            DeptComboBinding();
            DomainListBinding();
        }



        public bool IsValidEmail(string email)
        {
            bool valid = Regex.IsMatch(email, @"^([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+){1,}$");
            return valid;
        }


        

        /// <summary>
        /// Auther : 류경석
        /// 사원등록 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtName, txtPhone, txtEmail, txtDomain });
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
                return;
            }
            if (cboDomain.SelectedIndex == 0)
            {
                MessageBox.Show("이메일을 입력해주세요");
                return;
            }
            else if (cboDomain.SelectedIndex == 1)
            {
                if (!IsValidEmail(txtDomain.Text))
                {
                    MessageBox.Show("이메일을 확인해주세요");
                    return;
                }

                domain = txtDomain.Text;
            }
            else
            {
                domain = cboDomain.Text;
            }
            if(txtPhone.Text.Length < txtPhone.MaxLength)
            {
                MessageBox.Show("전화번호를 제대로 입력해주세요");
                return;
            }
            
            if (cboDept.SelectedIndex == 0)
            {
                MessageBox.Show("부서를 선택해주세요");
                return;
            }

            if(cboTeam.SelectedIndex != 0)
            {
                TeamList = employeeSrv.GetCodeByTeam(deptCode);
                TeamCode = TeamList.Find((c) => c.TeamName == cboTeam.Text).TeamNo;
            }
                        

            EmployeeVO emp = new EmployeeVO
            {
                EmpName = txtName.Text,
                DeptNo = deptCode,
                TeamNo = TeamCode,
                Phone = txtPhone.Text,
                Email = string.Concat(txtEmail.Text, "@", domain),
                Pwd = "1234",
                FromDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
            };
            bool result = employeeSrv.InsertEmployee(emp);

            if (result)
            {
                MessageBox.Show("등록되었습니다.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("등록 중 오류가 발생했습니다.");
                return;
            }
                
        }
        

        
        /// <summary>
        /// Auther :류경석
        /// 도메인 콤보박스 바인딩
        /// </summary>
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

        /// <summary>
        /// Auther :류경석
        /// 부서명 콤보박스 바인딩
        /// </summary>
        public void DeptComboBinding()
        {
           
            employeeSrv = new EmployeeService();
            deptList = employeeSrv.GetCodeByDept();
            deptList.Insert(0, new DepartmentVO()
            {
                DeptName = "선택",
                DeptNo = 0
            });
            ComboBoxUtil.SetComboBoxByList<DepartmentVO>(cboDept, deptList, "DeptName", "DeptNo");
            cboDept.SelectedIndex = 0;
        }
        /// <summary>
        /// Auther : 류경석
        /// 팀명 콤보박스 바인딩
        /// </summary>
        public void TeamComboBinding()
        {
            employeeSrv = new EmployeeService();
            TeamList = employeeSrv.GetCodeByTeam(deptCode);
            TeamList.Insert(0, new TeamVO()
            {
                TeamName = "선택",
                DeptNo = 0
            });
            ComboBoxUtil.SetComboBoxByList<TeamVO>(cboTeam, TeamList, "TeamName", "DeptNo");
            cboTeam.SelectedIndex = 0;
        }

        private void popEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Auther : 류경석
        /// 전화번호 "-" 자동입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhone_TextChanged_1(object sender, EventArgs e)
        {
            string phone;
            if (txtPhone.Text.Length == 11)
            {
                txtPhone.Text = txtPhone.Text.Insert(3, "-");
                txtPhone.Text = txtPhone.Text.Insert(8, "-");
            }



            /*if (txtPhone.Text.Length == 3 || txtPhone.Text.Length == 8)
            {
                txtPhone.Text += "-";
                txtPhone.Select(txtPhone.Text.Length, 0);
            }*/
        }

        /// <summary>
        /// Auther : 류경석
        /// 도메인 직접입력 선택 시 도메인텍스트박스 활성화 여부
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDomain.Text.Equals("직접입력"))
            {
                txtDomain.Visible = true;
            }
            else
            {
                txtDomain.Visible = false;
            }
            
        }
        /// <summary>
        /// Auther : 류경석
        /// 부서 선택시 해당하는 팀 콤보박스 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDept.SelectedIndex != 0)
            {
                DepartmentVO deptNo = deptList.Find((c) => c.DeptName == cboDept.Text);
                deptCode = deptNo.DeptNo;

                TeamComboBinding();
            }
        }


        /// <summary>
        /// Auther : 류경석
        /// 이메일 유효성 검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Regex emailregex = new Regex(@"[0-9a-zA-Z]$"); 
            Boolean ismatch = emailregex.IsMatch(txtEmail.Text); 
            if (!ismatch) 
            { 
                MessageBox.Show("영문자와 숫자만만 입력해 주세요.");
                txtEmail.Text = "";
                return;
            }
            
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (txtPhone.Text.Length == 11)
            {
                txtPhone.Text = txtPhone.Text.Insert(3, "-");
                txtPhone.Text = txtPhone.Text.Insert(8, "-");
            }*/
        }
    }
}
