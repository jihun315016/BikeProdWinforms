using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeProd
{
    public partial class popChangePwd : bPopCommon
    {
        int empNo;

        public popChangePwd(int empNo)
        {
            InitializeComponent();

            this.empNo = empNo;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtPwd, txtChkPwd });
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
                return;
            }

            if (txtPwd.Text != txtChkPwd.Text)
            {
                MessageBox.Show("비밀번호가 다릅니다.");
                return;
            } 
            try
            {
                bool result = new EmployeeService().UpdateEmpPwd(empNo, txtPwd.Text);
                if (result)
                {
                    MessageBox.Show("비밀번호가 변경되었습니다.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("비밀번호 변경에 실패했습니다.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("비밀번호 변경에 실패했습니다.");
                Debug.WriteLine(err.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
