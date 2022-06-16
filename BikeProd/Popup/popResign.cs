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
    public partial class popResign : bPopCommon
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public bool Resign { get; set; }
        EmployeeService srv = new EmployeeService();
        public popResign(int EmpNO, string Name, string Resign)
        {
            InitializeComponent();
            this.EmpNo = EmpNO;
            this.EmpName = Name;
            btnResign.Text = Resign;
            
        }
        public popResign()
        {
            InitializeComponent();
        }
        private void btnResign_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(btnResign.Text == "퇴사")
                {
                    string ToDate = dtpResign.Text;
                    if (MessageBox.Show($"{EmpName}님을 {ToDate}에 퇴사처리 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool result = srv.UpdateOut(EmpNo, ToDate, btnResign.Text);
                        if (result)
                        {
                            MessageBox.Show("등록되었습니다");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("오류가 발생하였습니다");
                        }
                    }
                }
                else
                {
                    string ToDate = dtpResign.Text;
                    if (MessageBox.Show($"{EmpName}님을 {ToDate}에 재입사처리 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool result = srv.UpdateOut(EmpNo, ToDate, btnResign.Text);
                        if (result)
                        {
                            MessageBox.Show("등록되었습니다");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("오류가 발생하였습니다");
                        }
                    }
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void popResign_Load(object sender, EventArgs e)
        {

        }
    }
}
