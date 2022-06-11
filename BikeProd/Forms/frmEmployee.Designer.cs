
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.rdOut = new System.Windows.Forms.RadioButton();
            this.rdWorking = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.ccTextBox1 = new BikeProd.ccTextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnWorkOut = new System.Windows.Forms.Button();
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
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ccTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnReturn);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.cboDept);
            this.splitContainer1.Panel1.Controls.Add(this.rdWorking);
            this.splitContainer1.Panel1.Controls.Add(this.rdOut);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnWorkOut);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Size = new System.Drawing.Size(1304, 673);
            this.splitContainer1.SplitterDistance = 76;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Location = new System.Drawing.Point(36, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1159, 372);
            this.panel1.Controls.SetChildIndex(this.dgvList, 0);
            // 
            // cboDept
            // 
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(15, 45);
            this.cboDept.Margin = new System.Windows.Forms.Padding(4);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(154, 28);
            this.cboDept.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(363, 44);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(467, 44);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(154, 31);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "초기화/새로고침";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdOut
            // 
            this.rdOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdOut.AutoSize = true;
            this.rdOut.Location = new System.Drawing.Point(748, 51);
            this.rdOut.Margin = new System.Windows.Forms.Padding(4);
            this.rdOut.Name = "rdOut";
            this.rdOut.Size = new System.Drawing.Size(60, 24);
            this.rdOut.TabIndex = 5;
            this.rdOut.Text = "퇴사";
            this.rdOut.UseVisualStyleBackColor = true;
            this.rdOut.CheckedChanged += new System.EventHandler(this.rdOut_CheckedChanged);
            // 
            // rdWorking
            // 
            this.rdWorking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdWorking.AutoSize = true;
            this.rdWorking.Location = new System.Drawing.Point(663, 51);
            this.rdWorking.Margin = new System.Windows.Forms.Padding(4);
            this.rdWorking.Name = "rdWorking";
            this.rdWorking.Size = new System.Drawing.Size(60, 24);
            this.rdWorking.TabIndex = 5;
            this.rdWorking.Text = "재직";
            this.rdWorking.UseVisualStyleBackColor = true;
            this.rdWorking.CheckedChanged += new System.EventHandler(this.rdWorking_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1119, 448);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 53);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ccTextBox1
            // 
            this.ccTextBox1.isNumeric = false;
            this.ccTextBox1.isRequired = false;
            this.ccTextBox1.Location = new System.Drawing.Point(179, 45);
            this.ccTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ccTextBox1.Name = "ccTextBox1";
            this.ccTextBox1.PlaceHolder = "";
            this.ccTextBox1.Size = new System.Drawing.Size(175, 27);
            this.ccTextBox1.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(1159, 372);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // btnWorkOut
            // 
            this.btnWorkOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkOut.Location = new System.Drawing.Point(1003, 448);
            this.btnWorkOut.Name = "btnWorkOut";
            this.btnWorkOut.Size = new System.Drawing.Size(108, 53);
            this.btnWorkOut.TabIndex = 3;
            this.btnWorkOut.Text = "퇴사";
            this.btnWorkOut.UseVisualStyleBackColor = true;
            this.btnWorkOut.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 673);
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "frmEmployee";
            this.Text = "사원조회";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmployee_Load);
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
        private ccTextBox ccTextBox1;
        private System.Windows.Forms.RadioButton rdWorking;
        private System.Windows.Forms.RadioButton rdOut;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnWorkOut;
    }
}