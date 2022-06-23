
namespace BikeProd
{
    partial class popSaveAddress
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddrSearch = new BikeProd.ccTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btanSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddr2 = new BikeProd.ccTextBox();
            this.txtAddr1 = new BikeProd.ccTextBox();
            this.txtAddrCode = new BikeProd.ccTextBox();
            this.txtAddrDetail = new BikeProd.ccTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddrDetail);
            this.panel1.Controls.Add(this.txtAddr2);
            this.panel1.Controls.Add(this.txtAddr1);
            this.panel1.Controls.Add(this.txtAddrCode);
            this.panel1.Controls.Add(this.btanSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtAddrSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Size = new System.Drawing.Size(515, 474);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "도로명 / 지번주소";
            // 
            // txtAddrSearch
            // 
            this.txtAddrSearch.isNumeric = false;
            this.txtAddrSearch.isRequired = false;
            this.txtAddrSearch.Location = new System.Drawing.Point(113, 15);
            this.txtAddrSearch.Name = "txtAddrSearch";
            this.txtAddrSearch.PlaceHolder = null;
            this.txtAddrSearch.Size = new System.Drawing.Size(300, 23);
            this.txtAddrSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(419, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(3, 55);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(509, 289);
            this.dgvList.TabIndex = 3;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // btanSave
            // 
            this.btanSave.Location = new System.Drawing.Point(383, 433);
            this.btanSave.Name = "btanSave";
            this.btanSave.Size = new System.Drawing.Size(93, 27);
            this.btanSave.TabIndex = 57;
            this.btanSave.Text = "주소 등록";
            this.btanSave.UseVisualStyleBackColor = true;
            this.btanSave.Click += new System.EventHandler(this.btanSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "도로명 주소";
            // 
            // txtAddr2
            // 
            this.txtAddr2.isNumeric = false;
            this.txtAddr2.isRequired = false;
            this.txtAddr2.Location = new System.Drawing.Point(100, 393);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.PlaceHolder = null;
            this.txtAddr2.Size = new System.Drawing.Size(242, 23);
            this.txtAddr2.TabIndex = 60;
            // 
            // txtAddr1
            // 
            this.txtAddr1.isNumeric = false;
            this.txtAddr1.isRequired = false;
            this.txtAddr1.Location = new System.Drawing.Point(100, 364);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.PlaceHolder = null;
            this.txtAddr1.Size = new System.Drawing.Size(272, 23);
            this.txtAddr1.TabIndex = 59;
            // 
            // txtAddrCode
            // 
            this.txtAddrCode.isNumeric = false;
            this.txtAddrCode.isRequired = false;
            this.txtAddrCode.Location = new System.Drawing.Point(378, 364);
            this.txtAddrCode.Name = "txtAddrCode";
            this.txtAddrCode.PlaceHolder = null;
            this.txtAddrCode.Size = new System.Drawing.Size(98, 23);
            this.txtAddrCode.TabIndex = 58;
            // 
            // txtAddrDetail
            // 
            this.txtAddrDetail.isNumeric = false;
            this.txtAddrDetail.isRequired = false;
            this.txtAddrDetail.Location = new System.Drawing.Point(348, 393);
            this.txtAddrDetail.Name = "txtAddrDetail";
            this.txtAddrDetail.PlaceHolder = null;
            this.txtAddrDetail.Size = new System.Drawing.Size(128, 23);
            this.txtAddrDetail.TabIndex = 61;
            // 
            // popSaveAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 502);
            this.Name = "popSaveAddress";
            this.Text = "popSaveAddress";
            this.Load += new System.EventHandler(this.popSaveAddress_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnSearch;
        private ccTextBox txtAddrSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btanSave;
        private System.Windows.Forms.Label label3;
        private ccTextBox txtAddr2;
        private ccTextBox txtAddr1;
        private ccTextBox txtAddrCode;
        private ccTextBox txtAddrDetail;
    }
}