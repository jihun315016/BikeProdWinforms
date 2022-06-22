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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelProduction = new System.Windows.Forms.Button();
            this.btnCompleteProduction = new System.Windows.Forms.Button();
            this.btnSaveProduction = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduction = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvComplete = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDefectRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoss = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplete)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.SplitterDistance = 51;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Size = new System.Drawing.Size(1090, 518);
            this.panel1.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1090, 518);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelProduction);
            this.panel2.Controls.Add(this.btnCompleteProduction);
            this.panel2.Controls.Add(this.btnSaveProduction);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 34);
            this.panel2.TabIndex = 0;
            // 
            // btnCancelProduction
            // 
            this.btnCancelProduction.Location = new System.Drawing.Point(973, 4);
            this.btnCancelProduction.Name = "btnCancelProduction";
            this.btnCancelProduction.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProduction.TabIndex = 2;
            this.btnCancelProduction.Text = "생산 취소";
            this.btnCancelProduction.UseVisualStyleBackColor = true;
            this.btnCancelProduction.Click += new System.EventHandler(this.btnCancelProduction_Click);
            // 
            // btnCompleteProduction
            // 
            this.btnCompleteProduction.Location = new System.Drawing.Point(892, 4);
            this.btnCompleteProduction.Name = "btnCompleteProduction";
            this.btnCompleteProduction.Size = new System.Drawing.Size(75, 23);
            this.btnCompleteProduction.TabIndex = 1;
            this.btnCompleteProduction.Text = "생산 완료";
            this.btnCompleteProduction.UseVisualStyleBackColor = true;
            this.btnCompleteProduction.Click += new System.EventHandler(this.btnCompleteProduction_Click);
            // 
            // btnSaveProduction
            // 
            this.btnSaveProduction.Location = new System.Drawing.Point(811, 4);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 213);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "생산 지시";
            // 
            // dgvProduction
            // 
            this.dgvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduction.Location = new System.Drawing.Point(3, 19);
            this.dgvProduction.Name = "dgvProduction";
            this.dgvProduction.RowTemplate.Height = 23;
            this.dgvProduction.Size = new System.Drawing.Size(1078, 191);
            this.dgvProduction.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvComplete);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1084, 213);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "생산 실적";
            // 
            // dgvComplete
            // 
            this.dgvComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComplete.Location = new System.Drawing.Point(3, 19);
            this.dgvComplete.Name = "dgvComplete";
            this.dgvComplete.RowTemplate.Height = 23;
            this.dgvComplete.Size = new System.Drawing.Size(1078, 191);
            this.dgvComplete.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDefectRate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtLoss);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 34);
            this.panel3.TabIndex = 5;
            // 
            // txtDefectRate
            // 
            this.txtDefectRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefectRate.Location = new System.Drawing.Point(948, 8);
            this.txtDefectRate.Name = "txtDefectRate";
            this.txtDefectRate.ReadOnly = true;
            this.txtDefectRate.Size = new System.Drawing.Size(100, 23);
            this.txtDefectRate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(899, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "불량률";
            // 
            // txtLoss
            // 
            this.txtLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoss.Location = new System.Drawing.Point(771, 8);
            this.txtLoss.Name = "txtLoss";
            this.txtLoss.ReadOnly = true;
            this.txtLoss.Size = new System.Drawing.Size(100, 23);
            this.txtLoss.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loss";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(604, 8);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "총 생산량";
            // 
            // frmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmProduction";
            this.Text = "frmProduction";
            this.Load += new System.EventHandler(this.frmProduction_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplete)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveProduction;
        private System.Windows.Forms.DataGridView dgvProduction;
        private System.Windows.Forms.Button btnCompleteProduction;
        private System.Windows.Forms.Button btnCancelProduction;
        private System.Windows.Forms.DataGridView dgvComplete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDefectRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoss;
        private System.Windows.Forms.Label label3;
    }
}