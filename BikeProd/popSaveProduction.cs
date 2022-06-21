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
    public partial class popSaveProduction : bPopCommon
    {
        ProductionService ProductionSrv;
        List<BomInfoVO> prodList;

        public popSaveProduction()
        {
            InitializeComponent();
        }

        private void popSaveProduction_Load(object sender, EventArgs e)
        {
            ProductionSrv = new ProductionService();
            prodList = ProductionSrv.GetOrderedProd();
            InitControl();
        }

        void InitControl()
        {
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "코드", "Code", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "제품명", "Name", colWidth: 170);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "분류", "Kind", colWidth: 70);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "품목", "Category", colWidth: 70);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "필요 수량", "Requirement", colWidth: 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "Lead Time", "LeadTime", colWidth: 90);
            dgvList.DataSource = prodList;

            DataGridViewUtil.SetInitGridView(dgvPart);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPart, "코드", "Code", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPart, "부품명", "Name", colWidth: 170);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPart, "분류", "Kind", colWidth: 70);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPart, "품목", "Category", colWidth: 70);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPart, "필요 수량", "Requirement", colWidth: 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPart, "재고", "Inventory", colWidth: 70);

            List<TeamVO> list = ProductionSrv.GetProductionTeeamList();
            list.Insert(0, new TeamVO() { TeamNo = 0, TeamName = "작업팀" });
            ComboBoxUtil.SetComboBoxByList(cboProductionTeam, list, "TeamName", "TeamNo");

            txtQty.SetPlaceHolder();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            List<BomInfoVO> list = ProductionSrv.GetPartsByProd(dgvList["Code", e.RowIndex].Value.ToString());
            dgvPart.DataSource = list;

            txtCode.Text = dgvList["Code", e.RowIndex].Value.ToString();
            txtName.Text = dgvList["Name", e.RowIndex].Value.ToString();
            txtKind.Text = dgvList["Kind", e.RowIndex].Value.ToString();
            txtCatagory.Text = dgvList["Category", e.RowIndex].Value.ToString();

            cboProductionTeam.SelectedIndex = 0;

            txtQty.Text = string.Empty;
            txtQty.SetPlaceHolder();
        }

        private void btnSaveProduction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQty.Text) || txtQty.Text == txtQty.PlaceHolder)
            {
                MessageBox.Show("수량을 입력해주세요.");
                return;
            }

            if (cboProductionTeam.SelectedIndex == 0)
            {
                MessageBox.Show("작업팀을 선택해주세요.");
                return;
            }

            // 지시 날짜 기본값 : CONVERT (date, GETDATE())
            // C# 말고 SQL Server에서 설정할 것

            /* 생산할 부품의 재고가 있는지 검사 */
            StringBuilder sb = new StringBuilder();
            List<BomInfoVO> partList = new List<BomInfoVO>();

            int qty = Convert.ToInt32(txtQty.Text); // 생산 수량
            for (int i = 0; i < dgvPart.Rows.Count; i++)
            {
                int inventory = Convert.ToInt32(dgvPart.Rows[i].Cells["Inventory"].Value); // 재고
                int requirement = Convert.ToInt32(dgvPart.Rows[i].Cells["Requirement"].Value); // 필요 수량
                if (qty * requirement > inventory)                
                    sb.Append($"[{dgvPart.Rows[i].Cells["Name"].Value}] ");

                // 각 부품에 대한 코드와 필요 수량
                // 생산 지시 등록 쿼리에서 사용(UPDATE)
                BomInfoVO partVO = new BomInfoVO()
                {
                    Code = dgvPart.Rows[i].Cells["Code"].Value.ToString(),
                    Requirement = Convert.ToInt32(dgvPart.Rows[i].Cells["Requirement"].Value) * qty
                };
                partList.Add(partVO);
            }

            if (sb.Length > 0) // 재고 부족
            {
                sb.Append($"{Environment.NewLine}재고가 부족합니다.");
                MessageBox.Show(sb.ToString());
                return;
            }
            else // 생산 가능
            {
                // 지시할 생산 정보
                ProductionVO production = new ProductionVO()
                {
                    ProdCode = txtCode.Text,
                    Qty = Convert.ToInt32(txtQty.Text),
                    ReqDate = dtpReqDate.Value,
                    Team = cboProductionTeam.Text
                };

                try
                {
                    bool result = ProductionSrv.SaveProduction(production, partList);
                    if (result)
                    {
                        MessageBox.Show("생산 등록되었습니다.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("등록에 실패했습니다.");
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
