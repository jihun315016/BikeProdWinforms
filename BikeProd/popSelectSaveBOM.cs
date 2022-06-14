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
    public partial class popSelectSaveBOM : bPopCommon
    {
        public string selectedCode;
        ModelService modelSrv;
        List<ProdPartVO> notBomProdList;

        public popSelectSaveBOM()
        {
            InitializeComponent();
        }

        private void popSelectSaveBOM_Load(object sender, EventArgs e)
        {
            modelSrv = new ModelService();
            InitControl();
        }

        void InitControl()
        {
            cboKind.Items.AddRange(new string[] { "분류", "완제품", "반제품" });
            cboKind.SelectedIndex = 0;

            List<CommonCodeVO> list = modelSrv.GetCategory().FindAll(l => l.Category == "제품");
            list.Insert(0, new CommonCodeVO()
            {
                Name = "품목",
                Code = String.Empty
            });
            ComboBoxUtil.SetComboBoxByList<CommonCodeVO>(cboCategory, list, "Name", "Code");
            cboCategory.SelectedIndex = 0;

            txtSearch.SetPlaceHolder();

            notBomProdList = modelSrv.GetNotBomProd();
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "제품명", "Name", colWidth: 280);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "분류", "Kind");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "품목", "Category");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "코드", "Code", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "가격", "Price", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "재고", "Inventory", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래", "Dealing", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이미지", "Image", isVisible: false);

            dgvList.DataSource = notBomProdList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ProdPartVO> list = notBomProdList.ConvertAll<ProdPartVO>(p => p);

            if (cboKind.SelectedIndex > 0)
                list = list.FindAll(p => p.Kind == cboKind.Text);

            if (cboCategory.SelectedIndex > 0)
                list = list.FindAll(p => p.Category == cboCategory.Text);

            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text != txtSearch.PlaceHolder)
                list = list.FindAll(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower()));

            dgvList.DataSource = list;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            cboKind.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            txtSearch.Text = String.Empty;
            txtSearch.SetPlaceHolder();
            dgvList.DataSource = notBomProdList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            DataGridViewRow row = dgvList.SelectedRows[0];
            selectedCode = row.Cells["Code"].Value.ToString();
            this.Close();
        }
    }
}
