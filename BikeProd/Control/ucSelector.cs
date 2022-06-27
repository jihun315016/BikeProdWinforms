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

    public partial class ucSelector : UserControl
    {
        public event EventHandler LabelClick;
        public event EventHandler ButtonClick;

        public string LabelText 
        { 
            get { return label1.Text; }
            set { label1.Text = value; } 
        }

        public ucSelector()
        {
            InitializeComponent();
        }

        private void ucSelector_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Top = button1.Top + 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (LabelClick != null)
                LabelClick(this, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick(this, null);
        }

        public void UnDisplayButton()
        {
            button1.Visible = false;
        }

        public void DisplayButton()
        {
            button1.Visible = true;
        }

        public void SetLabelWidth()
        {
            label1.Width = this.Width - button1.Width - 3;
        }
    }
}
