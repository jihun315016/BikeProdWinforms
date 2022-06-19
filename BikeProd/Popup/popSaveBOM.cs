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
        List<BomInfoVO> bomList;

        string code;
        string kind;
        string copyCode;

        public popSaveBOM(string code, string name, string kind, string copyCode = "")
        {
            InitializeComponent();

            this.code = code;
            lblTitle.Text = name;
            this.kind = kind;
            this.copyCode = copyCode;
        }

        private void popSaveBOM_Load(object sender, EventArgs e)
        {
            modelSrv = new ModelService();
            bomList = new List<BomInfoVO>();
            categoryList = modelSrv.GetCategory();
            InitControl();
        }

        void InitControl()
        {
            if (kind == "완제품")
            {
                cboKind.Items.AddRange(new string[] { "분류", "반제품", "부품" });
                modelList = modelSrv.GetPartAndSemiProd(true);
            }
            else // 반제품
            {
                cboKind.Items.AddRange(new string[] { "분류", "부품" });
                modelList = modelSrv.GetPartAndSemiProd(false);
            }
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
            dgvList.DataSource = modelList;

            DataGridViewUtil.SetInitGridView(dgvBom);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "모델명", "Name", colWidth: 190);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "분류", "Kind", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "품목", "Category");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "수량", "Requirement", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvBom, "코드", "Code", isVisible: false);

            if (!string.IsNullOrWhiteSpace(copyCode))
            {
                bomList = modelSrv.GetBomRelation(copyCode).FindAll(b => b.Relation == "정전개");
                dgvBom.DataSource = bomList;
            }
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
                        new BomInfoVO()
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
                BomInfoVO item = bomList.Find(b => b.Code == txtCode.Text);
                item.Requirement = item.Requirement + Convert.ToInt32(txtRequirement.Text);
            }

            dgvBom.DataSource = null;
            dgvBom.DataSource = bomList;
        }

        private void btnBomCancel_Click(object sender, EventArgs e)
        {
            BomInfoVO item = bomList.Find(b => b.Code == txtCode.Text);
            bomList.Remove(item);
            dgvBom.DataSource = null;
            dgvBom.DataSource = bomList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bomList.Count == 0)
            {
                MessageBox.Show("BOM 등록할 하위 모델을 선택하세요.");
                return;
            }

            try
            {
                bool result = modelSrv.SaveBom(code, bomList);
                if (result)
                {
                    MessageBox.Show("BOM 등록이 완료되었습니다.");
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("BOM 등록에 실패했습니다.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
