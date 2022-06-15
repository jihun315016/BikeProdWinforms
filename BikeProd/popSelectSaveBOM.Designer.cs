namespace BikeProd
{
    partial class popSelectSaveBOM
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
            this.txtSearch = new BikeProd.ccTextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboKind = new System.Windows.Forms.ComboBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnInit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cboCategory);
            this.panel1.Controls.Add(this.cboKind);
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Size = new System.Drawing.Size(523, 390);
            // 
            // txtSearch
            // 
            this.txtSearch.isNumeric = false;
            this.txtSearch.isRequired = false;
            this.txtSearch.Location = new System.Drawing.Point(257, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolder = "제품명 검색";
            this.txtSearch.Size = new System.Drawing.Size(100, 23);
            this.txtSearch.TabIndex = 9;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(130, 6);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 23);
            this.cboCategory.TabIndex = 8;
            // 
            // cboKind
            // 
            this.cboKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKind.FormattingEnabled = true;
            this.cboKind.Location = new System.Drawing.Point(3, 6);
            this.cboKind.Name = "cboKind";
            this.cboKind.Size = new System.Drawing.Size(121, 23);
            this.cboKind.TabIndex = 7;
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(3, 54);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(516, 301);
            this.dgvList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "등록할 BOM 제품 선택";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(363, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(444, 6);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 16;
            this.btnInit.Text = "초기화";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(444, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(363, 361);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // popSelectSaveBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 413);
            this.Name = "popSelectSaveBOM";
            this.Text = "popSelectSaveBOM";
            this.Load += new System.EventHandler(this.popSelectSaveBOM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ccTextBox txtSearch;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboKind;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
    }
}