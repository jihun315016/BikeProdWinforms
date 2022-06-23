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
    public partial class popLoading : Form
    {
        public Action Worker { get; set; }

        public popLoading(Action worker)
        {
            InitializeComponent();
            this.Worker = worker;
        }

        private void popWaitAsync_Load(object sender, EventArgs e)
        {
            var task = Task.Factory.StartNew(this.Worker);
            task.ContinueWith((t)=>this.Close(), TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
