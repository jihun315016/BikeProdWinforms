
namespace BikeProd
{
    partial class frmEmployee
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
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rdOut = new System.Windows.Forms.RadioButton();
            this.rdWorking = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmpName = new BikeProd.ccTextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnResign = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtEmpName);
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.cboDept);
            this.splitContainer1.Panel1.Controls.Add(this.rdWorking);
            this.splitContainer1.Panel1.Controls.Add(this.rdOut);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnResign);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Size = new System.Drawing.Size(1014, 505);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.SplitterWidth = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Location = new System.Drawing.Point(28, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(816, 272);
            this.panel1.Controls.SetChildIndex(this.dgvList, 0);
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(12, 34);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(121, 23);
            this.cboDept.TabIndex = 0;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(282, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(363, 33);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "초기화/새로고침";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rdOut
            // 
            this.rdOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdOut.AutoSize = true;
            this.rdOut.Location = new System.Drawing.Point(867, 33);
            this.rdOut.Name = "rdOut";
            this.rdOut.Size = new System.Drawing.Size(49, 19);
            this.rdOut.TabIndex = 5;
            this.rdOut.Text = "퇴사";
            this.rdOut.UseVisualStyleBackColor = true;
            this.rdOut.CheckedChanged += new System.EventHandler(this.rdOut_CheckedChanged);
            // 
            // rdWorking
            // 
            this.rdWorking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdWorking.AutoSize = true;
            this.rdWorking.Location = new System.Drawing.Point(801, 33);
            this.rdWorking.Name = "rdWorking";
            this.rdWorking.Size = new System.Drawing.Size(49, 19);
            this.rdWorking.TabIndex = 5;
            this.rdWorking.Text = "재직";
            this.rdWorking.UseVisualStyleBackColor = true;
            this.rdWorking.CheckedChanged += new System.EventHandler(this.rdWorking_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(896, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmpName
            // 
            this.txtEmpName.isNumeric = false;
            this.txtEmpName.isRequired = false;
            this.txtEmpName.Location = new System.Drawing.Point(139, 34);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.PlaceHolder = "";
            this.txtEmpName.Size = new System.Drawing.Size(137, 23);
            this.txtEmpName.TabIndex = 1;
            this.txtEmpName.Tag = "사원이름";
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(816, 272);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // btnResign
            // 
            this.btnResign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResign.Location = new System.Drawing.Point(805, 395);
            this.btnResign.Margin = new System.Windows.Forms.Padding(2);
            this.btnResign.Name = "btnResign";
            this.btnResign.Size = new System.Drawing.Size(84, 40);
            this.btnResign.TabIndex = 3;
            this.btnResign.Text = "퇴사";
            this.btnResign.UseVisualStyleBackColor = true;
            this.btnResign.Click += new System.EventHandler(this.btnResign_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 505);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmEmployee";
            this.Text = "사원조회";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmEmployee_KeyPress);
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

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboDept;
        private ccTextBox txtEmpName;
        private System.Windows.Forms.RadioButton rdWorking;
        private System.Windows.Forms.RadioButton rdOut;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnResign;
    }
}