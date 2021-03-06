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
            this.lblDept = new System.Windows.Forms.Label();
            this.cboTeamselect = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeptAuth = new BikeProd.ccTextBox();
            this.btnMenuInsert = new System.Windows.Forms.Button();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNewTeam = new BikeProd.ccTextBox();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.btnTeamDelete = new System.Windows.Forms.Button();
            this.btnTeamInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNewDept = new BikeProd.ccTextBox();
            this.btnDeptDelete = new System.Windows.Forms.Button();
            this.btnDeptInsert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1323, 580);
            this.splitContainer2.SplitterDistance = 804;
            // 
            // dgvDept
            // 
            this.dgvDept.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDept.Location = new System.Drawing.Point(3, 19);
            this.dgvDept.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDept.Name = "dgvDept";
            this.dgvDept.RowHeadersWidth = 51;
            this.dgvDept.RowTemplate.Height = 27;
            this.dgvDept.Size = new System.Drawing.Size(390, 262);
            this.dgvDept.TabIndex = 2;
            this.dgvDept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDept_CellClick);
            // 
            // dgvTeam
            // 
            this.dgvTeam.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeam.Location = new System.Drawing.Point(3, 19);
            this.dgvTeam.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.RowHeadersWidth = 51;
            this.dgvTeam.RowTemplate.Height = 27;
            this.dgvTeam.Size = new System.Drawing.Size(390, 262);
            this.dgvTeam.TabIndex = 3;
            this.dgvTeam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeam_CellClick);
            // 
            // dgvDetail
            // 
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(2, 29);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 27;
            this.dgvDetail.Size = new System.Drawing.Size(793, 248);
            this.dgvDetail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(148, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "부서";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDept.Location = new System.Drawing.Point(5, 3);
            this.lblDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(0, 20);
            this.lblDept.TabIndex = 7;
            // 
            // cboTeamselect
            // 
            this.cboTeamselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeamselect.FormattingEnabled = true;
            this.cboTeamselect.Location = new System.Drawing.Point(81, 2);
            this.cboTeamselect.Margin = new System.Windows.Forms.Padding(2);
            this.cboTeamselect.Name = "cboTeamselect";
            this.cboTeamselect.Size = new System.Drawing.Size(95, 23);
            this.cboTeamselect.TabIndex = 8;
            this.cboTeamselect.Visible = false;
            this.cboTeamselect.SelectedIndexChanged += new System.EventHandler(this.cboTeamselect_SelectedIndexChanged);
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
            this.groupBox1.Size = new System.Drawing.Size(384, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "부서별 접근 메뉴";
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
            this.txtDeptAuth.Size = new System.Drawing.Size(225, 95);
            this.txtDeptAuth.TabIndex = 5;
            // 
            // btnMenuInsert
            // 
            this.btnMenuInsert.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenuInsert.Location = new System.Drawing.Point(206, 163);
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
            this.txtDeptName.Size = new System.Drawing.Size(225, 25);
            this.txtDeptName.TabIndex = 2;
            this.txtDeptName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDeptName_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(59, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "권한";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(59, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
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
            this.groupBox2.Size = new System.Drawing.Size(384, 146);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "팀 등록";
            // 
            // txtNewTeam
            // 
            this.txtNewTeam.isNumeric = false;
            this.txtNewTeam.isRequired = false;
            this.txtNewTeam.Location = new System.Drawing.Point(131, 57);
            this.txtNewTeam.Name = "txtNewTeam";
            this.txtNewTeam.PlaceHolder = "예) 생산 1팀";
            this.txtNewTeam.Size = new System.Drawing.Size(225, 27);
            this.txtNewTeam.TabIndex = 7;
            this.txtNewTeam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNewTeam_MouseClick);
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(131, 26);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(225, 25);
            this.cboDept.TabIndex = 14;
            // 
            // btnTeamDelete
            // 
            this.btnTeamDelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTeamDelete.Location = new System.Drawing.Point(284, 90);
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
            this.btnTeamInsert.Location = new System.Drawing.Point(206, 90);
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
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "부서명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(59, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
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
            this.groupBox3.Size = new System.Drawing.Size(384, 146);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "부서 등록";
            // 
            // txtNewDept
            // 
            this.txtNewDept.isNumeric = false;
            this.txtNewDept.isRequired = false;
            this.txtNewDept.Location = new System.Drawing.Point(131, 57);
            this.txtNewDept.Name = "txtNewDept";
            this.txtNewDept.PlaceHolder = "예) 생산부서";
            this.txtNewDept.Size = new System.Drawing.Size(225, 27);
            this.txtNewDept.TabIndex = 7;
            // 
            // btnDeptDelete
            // 
            this.btnDeptDelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeptDelete.Location = new System.Drawing.Point(284, 90);
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
            this.btnDeptInsert.Location = new System.Drawing.Point(206, 90);
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
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "부서명";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 580);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvDept);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(396, 284);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "부서";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.dgvDetail);
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.cboTeamselect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 284);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvTeam);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(405, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 284);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "팀";
            // 
            // frmDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1323, 633);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDepartment";
            this.Text = "8";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmDepartment_Activated);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboTeamselect;
        private System.Windows.Forms.Label lblDept;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}