
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblFPwd = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ccTextBox1 = new BikeProd.ccTextBox();
            this.ccTextBox2 = new BikeProd.ccTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ccTextBox2);
            this.panel1.Controls.Add(this.ccTextBox1);
            this.panel1.Controls.Add(this.lblFPwd);
            this.panel1.Controls.Add(this.btnLogin);
            // 
            // lblFPwd
            // 
            this.lblFPwd.AutoSize = true;
            this.lblFPwd.Location = new System.Drawing.Point(158, 238);
            this.lblFPwd.Name = "lblFPwd";
            this.lblFPwd.Size = new System.Drawing.Size(83, 15);
            this.lblFPwd.TabIndex = 4;
            this.lblFPwd.TabStop = true;
            this.lblFPwd.Text = "비밀번호 찾기";
            this.lblFPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFPwd_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(247, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(99, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ccTextBox1
            // 
            this.ccTextBox1.isNumeric = false;
            this.ccTextBox1.isRequired = false;
            this.ccTextBox1.Location = new System.Drawing.Point(156, 140);
            this.ccTextBox1.Name = "ccTextBox1";
            this.ccTextBox1.PlaceHolder = null;
            this.ccTextBox1.Size = new System.Drawing.Size(190, 23);
            this.ccTextBox1.TabIndex = 1;
            // 
            // ccTextBox2
            // 
            this.ccTextBox2.isNumeric = false;
            this.ccTextBox2.isRequired = false;
            this.ccTextBox2.Location = new System.Drawing.Point(156, 184);
            this.ccTextBox2.Name = "ccTextBox2";
            this.ccTextBox2.PlaceHolder = null;
            this.ccTextBox2.Size = new System.Drawing.Size(190, 23);
            this.ccTextBox2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lblFPwd;
        private System.Windows.Forms.Button btnLogin;
        private ccTextBox ccTextBox2;
        private ccTextBox ccTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}