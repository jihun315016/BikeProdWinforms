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
        List<BomDetailVO> bomList;

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
            bomList = new List<BomDetailVO>();
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

            txtSearch.SetPlaceHolder();
            txtRequirement.SetPlaceHolder();

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

            DataGridViewUtil.SetInitGridView(dgvBom);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "모델명", "Name", colWidth: 190);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "분류", "Kind", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "품목", "Category");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "수량", "Requirement", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "코드", "Code", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "가격", "Price", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "재고", "Inventory", isVisible: false);
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

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtCode.Text = dgvList["Code", e.RowIndex].Value.ToString();
            txtName.Text = dgvList["Name", e.RowIndex].Value.ToString();
            txtKind.Text = dgvList["Kind", e.RowIndex].Value.ToString();
            txtCatagory.Text = dgvList["Category", e.RowIndex].Value.ToString();

            txtRequirement.Text = string.Empty;
            txtRequirement.SetPlaceHolder();
        }

        private void dgvBom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtCode.Text = dgvBom["Code", e.RowIndex].Value.ToString();
            txtName.Text = dgvBom["Name", e.RowIndex].Value.ToString();
            txtKind.Text = dgvBom["Kind", e.RowIndex].Value.ToString();
            txtCatagory.Text = dgvBom["Category", e.RowIndex].Value.ToString();

            txtRequirement.Text = string.Empty;
            txtRequirement.SetPlaceHolder();
        }

        private void btnAddBom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRequirement.Text) || txtRequirement.Text == txtRequirement.PlaceHolder)
            {
                MessageBox.Show("수량을 입력해주세요.");
                return;
            }

            // 하위 항목을 새로 등록하는 경우
            if (bomList.FindIndex(b => b.Code == txtCode.Text) == -1)
            {
                bomList.Add
                    (
                        new BomDetailVO()
                        {
                            Code = txtCode.Text,
                            Name = txtName.Text,
                            Kind = txtKind.Text,
                            Category = txtCatagory.Text,
                            Requirement = Convert.ToInt32(txtRequirement.Text)
                        }
                    );
            }
            // 이미 등록한 항목을 다시 등록하는 경우
            else
            {
                BomDetailVO item = bomList.Find(b => b.Code == txtCode.Text);
                item.Requirement = item.Requirement + Convert.ToInt32(txtRequirement.Text);
            }

            // dgvBom.DataSource = bomList; 이거 왜 안돼?            
            dgvBom.DataSource = bomList.FindAll(b => true).ToList();
        }

        private void btnBomCancel_Click(object sender, EventArgs e)
        {
            BomDetailVO item = bomList.Find(b => b.Code == txtCode.Text);
            bomList.Remove(item);
            dgvBom.DataSource = bomList.FindAll(b => true).ToList();
        }
    }
}
