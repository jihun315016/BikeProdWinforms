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
    public partial class frmBOM : baseCommon
    {
        ModelService modelSrv;
        List<ProdPartVO> bomProdList;

        public frmBOM()
        {
            InitializeComponent();
        }

        private void frmBOM_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IsNotVisibleLabel();
            modelSrv = new ModelService();

            InitControl();
        }

        void InitControl()
        {
            bomProdList = modelSrv.GetBomProd(true);
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "제품명", "Name", colWidth: 220);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "분류", "Kind");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "카테고리", "Category", colWidth: 120);
            dgvList.DataSource = bomProdList;

            DataGridViewUtil.SetInitGridView(dgvParent);
            DataGridViewUtil.SetInitGridView(dgvChild);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            popSelectSaveBOM pop1 = new popSelectSaveBOM();
            if (pop1.ShowDialog() == DialogResult.OK)
            {
                popSaveBOM pop2 = new popSaveBOM(pop1.selectedCode, pop1.selectedKind);
                pop2.ShowDialog();
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBOM_Shown(object sender, EventArgs e)
        {
            dgvParent.Top = 70;
            dgvParent.Height = panel3.Height / 2 - 100;
            dgvChild.Top = panel3.Height / 2 + 70;
            dgvChild.Height = panel3.Height / 2 - 100;

            lblParent.Top = dgvParent.Top - lblParent.Height - 5;
            lblChild.Top = dgvChild.Top - lblChild.Height - 5;
        }
    }
}
