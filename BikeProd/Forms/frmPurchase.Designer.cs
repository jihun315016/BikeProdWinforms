namespace BikeProd
{
    partial class frmPurchase
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboStateFilter = new System.Windows.Forms.ComboBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnGetOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtState = new BikeProd.ccTextBox();
            this.dtpAliveDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPurDate = new System.Windows.Forms.DateTimePicker();
            this.txtClient = new BikeProd.ccTextBox();
            this.txtAddress = new BikeProd.ccTextBox();
            this.txtManager = new BikeProd.ccTextBox();
            this.txtSubManager = new BikeProd.ccTextBox();
            this.txtPurName = new BikeProd.ccTextBox();
            this.txtBusinessNo = new BikeProd.ccTextBox();
            this.txtPurNo = new BikeProd.ccTextBox();
            this.dgvList2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOrderCancle = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new BikeProd.ccTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptLabel1
            // 
            this.DescriptLabel1.Location = new System.Drawing.Point(639, 9);
            this.DescriptLabel1.Visible = false;
            // 
            // DescriptLabel2
            // 
            this.DescriptLabel2.Location = new System.Drawing.Point(467, 9);
            this.DescriptLabel2.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "발주 일자";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "거래처";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(96, 17);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(97, 23);
            this.dtpFrom.TabIndex = 9;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(220, 17);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(97, 23);
            this.dtpTo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "~";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(321, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboStateFilter
            // 
            this.cboStateFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboStateFilter.FormattingEnabled = true;
            this.cboStateFilter.Location = new System.Drawing.Point(322, 16);
            this.cboStateFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cboStateFilter.Name = "cboStateFilter";
            this.cboStateFilter.Size = new System.Drawing.Size(89, 23);
            this.cboStateFilter.TabIndex = 12;
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvList.Location = new System.Drawing.Point(0, 80);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 27;
            this.dgvList.Size = new System.Drawing.Size(454, 341);
            this.dgvList.TabIndex = 13;
            this.dgvList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentDoubleClick);
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvList_CellFormatting);
            // 
            // btnGetOK
            // 
            this.btnGetOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGetOK.Location = new System.Drawing.Point(316, 456);
            this.btnGetOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetOK.Name = "btnGetOK";
            this.btnGetOK.Size = new System.Drawing.Size(79, 32);
            this.btnGetOK.TabIndex = 14;
            this.btnGetOK.Text = "입고완료";
            this.btnGetOK.UseVisualStyleBackColor = true;
            this.btnGetOK.Click += new System.EventHandler(this.btnGetOK_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "발주 번호";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtState);
            this.panel1.Controls.Add(this.dtpAliveDate);
            this.panel1.Controls.Add(this.dtpPurDate);
            this.panel1.Controls.Add(this.txtClient);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtManager);
            this.panel1.Controls.Add(this.txtSubManager);
            this.panel1.Controls.Add(this.txtPurName);
            this.panel1.Controls.Add(this.txtBusinessNo);
            this.panel1.Controls.Add(this.txtPurNo);
            this.panel1.Controls.Add(this.dgvList2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(484, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 403);
            this.panel1.TabIndex = 15;
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtState.isNumeric = false;
            this.txtState.isRequired = false;
            this.txtState.Location = new System.Drawing.Point(420, 72);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.Name = "txtState";
            this.txtState.PlaceHolder = "상태";
            this.txtState.Size = new System.Drawing.Size(79, 23);
            this.txtState.TabIndex = 16;
            // 
            // dtpAliveDate
            // 
            this.dtpAliveDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpAliveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAliveDate.Location = new System.Drawing.Point(110, 135);
            this.dtpAliveDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAliveDate.Name = "dtpAliveDate";
            this.dtpAliveDate.Size = new System.Drawing.Size(120, 23);
            this.dtpAliveDate.TabIndex = 15;
            // 
            // dtpPurDate
            // 
            this.dtpPurDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpPurDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurDate.Location = new System.Drawing.Point(110, 105);
            this.dtpPurDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPurDate.Name = "dtpPurDate";
            this.dtpPurDate.Size = new System.Drawing.Size(120, 23);
            this.dtpPurDate.TabIndex = 15;
            // 
            // txtClient
            // 
            this.txtClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClient.isNumeric = false;
            this.txtClient.isRequired = false;
            this.txtClient.Location = new System.Drawing.Point(343, 5);
            this.txtClient.Name = "txtClient";
            this.txtClient.PlaceHolder = null;
            this.txtClient.Size = new System.Drawing.Size(141, 23);
            this.txtClient.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.isNumeric = false;
            this.txtAddress.isRequired = false;
            this.txtAddress.Location = new System.Drawing.Point(110, 171);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceHolder = null;
            this.txtAddress.Size = new System.Drawing.Size(388, 59);
            this.txtAddress.TabIndex = 14;
            // 
            // txtManager
            // 
            this.txtManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtManager.isNumeric = false;
            this.txtManager.isRequired = false;
            this.txtManager.Location = new System.Drawing.Point(357, 104);
            this.txtManager.Name = "txtManager";
            this.txtManager.PlaceHolder = null;
            this.txtManager.Size = new System.Drawing.Size(141, 23);
            this.txtManager.TabIndex = 14;
            // 
            // txtSubManager
            // 
            this.txtSubManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubManager.isNumeric = false;
            this.txtSubManager.isRequired = false;
            this.txtSubManager.Location = new System.Drawing.Point(357, 135);
            this.txtSubManager.Name = "txtSubManager";
            this.txtSubManager.PlaceHolder = null;
            this.txtSubManager.Size = new System.Drawing.Size(141, 23);
            this.txtSubManager.TabIndex = 14;
            // 
            // txtPurName
            // 
            this.txtPurName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPurName.isNumeric = false;
            this.txtPurName.isRequired = false;
            this.txtPurName.Location = new System.Drawing.Point(110, 71);
            this.txtPurName.Name = "txtPurName";
            this.txtPurName.PlaceHolder = null;
            this.txtPurName.Size = new System.Drawing.Size(264, 23);
            this.txtPurName.TabIndex = 14;
            // 
            // txtBusinessNo
            // 
            this.txtBusinessNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusinessNo.isNumeric = false;
            this.txtBusinessNo.isRequired = false;
            this.txtBusinessNo.Location = new System.Drawing.Point(110, 41);
            this.txtBusinessNo.Name = "txtBusinessNo";
            this.txtBusinessNo.PlaceHolder = null;
            this.txtBusinessNo.Size = new System.Drawing.Size(264, 23);
            this.txtBusinessNo.TabIndex = 14;
            // 
            // txtPurNo
            // 
            this.txtPurNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPurNo.isNumeric = false;
            this.txtPurNo.isRequired = false;
            this.txtPurNo.Location = new System.Drawing.Point(110, 9);
            this.txtPurNo.Name = "txtPurNo";
            this.txtPurNo.PlaceHolder = null;
            this.txtPurNo.Size = new System.Drawing.Size(141, 23);
            this.txtPurNo.TabIndex = 14;
            // 
            // dgvList2
            // 
            this.dgvList2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvList2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList2.Location = new System.Drawing.Point(19, 248);
            this.dgvList2.Name = "dgvList2";
            this.dgvList2.RowHeadersWidth = 51;
            this.dgvList2.RowTemplate.Height = 23;
            this.dgvList2.Size = new System.Drawing.Size(511, 155);
            this.dgvList2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "주소";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 138);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "발주 담당자";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "입고 예정일";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "거래처 담당자";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "발주 일자";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "발주서명";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "사업자 번호";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "입고처";
            // 
            // btnOrderCancle
            // 
            this.btnOrderCancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrderCancle.Location = new System.Drawing.Point(400, 456);
            this.btnOrderCancle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderCancle.Name = "btnOrderCancle";
            this.btnOrderCancle.Size = new System.Drawing.Size(79, 32);
            this.btnOrderCancle.TabIndex = 14;
            this.btnOrderCancle.Text = "주문취소";
            this.btnOrderCancle.UseVisualStyleBackColor = true;
            this.btnOrderCancle.Click += new System.EventHandler(this.btnOrderCancle_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(840, 456);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(79, 32);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "발주서";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(924, 456);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 32);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "발주서 등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Controls.Add(this.cboStateFilter);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 421);
            this.panel2.TabIndex = 16;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.isNumeric = false;
            this.txtSearch.isRequired = false;
            this.txtSearch.Location = new System.Drawing.Point(97, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolder = null;
            this.txtSearch.Size = new System.Drawing.Size(220, 23);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 510);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGetOK);
            this.Controls.Add(this.btnOrderCancle);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmPurchase";
            this.Text = "발주";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBalJu_Load);
            this.Controls.SetChildIndex(this.btnOrderCancle, 0);
            this.Controls.SetChildIndex(this.btnGetOK, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnExport, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.DescriptLabel1, 0);
            this.Controls.SetChildIndex(this.DescriptLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboStateFilter;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnGetOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvList2;
        private System.Windows.Forms.Button btnOrderCancle;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private ccTextBox txtClient;
        private ccTextBox txtAddress;
        private ccTextBox txtManager;
        private ccTextBox txtSubManager;
        private ccTextBox txtPurName;
        private ccTextBox txtBusinessNo;
        private ccTextBox txtPurNo;
        private ccTextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtpAliveDate;
        private System.Windows.Forms.DateTimePicker dtpPurDate;
        private ccTextBox txtState;
    }
}