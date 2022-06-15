namespace BikeProd.Forms
{
    partial class frmPerformance
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboTeam = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            this.splitContainer1.Panel1.Controls.Add(this.dgvTo);
            this.splitContainer1.Panel1.Controls.Add(this.cboTeam);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFrom);
            this.splitContainer1.Panel1.Controls.Add(this.cboState);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 598);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.SplitterWidth = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Size = new System.Drawing.Size(1099, 443);
            this.panel1.Controls.SetChildIndex(this.dgvList, 0);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 27;
            this.dgvList.Size = new System.Drawing.Size(1099, 443);
            this.dgvList.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(579, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 26);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(516, 38);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(58, 26);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // cboTeam
            // 
            this.cboTeam.FormattingEnabled = true;
            this.cboTeam.Location = new System.Drawing.Point(404, 40);
            this.cboTeam.Margin = new System.Windows.Forms.Padding(2);
            this.cboTeam.Name = "cboTeam";
            this.cboTeam.Size = new System.Drawing.Size(95, 23);
            this.cboTeam.TabIndex = 9;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(298, 40);
            this.cboState.Margin = new System.Windows.Forms.Padding(2);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(95, 23);
            this.cboState.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "~";
            // 
            // dgvTo
            // 
            this.dgvTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dgvTo.Location = new System.Drawing.Point(156, 41);
            this.dgvTo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTo.Name = "dgvTo";
            this.dgvTo.Size = new System.Drawing.Size(107, 23);
            this.dgvTo.TabIndex = 6;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(27, 41);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(107, 23);
            this.dtpFrom.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(1039, 477);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 598);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "frmPerformance";
            this.Text = "frmPerformance";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dgvTo;
        private System.Windows.Forms.ComboBox cboTeam;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
    }
}