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
        EmployeeService srv = new EmployeeService();
        public popResign(int EmpNO, string Name)
        {

            this.EmpNo = EmpNO;
            this.EmpName = Name;
            InitializeComponent();
        }
        public popResign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ToDate = dateTimePicker1.Text;
                if(MessageBox.Show($"{EmpName}님을 {ToDate}에 퇴사처리 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool result = srv.UpdateOut(EmpNo, ToDate);
                    if (result)
                    {
                        MessageBox.Show("등록되었습니다");
                    }
                    else
                    {
                        MessageBox.Show("오류가 발생하였습니다");
                    }
                }
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void popleave_Load(object sender, EventArgs e)
        {

        }
    }
}
