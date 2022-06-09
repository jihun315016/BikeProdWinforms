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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnGetOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvList2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.txtPurNo = new BikeProd.ccTextBox();
            this.ccTextBox2 = new BikeProd.ccTextBox();
            this.txtBusinessNo = new BikeProd.ccTextBox();
            this.ccPurName = new BikeProd.ccTextBox();
            this.ccTextBox5 = new BikeProd.ccTextBox();
            this.ccTextBox6 = new BikeProd.ccTextBox();
            this.ccTextBox7 = new BikeProd.ccTextBox();
            this.ccTextBox8 = new BikeProd.ccTextBox();
            this.ccTextBox9 = new BikeProd.ccTextBox();
            this.ccTextBox10 = new BikeProd.ccTextBox();
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "발주 일자";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "거래처";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(66, 17);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(97, 23);
            this.dtpFrom.TabIndex = 9;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(190, 17);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(97, 23);
            this.dtpTo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "~";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(292, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(6, 104);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 27;
            this.dgvList.Size = new System.Drawing.Size(343, 311);
            this.dgvList.TabIndex = 13;
            // 
            // btnGetOK
            // 
            this.btnGetOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetOK.Location = new System.Drawing.Point(183, 435);
            this.btnGetOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetOK.Name = "btnGetOK";
            this.btnGetOK.Size = new System.Drawing.Size(79, 32);
            this.btnGetOK.TabIndex = 14;
            this.btnGetOK.Text = "입고완료";
            this.btnGetOK.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "발주 번호";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ccTextBox2);
            this.panel1.Controls.Add(this.ccTextBox9);
            this.panel1.Controls.Add(this.ccTextBox8);
            this.panel1.Controls.Add(this.ccTextBox7);
            this.panel1.Controls.Add(this.ccTextBox6);
            this.panel1.Controls.Add(this.ccTextBox5);
            this.panel1.Controls.Add(this.ccPurName);
            this.panel1.Controls.Add(this.txtBusinessNo);
            this.panel1.Controls.Add(this.txtPurNo);
            this.panel1.Controls.Add(this.dgvList2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(378, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 398);
            this.panel1.TabIndex = 15;
            // 
            // dgvList2
            // 
            this.dgvList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvList2.Location = new System.Drawing.Point(0, 248);
            this.dgvList2.Name = "dgvList2";
            this.dgvList2.RowTemplate.Height = 23;
            this.dgvList2.Size = new System.Drawing.Size(511, 150);
            this.dgvList2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "주소";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 138);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "발주 담당자";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(361, 70);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(86, 23);
            this.comboBox2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "입고 예정일";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "거래처 담당자";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "발주 일자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "발주서명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "사업자 번호";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "입고처";
            // 
            // btnOrderCancle
            // 
            this.btnOrderCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderCancle.Location = new System.Drawing.Point(263, 435);
            this.btnOrderCancle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderCancle.Name = "btnOrderCancle";
            this.btnOrderCancle.Size = new System.Drawing.Size(79, 32);
            this.btnOrderCancle.TabIndex = 14;
            this.btnOrderCancle.Text = "주문취소";
            this.btnOrderCancle.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(728, 451);
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
            this.btnAdd.Location = new System.Drawing.Point(811, 451);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 32);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "발주서 등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ccTextBox10);
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnGetOK);
            this.panel2.Controls.Add(this.btnOrderCancle);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 477);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtPurNo
            // 
            this.txtPurNo.isNumeric = false;
            this.txtPurNo.isRequired = false;
            this.txtPurNo.Location = new System.Drawing.Point(92, 9);
            this.txtPurNo.Name = "txtPurNo";
            this.txtPurNo.PlaceHolder = null;
            this.txtPurNo.Size = new System.Drawing.Size(141, 23);
            this.txtPurNo.TabIndex = 14;
            // 
            // ccTextBox2
            // 
            this.ccTextBox2.isNumeric = false;
            this.ccTextBox2.isRequired = false;
            this.ccTextBox2.Location = new System.Drawing.Point(325, 5);
            this.ccTextBox2.Name = "ccTextBox2";
            this.ccTextBox2.PlaceHolder = null;
            this.ccTextBox2.Size = new System.Drawing.Size(141, 23);
            this.ccTextBox2.TabIndex = 14;
            // 
            // txtBusinessNo
            // 
            this.txtBusinessNo.isNumeric = false;
            this.txtBusinessNo.isRequired = false;
            this.txtBusinessNo.Location = new System.Drawing.Point(92, 41);
            this.txtBusinessNo.Name = "txtBusinessNo";
            this.txtBusinessNo.PlaceHolder = null;
            this.txtBusinessNo.Size = new System.Drawing.Size(264, 23);
            this.txtBusinessNo.TabIndex = 14;
            // 
            // ccPurName
            // 
            this.ccPurName.isNumeric = false;
            this.ccPurName.isRequired = false;
            this.ccPurName.Location = new System.Drawing.Point(92, 71);
            this.ccPurName.Name = "ccPurName";
            this.ccPurName.PlaceHolder = null;
            this.ccPurName.Size = new System.Drawing.Size(264, 23);
            this.ccPurName.TabIndex = 14;
            // 
            // ccTextBox5
            // 
            this.ccTextBox5.isNumeric = false;
            this.ccTextBox5.isRequired = false;
            this.ccTextBox5.Location = new System.Drawing.Point(92, 106);
            this.ccTextBox5.Name = "ccTextBox5";
            this.ccTextBox5.PlaceHolder = null;
            this.ccTextBox5.Size = new System.Drawing.Size(141, 23);
            this.ccTextBox5.TabIndex = 14;
            // 
            // ccTextBox6
            // 
            this.ccTextBox6.isNumeric = false;
            this.ccTextBox6.isRequired = false;
            this.ccTextBox6.Location = new System.Drawing.Point(92, 136);
            this.ccTextBox6.Name = "ccTextBox6";
            this.ccTextBox6.PlaceHolder = null;
            this.ccTextBox6.Size = new System.Drawing.Size(141, 23);
            this.ccTextBox6.TabIndex = 14;
            // 
            // ccTextBox7
            // 
            this.ccTextBox7.isNumeric = false;
            this.ccTextBox7.isRequired = false;
            this.ccTextBox7.Location = new System.Drawing.Point(339, 135);
            this.ccTextBox7.Name = "ccTextBox7";
            this.ccTextBox7.PlaceHolder = null;
            this.ccTextBox7.Size = new System.Drawing.Size(141, 23);
            this.ccTextBox7.TabIndex = 14;
            // 
            // ccTextBox8
            // 
            this.ccTextBox8.isNumeric = false;
            this.ccTextBox8.isRequired = false;
            this.ccTextBox8.Location = new System.Drawing.Point(339, 104);
            this.ccTextBox8.Name = "ccTextBox8";
            this.ccTextBox8.PlaceHolder = null;
            this.ccTextBox8.Size = new System.Drawing.Size(141, 23);
            this.ccTextBox8.TabIndex = 14;
            // 
            // ccTextBox9
            // 
            this.ccTextBox9.isNumeric = false;
            this.ccTextBox9.isRequired = false;
            this.ccTextBox9.Location = new System.Drawing.Point(92, 171);
            this.ccTextBox9.Multiline = true;
            this.ccTextBox9.Name = "ccTextBox9";
            this.ccTextBox9.PlaceHolder = null;
            this.ccTextBox9.Size = new System.Drawing.Size(388, 59);
            this.ccTextBox9.TabIndex = 14;
            // 
            // ccTextBox10
            // 
            this.ccTextBox10.isNumeric = false;
            this.ccTextBox10.isRequired = false;
            this.ccTextBox10.Location = new System.Drawing.Point(67, 49);
            this.ccTextBox10.Name = "ccTextBox10";
            this.ccTextBox10.PlaceHolder = null;
            this.ccTextBox10.Size = new System.Drawing.Size(220, 23);
            this.ccTextBox10.TabIndex = 15;
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 505);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmPurchase";
            this.Text = "발주";
            this.Load += new System.EventHandler(this.frmBalJu_Load);
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
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnOrderCancle;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private ccTextBox ccTextBox2;
        private ccTextBox ccTextBox9;
        private ccTextBox ccTextBox8;
        private ccTextBox ccTextBox7;
        private ccTextBox ccTextBox6;
        private ccTextBox ccTextBox5;
        private ccTextBox ccPurName;
        private ccTextBox txtBusinessNo;
        private ccTextBox txtPurNo;
        private ccTextBox ccTextBox10;
    }
}