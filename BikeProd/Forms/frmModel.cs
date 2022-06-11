﻿using BikeProd.VO;
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
    public partial class frmModel : bFrmListAndDetail
    {
        ModelService modelSrv;
        List<ProdPartVO> prodPartList;
        List<CommonCodeVO> categoryList;

        public frmModel()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            modelSrv = new ModelService();
            prodPartList = modelSrv.GetModelList();
            categoryList = modelSrv.GetCategory();
            InitControls();
        }

        /// <summary>
        /// Author : 강지훈
        /// 컨트롤 초기화
        /// </summary>
        void InitControls()
        {
            cboDealing.Items.AddRange(new string[] { "거래 여부", "거래 물품", "미거래 물품" });
            cboDealing.SelectedIndex = 0;

            cboKind.Items.AddRange(new string[] { "분류", "완제품", "반제품", "부품" });
            cboKind.SelectedIndex = 0;

            cboCategory.Items.Add("품목");
            cboCategory.SelectedIndex = 0;

            txtSearch.SetPlaceHolder();

            txtCode.ReadOnly = txtName.ReadOnly = txtCategory.ReadOnly = txtPrice.ReadOnly
                = txtInventory.ReadOnly = txtSafeInventory.ReadOnly = txtTotInventory.ReadOnly
                = txtUnit.ReadOnly = txtClient.ReadOnly = txtLeadTime.ReadOnly = true;
            btnUpLoad.Visible = false;

            lblSafeInventory.Visible = lblTotInventory.Visible
                = lblUit.Visible = lblClient.Visible = txtLeadTime.Visible = false;
            txtSafeInventory.Visible = txtTotInventory.Visible
                = txtUnit.Visible = txtClient.Visible = lblLeadTime.Visible = false;

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "코드", "Code", colWidth: 205);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "모델명", "Name", colWidth: 205);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "분류", "Kind", colWidth: 180);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "품목", "Category", colWidth: 180);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "가격", "Price", colWidth: 180);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "재고", "Inventory", colWidth: 170);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래 여부", "Dealing", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이미지 유무", "Image", isVisible: false);
            dgvList.DataSource = prodPartList;
        }

        private void frmModel_Shown(object sender, EventArgs e)
        {
            pnlDetail.Left = splitContainer2.Panel2.Width / 2 - pnlDetail.Width / 2;
        }

        /// <summary>
        /// Author : 강지훈
        /// 선택된 cboKind 값에 따라 cboCategory에 품목을 입력한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKind.SelectedIndex == 0)
            {
                cboCategory.DataSource = null;
                cboCategory.Items.Add("품목");
                cboCategory.SelectedIndex = 0;
            }
            else
            {
                List<CommonCodeVO> list;
                if (cboKind.Text == "완제품" || cboKind.Text == "반제품")
                    list = categoryList.FindAll(c => c.Category == "제품");
                else
                    list = categoryList.FindAll(c => c.Category == "부품");

                list.Insert(0, new CommonCodeVO()
                {
                    Name = "품목",
                    Code = String.Empty
                });
                ComboBoxUtil.SetComboBoxByList<CommonCodeVO>(cboCategory, list, "Name", "Code");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ProdPartVO> list = prodPartList.ConvertAll<ProdPartVO>(p => p);

            // 거래 여부(단종 여부) 체크
            if (cboDealing.SelectedIndex > 0)
                list = list.FindAll(p => p.Dealing == cboDealing.SelectedIndex - 1);

            // 분류 체크
            if (cboKind.SelectedIndex > 0)
                list = list.FindAll(p => p.Kind == cboKind.Text);

            // 품목 체크
            if (cboCategory.SelectedIndex > 0)
                list = list.FindAll(p => p.Category == cboCategory.Text);

            // 검색 체크
            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text != txtSearch.PlaceHolder)
                list = list.FindAll(p => p.Name.Contains(txtSearch.Text));

            dgvList.DataSource = list;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = prodPartList;
            cboDealing.SelectedIndex = cboKind.SelectedIndex = cboCategory.SelectedIndex = 0;
            txtSearch.Text = String.Empty;
            txtSearch.SetPlaceHolder();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            popSaveModel pop = new popSaveModel();
            pop.ShowDialog();
        }

        /// <summary>
        /// Author : 강지훈
        /// 모델 정보 상세보기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtCode.Text = dgvList["Code", e.RowIndex].Value.ToString();
            txtName.Text = dgvList["Name", e.RowIndex].Value.ToString();
            txtPrice.Text = dgvList["Kind", e.RowIndex].Value.ToString();
            txtCategory.Text = $"[{dgvList["Kind", e.RowIndex].Value}] {dgvList["Category", e.RowIndex].Value}";
            txtPrice.Text = dgvList["Price", e.RowIndex].Value.ToString();
            txtInventory.Text = dgvList["Inventory", e.RowIndex].Value.ToString();

            if (dgvList["Kind", e.RowIndex].Value.ToString() == "부품")
            {
                lblSafeInventory.Visible = lblTotInventory.Visible = lblUit.Visible = lblClient.Visible = true;
                txtSafeInventory.Visible = txtTotInventory.Visible = txtUnit.Visible = txtClient.Visible = true;
                lblLeadTime.Visible = txtLeadTime.Visible = false;

                try
                {
                    PartVO part = modelSrv.GetPartClientAndQtyInfo(dgvList["Code", e.RowIndex].Value.ToString());
                    txtSafeInventory.Text = part.SfInvn.ToString();
                    txtTotInventory.Text = part.TotInvn.ToString();
                    txtUnit.Text = part.Unit.ToString();
                    txtClient.Text = part.ClientName;
                }
                catch (Exception err)
                {
                    MessageBox.Show("조회에 실패했습니다.");
                }

                try
                {
                    // 이미지가 있다면 불러오기
                    int isImg = Convert.ToInt32(dgvList["Image", e.RowIndex].Value.ToString());
                    if (isImg > 0)
                    {
                        string url = "http://127.0.0.1:5000/getImg";
                        byte[] imgByte = WebRequestUtil.GetImage(url, txtName.Text);
                        TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                        Image img = (Bitmap)tc.ConvertFrom(imgByte);
                        pictureBox1.Image = img;
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                catch(Exception err) { MessageBox.Show(err.Message); }
            }
            else
            {
                lblSafeInventory.Visible = lblTotInventory.Visible = lblUit.Visible = lblClient.Visible = false;
                txtSafeInventory.Visible = txtTotInventory.Visible = txtUnit.Visible = txtClient.Visible = false;
                lblLeadTime.Visible = txtLeadTime.Visible = true;
            }
        }

        /// <summary>
        /// Author : 강지훈
        /// 모델 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "수정")
            {
                btnUpdate.Text = "저장";
                txtPrice.ReadOnly = txtSafeInventory.ReadOnly
                    = txtUnit.ReadOnly = txtClient.ReadOnly = txtLeadTime.ReadOnly = false;
            }
            else // 저장
            {
                btnUpdate.Text = "수정";
                txtPrice.ReadOnly = txtSafeInventory.ReadOnly
                    = txtUnit.ReadOnly = txtClient.ReadOnly = txtLeadTime.ReadOnly = true;

                int leadTime = txtLeadTime.Text == String.Empty ? -1 : Convert.ToInt32(txtLeadTime.Text);
                // 유효성 검사
                string msg;
                if (txtLeadTime.Visible) // 제품
                {
                    msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[] { txtPrice, txtLeadTime });
                }
                else // 부품
                {
                    msg = TextBoxUtil.IsRequiredCheck(new ccTextBox[]
                    {
                        txtPrice, txtSafeInventory, txtTotInventory,
                        txtUnit, txtClient
                    });
                }
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg);
                    return;
                }

                PartVO part = new PartVO()
                {
                    SfInvn = txtSafeInventory.Text == String.Empty ? -1 : Convert.ToInt32(txtSafeInventory.Text),
                    TotInvn = txtTotInventory.Text == String.Empty ? -1 : Convert.ToInt32(txtTotInventory.Text),
                    Unit = txtUnit.Text == String.Empty ? -1 : Convert.ToInt32(txtUnit.Text),
                    ClientName = txtClient.Text
                };

                try
                {
                    bool result = modelSrv.UpdateProdPart(txtCode.Text, Convert.ToInt32(txtPrice.Text), leadTime, part);
                    if (result)
                        MessageBox.Show("수정되었습니다.");
                }
                catch (Exception err)
                {
                    MessageBox.Show("수정에 실패했습니다.");
                }
            }
        }
    }
}
