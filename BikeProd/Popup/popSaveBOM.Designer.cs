namespace BikeProd
{
    partial class popSaveBOM
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cboKind = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new BikeProd.ccTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.dgvBom = new System.Windows.Forms.DataGridView();
            this.txtCode = new BikeProd.ccTextBox();
            this.txtName = new BikeProd.ccTextBox();
            this.txtKind = new BikeProd.ccTextBox();
            this.txtRequirement = new BikeProd.ccTextBox();
            this.btnAddBom = new System.Windows.Forms.Button();
            this.txtCatagory = new BikeProd.ccTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBomCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnBomCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtCatagory);
            this.panel1.Controls.Add(this.btnAddBom);
            this.panel1.Controls.Add(this.txtRequirement);
            this.panel1.Controls.Add(this.txtKind);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.dgvBom);
            this.panel1.Controls.Add(this.btnInit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cboCategory);
            this.panel1.Controls.Add(this.cboKind);
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Size = new System.Drawing.Size(943, 415);
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(3, 77);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(429, 332);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // cboKind
            // 
            this.cboKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKind.FormattingEnabled = true;
            this.cboKind.Location = new System.Drawing.Point(3, 48);
            this.cboKind.Name = "cboKind";
            this.cboKind.Size = new System.Drawing.Size(94, 23);
            this.cboKind.TabIndex = 1;
            this.cboKind.SelectedIndexChanged += new System.EventHandler(this.cboKind_SelectedIndexChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(103, 48);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(94, 23);
            this.cboCategory.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.isNumeric = false;
            this.txtSearch.isRequired = false;
            this.txtSearch.Location = new System.Drawing.Point(203, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolder = "모델명 검색";
            this.txtSearch.Size = new System.Drawing.Size(87, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(296, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(367, 48);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(65, 23);
            this.btnInit.TabIndex = 5;
            this.btnInit.Text = "초기화";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // dgvBom
            // 
            this.dgvBom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBom.Location = new System.Drawing.Point(449, 78);
            this.dgvBom.Name = "dgvBom";
            this.dgvBom.RowTemplate.Height = 23;
            this.dgvBom.Size = new System.Drawing.Size(490, 303);
            this.dgvBom.TabIndex = 6;
            this.dgvBom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBom_CellClick);
            // 
            // txtCode
            // 
            this.txtCode.isNumeric = false;
            this.txtCode.isRequired = false;
            this.txtCode.Location = new System.Drawing.Point(449, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.PlaceHolder = "모델명 검색";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(125, 23);
            this.txtCode.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.isNumeric = false;
            this.txtName.isRequired = false;
            this.txtName.Location = new System.Drawing.Point(573, 20);
            this.txtName.Name = "txtName";
            this.txtName.PlaceHolder = "모델명 검색";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(366, 23);
            this.txtName.TabIndex = 8;
            // 
            // txtKind
            // 
            this.txtKind.isNumeric = false;
            this.txtKind.isRequired = false;
            this.txtKind.Location = new System.Drawing.Point(449, 47);
            this.txtKind.Name = "txtKind";
            this.txtKind.PlaceHolder = "모델명 검색";
            this.txtKind.ReadOnly = true;
            this.txtKind.Size = new System.Drawing.Size(125, 23);
            this.txtKind.TabIndex = 9;
            // 
            // txtRequirement
            // 
            this.txtRequirement.isNumeric = true;
            this.txtRequirement.isRequired = true;
            this.txtRequirement.Location = new System.Drawing.Point(711, 47);
            this.txtRequirement.Name = "txtRequirement";
            this.txtRequirement.PlaceHolder = "수량";
            this.txtRequirement.Size = new System.Drawing.Size(83, 23);
            this.txtRequirement.TabIndex = 10;
            // 
            // btnAddBom
            // 
            this.btnAddBom.Location = new System.Drawing.Point(800, 48);
            this.btnAddBom.Name = "btnAddBom";
            this.btnAddBom.Size = new System.Drawing.Size(60, 22);
            this.btnAddBom.TabIndex = 11;
            this.btnAddBom.Text = "추가";
            this.btnAddBom.UseVisualStyleBackColor = true;
            this.btnAddBom.Click += new System.EventHandler(this.btnAddBom_Click);
            // 
            // txtCatagory
            // 
            this.txtCatagory.isNumeric = false;
            this.txtCatagory.isRequired = false;
            this.txtCatagory.Location = new System.Drawing.Point(580, 47);
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.PlaceHolder = "모델명 검색";
            this.txtCatagory.ReadOnly = true;
            this.txtCatagory.Size = new System.Drawing.Size(125, 23);
            this.txtCatagory.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(879, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 22);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(813, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 22);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBomCancel
            // 
            this.btnBomCancel.Location = new System.Drawing.Point(866, 48);
            this.btnBomCancel.Name = "btnBomCancel";
            this.btnBomCancel.Size = new System.Drawing.Size(73, 22);
            this.btnBomCancel.TabIndex = 15;
            this.btnBomCancel.Text = "등록 취소";
            this.btnBomCancel.UseVisualStyleBackColor = true;
            this.btnBomCancel.Click += new System.EventHandler(this.btnBomCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(429, 40);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "lblTitle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // popSaveBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(968, 437);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "popSaveBOM";
            this.Text = "popSaveBOM";
            this.Load += new System.EventHandler(this.popSaveBOM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBom;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnSearch;
        private ccTextBox txtSearch;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboKind;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnAddBom;
        private ccTextBox txtRequirement;
        private ccTextBox txtKind;
        private ccTextBox txtName;
        private ccTextBox txtCode;
        private ccTextBox txtCatagory;
        private System.Windows.Forms.Button btnBomCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
    }
}