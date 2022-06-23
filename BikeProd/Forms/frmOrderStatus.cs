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
    public partial class frmOrderStatus : bFrmList
    {
        List<SalesStateVO> stateList;
        TradeService tradeSrv = new TradeService();
        public frmOrderStatus()
        {
            InitializeComponent();
        }

        private void frmSalesStatus_Load(object sender, EventArgs e)
        {
            //OrderNo, ClientName, Manager, PManager, DeliveryDate, ProdName, Price, Qty, Sum, State
            DataGridViewUtil.SetInitGridView(dgvSoldList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldList, "주문 번호", "OrderNo", colWidth: 100, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldList, "고객", "ClientName", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldList, "매출 일자", "DeliveryDate", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldList, "매출액", "Sum", colWidth: 135, alignContent: DataGridViewContentAlignment.MiddleRight);
            //다음 컬럼들은 그리드뷰에서 보이지 않게 처리
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldList, "주문 담당자", "PManager", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldList, "고객 담당자", "Manager", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldList, "state", "State", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldList, "제품명", "ProdName", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldList, "수량", "Qty", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldList, "가격", "Price", isVisible: false);

            DataGridViewUtil.SetInitGridView(dgvSoldDetail);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldDetail, "고객 담당자", "Manager", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldDetail, "주문 담당자", "PManager", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldDetail, "제품명", "ProdName", colWidth: 350, alignContent: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldDetail, "수량", "Qty", colWidth: 100, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldDetail, "가격", "Price", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldDetail, "매출액", "Amount", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleRight);
            //다음 컬럼들은 그리드뷰에서 보이지 않게 처리
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldDetail, "고객", "ClientName", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldDetail, "주문 번호", "OrderNo", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldDetail, "state", "State", isVisible: false);
            //DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvSoldDetail, "매출 일자", "DeliveryDate", isVisible: false);

            dgvSoldList.Columns["Sum"].DefaultCellStyle.Format = "###,##0";
            dgvSoldDetail.Columns["Price"].DefaultCellStyle.Format = "###,##0";
            dgvSoldDetail.Columns["Amount"].DefaultCellStyle.Format = "###,##0";

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

            stateList = tradeSrv.GetSalesSumInfo(dateFrom, dateTo);
            dgvSoldList.DataSource = stateList;

            //매입액 컬럼(Sum) 전체 총합
            int sum = 0;
            for (int i = 0; i < dgvSoldList.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvSoldList.Rows[i].Cells["Sum"].Value);
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


        private void dgvSoldList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int orderNo = Convert.ToInt32(dgvSoldList["OrderNo", e.RowIndex].Value);
            stateList = tradeSrv.GetAllSalesInfo();
            List<SalesStateVO> result = stateList.FindAll((r) => r.OrderNo.Equals(orderNo));

            dgvSoldDetail.DataSource = result;

            //매입액 컬럼(Amount) 전체 총합
            int sum = 0;
            for (int i = 0; i < dgvSoldDetail.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvSoldDetail.Rows[i].Cells["Amount"].Value);
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

            txtClientS.Clear();
            txtDetailTotal.Clear();
            dgvSoldDetail.DataSource = null;


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
            dgvSoldDetail.DataSource = null;

            string dateFrom = dtpFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dtpTo.Value.ToString("yyyy-MM-dd");
            stateList = tradeSrv.GetSalesSumInfo(dateFrom, dateTo);
            int dtfrom = Convert.ToInt32(dtpFrom.Value.ToString("yyyyMMdd"));
            int dtto = Convert.ToInt32(dtpTo.Value.ToString("yyyyMMdd"));

            if (dtfrom > dtto)
            {
                MessageBox.Show("매입일자 설정을 확인해 주세요.");
                return;
            }
            else
            {
                var ssList = stateList.FindAll((m) => m.ClientName.ToLower().Contains(txtClientS.Text.ToLower())).ToList();
                if (ssList.Count <= 0)
                {
                    txtListTotal.Clear();
                    txtDetailTotal.Clear();
                    //txtClientP.Clear();
                    dgvSoldList.DataSource = null;
                    dgvSoldDetail.DataSource = null;
                    MessageBox.Show("해당사항이 없습니다. 거래처명 또는 매입일자를 확인해 주세요.");
                    return;
                }
                else
                {
                    dgvSoldList.DataSource = null;
                    dgvSoldList.DataSource = ssList;

                    //매입액 컬럼(Sum) 전체 총합
                    int sum = 0;
                    for (int i = 0; i < dgvSoldList.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dgvSoldList.Rows[i].Cells["Sum"].Value);
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
