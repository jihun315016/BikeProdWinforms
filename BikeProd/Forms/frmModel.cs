using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            this.WindowState = FormWindowState.Maximized;
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
            cboDealing.Items.AddRange(new string[] { "거래 물품", "미거래 물품" });
            cboDealing.SelectedIndex = 0;

            cboKind.Items.AddRange(new string[] { "분류", "완제품", "반제품", "부품" });
            cboKind.SelectedIndex = 0;

            txtSearch.SetPlaceHolder();

            InitDetail();

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "코드", "Code", colWidth: 180, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "모델명", "Name", colWidth: 200);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "분류", "Kind", colWidth: 140);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "품목", "Category", colWidth: 140);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "가격", "Price", colWidth: 140, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "재고", "Inventory", colWidth: 140, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "논리재고", "TotInvn", colWidth: 140, alignContent: DataGridViewContentAlignment.MiddleRight);            
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "거래 여부", "Dealing", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이미지 유무", "Image", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "안전 재고", "SfInvn", isVisible: false);
            dgvList.Columns["Price"].DefaultCellStyle.Format = "###,##0";
            dgvList.DataSource = prodPartList.FindAll(p => p.Dealing == (cboDealing.SelectedIndex + 1) % 2);            
        }

        /// <summary>
        /// Author : 강지훈
        /// 상세보기 관련 초기화
        /// </summary>
        void InitDetail()
        {
            txtCode.ReadOnly = txtName.ReadOnly = txtCategory.ReadOnly = txtPrice.ReadOnly
                = txtInventory.ReadOnly = txtSafeInventory.ReadOnly = txtTotInventory.ReadOnly
                = txtUnit.ReadOnly = txtClient.ReadOnly = txtLeadTime.ReadOnly = true;

            txtCode.Text = txtName.Text = txtCategory.Text = txtPrice.Text = txtUnit.Text
                = txtClient.Text = txtLeadTime.Text = txtInventory.Text = txtSafeInventory.Text
                = txtTotInventory.Text = String.Empty;

            btnUpLoad.Visible = false;

            lblSafeInventory.Visible = lblTotInventory.Visible
                = lblUit.Visible = lblClient.Visible = txtLeadTime.Visible = false;
            txtSafeInventory.Visible = txtTotInventory.Visible
                = txtUnit.Visible = txtClient.Visible = lblLeadTime.Visible = false;
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
                ComboBoxUtil.SetComboBoxByList<CommonCodeVO>
                (
                    cboCategory,
                    new List<CommonCodeVO>() { new CommonCodeVO() { Name = "품목", Code = String.Empty } },
                    "Name", "Code"
                );
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
                list = list.FindAll(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower()));

            dgvList.DataSource = list;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            prodPartList = modelSrv.GetModelList();
            cboDealing.SelectedIndex = 0;
            dgvList.DataSource = dgvList.DataSource = prodPartList.FindAll(p => p.Dealing == 1);
            cboDealing.SelectedIndex = cboKind.SelectedIndex = cboCategory.SelectedIndex = 0;
            txtSearch.Text = String.Empty;
            txtSearch.SetPlaceHolder();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            popSaveModel pop = new popSaveModel();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                prodPartList = modelSrv.GetModelList();
                categoryList = modelSrv.GetCategory();
                dgvList.DataSource = prodPartList.FindAll(p => p.Dealing == (cboDealing.SelectedIndex + 1) % 2);
            }
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

            popLoading pop = new popLoading(() => ShowModelDetail(e.RowIndex));
            pop.ShowDialog();
        }

        void ShowModelDetail(int iRow)
        {
            // 저장 버튼을 눌렀을 때 Tag 값이 빈 문자열이 아니라면 이미지 수정
            this.Invoke(new Action(() =>
            {
                ptbModel.Tag = string.Empty;
                txtClient.Tag = string.Empty;

                txtCode.ReadOnly = txtName.ReadOnly = txtCategory.ReadOnly = txtPrice.ReadOnly
                    = txtInventory.ReadOnly = txtSafeInventory.ReadOnly = txtTotInventory.ReadOnly
                    = txtUnit.ReadOnly = txtClient.ReadOnly = txtLeadTime.ReadOnly = true;
                btnUpdate.Text = "수정";

                // 거래처 정보도 기본적으로 빈 문자열
                txtClient.Tag = string.Empty;

                txtCode.ReadOnly = txtName.ReadOnly = txtCategory.ReadOnly = txtPrice.ReadOnly
                    = txtInventory.ReadOnly = txtSafeInventory.ReadOnly = txtTotInventory.ReadOnly
                    = txtUnit.ReadOnly = txtClient.ReadOnly = txtLeadTime.ReadOnly = true;
                btnUpdate.Text = "수정";

                txtCode.Text = dgvList["Code", iRow].Value.ToString();
                txtName.Text = dgvList["Name", iRow].Value.ToString();
                txtPrice.Text = dgvList["Kind", iRow].Value.ToString();
                txtCategory.Text = $"[{dgvList["Kind", iRow].Value}] {dgvList["Category", iRow].Value}";
                txtPrice.Text = dgvList["Price", iRow].Value.ToString();
                txtInventory.Text = dgvList["Inventory", iRow].Value.ToString();

                if (Convert.ToInt32(dgvList["Dealing", iRow].Value) == 1)
                {
                    btnDelete.Text = "삭제";
                }
                else
                {
                    btnDelete.Text = "재등록";
                }

                if (dgvList["Kind", iRow].Value.ToString() == "부품")
                {
                    lblSafeInventory.Visible = lblTotInventory.Visible = lblUit.Visible = lblClient.Visible = true;
                    txtSafeInventory.Visible = txtTotInventory.Visible = txtUnit.Visible = txtClient.Visible = true;
                    lblLeadTime.Visible = txtLeadTime.Visible = false;

                    try
                    {
                        PartVO part = modelSrv.GetPartClientAndQtyInfo(dgvList["Code", iRow].Value.ToString());
                        txtSafeInventory.Text = part.SfInvn.ToString();
                        txtTotInventory.Text = part.TotInvn.ToString();
                        txtUnit.Text = part.Unit.ToString();
                        txtClient.Text = part.ClientName;
                        txtClient.Tag = part.BusinessNo;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("조회에 실패했습니다.");
                    }
                }
                else // 제품 더블 클릭
                {
                    lblSafeInventory.Visible = lblTotInventory.Visible = lblUit.Visible = lblClient.Visible = false;
                    txtSafeInventory.Visible = txtTotInventory.Visible = txtUnit.Visible = txtClient.Visible = false;
                    lblLeadTime.Visible = txtLeadTime.Visible = true;

                    txtLeadTime.Text = modelSrv.GetProdLeadTime(txtCode.Text).ToString();
                }

                try
                {
                    // 이미지가 있다면 불러오기
                    int isImg = Convert.ToInt32(dgvList["Image", iRow].Value);
                    if (isImg > 0)
                    {
                        string url = "http://3.39.226.41:5000/getImg";
                        byte[] imgByte = WebRequestUtil.GetImage(url, txtName.Text);
                        TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                        Image img = (Bitmap)tc.ConvertFrom(imgByte);
                        ptbModel.Image = img;
                    }
                    else
                    {
                        ptbModel.Image = null;
                    }
                }
                catch (Exception err) { Debug.WriteLine(err.Message); }
            }
            ));
        }

        /// <summary>
        /// Author : 강지훈
        /// 모델 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 아무것도 선택되지 않은 상태
            if (string.IsNullOrWhiteSpace(txtCode.Text))
                return;

            if (btnUpdate.Text == "수정")
            {
                // 이미 폐기된 모델은 수정 불가능
                if (btnDelete.Text == "재등록")
                {
                    MessageBox.Show("폐기된 모델은 수정할 수 없습니다.");
                    return;
                }

                btnUpLoad.Visible = true;
                btnUpdate.Text = "저장";
                txtPrice.ReadOnly = txtSafeInventory.ReadOnly
                    = txtUnit.ReadOnly = txtClient.ReadOnly = txtLeadTime.ReadOnly = false;
            }
            else // 저장
            {
                // 거래처 정보도 기본적으로 빈 문자열
                // txtClient.Tag = string.Empty;

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
                    BusinessNo = txtClient.Tag.ToString(),
                    ClientName = txtClient.Text,
                    Image = !string.IsNullOrWhiteSpace(ptbModel.Tag.ToString()) ? 1 : 0
                };

                try
                {
                    bool result = modelSrv.UpdateProdPart(txtCode.Text, Convert.ToInt32(txtPrice.Text), leadTime, ptbModel.Tag.ToString(), txtName.Text, part);
                    if (result)
                    {
                        MessageBox.Show("수정되었습니다.");
                        btnUpLoad.Visible = false;
                        InitDetail();
                        btnInit_Click(this, null);
                        btnUpdate.Text = "수정";
                        txtPrice.ReadOnly = txtSafeInventory.ReadOnly
                            = txtUnit.ReadOnly = txtClient.ReadOnly = txtLeadTime.ReadOnly = true;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("수정에 실패했습니다.");
                }
            }
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image File|*.jpg;*.jpeg;*.png;*.bmp";

            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptbModel.Image = Image.FromFile(dlg.FileName);
                ptbModel.Tag = dlg.FileName;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("삭제할 모델을 선택하세요.");
                return;
            }

                int changedValue;

            if (MessageBox.Show($"[{txtName.Text}] {btnDelete.Text}하시겠습니까?", $"{btnDelete.Text} 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool isProd;
                if (btnDelete.Text == "삭제") // 폐기
                    changedValue = 0;
                else // 재등록                
                    changedValue = 1;


                if (txtLeadTime.Visible) // 제품                               
                    isProd = true;
                else // 부품 
                    isProd = false;

                try
                {
                    bool result = modelSrv.UpdateModelDealing(txtCode.Text, isProd, changedValue);
                    if (result)
                    {
                        MessageBox.Show($"{btnDelete.Text}되었습니다.");
                        InitDetail();
                        btnInit_Click(this, null);
                        btnDelete.Text = "삭제";
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show($"{btnDelete.Text}에 실패했습니다.");
                }
            }
        }

        private void txtClient_Click(object sender, EventArgs e)
        {
            popSearchClient pop = new popSearchClient(false);
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtClient.Text = pop.selectedClient.ClientName;
                txtClient.Tag = pop.selectedClient.BusinessNo;
            }
        }

        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string kind = dgvList.Rows[e.RowIndex].Cells["Kind"].Value.ToString();
            int TotInvn = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["TotInvn"].Value);
            int safeInventory = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["SfInvn"].Value);
                        
            if (kind == "부품" && TotInvn < safeInventory)
            {
                e.CellStyle.ForeColor = Color.Red;
            }           
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(this, null);
            }
        }

        private void frmModel_Activated(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
