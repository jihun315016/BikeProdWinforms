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
            this.btnMenuInsert = new System.Windows.Forms.Button();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.btnTeamDelete = new System.Windows.Forms.Button();
            this.btnTeamInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeptDelete = new System.Windows.Forms.Button();
            this.btnDeptInsert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeptAuth = new BikeProd.ccTextBox();
            this.txtNewDept = new BikeProd.ccTextBox();
            this.txtNewTeam = new BikeProd.ccTextBox();
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
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = false;
            this.splitContainer1.Size = new System.Drawing.Size(1323, 633);
            this.splitContainer1.SplitterDistance = 52;
            // 
            // splitContainer2
            // 
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1323, 580);
            this.splitContainer2.SplitterDistance = 878;
            // 
            // dgvDept
            // 
            this.dgvDept.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvDept.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDept.Location = new System.Drawing.Point(94, 32);
            this.dgvDept.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDept.Name = "dgvDept";
            this.dgvDept.RowHeadersWidth = 51;
            this.dgvDept.RowTemplate.Height = 27;
            this.dgvDept.Size = new System.Drawing.Size(351, 218);
            this.dgvDept.TabIndex = 2;
            this.dgvDept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDept_CellClick);
            // 
            // dgvTeam
            // 
            this.dgvTeam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvTeam.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam.Location = new System.Drawing.Point(498, 32);
            this.dgvTeam.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.RowHeadersWidth = 51;
            this.dgvTeam.RowTemplate.Height = 27;
            this.dgvTeam.Size = new System.Drawing.Size(351, 218);
            this.dgvTeam.TabIndex = 3;
            // 
            // dgvDetail
            // 
            this.dgvDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(94, 302);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 27;
            this.dgvDetail.Size = new System.Drawing.Size(755, 248);
            this.dgvDetail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(95, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "부서";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(500, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "팀";
            // 
            // lblDept
            // 
            this.lblDept.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDept.Location = new System.Drawing.Point(97, 276);
            this.lblDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(0, 25);
            this.lblDept.TabIndex = 7;
            // 
            // cboTeamselect
            // 
            this.cboTeamselect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTeamselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeamselect.FormattingEnabled = true;
            this.cboTeamselect.Location = new System.Drawing.Point(173, 275);
            this.cboTeamselect.Margin = new System.Windows.Forms.Padding(2);
            this.cboTeamselect.Name = "cboTeamselect";
            this.cboTeamselect.Size = new System.Drawing.Size(95, 28);
            this.cboTeamselect.TabIndex = 8;
            this.cboTeamselect.SelectedIndexChanged += new System.EventHandler(this.cboTeamselect_SelectedIndexChanged);
            this.cboTeamselect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboTeamselect_MouseClick);
            // 
            // txtEmpSearch
            // 
            this.txtEmpSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmpSearch.Location = new System.Drawing.Point(272, 275);
            this.txtEmpSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpSearch.Name = "txtEmpSearch";
            this.txtEmpSearch.Size = new System.Drawing.Size(102, 27);
            this.txtEmpSearch.TabIndex = 9;
            this.txtEmpSearch.Click += new System.EventHandler(this.txtEmpSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(378, 274);
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
            this.groupBox1.Controls.Add(this.txtDeptAuth);
            this.groupBox1.Controls.Add(this.btnMenuInsert);
            this.groupBox1.Controls.Add(this.txtDeptName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(25, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "부서별 접근 메뉴";
            // 
            // btnMenuInsert
            // 
            this.btnMenuInsert.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenuInsert.Location = new System.Drawing.Point(140, 159);
            this.btnMenuInsert.Name = "btnMenuInsert";
            this.btnMenuInsert.Size = new System.Drawing.Size(150, 28);
            this.btnMenuInsert.TabIndex = 4;
            this.btnMenuInsert.Text = "등록 및 수정";
            this.btnMenuInsert.UseVisualStyleBackColor = true;
            this.btnMenuInsert.Click += new System.EventHandler(this.btnMenuInsert_Click);
            // 
            // txtDeptName
            // 
            this.txtDeptName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDeptName.Location = new System.Drawing.Point(131, 27);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(159, 29);
            this.txtDeptName.TabIndex = 2;
            this.txtDeptName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDeptName_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(59, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "권한";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(59, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "부서명";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNewTeam);
            this.groupBox2.Controls.Add(this.cboDept);
            this.groupBox2.Controls.Add(this.btnTeamDelete);
            this.groupBox2.Controls.Add(this.btnTeamInsert);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(25, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 146);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "팀 등록";
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(131, 26);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(159, 29);
            this.cboDept.TabIndex = 14;
            // 
            // btnTeamDelete
            // 
            this.btnTeamDelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTeamDelete.Location = new System.Drawing.Point(218, 90);
            this.btnTeamDelete.Name = "btnTeamDelete";
            this.btnTeamDelete.Size = new System.Drawing.Size(72, 28);
            this.btnTeamDelete.TabIndex = 13;
            this.btnTeamDelete.Text = "삭제";
            this.btnTeamDelete.UseVisualStyleBackColor = true;
            this.btnTeamDelete.Click += new System.EventHandler(this.btnTeamDelete_Click);
            // 
            // btnTeamInsert
            // 
            this.btnTeamInsert.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTeamInsert.Location = new System.Drawing.Point(140, 90);
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
            this.label7.Location = new System.Drawing.Point(59, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "부서명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(59, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "팀명";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNewDept);
            this.groupBox3.Controls.Add(this.btnDeptDelete);
            this.groupBox3.Controls.Add(this.btnDeptInsert);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(25, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 146);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "부서 등록";
            // 
            // btnDeptDelete
            // 
            this.btnDeptDelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeptDelete.Location = new System.Drawing.Point(218, 90);
            this.btnDeptDelete.Name = "btnDeptDelete";
            this.btnDeptDelete.Size = new System.Drawing.Size(72, 28);
            this.btnDeptDelete.TabIndex = 13;
            this.btnDeptDelete.Text = "삭제";
            this.btnDeptDelete.UseVisualStyleBackColor = true;
            this.btnDeptDelete.Click += new System.EventHandler(this.btnDeptDelete_Click);
            // 
            // btnDeptInsert
            // 
            this.btnDeptInsert.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeptInsert.Location = new System.Drawing.Point(140, 90);
            this.btnDeptInsert.Name = "btnDeptInsert";
            this.btnDeptInsert.Size = new System.Drawing.Size(72, 28);
            this.btnDeptInsert.TabIndex = 11;
            this.btnDeptInsert.Text = "등록";
            this.btnDeptInsert.UseVisualStyleBackColor = true;
            this.btnDeptInsert.Click += new System.EventHandler(this.btnDeptInsert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(59, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "부서명";
            // 
            // txtDeptAuth
            // 
            this.txtDeptAuth.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDeptAuth.isNumeric = false;
            this.txtDeptAuth.isRequired = false;
            this.txtDeptAuth.Location = new System.Drawing.Point(131, 62);
            this.txtDeptAuth.Multiline = true;
            this.txtDeptAuth.Name = "txtDeptAuth";
            this.txtDeptAuth.PlaceHolder = null;
            this.txtDeptAuth.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeptAuth.Size = new System.Drawing.Size(159, 95);
            this.txtDeptAuth.TabIndex = 5;
            // 
            // txtNewDept
            // 
            this.txtNewDept.isNumeric = false;
            this.txtNewDept.isRequired = false;
            this.txtNewDept.Location = new System.Drawing.Point(131, 57);
            this.txtNewDept.Name = "txtNewDept";
            this.txtNewDept.PlaceHolder = "예) 생산부서";
            this.txtNewDept.Size = new System.Drawing.Size(159, 32);
            this.txtNewDept.TabIndex = 7;
            // 
            // txtNewTeam
            // 
            this.txtNewTeam.isNumeric = false;
            this.txtNewTeam.isRequired = false;
            this.txtNewTeam.Location = new System.Drawing.Point(131, 57);
            this.txtNewTeam.Name = "txtNewTeam";
            this.txtNewTeam.PlaceHolder = "예) 생산 1팀";
            this.txtNewTeam.Size = new System.Drawing.Size(159, 32);
            this.txtNewTeam.TabIndex = 7;
            this.txtNewTeam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNewTeam_MouseClick);
            // 
            // frmDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1323, 633);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDepartment";
            this.Text = "8";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button btnMenuInsert;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ccTextBox txtNewTeam;
        private System.Windows.Forms.GroupBox groupBox3;
        private ccTextBox txtNewDept;
        private System.Windows.Forms.Button btnDeptDelete;
        private System.Windows.Forms.Button btnDeptInsert;
        private System.Windows.Forms.Label label8;
        private ccTextBox txtDeptAuth;
    }
}