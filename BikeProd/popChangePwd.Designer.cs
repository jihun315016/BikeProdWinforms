namespace BikeProd
{
    partial class popChangePwd
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
            this.txtPwd = new BikeProd.ccTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChkPwd = new BikeProd.ccTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnCommit);
            this.panel1.Controls.Add(this.txtChkPwd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Size = new System.Drawing.Size(182, 145);
            // 
            // txtPwd
            // 
            this.txtPwd.isNumeric = false;
            this.txtPwd.isRequired = true;
            this.txtPwd.Location = new System.Drawing.Point(6, 28);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.PlaceHolder = null;
            this.txtPwd.Size = new System.Drawing.Size(169, 23);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.Tag = "비밀번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "비밀번호";
            // 
            // txtChkPwd
            // 
            this.txtChkPwd.isNumeric = false;
            this.txtChkPwd.isRequired = true;
            this.txtChkPwd.Location = new System.Drawing.Point(6, 81);
            this.txtChkPwd.Name = "txtChkPwd";
            this.txtChkPwd.PasswordChar = '*';
            this.txtChkPwd.PlaceHolder = null;
            this.txtChkPwd.Size = new System.Drawing.Size(169, 23);
            this.txtChkPwd.TabIndex = 5;
            this.txtChkPwd.Tag = "비밀번호 확인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "비밀번호 확인";
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(40, 110);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(65, 23);
            this.btnCommit.TabIndex = 6;
            this.btnCommit.Text = "확인";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // popChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 169);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "popChangePwd";
            this.Text = "popChangePwd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private ccTextBox txtChkPwd;
        private System.Windows.Forms.Label label2;
        private ccTextBox txtPwd;
        private System.Windows.Forms.Label label1;
    }
}