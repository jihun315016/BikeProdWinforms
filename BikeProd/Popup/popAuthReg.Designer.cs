namespace BikeProd
{
    partial class popAuthReg
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstDept = new System.Windows.Forms.ListBox();
            this.lstSelect = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(381, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(381, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstDept
            // 
            this.lstDept.FormattingEnabled = true;
            this.lstDept.ItemHeight = 12;
            this.lstDept.Location = new System.Drawing.Point(12, 32);
            this.lstDept.Name = "lstDept";
            this.lstDept.Size = new System.Drawing.Size(156, 184);
            this.lstDept.TabIndex = 8;
            this.lstDept.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstDept_MouseClick);
            // 
            // lstSelect
            // 
            this.lstSelect.FormattingEnabled = true;
            this.lstSelect.ItemHeight = 12;
            this.lstSelect.Location = new System.Drawing.Point(444, 34);
            this.lstSelect.Name = "lstSelect";
            this.lstSelect.Size = new System.Drawing.Size(156, 184);
            this.lstSelect.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(464, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 31);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "< 부서 리스트 >";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(244, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "< 전체 권한 >";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(469, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "< 부여 권한 >";
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReg.Location = new System.Drawing.Point(322, 224);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(136, 31);
            this.btnReg.TabIndex = 11;
            this.btnReg.Text = "등록";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(168, 236);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 12);
            this.lblPath.TabIndex = 16;
            // 
            // lstMenu
            // 
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 12;
            this.lstMenu.Location = new System.Drawing.Point(219, 34);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(156, 184);
            this.lstMenu.TabIndex = 17;
            // 
            // popAuthReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 272);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDept);
            this.Controls.Add(this.lstSelect);
            this.Name = "popAuthReg";
            this.Text = "권한등록창";
            this.Load += new System.EventHandler(this.frmAuthRegPopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstDept;
        private System.Windows.Forms.ListBox lstSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ListBox lstMenu;
    }
}