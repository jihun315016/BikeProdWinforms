namespace BikeProd
{
    partial class frmModel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cboKind = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new BikeProd.ccTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.cboDealing = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCode = new BikeProd.ccTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new BikeProd.ccTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategory = new BikeProd.ccTextBox();
            this.txtPrice = new BikeProd.ccTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInventory = new BikeProd.ccTextBox();
            this.lblSafeInventory = new System.Windows.Forms.Label();
            this.txtSafeInventory = new BikeProd.ccTextBox();
            this.lblTotInventory = new System.Windows.Forms.Label();
            this.txtTotInventory = new BikeProd.ccTextBox();
            this.lblUit = new System.Windows.Forms.Label();
            this.txtUnit = new BikeProd.ccTextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClient = new BikeProd.ccTextBox();
            this.btnUpLoad = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.txtLeadTime = new BikeProd.ccTextBox();
            this.lblLeadTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboKind);
            this.splitContainer1.Panel1.Controls.Add(this.cboDealing);
            this.splitContainer1.Panel1.Controls.Add(this.btnInit);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.cboCategory);
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnlDetail);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvList
            // 
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(28, 15);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(745, 488);
            this.dgvList.TabIndex = 2;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // cboKind
            // 
            this.cboKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKind.FormattingEnabled = true;
            this.cboKind.Location = new System.Drawing.Point(155, 42);
            this.cboKind.Name = "cboKind";
            this.cboKind.Size = new System.Drawing.Size(121, 23);
            this.cboKind.TabIndex = 1;
            this.cboKind.SelectedIndexChanged += new System.EventHandler(this.cboKind_SelectedIndexChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(282, 42);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 23);
            this.cboCategory.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.isNumeric = false;
            this.txtSearch.isRequired = false;
            this.txtSearch.Location = new System.Drawing.Point(409, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolder = "모델명 검색";
            this.txtSearch.Size = new System.Drawing.Size(143, 23);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(558, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInit
            // 
            this.btnInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInit.Location = new System.Drawing.Point(623, 42);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(59, 23);
            this.btnInit.TabIndex = 5;
            this.btnInit.Text = "초기화";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // cboDealing
            // 
            this.cboDealing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboDealing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDealing.FormattingEnabled = true;
            this.cboDealing.Location = new System.Drawing.Point(28, 42);
            this.cboDealing.Name = "cboDealing";
            this.cboDealing.Size = new System.Drawing.Size(121, 23);
            this.cboDealing.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(184, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.isNumeric = false;
            this.txtCode.isRequired = false;
            this.txtCode.Location = new System.Drawing.Point(15, 32);
            this.txtCode.Name = "txtCode";
            this.txtCode.PlaceHolder = null;
            this.txtCode.Size = new System.Drawing.Size(149, 23);
            this.txtCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "제품 코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "모델명";
            // 
            // txtName
            // 
            this.txtName.isNumeric = false;
            this.txtName.isRequired = false;
            this.txtName.Location = new System.Drawing.Point(15, 85);
            this.txtName.Name = "txtName";
            this.txtName.PlaceHolder = null;
            this.txtName.Size = new System.Drawing.Size(149, 23);
            this.txtName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "품목";
            // 
            // txtCategory
            // 
            this.txtCategory.isNumeric = false;
            this.txtCategory.isRequired = false;
            this.txtCategory.Location = new System.Drawing.Point(15, 141);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PlaceHolder = null;
            this.txtCategory.Size = new System.Drawing.Size(149, 23);
            this.txtCategory.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.isNumeric = false;
            this.txtPrice.isRequired = true;
            this.txtPrice.Location = new System.Drawing.Point(49, 209);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceHolder = null;
            this.txtPrice.Size = new System.Drawing.Size(115, 23);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.Tag = "가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "가격";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "재고";
            // 
            // txtInventory
            // 
            this.txtInventory.isNumeric = false;
            this.txtInventory.isRequired = false;
            this.txtInventory.Location = new System.Drawing.Point(218, 209);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.PlaceHolder = null;
            this.txtInventory.Size = new System.Drawing.Size(115, 23);
            this.txtInventory.TabIndex = 14;
            // 
            // lblSafeInventory
            // 
            this.lblSafeInventory.AutoSize = true;
            this.lblSafeInventory.Location = new System.Drawing.Point(12, 251);
            this.lblSafeInventory.Name = "lblSafeInventory";
            this.lblSafeInventory.Size = new System.Drawing.Size(59, 15);
            this.lblSafeInventory.TabIndex = 17;
            this.lblSafeInventory.Text = "안전 재고";
            // 
            // txtSafeInventory
            // 
            this.txtSafeInventory.isNumeric = false;
            this.txtSafeInventory.isRequired = true;
            this.txtSafeInventory.Location = new System.Drawing.Point(15, 269);
            this.txtSafeInventory.Name = "txtSafeInventory";
            this.txtSafeInventory.PlaceHolder = null;
            this.txtSafeInventory.Size = new System.Drawing.Size(149, 23);
            this.txtSafeInventory.TabIndex = 16;
            this.txtSafeInventory.Tag = "안전 재고";
            // 
            // lblTotInventory
            // 
            this.lblTotInventory.AutoSize = true;
            this.lblTotInventory.Location = new System.Drawing.Point(181, 251);
            this.lblTotInventory.Name = "lblTotInventory";
            this.lblTotInventory.Size = new System.Drawing.Size(59, 15);
            this.lblTotInventory.TabIndex = 19;
            this.lblTotInventory.Text = "논리 재고";
            // 
            // txtTotInventory
            // 
            this.txtTotInventory.isNumeric = false;
            this.txtTotInventory.isRequired = true;
            this.txtTotInventory.Location = new System.Drawing.Point(184, 269);
            this.txtTotInventory.Name = "txtTotInventory";
            this.txtTotInventory.PlaceHolder = null;
            this.txtTotInventory.Size = new System.Drawing.Size(149, 23);
            this.txtTotInventory.TabIndex = 18;
            this.txtTotInventory.Tag = "논리 재고";
            // 
            // lblUit
            // 
            this.lblUit.AutoSize = true;
            this.lblUit.Location = new System.Drawing.Point(12, 308);
            this.lblUit.Name = "lblUit";
            this.lblUit.Size = new System.Drawing.Size(59, 15);
            this.lblUit.TabIndex = 21;
            this.lblUit.Text = "발주 단위";
            // 
            // txtUnit
            // 
            this.txtUnit.isNumeric = false;
            this.txtUnit.isRequired = true;
            this.txtUnit.Location = new System.Drawing.Point(15, 326);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PlaceHolder = null;
            this.txtUnit.Size = new System.Drawing.Size(149, 23);
            this.txtUnit.TabIndex = 20;
            this.txtUnit.Tag = "발주 단위";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(181, 308);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 15);
            this.lblClient.TabIndex = 23;
            this.lblClient.Text = "거래처";
            // 
            // txtClient
            // 
            this.txtClient.isNumeric = false;
            this.txtClient.isRequired = true;
            this.txtClient.Location = new System.Drawing.Point(184, 326);
            this.txtClient.Name = "txtClient";
            this.txtClient.PlaceHolder = null;
            this.txtClient.Size = new System.Drawing.Size(149, 23);
            this.txtClient.TabIndex = 22;
            this.txtClient.Tag = "거래처";
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.Location = new System.Drawing.Point(275, 170);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(59, 23);
            this.btnUpLoad.TabIndex = 24;
            this.btnUpLoad.Text = "업로드";
            this.btnUpLoad.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(211, 371);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(275, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.txtLeadTime);
            this.pnlDetail.Controls.Add(this.lblLeadTime);
            this.pnlDetail.Controls.Add(this.label1);
            this.pnlDetail.Controls.Add(this.btnDelete);
            this.pnlDetail.Controls.Add(this.btnSave);
            this.pnlDetail.Controls.Add(this.btnUpdate);
            this.pnlDetail.Controls.Add(this.pictureBox1);
            this.pnlDetail.Controls.Add(this.btnUpLoad);
            this.pnlDetail.Controls.Add(this.txtCode);
            this.pnlDetail.Controls.Add(this.txtName);
            this.pnlDetail.Controls.Add(this.lblClient);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.txtClient);
            this.pnlDetail.Controls.Add(this.txtCategory);
            this.pnlDetail.Controls.Add(this.lblUit);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.txtUnit);
            this.pnlDetail.Controls.Add(this.txtPrice);
            this.pnlDetail.Controls.Add(this.lblTotInventory);
            this.pnlDetail.Controls.Add(this.label4);
            this.pnlDetail.Controls.Add(this.txtTotInventory);
            this.pnlDetail.Controls.Add(this.txtInventory);
            this.pnlDetail.Controls.Add(this.lblSafeInventory);
            this.pnlDetail.Controls.Add(this.label5);
            this.pnlDetail.Controls.Add(this.txtSafeInventory);
            this.pnlDetail.Location = new System.Drawing.Point(3, 15);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(348, 402);
            this.pnlDetail.TabIndex = 27;
            // 
            // txtLeadTime
            // 
            this.txtLeadTime.isNumeric = false;
            this.txtLeadTime.isRequired = true;
            this.txtLeadTime.Location = new System.Drawing.Point(15, 269);
            this.txtLeadTime.Name = "txtLeadTime";
            this.txtLeadTime.PlaceHolder = null;
            this.txtLeadTime.Size = new System.Drawing.Size(149, 23);
            this.txtLeadTime.TabIndex = 27;
            this.txtLeadTime.Tag = "Lead Time";
            // 
            // lblLeadTime
            // 
            this.lblLeadTime.AutoSize = true;
            this.lblLeadTime.Location = new System.Drawing.Point(12, 251);
            this.lblLeadTime.Name = "lblLeadTime";
            this.lblLeadTime.Size = new System.Drawing.Size(62, 15);
            this.lblLeadTime.TabIndex = 28;
            this.lblLeadTime.Text = "Lead Time";
            // 
            // frmModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmModel";
            this.Text = "frmProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.Shown += new System.EventHandler(this.frmModel_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvList;
        private ccTextBox txtSearch;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboKind;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboDealing;
        private System.Windows.Forms.Label label3;
        private ccTextBox txtCategory;
        private System.Windows.Forms.Label label2;
        private ccTextBox txtName;
        private System.Windows.Forms.Label label1;
        private ccTextBox txtCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private ccTextBox txtInventory;
        private System.Windows.Forms.Label label4;
        private ccTextBox txtPrice;
        private System.Windows.Forms.Label lblClient;
        private ccTextBox txtClient;
        private System.Windows.Forms.Label lblUit;
        private ccTextBox txtUnit;
        private System.Windows.Forms.Label lblTotInventory;
        private ccTextBox txtTotInventory;
        private System.Windows.Forms.Label lblSafeInventory;
        private ccTextBox txtSafeInventory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpLoad;
        private System.Windows.Forms.Panel pnlDetail;
        private ccTextBox txtLeadTime;
        private System.Windows.Forms.Label lblLeadTime;
    }
}