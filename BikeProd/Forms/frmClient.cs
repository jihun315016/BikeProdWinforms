using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeProd.VO;

namespace BikeProd
{
    public partial class frmClient : bFrmList
    {
        ClientService clientSrv;
        List<ClientVO> clientList;

        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            cboType.Items.AddRange(new string[] { "구분", "입고", "출고" });
            cboType.SelectedIndex = 0;
            
            AddressListBinding();

            txtSearch.PlaceHolder = "거래처명 검색";
            txtSearch.SetPlaceHolder();

            clientSrv = new ClientService();
            clientList = clientSrv.GetClientList();

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래처명", "ClientName", colWidth: 200);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "사업자번호", "BusinessNo", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);//isVisible: false);            
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "구분", "Type", colWidth: 90, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "담당자", "Manager", colWidth: 130);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "담당자 연락처", "ManagerPhone", colWidth: 150, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이메일", "Email", colWidth: 220);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주소", "Address", colWidth: 520);
                       

            dgvList.DataSource = clientList;
        }

        // 초기화 버튼
        private void btnReturn_Click(object sender, EventArgs e)
        {
            cboType.SelectedIndex = cboAddr.SelectedIndex = 0;
            txtSearch.Text = "";
            txtSearch.PlaceHolder = "거래처명 검색";
            txtSearch.SetPlaceHolder();

            dgvList.DataSource = clientList;
        }

        // 검색 조건
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ClientVO> list = clientList.ConvertAll<ClientVO>((p) => p);

            // 구분
            if (cboType.SelectedIndex > 0)
                list = list.FindAll((p) => p.Type.Equals(cboType.Text));

            // 주소
            if (cboAddr.SelectedIndex > 0)
                list = list.FindAll((p) => p.Address.Contains(cboAddr.Text));

            // 거래처명
            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text != txtSearch.PlaceHolder)
                list = list.FindAll((p) => p.ClientName.ToLower().Contains(txtSearch.Text.ToLower())).ToList(); 
                //list = list.FindAll((p) => p.ClientName.Contains(txtSearch.Text)).ToList();

            dgvList.DataSource = list;
        }        

        private void AddressListBinding()
        {
            cboAddr.Items.AddRange(new string[]
            {
                "주소", "서울", "부산", "대구", "인천", "광주", "대전", "울산", "세종", "제주", "경기도", "경기도", "강원도", "충청북도", "충청남도", "전라북도", "전라남도", "경상북도", "경상남도"
            });
            cboAddr.SelectedIndex = 0;
        }

        // 삭제 버튼
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("삭제할 거래처를 선택해주세요.");
                    return;
                }

                // 해당 거래처가 거래중이거나 부품, 제품이 등록되어있다면 삭제 불가
                string clientName = (dgvList.SelectedRows[0].Cells["ClientName"].Value).ToString();
                string BusinessNo = (dgvList.SelectedRows[0].Cells["BusinessNo"].Value).ToString();
                if (!clientSrv.ChkClient(BusinessNo))
                {
                    MessageBox.Show("거래중인 거래처입니다. 확인 후 삭제 부탁드립니다");
                    return;
                }

                if (MessageBox.Show($"[{clientName}] : 거래처를 삭제 하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool result = clientSrv.DeleteClient(clientName);
                    if (result)
                    {
                        MessageBox.Show($"[{clientName}] 삭제 완료.");
                        clientList = clientSrv.GetClientList();
                        dgvList.DataSource = clientList;
                    }
                    else
                    {
                        MessageBox.Show("삭제 중 오류 발생.");
                        return;
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("삭제 중 오류가 발생하였습니다.");
            }
                       
        }

        // 등록 버튼
        private void btnSave_Click(object sender, EventArgs e)
        {
            popSaveClient pop = new popSaveClient();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                clientList = clientSrv.GetClientList();
                dgvList.DataSource = clientList;
            }
        }

        private void frmClient_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(this, null);
            }
        }
    }
}
