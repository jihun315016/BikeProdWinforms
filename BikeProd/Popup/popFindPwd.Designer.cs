
namespace BikeProd
{
    partial class popFindPwd
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.txtName = new BikeProd.ccTextBox();
            this.txtEmpNo = new BikeProd.ccTextBox();
            this.txtDomain = new BikeProd.ccTextBox();
            this.cboDomain = new System.Windows.Forms.ComboBox();
            this.txtEmail = new BikeProd.ccTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMessage2);
            this.panel1.Controls.Add(this.lblMessage1);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtDomain);
            this.panel1.Controls.Add(this.cboDomain);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmpNo);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSendEmail);
            this.panel1.Size = new System.Drawing.Size(447, 214);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "사번";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "이메일";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(355, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(264, 182);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(75, 23);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "메일 전송";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // txtName
            // 
            this.txtName.isNumeric = false;
            this.txtName.isRequired = false;
            this.txtName.Location = new System.Drawing.Point(60, 21);
            this.txtName.Name = "txtName";
            this.txtName.PlaceHolder = null;
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 0;
            this.txtName.Tag = "이름";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.isNumeric = false;
            this.txtEmpNo.isRequired = false;
            this.txtEmpNo.Location = new System.Drawing.Point(60, 61);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.PlaceHolder = null;
            this.txtEmpNo.Size = new System.Drawing.Size(100, 23);
            this.txtEmpNo.TabIndex = 1;
            this.txtEmpNo.Tag = "사번";
            // 
            // txtDomain
            // 
            this.txtDomain.isNumeric = false;
            this.txtDomain.isRequired = false;
            this.txtDomain.Location = new System.Drawing.Point(182, 101);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.PlaceHolder = null;
            this.txtDomain.Size = new System.Drawing.Size(121, 23);
            this.txtDomain.TabIndex = 6;
            this.txtDomain.Tag = "메일주소";
            this.txtDomain.Leave += new System.EventHandler(this.txtDomain_Leave);
            // 
            // cboDomain
            // 
            this.cboDomain.FormattingEnabled = true;
            this.cboDomain.Location = new System.Drawing.Point(309, 101);
            this.cboDomain.Name = "cboDomain";
            this.cboDomain.Size = new System.Drawing.Size(121, 23);
            this.cboDomain.TabIndex = 3;
            this.cboDomain.SelectedIndexChanged += new System.EventHandler(this.cboDomain_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.isNumeric = false;
            this.txtEmail.isRequired = false;
            this.txtEmail.Location = new System.Drawing.Point(60, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceHolder = null;
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Tag = "이메일";
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "@";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 15);
            this.lblEmail.TabIndex = 44;
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Location = new System.Drawing.Point(57, 133);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(0, 15);
            this.lblMessage1.TabIndex = 45;
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Location = new System.Drawing.Point(57, 159);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(0, 15);
            this.lblMessage2.TabIndex = 46;
            // 
            // popFindPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 240);
            this.Name = "popFindPwd";
            this.Text = "popFindPwd";
            this.Load += new System.EventHandler(this.popFindPwd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ccTextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSendEmail;
        private ccTextBox txtEmpNo;
        private ccTextBox txtDomain;
        private System.Windows.Forms.ComboBox cboDomain;
        private ccTextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Label lblMessage2;
    }
}