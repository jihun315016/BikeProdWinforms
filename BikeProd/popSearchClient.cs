using BikeProd.Service;
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
    public partial class popSearchClient : bPopCommon
    {
        // 고객사인지 여부
        bool isCustomer;
        ClientService clientService;
        List<ClientVO> clientList;

        // 선택된 거래처
        string selectedClient;

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

            for (int i = 0; i < clientList.Count; i++)
            {
                ucSelector selector = new ucSelector();
                selector.LabelText = clientList[i].ClientName;
                selector.Location = new Point(3, 3 + 25 * i);
                selector.Width = 235;

                selector.LabelClick += (object obj, EventArgs eArgs) =>
                {
                    foreach (Control elem in panel2.Controls)
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
                        selectedClient = clientList[i].BusinessNo;
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                };

                panel2.Controls.Add(selector);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO : 검색 필터링
        }
    }
}
