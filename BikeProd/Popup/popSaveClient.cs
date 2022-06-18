using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeProd.VO;

namespace BikeProd
{
    public partial class popSaveClient : bPopCommon
    {
        ClientService clientSrv = new ClientService();
        public popSaveClient()
        {
            InitializeComponent();
        }
        private void popSaveClient_Load(object sender, EventArgs e)
        {
            cboType.Items.AddRange(new string[] { "구분", "입고", "출고" });
            cboType.SelectedIndex = 0;

            txtAddrCode.ReadOnly = txtAddr1.ReadOnly = txtAddr2.ReadOnly = true;

            DomainListBinding();
        }

        // 우편번호 검색 버튼
        private void btnZipCodeSearch_Click(object sender, EventArgs e)
        {
            popSaveAddress pop = new popSaveAddress();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtAddrCode.Text = pop.AddrCode;
                txtAddr1.Text = pop.Address1;
                txtAddr2.Text = pop.Address2;
            }
        }

        // 등록 버튼
        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtClientName, txtAddr1, txtManager, txtMPhone, txtCPhone, txtEmail });
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
                return;
            }

            if (cboType.SelectedIndex == 0)
            {
                MessageBox.Show("분류를 선택해주세요");
                return;
            }
            
            ClientVO client = new ClientVO
            {
                ClientName = txtClientName.Text,
                BusinessNo = txtBusinessNo.Text,
                Type = cboType.Text,
                Address = string.Concat(txtAddr1.Text, txtAddr2.Text),
                Manager = txtManager.Text,
                ManagerPhone = txtMPhone.Text,
                CompanyPhone = txtMPhone.Text,
                Email = string.Concat(txtEmail.Text, "@", txtDomain.Text)            
            };
            bool result = clientSrv.SaveClient(client);

            if (result)
            {
                MessageBox.Show($"[{client.ClientName}] : 등록완료.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("등록 중 오류 발생.");
                return;
            }
        }        

        // 취소 버튼
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Author : 이진형
        /// 도메인 콤보박스 선택에 따른 처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDomain.SelectedIndex == 0) // 선택
            {
                txtDomain.ReadOnly = true;
                txtDomain.Clear();
            }
            else if (cboDomain.SelectedIndex == 1) // 직접입력
            {
                txtDomain.ReadOnly = false;
                txtDomain.Focus();
                txtDomain.Clear();
            }
            else // 도메인 주소
            {
                txtDomain.ReadOnly = true;
                txtDomain.Text = cboDomain.Text;
                txtDomain.Focus();
            }
        }

        /// <summary>
        /// Author : 이진형
        /// 콤보박스 이메일 도메인 주소 바인딩
        /// </summary>
        private void DomainListBinding()
        {
            cboDomain.Items.AddRange(new string[] { "선택", "직접입력", "naver.com", "gmail.com", "kakao.com", "daum.net" });
            cboDomain.SelectedIndex = 0;
        }

        private bool IsMatch(string regex, string value)
        {
            Regex reg = new Regex(regex);
            return reg.IsMatch(value);
        }

        /// <summary>
        /// Author : 이진형
        /// 공백없는 영문 소문자 숫자 형식 유효성 검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Boolean ismatch = IsMatch(@"^[0-9a-z]{1,50}$", txtEmail.Text);
            if (!ismatch)
            {
                lblMessage1.Text = "이메일 : 영문자와 숫자만 입력해 주세요.";
                lblMessage1.ForeColor = Color.Red;
                txtEmail.Clear();
            }
            else
                lblMessage1.Text = "";
        }

        /// <summary>
        /// Author : 이진형
        /// 공백없는 영문 소문자 도메인(xxx.com)형식 유효성 검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDomain_Leave(object sender, EventArgs e)
        {
            Boolean ismatch = IsMatch(@"^[a-z]+\.[a-z]{1,50}$", txtDomain.Text);
            if (!ismatch)
            {
                lblMessage2.Text = "메일주소 : 형식에 맞춰 영문자만 입력해 주세요.";
                lblMessage2.ForeColor = Color.Red;
                txtDomain.Clear();
            }
            else
                lblMessage2.Text = "";
        }
    }
}
