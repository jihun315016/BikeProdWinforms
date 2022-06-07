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
        ModelService modelService;
        List<CommonCodeVO> categoryList;

        // 이미지 경로
        string path;

        // 선택된 Path가 제품 이미지인지 부품 이미지인지 판별
        // true이면 제품 이미지, false이면 부품 이미지를 의미한다.
        bool isProdPath;

        public popSaveModel()
        {
            InitializeComponent();
        }

        private void popSaveModel_Load(object sender, EventArgs e)
        {
            modelService = new ModelService();
            categoryList = modelService.GetCategory();
            categoryList.Insert(0, new CommonCodeVO()
            {
                Name = "품목",
                Code = String.Empty
            });

            InitProd();
            InitPart();
        }

        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            string textBoxMsg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { ccTxtProdName, ccTxtLeadTime ,ccTxtProdPrice });
            if (textBoxMsg.Length > 0)
            {
                MessageBox.Show(textBoxMsg);
                return;
            }

            if (cmbProdCategory.SelectedIndex == 0)
            {
                MessageBox.Show("품목을 입력해주세요.");
                return;
            }
            else if (cmbIsFinished.SelectedIndex == 0)
            {
                MessageBox.Show("분류를 입력해주세요.");
                return;
            }

            CommonCodeVO category = (CommonCodeVO)categoryList.Find(c => c.Code == cmbProdCategory.SelectedValue);
            ProductVO product = new ProductVO()
            {
                ProdCode = $"{cmbProdCategory.SelectedValue}{category.LastNum.ToString("0000")}",
                ProdName = ccTxtProdName.Text,
                IsFinished = (cmbProdCategory.SelectedIndex == 1) ? 1 : 0,
                Category = cmbProdCategory.Text,
                LeadTime = Convert.ToInt32(ccTxtLeadTime.Text),
                Price = Convert.ToInt32(ccTxtProdPrice.Text),
                Image = 0
            };

            try
            {
                bool result = modelService.InsertProd(product, cmbProdCategory.SelectedValue.ToString(), path);
                if (result)
                {
                    MessageBox.Show("제품이 등록되었습니다.");
                    category.LastNum++;
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
                string url = "http://127.0.0.1:5000/logging";

                Regex engRegex = new Regex(@"[a-zA-Z]");
                StringBuilder sb = new StringBuilder();
                foreach (char c in err.StackTrace)
                {
                    if (char.IsDigit(c) || engRegex.IsMatch(c.ToString()) || 
                        char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter || c == ' ')                    
                        sb.Append(c);                    
                }
                WebRequestUtil.WriteErrLog(url, err.Message, sb.ToString());
            }           
        }
        
        private void btnUploadProdImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image File|*.jpg;*.jpeg;*.png;*.bmp";

            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = dlg.FileName;
                isProdPath = true;
            }

            pictureBox1.Image = Image.FromFile(path);
        }

        private void ccTxtClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("??");
        }

        void InitProd()
        {
            cmbIsFinished.Items.AddRange(new string[] { "분류", "완제품", "반제품" });
            cmbIsFinished.SelectedIndex = 0;            

            var list = categoryList.FindAll(c => c.Category == "제품" || string.IsNullOrWhiteSpace(c.Category));
            ComboBoxUtil.SetComboBoxByList(cmbProdCategory, list, "Name", "Code");
        }

        void InitPart()
        {
            var list = categoryList.FindAll(c => c.Category == "부품" || string.IsNullOrWhiteSpace(c.Category));
            ComboBoxUtil.SetComboBoxByList(cmbPartCategory, list, "Name", "Code");
        }

        void InputClear()
        {
            ccTxtProdName.Text = ccTxtProdPrice.Text = ccTxtLeadTime.Text = String.Empty;
            cmbIsFinished.SelectedIndex = cmbProdCategory.SelectedIndex = 0;
        }
    }
}
