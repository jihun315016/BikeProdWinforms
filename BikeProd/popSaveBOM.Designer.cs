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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btnInit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cboCategory);
            this.panel1.Controls.Add(this.cboKind);
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Size = new System.Drawing.Size(973, 538);
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(3, 44);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(429, 301);
            this.dgvList.TabIndex = 0;
            // 
            // cboKind
            // 
            this.cboKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKind.FormattingEnabled = true;
            this.cboKind.Location = new System.Drawing.Point(3, 15);
            this.cboKind.Name = "cboKind";
            this.cboKind.Size = new System.Drawing.Size(94, 23);
            this.cboKind.TabIndex = 1;
            this.cboKind.SelectedIndexChanged += new System.EventHandler(this.cboKind_SelectedIndexChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(103, 15);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(94, 23);
            this.cboCategory.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.isNumeric = false;
            this.txtSearch.isRequired = false;
            this.txtSearch.Location = new System.Drawing.Point(203, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolder = null;
            this.txtSearch.Size = new System.Drawing.Size(87, 23);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(296, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(367, 15);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(65, 23);
            this.btnInit.TabIndex = 5;
            this.btnInit.Text = "초기화";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(502, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(468, 268);
            this.dataGridView2.TabIndex = 6;
            // 
            // popSaveBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "popSaveBOM";
            this.Text = "popSaveBOM";
            this.Load += new System.EventHandler(this.popSaveBOM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnSearch;
        private ccTextBox txtSearch;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboKind;
        private System.Windows.Forms.DataGridView dgvList;
    }
}