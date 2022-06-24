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
    public partial class frmProduction : baseCommon
    {
        ProductionService productionSrv;
        List<ProductionVO> productionList;

        public frmProduction()
        {
            InitializeComponent();
        }

        private void frmProduction_Load(object sender, EventArgs e)
        {
            base.IsNotVisibleLabel();
            productionSrv = new ProductionService();
            InitControl();
            SetDataGridView();            

        }
        void InitControl()
        {
            ccTxtLoss.SetPlaceHolder();

            DataGridViewUtil.SetInitGridView(dgvProduction);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "생산 번호", "ID", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "제품 코드", "ProdCode", colWidth: 130, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "제품명", "ProdName", colWidth: 250);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "재고", "Inventory", colWidth: 120, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "생산 수량", "Qty", colWidth: 120, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "가격", "Price", colWidth: 120, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "Lead Time", "LeadTime", colWidth: 120, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "지시일", "OrderDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "납품 요청일", "ReqDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "작업팀", "Team", colWidth: 150);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "상태", "State", colWidth: 150);
            dgvProduction.Columns["Price"].DefaultCellStyle.Format = "###,##0";

            DataGridViewUtil.SetInitGridView(dgvComplete);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "생산 번호", "ID", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "제품 코드", "ProdCode", colWidth: 130, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "제품명", "ProdName", colWidth: 250);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "재고", "Inventory", colWidth: 120, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "생산 수량", "Qty", colWidth: 120, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "Loss", "Loss", colWidth: 120, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "가격", "Price", colWidth: 120, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "지시일", "OrderDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "납품 요청일", "ReqDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "생산 완료일", "CompleteDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "작업팀", "Team", colWidth: 150);
            dgvComplete.Columns["Price"].DefaultCellStyle.Format = "###,##0";

            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = DateTime.Now.AddMonths(-1);

            cboState.Items.AddRange(new string[] { "상태", "생산 진행 중", "생산 취소" });
            List<string> ProductionTeams = new DepartmentService().GetTeamInfo(1002).Select(t => t.TeamName).ToList();
            ProductionTeams.Insert(0, "작업팀");
            cboTeam.DataSource = ProductionTeams;
            cboState.SelectedIndex = cboTeam.SelectedIndex = 0;
        }

        void SetDataGridView()
        {
            string state = cboState.SelectedIndex == 0 ? string.Empty : cboState.SelectedItem.ToString();
            string team = cboTeam.SelectedIndex == 0 ? string.Empty : cboTeam.SelectedItem.ToString();
            productionList = productionSrv.GetProductionList(dtpStart.Value, dtpEnd.Value, state, team);
            dgvProduction.DataSource = productionList.Where(p => p.State != "생산 완료").ToList();
            dgvComplete.DataSource = productionList.Where(p => p.State == "생산 완료").ToList();

            int total = 0;
            int loss = 0;
            foreach (DataGridViewRow row in dgvComplete.Rows)
            {
                total = total + Convert.ToInt32(row.Cells["Qty"].Value);
                loss = loss + Convert.ToInt32(row.Cells["Loss"].Value);
            }
            ccTxtTotal.Text = total.ToString();
            ccTxtTotalLoss.Text = loss.ToString();
            if (ccTxtTotal.Text == "0")
                ccTxtDefectRate.Text = string.Empty;
            else
                ccTxtDefectRate.Text = $"{Math.Round((double)loss / total, 4) * 100}%";
        }

        private void dgvProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ccTxtLoss.Text = string.Empty;
            ccTxtLoss.SetPlaceHolder();
        }

        private void btnSaveProduction_Click(object sender, EventArgs e)
        {
            popSaveProduction pop = new popSaveProduction();
            pop.ShowDialog();
        }

        private void btnCompleteProduction_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProduction.CurrentRow.Cells["ID"].Value);
            string code = dgvProduction.CurrentRow.Cells["ProdCode"].Value.ToString();
            int loss = Convert.ToInt32(ccTxtLoss.Text);

            if (string.IsNullOrWhiteSpace(ccTxtLoss.Text) || ccTxtLoss.Text == ccTxtLoss.PlaceHolder)
            {
                MessageBox.Show("Loss를 입력해주세요.");
                return;
            }
            else if (loss > Convert.ToInt32(dgvProduction.CurrentRow.Cells["Qty"].Value))
            {
                MessageBox.Show("Loss가 생산 수량보다 많습니다.");
                return;
            }

            DialogResult result = MessageBox.Show($"[{dgvProduction.CurrentRow.Cells["ProdName"].Value}]{Environment.NewLine}생산 완료 처리하시겠습니까?", "생산 완료", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool queryResult = productionSrv.UpdateProductionState(true, id, code, loss);
                if (queryResult)
                {
                    MessageBox.Show("완료 처리되었습니다.");
                    ccTxtLoss.Text = string.Empty;
                    ccTxtLoss.SetPlaceHolder();
                    SetDataGridView();
                }
                else
                {
                    MessageBox.Show("완료 처리에 실패했습니다.");
                }
            }
        }

        private void btnCancelProduction_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"[{dgvProduction.CurrentRow.Cells["ProdName"].Value}]{Environment.NewLine}생산 취소 처리하시겠습니까?", "생산 취소", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvProduction.CurrentRow.Cells["ID"].Value);
                string code = dgvProduction.CurrentRow.Cells["ProdCode"].Value.ToString();
                bool queryResult = productionSrv.UpdateProductionState(false, id, code);
                if (queryResult)
                {
                    MessageBox.Show("취소 처리되었습니다.");
                    SetDataGridView();
                }
                else
                {
                    MessageBox.Show("취소 처리에 실패했습니다.");
                }
            }
        }

        private void btnSearchProduction_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            cboState.SelectedIndex = cboTeam.SelectedIndex = 0;
            SetDataGridView();
        }
    }
}
