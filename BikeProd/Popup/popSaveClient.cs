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
        bool b_NoCheck = false;
        public popSaveClient()
        {
            InitializeComponent();
        }
        private void popSaveClient_Load(object sender, EventArgs e)
        {
            cboType.Items.AddRange(new string[] { "구분", "입고", "출고" });
            cboType.SelectedIndex = 0;            

            txtAddrCode.ReadOnly = txtAddr1.ReadOnly = txtAddr2.ReadOnly = txtAddrDetail.ReadOnly = true;

            txtMPhone.isNumeric = txtBusinessNo.isNumeric = true;

            txtClientName.isRequired = txtBusinessNo.isRequired = txtAddr1.isRequired
                = txtManager.isRequired = txtMPhone.isRequired = txtEmail.isRequired = true;

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
                txtAddrDetail.Text = pop.AddrDetail;
            }
        }

        // 등록 버튼
        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtClientName, txtBusinessNo, txtAddr1, txtManager, txtMPhone, txtEmail });
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

            if (string.IsNullOrWhiteSpace(txtDomain.Text))
            {
                MessageBox.Show("이메일 주소를 입력 또는 선택하여 주세요.");
                return;
            }

            if (!b_NoCheck)            {
                              
                MessageBox.Show("사업자번호 중복체크 확인해 주세요");
                return;
            }

            if (txtMPhone.Text.Length < 13)
            {
                txtMPhone.Clear();
                MessageBox.Show("담당자 전화번호를 확인해 주세요");
                return;
            }            

            ClientVO client = new ClientVO
            {
                ClientName = txtClientName.Text,
                BusinessNo = txtBusinessNo.Text,
                Type = cboType.Text,
                Address = string.Concat(txtAddr1.Text, " ", txtAddr2.Text, " ", txtAddrDetail.Text, " / ", txtAddrCode.Text),
                Manager = txtManager.Text,
                ManagerPhone = txtMPhone.Text,                
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
            Boolean ismatch = IsMatch(@"^[0-9a-zA-Z]{1,50}$", txtEmail.Text);
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
               

        private void txtBusinessNo_Leave(object sender, EventArgs e)        {
            
            if (txtBusinessNo.Text.Length == 9)
            {
                txtBusinessNo.Text = txtBusinessNo.Text.Insert(3, "-");
                txtBusinessNo.Text = txtBusinessNo.Text.Insert(6, "-");                
            }
        }

        private void txtMPhone_Leave(object sender, EventArgs e)
        {
            if (txtMPhone.Text.Length == 11)
            {
                txtMPhone.Text = txtMPhone.Text.Insert(3, "-");
                txtMPhone.Text = txtMPhone.Text.Insert(8, "-");
            }
        }

        private void btnBusinessNoCheck_Click(object sender, EventArgs e)
        {
            if (txtBusinessNo.Text.Length < 11)
            {
                MessageBox.Show("사업자번호를 정확하게 입력해 주세요");
                txtBusinessNo.Clear();
                txtBusinessNo.Focus();
                return;
            }

            clientSrv = new ClientService();
            ClientVO b_no = clientSrv.GetBusinessNo(txtBusinessNo.Text.Trim());
            if (b_no != null)
            {
                MessageBox.Show("해당 사업자번호는 이미 존재 합니다.");
                txtBusinessNo.Focus();
                return;
            }
            else
            {
                b_NoCheck = true;
                txtBusinessNo.ReadOnly = true;
                MessageBox.Show("등록 가능한 사업자번호 입니다.");
                return;
            }
        }
    }
}
