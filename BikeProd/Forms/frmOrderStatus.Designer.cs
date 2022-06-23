
namespace BikeProd
{
    partial class frmOrderStatus
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
            this.dgvSoldList = new System.Windows.Forms.DataGridView();
            this.dgvSoldDetail = new System.Windows.Forms.DataGridView();
            this.txtListTotal = new System.Windows.Forms.TextBox();
            this.txtDetailTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.txtClientS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(1473, 811);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.SplitterWidth = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvSoldList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDetailTotal);
            this.panel1.Controls.Add(this.txtListTotal);
            this.panel1.Controls.Add(this.dgvSoldDetail);
            this.panel1.Controls.SetChildIndex(this.dgvSoldDetail, 0);
            this.panel1.Controls.SetChildIndex(this.txtListTotal, 0);
            this.panel1.Controls.SetChildIndex(this.txtDetailTotal, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.dgvSoldList, 0);
            this.panel1.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // dgvSoldList
            // 
            this.dgvSoldList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSoldList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoldList.Location = new System.Drawing.Point(3, 3);
            this.dgvSoldList.Name = "dgvSoldList";
            this.dgvSoldList.RowHeadersWidth = 51;
            this.dgvSoldList.RowTemplate.Height = 27;
            this.dgvSoldList.Size = new System.Drawing.Size(729, 243);
            this.dgvSoldList.TabIndex = 1;
            this.dgvSoldList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoldList_CellClick);
            // 
            // dgvSoldDetail
            // 
            this.dgvSoldDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSoldDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoldDetail.Location = new System.Drawing.Point(0, 312);
            this.dgvSoldDetail.Name = "dgvSoldDetail";
            this.dgvSoldDetail.RowHeadersWidth = 51;
            this.dgvSoldDetail.RowTemplate.Height = 27;
            this.dgvSoldDetail.Size = new System.Drawing.Size(1392, 243);
            this.dgvSoldDetail.TabIndex = 2;
            // 
            // txtListTotal
            // 
            this.txtListTotal.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtListTotal.Location = new System.Drawing.Point(539, 252);
            this.txtListTotal.Name = "txtListTotal";
            this.txtListTotal.Size = new System.Drawing.Size(193, 31);
            this.txtListTotal.TabIndex = 3;
            // 
            // txtDetailTotal
            // 
            this.txtDetailTotal.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDetailTotal.Location = new System.Drawing.Point(1200, 561);
            this.txtDetailTotal.Name = "txtDetailTotal";
            this.txtDetailTotal.Size = new System.Drawing.Size(193, 31);
            this.txtDetailTotal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(438, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "총 매출액";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1099, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "총 매출액";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(100, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "고객사";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(76, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "매출 일자";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(168, 105);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(124, 30);
            this.dtpFrom.TabIndex = 9;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(332, 105);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(124, 30);
            this.dtpTo.TabIndex = 10;
            // 
            // cboPeriod
            // 
            this.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Location = new System.Drawing.Point(261, 145);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(194, 28);
            this.cboPeriod.TabIndex = 11;
            this.cboPeriod.SelectedIndexChanged += new System.EventHandler(this.cboPeriod_SelectedIndexChanged);
            // 
            // txtClientS
            // 
            this.txtClientS.Location = new System.Drawing.Point(168, 69);
            this.txtClientS.Name = "txtClientS";
            this.txtClientS.Size = new System.Drawing.Size(287, 27);
            this.txtClientS.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(298, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "~";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(261, 181);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 35);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(361, 180);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 35);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClientS);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.cboPeriod);
            this.groupBox1.Location = new System.Drawing.Point(831, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 277);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세 검색";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(66, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 38);
            this.label7.TabIndex = 9;
            this.label7.Text = "매출 완료 현황";
            // 
            // frmSalesStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 811);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmSalesStatus";
            this.Text = "매출현황";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSalesStatus_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSoldList;
        private System.Windows.Forms.DataGridView dgvSoldDetail;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetailTotal;
        private System.Windows.Forms.TextBox txtListTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClientS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label7;
    }
}