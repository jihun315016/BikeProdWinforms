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

            // Bom 등록된 제품 리스트
            bomProdList = modelSrv.GetBomProd(true);
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "제품명", "Name", colWidth: 240);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "분류", "Kind");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "카테고리", "Category");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "코드", "Code", isVisible: false);
            dgvList.DataSource = bomProdList;

            // 정전개
            DataGridViewUtil.SetInitGridView(dgvChild);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "코드", "Code", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "이름", "Name", colWidth: 250);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "분류", "Kind", colWidth: 110);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "품목", "Category", colWidth: 110);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "가격", "Price");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "수량", "Requirement");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "합계", "Total");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "관계", "Relation", isVisible: false);

            // 역전개
            DataGridViewUtil.SetInitGridView(dgvParent);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "코드", "Code", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "이름", "Name", colWidth: 250);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "분류", "Kind", colWidth: 110);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "품목", "Category", colWidth: 110);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "가격", "Price");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "관계", "Relation", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "재고", "Inventory");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "LeadTime", "LeadTime");            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            popSelectSaveBOM pop1 = new popSelectSaveBOM();
            if (pop1.ShowDialog() == DialogResult.OK)
            {
                popSaveBOM pop2 = new popSaveBOM(pop1.SelectedCode, pop1.SeletedName, pop1.SelectedKind);
                pop2.ShowDialog();
                bomProdList = modelSrv.GetBomProd(true);
                dgvList.DataSource = bomProdList;
                dgvParent.DataSource = null;
                dgvChild.DataSource = null;
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            List<BomRelationVO> list = modelSrv.GetBomRelation(dgvList["Code", e.RowIndex].Value.ToString());
            dgvParent.DataSource = list.FindAll(l => l.Relation == "역전개");
            dgvChild.DataSource = list.FindAll(l => l.Relation == "정전개");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ProdPartVO> list = bomProdList.ConvertAll<ProdPartVO>(p => p);

            // 분류 체크
            if (cboKind.SelectedIndex > 0)
                list = list.FindAll(p => p.Kind == cboKind.Text);

            // 품목 체크
            if (cboCategory.SelectedIndex > 0)
                list = list.FindAll(p => p.Category == cboCategory.Text);

            // 검색 체크
            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text != txtSearch.PlaceHolder)
                list = list.FindAll(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower()));

            dgvList.DataSource = list;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = bomProdList;                        
            cboKind.SelectedIndex = cboCategory.SelectedIndex = 0;
            txtSearch.Text = String.Empty;
            txtSearch.SetPlaceHolder();
        }

        private void btmCopy_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow.Index < 0)
            {
                MessageBox.Show("복사할 제품을 선택하세요.");
                return;
            }

            popSelectSaveBOM pop1 = new popSelectSaveBOM();
            if (pop1.ShowDialog() == DialogResult.OK)
            {
                popSaveBOM pop2 = new popSaveBOM
                    (
                        pop1.SelectedCode, 
                        pop1.SeletedName, 
                        pop1.SelectedKind,
                        dgvList.CurrentRow.Cells["Code"].Value.ToString()
                    );
                pop2.ShowDialog();
                bomProdList = modelSrv.GetBomProd(true);
                dgvList.DataSource = bomProdList;
                dgvParent.DataSource = null;
                dgvChild.DataSource = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow.Index < 0)
            {
                MessageBox.Show("삭제할 제품을 선택하세요.");
                return;
            }

            DialogResult result = MessageBox.Show
                (
                    $"{dgvList.CurrentRow.Cells["Name"].Value.ToString()}를 삭제하시겠습니까?",
                    "삭제 확인",
                    MessageBoxButtons.YesNo
                );

            if (result == DialogResult.Yes)
            {
                // TODO : BOM 삭제
            }
        }
    }
}
