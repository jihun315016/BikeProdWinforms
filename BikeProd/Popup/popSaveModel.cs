﻿using BikeProd.VO;
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

namespace BikeProd
{
    public partial class popSaveModel : bPopCommon
    {
        ModelService modelSrv;
        List<CommonCodeVO> categoryList;

        public popSaveModel()
        {
            InitializeComponent();
        }

        private void popSaveModel_Load(object sender, EventArgs e)
        {
            modelSrv = new ModelService();
            categoryList = modelSrv.GetCategory();
            categoryList.Insert(0, new CommonCodeVO()
            {
                Name = "품목",
                Code = String.Empty
            });
            ptbProd.Tag = ptbPart.Tag = string.Empty;

            InitProd();
            InitPart();
        }
        
        private void ccTxtClient_Click(object sender, EventArgs e)
        {
            popSearchClient pop = new popSearchClient(false);
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtClient.Text = pop.selectedClient.ClientName;
                txtClient.Tag = pop.selectedClient.BusinessNo;                
            }
        }

        /// <summary>
        /// Author : 강지훈
        /// 제품 등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            // 유효성 검사
            bool isRequired = IsRequiredTextBox(() => TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtProdName, txtLeadTime, txtProdPrice }));
            if (!isRequired) return;

            string comboBoxMsg = ComboBoxUtil.IsRequiredCheck(new ComboBox[] { cboProdCategory, cboIsFinished });
            if (comboBoxMsg.Length > 0)
            {
                MessageBox.Show(comboBoxMsg);
                return;
            }

            // 선택된 품목에 대한 제품 코드를 가져온다.
            CommonCodeVO category = (CommonCodeVO)categoryList.Find(c => c.Code == cboProdCategory.SelectedValue);
            ProductVO product = new ProductVO()
            {
                ProdCode = $"{cboProdCategory.SelectedValue}{category.LastNum.ToString("0000")}",
                ProdName = txtProdName.Text,
                IsFinished = (cboProdCategory.SelectedIndex == 1) ? 1 : 0,
                Category = cboProdCategory.Text,
                LeadTime = Convert.ToInt32(txtLeadTime.Text),
                Price = Convert.ToInt32(txtProdPrice.Text),
                Image = !string.IsNullOrWhiteSpace(ptbProd.Tag.ToString()) ? 1 : 0
            };

            try
            {
                bool result = modelSrv.SaveModel(product, null, cboProdCategory.SelectedValue.ToString(), ptbProd.Tag.ToString());
                if (result)
                {
                    MessageBox.Show("제품이 등록되었습니다.");
                    category.LastNum++; // 제품 CodeCnt++
                    InputClear();
                }
                else
                {
                    // 쿼리에 문제가 있을 확률
                    MessageBox.Show("제품 등록에 실패했습니다.");
                }
            }
            catch (Exception err)
            {
                string url = "http://jihun3100.pythonanywhere.com/logging";
                
                WebRequestUtil.WriteErrLog(url, err.Message, err.StackTrace);
            }           
        }

        /// <summary>
        /// Author : 강지훈
        /// 부품 등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavePart_Click(object sender, EventArgs e)
        {            
            bool isRequired = IsRequiredTextBox(() => TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtPartName, txtPartPrice, txtClient, txtSafeInv, txtUnit }));
            if (!isRequired) return; 

            string comboBoxMsg = ComboBoxUtil.IsRequiredCheck(new ComboBox[] { cboPartCategory });
            if (comboBoxMsg.Length > 0)
            {
                MessageBox.Show(comboBoxMsg);
                return;
            }

            // 선택된 품목에 대한 부품 코드 정보 정보를 가져온다.
            CommonCodeVO category = (CommonCodeVO)categoryList.Find(c => c.Code == cboPartCategory.SelectedValue);
            PartVO part = new PartVO()
            {
                PartCode = $"{cboPartCategory.SelectedValue}{category.LastNum.ToString("0000")}",
                PartName = txtPartName.Text,
                Price = Convert.ToInt32(txtPartPrice.Text),
                Category = cboPartCategory.Text,
                BusinessNo = txtClient.Tag.ToString(),
                SfInvn = Convert.ToInt32(txtSafeInv.Text),
                Unit = Convert.ToInt32(txtUnit.Text),
                Image = !string.IsNullOrWhiteSpace(ptbPart.Tag.ToString()) ? 1 : 0
            };

            try
            {
                bool result = modelSrv.SaveModel(null, part, cboPartCategory.SelectedValue.ToString(), ptbPart.Tag.ToString());
                if (result)
                {
                    MessageBox.Show("부품이 등록되었습니다.");
                    category.LastNum++; // 부품 CodeCnt++
                    InputClear();
                }
                else
                {                    
                    MessageBox.Show("부품 등록에 실패했습니다.");
                }
            }
            catch (Exception err)
            {
                string url = "http://127.0.0.1:5000/logging";
                WebRequestUtil.WriteErrLog(url, err.Message, err.StackTrace);
            }
        }

        private void btnUploadProdImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image File|*.jpg;*.jpeg;*.png;*.bmp";

            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptbProd.Image = Image.FromFile(dlg.FileName);
                ptbProd.Tag = dlg.FileName;                
            }
        }

        private void btnUploadPart_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image File|*.jpg;*.jpeg;*.png;*.bmp";

            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptbPart.Image = Image.FromFile(dlg.FileName);
                ptbPart.Tag = dlg.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Author : 강지훈
        /// ccTextBoxUtil.IsRequiredCheck() 콜백을 위한 메서드
        /// </summary>
        /// <param name="func">콜백 메서드</param>
        /// <returns></returns>
        bool IsRequiredTextBox(Func<string> func)
        {
            string textBoxMsg = func();
            if (textBoxMsg.Length > 0)
            {
                MessageBox.Show(textBoxMsg);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Author : 강지훈
        /// 제품 초기화
        /// </summary>
        void InitProd()
        {
            cboIsFinished.Items.AddRange(new string[] { "분류", "완제품", "반제품" });
            cboIsFinished.SelectedIndex = 0;

            var list = categoryList.FindAll(c => c.Category == "제품" || string.IsNullOrWhiteSpace(c.Category));
            ComboBoxUtil.SetComboBoxByList(cboProdCategory, list, "Name", "Code");
        }

        /// <summary>
        /// Author : 강지훈
        /// 부품 초기화
        /// </summary>
        void InitPart()
        {
            var list = categoryList.FindAll(c => c.Category == "부품" || string.IsNullOrWhiteSpace(c.Category));
            ComboBoxUtil.SetComboBoxByList(cboPartCategory, list, "Name", "Code");
        }

        /// <summary>
        /// Author : 강지훈
        /// 제품 또는 부품 등록 후 입력 컨트롤 초기화
        /// </summary>
        void InputClear()
        {
            txtProdName.Text = txtProdPrice.Text = txtLeadTime.Text = String.Empty;
            txtPartName.Text = txtPartPrice.Text = txtSafeInv.Text = txtUnit.Text = txtClient.Text = String.Empty;

            cboIsFinished.SelectedIndex = cboProdCategory.SelectedIndex = 0;
            cboPartCategory.SelectedIndex = 0;

            ptbProd.Image = ptbPart.Image = null;
            ptbProd.Tag = ptbPart.Tag = string.Empty;
        }

    }
}
