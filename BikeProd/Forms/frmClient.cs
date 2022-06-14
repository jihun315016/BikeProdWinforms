using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BikeProd; // Service 랑 DAC 네임스페이스 확인
using BikeProd.VO;

namespace BikeProd
{
    public partial class frmClient : bFrmList
    {
        ClientService clientSrv = null;
        List<ClientVO> clientList = null;

        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            cboType.Items.AddRange(new string[] { "구분", "입고", "출고" });
            cboType.SelectedIndex = 0;

            //cboAddr.Items.Add("주소");
            //cboAddr.SelectedIndex = 0;
            AddressListBinding();

            txtSearch.PlaceHolder = "거래처명 검색";
            txtSearch.SetPlaceHolder();

            clientSrv = new ClientService();
            clientList = clientSrv.GetClientList();

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래처명", "ClientName", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "구분", "Type", colWidth: 100);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "담당자", "Manager", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "담당자 연락처", "ManagerPhone", colWidth: 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이메일", "Email", colWidth: 200);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주소", "Address", colWidth: 200);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "사업자번호", "BusinessNo", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "대표번호", "CompanyPhone", isVisible: false);

            dgvList.DataSource = clientList;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            cboType.SelectedIndex = cboAddr.SelectedIndex = 0;
            txtSearch.Text = "";
            txtSearch.PlaceHolder = "거래처명 검색";
            txtSearch.SetPlaceHolder();

            dgvList.DataSource = clientList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ClientVO> list = clientList.ConvertAll<ClientVO>((p) => p);

            if (cboType.SelectedIndex > 0)
                list = list.FindAll((p) => p.Type.Equals(cboType.Text));

            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text != txtSearch.PlaceHolder)
                list = list.FindAll((p) => p.ClientName.Contains(txtSearch.Text));

            if (cboAddr.SelectedIndex > 0)
                list = list.FindAll((p) => p.Address.Contains(cboAddr.Text));

            dgvList.DataSource = list;
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // 돌았네 - 수정 예정
        private void AddressListBinding()
        {
            cboAddr.Items.AddRange(new string[]
            {
                "주소", "서울", "부산", "대구", "인천", "광주", "대전", "울산", "세종", "제주", "경기도", "경기도", "강원도", "충청북도", "충청남도", "전라북도", "전라남도", "경상북도", "경상남도"
            });

            cboAddr.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            popSaveClient pop = new popSaveClient();
            pop.ShowDialog();
        }
    }
}
