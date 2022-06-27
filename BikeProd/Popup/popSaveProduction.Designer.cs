namespace BikeProd
{
    partial class popSaveProduction
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
            this.txtCatagory = new BikeProd.ccTextBox();
            this.btnSaveProduction = new System.Windows.Forms.Button();
            this.txtQty = new BikeProd.ccTextBox();
            this.txtKind = new BikeProd.ccTextBox();
            this.txtName = new BikeProd.ccTextBox();
            this.txtCode = new BikeProd.ccTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvPart = new System.Windows.Forms.DataGridView();
            this.dtpReqDate = new System.Windows.Forms.DateTimePicker();
            this.cboProductionTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboProductionTeam);
            this.panel1.Controls.Add(this.dtpReqDate);
            this.panel1.Controls.Add(this.dgvPart);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtCatagory);
            this.panel1.Controls.Add(this.btnSaveProduction);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.txtKind);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Size = new System.Drawing.Size(1179, 422);
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(627, 411);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // txtCatagory
            // 
            this.txtCatagory.isNumeric = false;
            this.txtCatagory.isRequired = false;
            this.txtCatagory.Location = new System.Drawing.Point(801, 362);
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.PlaceHolder = "모델명 검색";
            this.txtCatagory.ReadOnly = true;
            this.txtCatagory.Size = new System.Drawing.Size(145, 23);
            this.txtCatagory.TabIndex = 21;
            // 
            // btnSaveProduction
            // 
            this.btnSaveProduction.Location = new System.Drawing.Point(1044, 392);
            this.btnSaveProduction.Name = "btnSaveProduction";
            this.btnSaveProduction.Size = new System.Drawing.Size(60, 22);
            this.btnSaveProduction.TabIndex = 20;
            this.btnSaveProduction.Text = "추가";
            this.btnSaveProduction.UseVisualStyleBackColor = true;
            this.btnSaveProduction.Click += new System.EventHandler(this.btnSaveProduction_Click);
            // 
            // txtQty
            // 
            this.txtQty.isNumeric = true;
            this.txtQty.isRequired = true;
            this.txtQty.Location = new System.Drawing.Point(952, 362);
            this.txtQty.Name = "txtQty";
            this.txtQty.PlaceHolder = "수량";
            this.txtQty.Size = new System.Drawing.Size(82, 23);
            this.txtQty.TabIndex = 19;
            // 
            // txtKind
            // 
            this.txtKind.isNumeric = false;
            this.txtKind.isRequired = false;
            this.txtKind.Location = new System.Drawing.Point(650, 362);
            this.txtKind.Name = "txtKind";
            this.txtKind.PlaceHolder = "모델명 검색";
            this.txtKind.ReadOnly = true;
            this.txtKind.Size = new System.Drawing.Size(145, 23);
            this.txtKind.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.isNumeric = false;
            this.txtName.isRequired = false;
            this.txtName.Location = new System.Drawing.Point(801, 335);
            this.txtName.Name = "txtName";
            this.txtName.PlaceHolder = "모델명 검색";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(369, 23);
            this.txtName.TabIndex = 17;
            // 
            // txtCode
            // 
            this.txtCode.isNumeric = false;
            this.txtCode.isRequired = false;
            this.txtCode.Location = new System.Drawing.Point(650, 335);
            this.txtCode.Name = "txtCode";
            this.txtCode.PlaceHolder = "모델명 검색";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(145, 23);
            this.txtCode.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1110, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 22);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvPart
            // 
            this.dgvPart.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPart.Location = new System.Drawing.Point(650, 3);
            this.dgvPart.Name = "dgvPart";
            this.dgvPart.RowTemplate.Height = 23;
            this.dgvPart.Size = new System.Drawing.Size(520, 326);
            this.dgvPart.TabIndex = 23;
            // 
            // dtpReqDate
            // 
            this.dtpReqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReqDate.Location = new System.Drawing.Point(733, 391);
            this.dtpReqDate.Name = "dtpReqDate";
            this.dtpReqDate.Size = new System.Drawing.Size(185, 23);
            this.dtpReqDate.TabIndex = 24;
            this.dtpReqDate.Value = new System.DateTime(2022, 6, 21, 21, 14, 41, 0);
            // 
            // cboProductionTeam
            // 
            this.cboProductionTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductionTeam.FormattingEnabled = true;
            this.cboProductionTeam.Location = new System.Drawing.Point(1040, 362);
            this.cboProductionTeam.Name = "cboProductionTeam";
            this.cboProductionTeam.Size = new System.Drawing.Size(130, 23);
            this.cboProductionTeam.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "납품 요청일";
            // 
            // popSaveProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 438);
            this.Name = "popSaveProduction";
            this.Text = "popSaveProduction";
            this.Load += new System.EventHandler(this.popSaveProduction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private ccTextBox txtCatagory;
        private System.Windows.Forms.Button btnSaveProduction;
        private ccTextBox txtQty;
        private ccTextBox txtKind;
        private ccTextBox txtName;
        private ccTextBox txtCode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProductionTeam;
        private System.Windows.Forms.DateTimePicker dtpReqDate;
    }
}