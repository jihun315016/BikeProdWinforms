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
    public partial class frmModel : bFrmListAndDetail
    {
        ModelService modelSrv;
        List<ProdPartVO> prodPartList;
        List<CommonCodeVO> categoryList;

        public frmModel()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            modelSrv = new ModelService();
            prodPartList = modelSrv.GetModelList();
            categoryList = modelSrv.GetCategory();
            InitControls();
        }

        /// <summary>
        /// Author : 강지훈
        /// 컨트롤 초기화
        /// </summary>
        void InitControls()
        {
            cboKind.Items.AddRange(new string[] { "분류", "완제품", "반제품", "부품" });
            cboKind.SelectedIndex = 0;

            cboCategory.Items.Add("품목");
            cboCategory.SelectedIndex = 0;

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "코드", "Code", colWidth: 180);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "모델명", "Name", colWidth: 180);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "분류", "Kind", colWidth: 180);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "품목", "Category", colWidth: 180);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "가격", "Price", colWidth: 180);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "재고", "Inventory", colWidth: 180);
            dgvList.DataSource = prodPartList;
        }

        /// <summary>
        /// Author : 강지훈
        /// 선택된 cboKind 값에 따라 cboCategory에 품목을 입력한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKind.SelectedIndex == 0)
            {
                cboCategory.DataSource = null;
                cboCategory.Items.Add("품목");
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
            if (cboKind.SelectedIndex > 0)
            {

            }

            if (cboCategory.SelectedIndex > 0)
            {

            }

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            popSaveModel pop = new popSaveModel();
            pop.ShowDialog();
        }
    }
}
