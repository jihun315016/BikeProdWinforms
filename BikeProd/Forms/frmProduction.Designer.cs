
namespace BikeProd
{
    partial class frmProduction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ccTxtLoss = new BikeProd.ccTextBox();
            this.btnCancelProduction = new System.Windows.Forms.Button();
            this.btnCompleteProduction = new System.Windows.Forms.Button();
            this.btnSaveProduction = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduction = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvComplete = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ccTxtDefectRate = new BikeProd.ccTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ccTxtTotalLoss = new BikeProd.ccTextBox();
            this.ccTxtTotal = new BikeProd.ccTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnSearchProduction = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTeam = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplete)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(32, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 541);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-6, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1090, 544);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ccTxtLoss);
            this.panel2.Controls.Add(this.btnCancelProduction);
            this.panel2.Controls.Add(this.btnCompleteProduction);
            this.panel2.Controls.Add(this.btnSaveProduction);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 34);
            this.panel2.TabIndex = 0;
            // 
            // ccTxtLoss
            // 
            this.ccTxtLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ccTxtLoss.isNumeric = true;
            this.ccTxtLoss.isRequired = false;
            this.ccTxtLoss.Location = new System.Drawing.Point(738, 3);
            this.ccTxtLoss.Name = "ccTxtLoss";
            this.ccTxtLoss.PlaceHolder = "Loss";
            this.ccTxtLoss.Size = new System.Drawing.Size(100, 23);
            this.ccTxtLoss.TabIndex = 3;
            // 
            // btnCancelProduction
            // 
            this.btnCancelProduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelProduction.Location = new System.Drawing.Point(1006, 3);
            this.btnCancelProduction.Name = "btnCancelProduction";
            this.btnCancelProduction.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProduction.TabIndex = 2;
            this.btnCancelProduction.Text = "생산 취소";
            this.btnCancelProduction.UseVisualStyleBackColor = true;
            this.btnCancelProduction.Click += new System.EventHandler(this.btnCancelProduction_Click);
            // 
            // btnCompleteProduction
            // 
            this.btnCompleteProduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompleteProduction.Location = new System.Drawing.Point(844, 3);
            this.btnCompleteProduction.Name = "btnCompleteProduction";
            this.btnCompleteProduction.Size = new System.Drawing.Size(75, 23);
            this.btnCompleteProduction.TabIndex = 1;
            this.btnCompleteProduction.Text = "생산 완료";
            this.btnCompleteProduction.UseVisualStyleBackColor = true;
            this.btnCompleteProduction.Click += new System.EventHandler(this.btnCompleteProduction_Click);
            // 
            // btnSaveProduction
            // 
            this.btnSaveProduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProduction.Location = new System.Drawing.Point(925, 3);
            this.btnSaveProduction.Name = "btnSaveProduction";
            this.btnSaveProduction.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProduction.TabIndex = 0;
            this.btnSaveProduction.Text = "생산 지시";
            this.btnSaveProduction.UseVisualStyleBackColor = true;
            this.btnSaveProduction.Click += new System.EventHandler(this.btnSaveProduction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProduction);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "생산 지시";
            // 
            // dgvProduction
            // 
            this.dgvProduction.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduction.Location = new System.Drawing.Point(3, 19);
            this.dgvProduction.Name = "dgvProduction";
            this.dgvProduction.RowTemplate.Height = 23;
            this.dgvProduction.Size = new System.Drawing.Size(1078, 164);
            this.dgvProduction.TabIndex = 1;
            this.dgvProduction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduction_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvComplete);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1084, 186);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "생산 실적";
            // 
            // dgvComplete
            // 
            this.dgvComplete.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComplete.Location = new System.Drawing.Point(3, 19);
            this.dgvComplete.Name = "dgvComplete";
            this.dgvComplete.RowTemplate.Height = 23;
            this.dgvComplete.Size = new System.Drawing.Size(1078, 164);
            this.dgvComplete.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ccTxtDefectRate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.ccTxtTotalLoss);
            this.panel3.Controls.Add(this.ccTxtTotal);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 507);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 34);
            this.panel3.TabIndex = 5;
            // 
            // ccTxtDefectRate
            // 
            this.ccTxtDefectRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ccTxtDefectRate.isNumeric = false;
            this.ccTxtDefectRate.isRequired = false;
            this.ccTxtDefectRate.Location = new System.Drawing.Point(981, 9);
            this.ccTxtDefectRate.Name = "ccTxtDefectRate";
            this.ccTxtDefectRate.PlaceHolder = null;
            this.ccTxtDefectRate.ReadOnly = true;
            this.ccTxtDefectRate.Size = new System.Drawing.Size(100, 23);
            this.ccTxtDefectRate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "~";
            // 
            // ccTxtTotalLoss
            // 
            this.ccTxtTotalLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ccTxtTotalLoss.isNumeric = true;
            this.ccTxtTotalLoss.isRequired = false;
            this.ccTxtTotalLoss.Location = new System.Drawing.Point(804, 9);
            this.ccTxtTotalLoss.Name = "ccTxtTotalLoss";
            this.ccTxtTotalLoss.PlaceHolder = null;
            this.ccTxtTotalLoss.Size = new System.Drawing.Size(100, 23);
            this.ccTxtTotalLoss.TabIndex = 5;
            // 
            // ccTxtTotal
            // 
            this.ccTxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ccTxtTotal.isNumeric = true;
            this.ccTxtTotal.isRequired = false;
            this.ccTxtTotal.Location = new System.Drawing.Point(637, 8);
            this.ccTxtTotal.Name = "ccTxtTotal";
            this.ccTxtTotal.PlaceHolder = null;
            this.ccTxtTotal.Size = new System.Drawing.Size(100, 23);
            this.ccTxtTotal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(932, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "불량률";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(768, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loss";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "총 생산량";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnInit);
            this.panel4.Controls.Add(this.btnSearchProduction);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cboTeam);
            this.panel4.Controls.Add(this.dtpStart);
            this.panel4.Controls.Add(this.dtpEnd);
            this.panel4.Controls.Add(this.cboState);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1084, 74);
            this.panel4.TabIndex = 6;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(507, 18);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(65, 23);
            this.btnInit.TabIndex = 11;
            this.btnInit.Text = "초기화";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnSearchProduction
            // 
            this.btnSearchProduction.Location = new System.Drawing.Point(436, 18);
            this.btnSearchProduction.Name = "btnSearchProduction";
            this.btnSearchProduction.Size = new System.Drawing.Size(65, 23);
            this.btnSearchProduction.TabIndex = 10;
            this.btnSearchProduction.Text = "검색";
            this.btnSearchProduction.UseVisualStyleBackColor = true;
            this.btnSearchProduction.Click += new System.EventHandler(this.btnSearchProduction_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "생산 지시일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "~";
            // 
            // cboTeam
            // 
            this.cboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeam.FormattingEnabled = true;
            this.cboTeam.Location = new System.Drawing.Point(332, 18);
            this.cboTeam.Name = "cboTeam";
            this.cboTeam.Size = new System.Drawing.Size(98, 23);
            this.cboTeam.TabIndex = 9;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(3, 18);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(96, 23);
            this.dtpStart.TabIndex = 4;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(126, 18);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(96, 23);
            this.dtpEnd.TabIndex = 6;
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(228, 18);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(98, 23);
            this.cboState.TabIndex = 8;
            // 
            // frmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.panel1);
            this.Name = "frmProduction";
            this.Text = "frmProduction";
            this.Activated += new System.EventHandler(this.frmProduction_Activated);
            this.Load += new System.EventHandler(this.frmProduction_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.DescriptLabel1, 0);
            this.Controls.SetChildIndex(this.DescriptLabel2, 0);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplete)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private ccTextBox ccTxtLoss;
        private System.Windows.Forms.Button btnCancelProduction;
        private System.Windows.Forms.Button btnCompleteProduction;
        private System.Windows.Forms.Button btnSaveProduction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduction;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvComplete;
        private System.Windows.Forms.Panel panel3;
        private ccTextBox ccTxtDefectRate;
        private ccTextBox ccTxtTotalLoss;
        private ccTextBox ccTxtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchProduction;
        private System.Windows.Forms.ComboBox cboTeam;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnInit;
    }
}