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
        List<BomRelationVO> allBomList;
        List<ProdPartVO> bomProdList;
        List<CommonCodeVO> categoryList;        

        public frmBOM()
        {
            InitializeComponent();
        }

        private void frmBOM_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IsNotVisibleLabel();
            modelSrv = new ModelService();
            bomProdList = modelSrv.GetBomProd(true);
            categoryList = modelSrv.GetCategory();
            
            InitControl();
            InitTreeView();
        }

        void InitControl()
        {

            cboKind.Items.AddRange(new string[] { "분류", "완제품", "반제품", "부품" });
            cboKind.SelectedIndex = 0;
         
            ComboBoxUtil.SetComboBoxByList<CommonCodeVO>
                (
                    cboCategory,
                    new List<CommonCodeVO>() { new CommonCodeVO() { Name = "품목", Code = String.Empty } },
                    "Name", "Code"
                );
            cboCategory.SelectedIndex = 0;

            txtSearch.SetPlaceHolder();

            // Bom 등록된 모델 리스트            
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "제품명", "Name", colWidth: 230);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "분류", "Kind");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "카테고리", "Category", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "코드", "Code", isVisible: false);
            dgvList.DataSource = bomProdList;

            // 정전개
            DataGridViewUtil.SetInitGridView(dgvChild);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "코드", "Code", colWidth: 120, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "이름", "Name", colWidth: 220);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "분류", "Kind", colWidth: 110);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "품목", "Category", colWidth: 110);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "가격", "Price", alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "수량", "Requirement", alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "합계", "Total", alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvChild, "관계", "Relation", isVisible: false);
            dgvChild.Columns["Price"].DefaultCellStyle.Format = "###,##0";

            // 역전개
            DataGridViewUtil.SetInitGridView(dgvParent);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "코드", "Code", colWidth: 120, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "이름", "Name", colWidth: 220);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "분류", "Kind", colWidth: 110);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "품목", "Category", colWidth: 110);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "가격", "Price", alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "관계", "Relation", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "재고", "Inventory", alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvParent, "LeadTime", "LeadTime");
            dgvParent.Columns["Price"].DefaultCellStyle.Format = "###,##0";
        }

        /// <summary>
        /// Author : 강지훈
        /// TreeView 초기화
        /// </summary>
        void InitTreeView()
        {            
            allBomList = modelSrv.GetAllBomRelation();
            bomTree.Nodes.Clear();
            List<BomRelationVO> list = allBomList.Where(a => a.Level == 1).ToList();
            foreach (BomRelationVO item in list)
            {
                TreeNode tn = new TreeNode(item.ChildName);
                bomTree.Nodes.Add(tn);
                SetTreeView(tn, item.ParentCode, 2);
            }
        }

        /// <summary>
        /// Author : 강지훈
        /// 전체 BOM을 TreeView 형태로 불러온다.
        /// parentCode과 level 조건에 맞는 항목을 노드로 추가한다.
        /// </summary>
        /// <param name="tn">상위 노드</param>
        /// <param name="parentCode">상위 노드의 코드</param>
        /// <param name="level">상위 노드 레벨</param>
        void SetTreeView(TreeNode tn, string parentCode, int level)
        {
            List<BomRelationVO> list = allBomList.Where(a => a.ParentCode == parentCode && a.Level == level).ToList();
            foreach (BomRelationVO bom in list)
            {
                TreeNode t = new TreeNode();
                t.Text = bom.ChildName;
                tn.Nodes.Add(t);
                SetTreeView(t, bom.ChildCode, level + 1);
            }
        }

        /// <summary>
        /// Author : 강지훈
        /// TreeView에서 Node 더블클릭시
        /// DataGridView에서 해당 노드 선택과 정전개, 역전개 조회
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void bomTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            btnInit_Click(this, null);
            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                if (dgvList.Rows[i].Cells["Name"].Value.ToString() == e.Node.Text)
                {
                    dgvList.CurrentCell = dgvList.Rows[i].Cells["Name"];
                    List<BomInfoVO> list = modelSrv.GetBomRelation(dgvList["Code", i].Value.ToString());
                    dgvParent.DataSource = list.FindAll(l => l.Relation == "역전개");
                    dgvChild.DataSource = list.FindAll(l => l.Relation == "정전개");
                    return;
                }
            }
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
                InitTreeView();
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            List<BomInfoVO> list = modelSrv.GetBomRelation(dgvList["Code", e.RowIndex].Value.ToString());
            dgvParent.DataSource = list.FindAll(l => l.Relation == "역전개");
            dgvChild.DataSource = list.FindAll(l => l.Relation == "정전개");
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
                if (cboKind.Text == "완제품" || cboKind.Text == "반제품")
                    list = categoryList.FindAll(c => c.Category == "제품");
                else
                    list = categoryList.FindAll(c => c.Category == "부품");

                list.Insert(0, new CommonCodeVO()
                {
                    Name = "품목",
                    Code = String.Empty
                });
                ComboBoxUtil.SetComboBoxByList<CommonCodeVO>(cboCategory, list, "Name", "Code");
            }
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
                InitTreeView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow.Index < 0)
            {
                MessageBox.Show("삭제할 제품을 선택하세요.");
                return;
            }
            else if (dgvList.CurrentRow.Cells["Kind"].Value.ToString() == "부품")
            {
                MessageBox.Show("부품은 삭제할 수 없습니다.");
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
                try
                {
                    bool queryResult = modelSrv.DeleteBOM(dgvList.CurrentRow.Cells["Code"].Value.ToString());
                    if (queryResult)
                    {
                        MessageBox.Show("삭제되었습니다.");
                        bomProdList = modelSrv.GetBomProd(true);
                        dgvList.DataSource = bomProdList;
                        dgvParent.DataSource = null;
                        dgvChild.DataSource = null;
                        InitTreeView();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("삭제에 실패했습니다.");
                }                
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(this, null);
            }
        }

        private void frmBOM_Activated(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
