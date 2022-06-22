
namespace BikeProd
{
    partial class frmSalesStatus
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(1146, 608);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.SplitterWidth = 3;
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
            this.dgvSoldList.Location = new System.Drawing.Point(2, 2);
            this.dgvSoldList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSoldList.Name = "dgvSoldList";
            this.dgvSoldList.RowHeadersWidth = 51;
            this.dgvSoldList.RowTemplate.Height = 27;
            this.dgvSoldList.Size = new System.Drawing.Size(567, 182);
            this.dgvSoldList.TabIndex = 1;
            this.dgvSoldList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoldList_CellClick);
            // 
            // dgvSoldDetail
            // 
            this.dgvSoldDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSoldDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoldDetail.Location = new System.Drawing.Point(0, 234);
            this.dgvSoldDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSoldDetail.Name = "dgvSoldDetail";
            this.dgvSoldDetail.RowHeadersWidth = 51;
            this.dgvSoldDetail.RowTemplate.Height = 27;
            this.dgvSoldDetail.Size = new System.Drawing.Size(1083, 182);
            this.dgvSoldDetail.TabIndex = 2;
            // 
            // txtListTotal
            // 
            this.txtListTotal.Enabled = false;
            this.txtListTotal.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtListTotal.Location = new System.Drawing.Point(419, 189);
            this.txtListTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtListTotal.Name = "txtListTotal";
            this.txtListTotal.Size = new System.Drawing.Size(151, 27);
            this.txtListTotal.TabIndex = 3;
            // 
            // txtDetailTotal
            // 
            this.txtDetailTotal.Enabled = false;
            this.txtDetailTotal.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDetailTotal.Location = new System.Drawing.Point(933, 421);
            this.txtDetailTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetailTotal.Name = "txtDetailTotal";
            this.txtDetailTotal.Size = new System.Drawing.Size(151, 27);
            this.txtDetailTotal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(341, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "총 매출액";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(855, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "총 매출액";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(78, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "고객사";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(59, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "매출 일자";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(131, 79);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(97, 26);
            this.dtpFrom.TabIndex = 9;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(258, 79);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(97, 26);
            this.dtpTo.TabIndex = 10;
            // 
            // cboPeriod
            // 
            this.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Location = new System.Drawing.Point(203, 109);
            this.cboPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(152, 23);
            this.cboPeriod.TabIndex = 11;
            // 
            // txtClientS
            // 
            this.txtClientS.Location = new System.Drawing.Point(131, 52);
            this.txtClientS.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientS.Name = "txtClientS";
            this.txtClientS.Size = new System.Drawing.Size(224, 23);
            this.txtClientS.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(232, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "~";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(203, 136);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 26);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(281, 135);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 26);
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
            this.groupBox1.Location = new System.Drawing.Point(646, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(437, 208);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세 검색";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(51, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "매출 완료 현황";
            // 
            // frmSalesStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 608);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmSalesStatus";
            this.Text = "매출현황";
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