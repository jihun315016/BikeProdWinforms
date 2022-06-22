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
    public partial class frmPurchaseStatus : bFrmList
    {
        List<PurchaseStateVO> stateList;
        TradeService tradeSrv = new TradeService();


        public frmPurchaseStatus()
        {
            InitializeComponent();
        }

        private void frmPurchaseStatus_Load(object sender, EventArgs e)
        {
            //PurchaseNo, ClientName, PManager, Manager, ArriveDate, State, PartName, Qty, Price, Amount
            DataGridViewUtil.SetInitGridView(dgvPCList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCList, "발주 번호", "PurchaseNo", colWidth: 100, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCList, "입고처", "ClientName", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCList, "매입 일자", "ArriveDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCList, "매입액", "Sum", colWidth: 135, alignContent: DataGridViewContentAlignment.MiddleRight);
            //다음 컬럼들은 그리드뷰에서 보이지 않게 처리
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCList, "발주 담당자", "PManager", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCList, "거래처 담당자", "Manager", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCList, "state", "State", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCList, "부품명", "PartName", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCList, "수량", "Qty", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCList, "가격", "Price", isVisible: false);

            DataGridViewUtil.SetInitGridView(dgvPCDetail);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCDetail, "거래처 담당자", "Manager", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCDetail, "발주 담당자", "PManager", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCDetail, "부품명", "PartName", colWidth: 350, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCDetail, "수량", "Qty", colWidth: 100, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCDetail, "가격", "Price", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCDetail, "매입액", "Amount", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleRight);
            //다음 컬럼들은 그리드뷰에서 보이지 않게 처리
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCDetail, "입고처", "ClientName", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCDetail, "발주 번호", "PurchaseNo", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCDetail, "state", "State", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvPCDetail, "매입 일자", "ArriveDate", isVisible: false);

            dgvPCList.Columns["Sum"].DefaultCellStyle.Format = "###,##0";
            dgvPCDetail.Columns["Price"].DefaultCellStyle.Format = "###,##0";
            dgvPCDetail.Columns["Amount"].DefaultCellStyle.Format = "###,##0";

            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = dtpTo.Value.AddDays(-7);

            LoadData();
            LoadcboPeriod();
        }

        private void LoadData()
        {
            //dtpTo.Value = DateTime.Today;
            //dtpFrom.Value = dtpTo.Value.AddDays(-7);

            string dateFrom = dtpFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dtpTo.Value.ToString("yyyy-MM-dd");

            stateList = tradeSrv.GetPurchaseSumInfo(dateFrom, dateTo);
            dgvPCList.DataSource = stateList;

            //매입액 컬럼(Sum) 전체 총합
            int sum = 0;
            for (int i = 0; i < dgvPCList.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvPCList.Rows[i].Cells["Sum"].Value);
            }
            txtListTotal.Text = sum.ToString();

            txtListTotal.ReadOnly = true;
            txtListTotal.TextAlign = HorizontalAlignment.Right;
            textMoney(txtListTotal);
        }

        private void textMoney(TextBox textMoney)
        {
            try //숫자 이외의 문자들 입력시, 발생하는 오류를 방지
            {
                int num;
                string temp = textMoney.Text.Replace(",", ""); //입력되는 텍스트들의 ','를 전부 삭제
                num = Convert.ToInt32(temp);                 // 문자열 temp를 int형으로 변환
                string k = string.Format("{0:#,###}", num); // num을 string으로 변환하면서 천단위 콤마 표시

                textMoney.Text = k;
                textMoney.SelectionStart = textMoney.TextLength; //커서를 항상 맨뒤로
            }
            catch (Exception err) { }
        }

        private void LoadcboPeriod()
        {
            cboPeriod.Items.Clear();

            //cboPeriod.Items.Insert(0, "기간 선택");
            //cboPeriod.Items.Add("1일");
            cboPeriod.Items.Add("1주일");
            cboPeriod.Items.Add("1개월");
            cboPeriod.Items.Add("3개월");
            cboPeriod.Items.Add("6개월");

            cboPeriod.SelectedIndex = 0;
        }


        private void dgvPurchasedList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int purchaseNo = Convert.ToInt32(dgvPCList["PurchaseNo", e.RowIndex].Value);
            stateList = tradeSrv.GetAllPurchasedInfo();
            List<PurchaseStateVO> result = stateList.FindAll((r) => r.PurchaseNo.Equals(purchaseNo));

            dgvPCDetail.DataSource = result;

            //매입액 컬럼(Amount) 전체 총합
            int sum = 0;
            for (int i = 0; i < dgvPCDetail.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvPCDetail.Rows[i].Cells["Amount"].Value);
            }
            txtDetailTotal.Text = sum.ToString();

            txtDetailTotal.ReadOnly = true;
            txtDetailTotal.TextAlign = HorizontalAlignment.Right;
            textMoney(txtDetailTotal);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = dtpTo.Value.AddDays(-7);

            LoadData();
            LoadcboPeriod();

            txtClientP.Clear();
            txtDetailTotal.Clear();
            dgvPCDetail.DataSource = null;


        }

        private void cboPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboPeriod.Text)
            {
                //case "기간 선택":
                //    dtpFrom.Value = dtpTo.Value;
                //    break;
                //case "1일":
                //    dtpFrom.Value = dtpTo.Value.AddDays(-1);
                //    break;                
                case "1주일":
                    dtpFrom.Value = dtpTo.Value.AddDays(-7);
                    break;
                case "1개월":
                    dtpFrom.Value = dtpTo.Value.AddMonths(-1);
                    break;
                case "3개월":
                    dtpFrom.Value = dtpTo.Value.AddMonths(-3);
                    break;
                case "6개월":
                    dtpFrom.Value = dtpTo.Value.AddMonths(-6);
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPCDetail.DataSource = null;

            string dateFrom = dtpFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dtpTo.Value.ToString("yyyy-MM-dd");
            stateList = tradeSrv.GetPurchaseSumInfo(dateFrom, dateTo);
            int dtfrom = Convert.ToInt32(dtpFrom.Value.ToString("yyyyMMdd"));
            int dtto = Convert.ToInt32(dtpTo.Value.ToString("yyyyMMdd"));

            if (dtfrom > dtto)
            {
                MessageBox.Show("매입일자 설정을 확인해 주세요.");
                return;
            }
            else
            {
                var ssList = stateList.FindAll((m) => m.ClientName.ToLower().Contains(txtClientP.Text.ToLower())).ToList();
                if (ssList.Count <= 0)
                {
                    txtListTotal.Clear();
                    txtDetailTotal.Clear();
                    //txtClientP.Clear();
                    dgvPCList.DataSource = null;
                    dgvPCDetail.DataSource = null;
                    MessageBox.Show("해당사항이 없습니다. 거래처명 또는 매입일자를 확인해 주세요.");
                    return;
                }                
                else
                {                    
                    dgvPCList.DataSource = null;
                    dgvPCList.DataSource = ssList;

                    //매입액 컬럼(Sum) 전체 총합
                    int sum = 0;
                    for (int i = 0; i < dgvPCList.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dgvPCList.Rows[i].Cells["Sum"].Value);
                    }
                    txtListTotal.Text = sum.ToString();

                    txtListTotal.ReadOnly = true;
                    txtListTotal.TextAlign = HorizontalAlignment.Right;
                    textMoney(txtListTotal);
                    
                    return;
                }

            }
        }
    }
}
