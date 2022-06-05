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
    public partial class bFrmListAndDetail : baseCommon
    {
        public bFrmListAndDetail()
        {
            InitializeComponent();
            IsNotVisibleLabel();
        }

        /// <summary>
        /// Author : 강지훈
        /// BaseForm에서 설명을 위해 넣어둔 라벨 제거
        /// </summary>
        protected override void IsNotVisibleLabel()
        {
            base.IsNotVisibleLabel();
            DescriptLabel3.Visible = false;
            DescriptLabel4.Visible = false;
            DescriptLabel5.Visible = false;
        }
    }
}
