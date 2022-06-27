using BikeProd;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BikeProd
{
    public partial class popSearchClient : bPopCommon
    {
        // 고객사인지 여부
        bool isCustomer;
        ClientService clientService;
        List<ClientVO> clientList;

        // 선택된 거래처
        public ClientVO selectedClient;

        public popSearchClient(bool isCustomer)
        {
            InitializeComponent();
            this.isCustomer = isCustomer;
        }

        private void popSearchClient_Load(object sender, EventArgs e)
        {
            // 거래처 정보 조회
            clientService = new ClientService();
            clientList = clientService.GetClientNameByType(isCustomer);
            InitUcSelecor(clientList);

            if (isCustomer)            
                lblTitle.Text = "출고처 검색";            
            else
                lblTitle.Text = "입고처 검색";
            txtSearch.SetPlaceHolder();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var list = clientList.FindAll(c => c.ClientName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            pnlClientList.Controls.Clear();
            InitUcSelecor(list);            
        }

        void InitUcSelecor(List<ClientVO> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                ucSelector selector = new ucSelector();
                selector.Width = 235;
                selector.Location = new Point(3, 3 + 25 * i);
                selector.LabelText = list[i].ClientName;
                selector.Tag = list[i];

                selector.LabelClick += (object obj, EventArgs eArgs) =>
                {
                    foreach (Control elem in pnlClientList.Controls)
                    {
                        if (elem is ucSelector el)
                            el.UnDisplayButton();
                    }

                    ucSelector s = obj as ucSelector;
                    if (s != null)
                        s.DisplayButton();
                };

                selector.ButtonClick += (object obj, EventArgs eArgs) =>
                {
                    ucSelector selected = obj as ucSelector;
                    if (selected != null)
                    {
                        selectedClient = (ClientVO)selected.Tag;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                };

                pnlClientList.Controls.Add(selector);
            }
        }
    }
}
