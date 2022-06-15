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
    public partial class popSaveBOM : bPopCommon
    {
        ModelService modelSrv;
        List<ProdPartVO> modelList;
        List<CommonCodeVO> categoryList;

        string code;

        public popSaveBOM(string code, string kind)
        {
            InitializeComponent();

            this.code = code;

            modelSrv = new ModelService();
            if (kind == "완제품")            
                modelList = modelSrv.GetPartAndSemiProd(true);            
            else // 부품
                modelList = modelSrv.GetPartAndSemiProd(false);
        }

        private void popSaveBOM_Load(object sender, EventArgs e)
        {
            categoryList = modelSrv.GetCategory();
            InitControl();
        }

        void InitControl()
        {
            cboKind.Items.AddRange(new string[] { "분류", "반제품", "부품" });
            cboKind.SelectedIndex = 0;
            
            ComboBoxUtil.SetComboBoxByList<CommonCodeVO>
                (
                    cboCategory, 
                    new List<CommonCodeVO>() { new CommonCodeVO() { Name = "품목", Code = String.Empty} },
                    "Name", "Code"
                );            
            cboCategory.SelectedIndex = 0;

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "모델명", "Name", colWidth: 210);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "분류", "Kind", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "품목", "Category");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "코드", "Code", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "가격", "Price", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "재고", "Inventory", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래", "Dealing", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이미지", "Image", isVisible: false);
            dgvList.DataSource = modelList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ProdPartVO> list = modelList.ConvertAll<ProdPartVO>(p => p);

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
            dgvList.DataSource = modelList;
        }

        private void cboKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKind.SelectedIndex == 0)
            {
                ComboBoxUtil.SetComboBoxByList<CommonCodeVO>
                (
                    cboCategory,
                    new List<CommonCodeVO>() { new CommonCodeVO() { Name = "품목", Code = String.Empty } },
                    "Name", "Code"
                );
                cboCategory.SelectedIndex = 0;
            }
            else
            {
                List<CommonCodeVO> list;
                if (cboKind.Text == "반제품")
                    list = categoryList.FindAll(c => c.Category == "제품");
                else // 부품
                    list = categoryList.FindAll(c => c.Category == "부품");

                list.Insert(0, new CommonCodeVO()
                {
                    Name = "품목",
                    Code = String.Empty
                });
                ComboBoxUtil.SetComboBoxByList<CommonCodeVO>(cboCategory, list, "Name", "Code");
            }
        }
    }
}
