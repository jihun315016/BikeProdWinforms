using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.Configuration;

namespace BikeProd
{
    public partial class popSaveAddress : bPopCommon
    {
        public string AddrCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public popSaveAddress()
        {
            InitializeComponent();
        }

        private void popSaveAddress_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvList);

            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "우편번호", "zipNo", colWidth: 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "도로명주소", "roadAddr", colWidth: 390);

            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "지번주소", "jibunAddr", colWidth: 150, isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주소1", "roadAddrPart1", colWidth: 150, isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "주소2", "roadAddrPart2", colWidth: 150, isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "건물명", "bdNm", colWidth: 150, isVisible: false);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string apiKey = ConfigurationManager.AppSettings["zipAPIKey"];            
            string apiUrl = $"https://www.juso.go.kr/addrlink/addrLinkApi.do?confmKey={apiKey}&currentPage=1&countPerPage=100&keyword={txtAddrSearch.Text}";
            // // h//ttps://www.juso.go.kr/addrlink/addrLinkApi.do?confmKey=devU01TX0FVVEgyMDIyMDQyNTA5MjcwNTExMjQ5NDc=&currentPage=1&countPerPage=100&keyword=%EB%8C%80%EB%A5%AD
            try
            {
                WebClient wc = new WebClient();
                XmlReader reader = new XmlTextReader(wc.OpenRead(apiUrl));

                DataSet ds = new DataSet();
                ds.ReadXml(reader);

                if (ds.Tables.Count > 0) // 정상
                {
                    if (ds.Tables[0].Rows[0]["errorCode"].ToString() == "0")
                    {
                        if (ds.Tables.Count > 1)  
                        {
                            dgvList.DataSource = ds.Tables[1];
                        }
                        else
                        {
                            dgvList.DataSource = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show(ds.Tables[0].Rows[0]["errorMessage"].ToString());
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtAddrCode.Text = dgvList["zipNo", e.RowIndex].Value.ToString();
            txtAddr1.Text = dgvList["roadAddrPart1", e.RowIndex].Value.ToString();            

            string addr2 = dgvList["roadAddrPart2", e.RowIndex].Value.ToString();
            string bdNm = dgvList["bdNm", e.RowIndex].Value.ToString();

            if (addr2.Contains(bdNm))
                txtAddr2.Text = addr2;
            else
                txtAddr2.Text = addr2 + bdNm;            
        }

        private void btanSave_Click(object sender, EventArgs e)
        {
            AddrCode = txtAddrCode.Text;
            Address1 = txtAddr1.Text;
            Address2 = txtAddr2.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }       
    }
}
