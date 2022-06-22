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
    public partial class frmProduction : bFrmList
    {
        ProductionService productionSrv;

        List<ProductionVO> productionList;

        public frmProduction()
        {
            InitializeComponent();
        }

        private void frmProduction_Load(object sender, EventArgs e)
        {
            productionSrv = new ProductionService();
            productionList = productionSrv.GetProductionList();
            InitControl();
            DataSetGridView(productionList);
        }

        void InitControl()
        {
            DataGridViewUtil.SetInitGridView(dgvProduction);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "생산 번호", "ID", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "제품 코드", "ProdCode", colWidth: 130, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "제품명", "ProdName", colWidth: 250);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "재고", "Inventory", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "생산 수량", "Qty", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "가격", "Price", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "Lead Time", "LeadTime", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "지시일", "OrderDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "납품 요청일", "ReqDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "작업팀", "Team", colWidth: 150);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvProduction, "상태", "State", colWidth: 150);            

            DataGridViewUtil.SetInitGridView(dgvComplete);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "생산 번호", "ID", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "제품 코드", "ProdCode", colWidth: 130, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "제품명", "ProdName", colWidth: 250);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "재고", "Inventory", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "생산 수량", "Qty", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "Loss", "Loss", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "가격", "Price", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "지시일", "OrderDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "납품 요청일", "ReqDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "생산 완료일", "ComplateDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvComplete, "작업팀", "Team", colWidth: 150);
        }

        void DataSetGridView(List<ProductionVO> list)
        {
            dgvProduction.DataSource = list.Where(p => p.State != "생산 완료").ToList();
            dgvComplete.DataSource = list.Where(p => p.State == "생산 완료").ToList();

            int total = 0;
            int loss = 0;
            foreach (DataGridViewRow row in dgvComplete.Rows)
            {
                total = total + Convert.ToInt32(row.Cells["Qty"].Value);
                loss = loss + Convert.ToInt32(row.Cells["Loss"].Value);
            }
            txtTotal.Text = total.ToString();
            txtLoss.Text = loss.ToString();
            txtDefectRate.Text = Math.Round((double)loss / total, 2).ToString();
        }

        // GetProductionList
        private void btnSaveProduction_Click(object sender, EventArgs e)
        {
            popSaveProduction pop = new popSaveProduction();
            pop.ShowDialog();
        }

        private void btnCompleteProduction_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"[{dgvProduction.CurrentRow.Cells["ProdName"].Value}]{Environment.NewLine}생산 완료 처리하시겠습니까?", "생산 완료", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvProduction.CurrentRow.Cells["ID"].Value);
                string code = dgvProduction.CurrentRow.Cells["ProdCode"].Value.ToString();
                bool queryResult = productionSrv.UpdateProductionState(true, id, code);
                if (queryResult)
                {
                    MessageBox.Show("완료 처리되었습니다.");
                    productionList = productionSrv.GetProductionList();
                    DataSetGridView(productionList);
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
                    DataSetGridView(productionList);
                }
                else
                {
                    MessageBox.Show("취소 처리에 실패했습니다.");
                }
            }
        }
    }
}
