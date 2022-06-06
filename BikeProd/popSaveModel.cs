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
    public partial class popSaveModel : bFrmPopCommon
    {
        ProductService prodService;
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
            cmbIsFinished.Items.AddRange(new string[] { "분류", "완제품", "반제품" });
            cmbIsFinished.SelectedIndex = 0;

            prodService = new ProductService();
            categoryList = prodService.GetCategory();            
            categoryList.Insert(0, new CommonCodeVO()
            {
                Name = "품목",
                Code = String.Empty
            });

            var list = categoryList.FindAll(c => c.Category == "제품" || string.IsNullOrWhiteSpace(c.Category));
            ComboBoxUtil.SetComboBoxByList(cmbProdCategory, list, "Name", "Code");
            list = categoryList.FindAll(c => c.Category == "부품" || string.IsNullOrWhiteSpace(c.Category));
            ComboBoxUtil.SetComboBoxByList(cmbPartCategory, list, "Name", "Code");
        }

        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            string textBoxMsg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { ccTxtProdName, ccTxtProdPrice });
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

            int lastNum = categoryList.Find(c => c.Code == cmbProdCategory.SelectedValue).LastNum;
            bool isImage = (!string.IsNullOrWhiteSpace(path) && isProdPath) ? true : false;
            ProductVO product = new ProductVO()
            {
                ProdCode = $"{cmbProdCategory.SelectedValue}{lastNum}",
                ProdName = ccTxtProdName.Text,
                IsFinished = (cmbProdCategory.SelectedIndex == 1) ? 1 : 0,
                Price = Convert.ToInt32(ccTxtProdPrice.Text),
                Image = (!string.IsNullOrWhiteSpace(path) && isProdPath) ? path : null
            };

            prodService.ImageTest("ee", path);

            // TODO : 데이터 받아서 INSERT 수행
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
    }
}
