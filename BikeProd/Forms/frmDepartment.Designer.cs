namespace BikeProd
{
    partial class frmDepartment
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
            this.dgvDept = new System.Windows.Forms.DataGridView();
            this.dgvTeam = new System.Windows.Forms.DataGridView();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.cboTeamselect = new System.Windows.Forms.ComboBox();
            this.txtEmpSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeptDelete = new System.Windows.Forms.Button();
            this.btnDeptInsert = new System.Windows.Forms.Button();
            this.txtDeptAuth = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeamName = new BikeProd.ccTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.btnTeamDelete = new System.Windows.Forms.Button();
            this.btnTeamInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1164, 601);
            this.splitContainer1.SplitterDistance = 66;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.None;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = false;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer2.Panel1.Controls.Add(this.txtEmpSearch);
            this.splitContainer2.Panel1.Controls.Add(this.cboTeamselect);
            this.splitContainer2.Panel1.Controls.Add(this.lblDept);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.dgvDetail);
            this.splitContainer2.Panel1.Controls.Add(this.dgvTeam);
            this.splitContainer2.Panel1.Controls.Add(this.dgvDept);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1164, 531);
            this.splitContainer2.SplitterDistance = 785;
            // 
            // dgvDept
            // 
            this.dgvDept.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDept.Location = new System.Drawing.Point(9, 32);
            this.dgvDept.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDept.Name = "dgvDept";
            this.dgvDept.RowHeadersWidth = 51;
            this.dgvDept.RowTemplate.Height = 27;
            this.dgvDept.Size = new System.Drawing.Size(351, 196);
            this.dgvDept.TabIndex = 2;
            this.dgvDept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDept_CellClick);
            // 
            // dgvTeam
            // 
            this.dgvTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeam.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam.Location = new System.Drawing.Point(413, 32);
            this.dgvTeam.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.RowHeadersWidth = 51;
            this.dgvTeam.RowTemplate.Height = 27;
            this.dgvTeam.Size = new System.Drawing.Size(351, 196);
            this.dgvTeam.TabIndex = 3;
            // 
            // dgvDetail
            // 
            this.dgvDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(9, 274);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 27;
            this.dgvDetail.Size = new System.Drawing.Size(755, 248);
            this.dgvDetail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "부서";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(414, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "팀";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDept.Location = new System.Drawing.Point(10, 248);
            this.lblDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(0, 20);
            this.lblDept.TabIndex = 7;
            // 
            // cboTeamselect
            // 
            this.cboTeamselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeamselect.FormattingEnabled = true;
            this.cboTeamselect.Location = new System.Drawing.Point(88, 247);
            this.cboTeamselect.Margin = new System.Windows.Forms.Padding(2);
            this.cboTeamselect.Name = "cboTeamselect";
            this.cboTeamselect.Size = new System.Drawing.Size(95, 23);
            this.cboTeamselect.TabIndex = 8;
            // 
            // txtEmpSearch
            // 
            this.txtEmpSearch.Location = new System.Drawing.Point(187, 247);
            this.txtEmpSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpSearch.Name = "txtEmpSearch";
            this.txtEmpSearch.Size = new System.Drawing.Size(102, 23);
            this.txtEmpSearch.TabIndex = 9;
            this.txtEmpSearch.Click += new System.EventHandler(this.txtEmpSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(293, 246);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 24);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeptDelete);
            this.groupBox1.Controls.Add(this.btnDeptInsert);
            this.groupBox1.Controls.Add(this.txtDeptAuth);
            this.groupBox1.Controls.Add(this.txtDeptName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 245);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "부서";
            // 
            // btnDeptDelete
            // 
            this.btnDeptDelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeptDelete.Location = new System.Drawing.Point(218, 168);
            this.btnDeptDelete.Name = "btnDeptDelete";
            this.btnDeptDelete.Size = new System.Drawing.Size(72, 28);
            this.btnDeptDelete.TabIndex = 6;
            this.btnDeptDelete.Text = "삭제";
            this.btnDeptDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeptInsert
            // 
            this.btnDeptInsert.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeptInsert.Location = new System.Drawing.Point(140, 168);
            this.btnDeptInsert.Name = "btnDeptInsert";
            this.btnDeptInsert.Size = new System.Drawing.Size(72, 28);
            this.btnDeptInsert.TabIndex = 4;
            this.btnDeptInsert.Text = "등록";
            this.btnDeptInsert.UseVisualStyleBackColor = true;
            this.btnDeptInsert.Click += new System.EventHandler(this.btnDeptInsert_Click);
            // 
            // txtDeptAuth
            // 
            this.txtDeptAuth.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDeptAuth.Location = new System.Drawing.Point(131, 103);
            this.txtDeptAuth.Multiline = true;
            this.txtDeptAuth.Name = "txtDeptAuth";
            this.txtDeptAuth.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeptAuth.Size = new System.Drawing.Size(159, 59);
            this.txtDeptAuth.TabIndex = 3;
            this.txtDeptAuth.TextChanged += new System.EventHandler(this.txtDeptAuth_TextChanged);
            // 
            // txtDeptName
            // 
            this.txtDeptName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDeptName.Location = new System.Drawing.Point(131, 65);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(159, 25);
            this.txtDeptName.TabIndex = 2;
            this.txtDeptName.TextChanged += new System.EventHandler(this.txtDeptName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(59, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "권한";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(59, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "부서명";
            // 
            // txtTeamName
            // 
            this.txtTeamName.isNumeric = false;
            this.txtTeamName.isRequired = false;
            this.txtTeamName.Location = new System.Drawing.Point(131, 97);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.PlaceHolder = "예) 생산 1팀";
            this.txtTeamName.Size = new System.Drawing.Size(159, 27);
            this.txtTeamName.TabIndex = 7;
            this.txtTeamName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTeamName_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTeamName);
            this.groupBox2.Controls.Add(this.cboDept);
            this.groupBox2.Controls.Add(this.btnTeamDelete);
            this.groupBox2.Controls.Add(this.btnTeamInsert);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(18, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 245);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "팀";
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(131, 62);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(159, 25);
            this.cboDept.TabIndex = 14;
            // 
            // btnTeamDelete
            // 
            this.btnTeamDelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTeamDelete.Location = new System.Drawing.Point(218, 156);
            this.btnTeamDelete.Name = "btnTeamDelete";
            this.btnTeamDelete.Size = new System.Drawing.Size(72, 28);
            this.btnTeamDelete.TabIndex = 13;
            this.btnTeamDelete.Text = "삭제";
            this.btnTeamDelete.UseVisualStyleBackColor = true;
            // 
            // btnTeamInsert
            // 
            this.btnTeamInsert.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTeamInsert.Location = new System.Drawing.Point(140, 156);
            this.btnTeamInsert.Name = "btnTeamInsert";
            this.btnTeamInsert.Size = new System.Drawing.Size(72, 28);
            this.btnTeamInsert.TabIndex = 11;
            this.btnTeamInsert.Text = "등록";
            this.btnTeamInsert.UseVisualStyleBackColor = true;
            this.btnTeamInsert.Click += new System.EventHandler(this.btnTeamInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(59, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "부서명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(59, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "팀명";
            // 
            // frmDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1164, 601);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDepartment";
            this.Text = "frmDeptMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDeptMain_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEmpSearch;
        private System.Windows.Forms.ComboBox cboTeamselect;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridView dgvTeam;
        private System.Windows.Forms.DataGridView dgvDept;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Button btnTeamDelete;
        private System.Windows.Forms.Button btnTeamInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeptDelete;
        private System.Windows.Forms.Button btnDeptInsert;
        private System.Windows.Forms.TextBox txtDeptAuth;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ccTextBox txtTeamName;
    }
}