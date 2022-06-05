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
    public partial class ucFormController : UserControl
    {
        public event EventHandler ButtonClick;
        Form frm;

        public string FormControlText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public ucFormController()
        {
            InitializeComponent();
        }

        public void SetButtonPosition()
        {
            button1.Location = new Point(label1.Left + label1.Width + 10, 0);
            label1.Location = new Point(3, 2);
            button1.Height = label1.Height = 23;
        }

        // ButtonClick 이벤트 발생
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClick(this, null);
        }

        // ButtonClick 이벤트 발생
        public void buttonClickEvent()
        {
            ButtonClick(this, null);
        }

        void FormClose()
        {
            this.frm.Close();
        }        
    }
}
