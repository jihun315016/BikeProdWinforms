
namespace BikeProd
{
    partial class frmLogin
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
            this.lblFPwd = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmpNo = new BikeProd.ccTextBox();
            this.txtPwd = new BikeProd.ccTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.txtEmpNo);
            this.panel1.Controls.Add(this.lblFPwd);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Size = new System.Drawing.Size(224, 174);
            // 
            // lblFPwd
            // 
            this.lblFPwd.AutoSize = true;
            this.lblFPwd.Location = new System.Drawing.Point(18, 142);
            this.lblFPwd.Name = "lblFPwd";
            this.lblFPwd.Size = new System.Drawing.Size(83, 15);
            this.lblFPwd.TabIndex = 4;
            this.lblFPwd.TabStop = true;
            this.lblFPwd.Text = "비밀번호 찾기";
            this.lblFPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFPwd_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(107, 134);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(99, 30);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.isNumeric = false;
            this.txtEmpNo.isRequired = false;
            this.txtEmpNo.Location = new System.Drawing.Point(16, 32);
            this.txtEmpNo.MaxLength = 20;
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.PlaceHolder = null;
            this.txtEmpNo.Size = new System.Drawing.Size(190, 23);
            this.txtEmpNo.TabIndex = 1;
            this.txtEmpNo.Tag = "";
            // 
            // txtPwd
            // 
            this.txtPwd.isNumeric = false;
            this.txtPwd.isRequired = false;
            this.txtPwd.Location = new System.Drawing.Point(16, 88);
            this.txtPwd.MaxLength = 20;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PlaceHolder = null;
            this.txtPwd.Size = new System.Drawing.Size(190, 23);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "사번";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "비밀번호";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 204);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmLogin";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lblFPwd;
        private System.Windows.Forms.Button btnLogin;
        private ccTextBox txtPwd;
        private ccTextBox txtEmpNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}