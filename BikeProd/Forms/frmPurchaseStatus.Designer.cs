
namespace BikeProd
{
    partial class frmPurchaseStatus
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClientP = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.dgvPCList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtListTotal = new System.Windows.Forms.TextBox();
            this.dgvPCDetail = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetailTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.SplitterDistance = 111;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvPCList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtListTotal);
            this.panel1.Controls.Add(this.dgvPCDetail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDetailTotal);
            this.panel1.Controls.SetChildIndex(this.txtDetailTotal, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.dgvPCDetail, 0);
            this.panel1.Controls.SetChildIndex(this.txtListTotal, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.dgvPCList, 0);
            this.panel1.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClientP);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.cboPeriod);
            this.groupBox1.Location = new System.Drawing.Point(649, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(437, 208);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세 검색";
            // 
            // txtClientP
            // 
            this.txtClientP.Location = new System.Drawing.Point(130, 51);
            this.txtClientP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClientP.Name = "txtClientP";
            this.txtClientP.Size = new System.Drawing.Size(223, 23);
            this.txtClientP.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 135);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 26);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(65, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "거래처명";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(202, 135);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 26);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(60, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "매입 일자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(231, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "~";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(130, 78);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(97, 26);
            this.dtpFrom.TabIndex = 9;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(256, 78);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(97, 26);
            this.dtpTo.TabIndex = 10;
            // 
            // cboPeriod
            // 
            this.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Location = new System.Drawing.Point(202, 108);
            this.cboPeriod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(150, 23);
            this.cboPeriod.TabIndex = 11;
            this.cboPeriod.SelectedIndexChanged += new System.EventHandler(this.cboPeriod_SelectedIndexChanged);
            // 
            // dgvPCList
            // 
            this.dgvPCList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPCList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPCList.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPCList.Location = new System.Drawing.Point(5, 2);
            this.dgvPCList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPCList.Name = "dgvPCList";
            this.dgvPCList.ReadOnly = true;
            this.dgvPCList.RowHeadersWidth = 51;
            this.dgvPCList.RowTemplate.Height = 27;
            this.dgvPCList.Size = new System.Drawing.Size(567, 182);
            this.dgvPCList.TabIndex = 17;
            this.dgvPCList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchasedList_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(344, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "총 매입액";
            // 
            // txtListTotal
            // 
            this.txtListTotal.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtListTotal.Location = new System.Drawing.Point(422, 189);
            this.txtListTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtListTotal.Name = "txtListTotal";
            this.txtListTotal.Size = new System.Drawing.Size(151, 27);
            this.txtListTotal.TabIndex = 19;
            this.txtListTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvPCDetail
            // 
            this.dgvPCDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPCDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPCDetail.Location = new System.Drawing.Point(3, 230);
            this.dgvPCDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPCDetail.Name = "dgvPCDetail";
            this.dgvPCDetail.RowHeadersWidth = 51;
            this.dgvPCDetail.RowTemplate.Height = 27;
            this.dgvPCDetail.Size = new System.Drawing.Size(1083, 182);
            this.dgvPCDetail.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(858, 419);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "총 매입액";
            // 
            // txtDetailTotal
            // 
            this.txtDetailTotal.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDetailTotal.Location = new System.Drawing.Point(936, 417);
            this.txtDetailTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDetailTotal.Name = "txtDetailTotal";
            this.txtDetailTotal.Size = new System.Drawing.Size(151, 27);
            this.txtDetailTotal.TabIndex = 20;
            this.txtDetailTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(51, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "매입 완료 현황";
            // 
            // frmPurchaseStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmPurchaseStatus";
            this.Text = "매입현황";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchaseStatus_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClientP;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.DataGridView dgvPCList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtListTotal;
        private System.Windows.Forms.DataGridView dgvPCDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetailTotal;
        private System.Windows.Forms.Label label7;
    }
}