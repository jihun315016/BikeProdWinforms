
namespace BikeProd
{
    partial class popSaveClient
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
            this.txtClientName = new BikeProd.ccTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtBusinessNo = new BikeProd.ccTextBox();
            this.txtDomain = new BikeProd.ccTextBox();
            this.cboDomain = new System.Windows.Forms.ComboBox();
            this.txtEmail = new BikeProd.ccTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnZipCodeSearch = new System.Windows.Forms.Button();
            this.txtAddr2 = new BikeProd.ccTextBox();
            this.txtAddr1 = new BikeProd.ccTextBox();
            this.txtAddrCode = new BikeProd.ccTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMPhone = new BikeProd.ccTextBox();
            this.txtManager = new BikeProd.ccTextBox();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddrDetail = new BikeProd.ccTextBox();
            this.btnBusinessNoCheck = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBusinessNoCheck);
            this.panel1.Controls.Add(this.txtAddrDetail);
            this.panel1.Controls.Add(this.lblMessage2);
            this.panel1.Controls.Add(this.lblMessage1);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtManager);
            this.panel1.Controls.Add(this.txtMPhone);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAddr2);
            this.panel1.Controls.Add(this.btnZipCodeSearch);
            this.panel1.Controls.Add(this.txtAddr1);
            this.panel1.Controls.Add(this.txtAddrCode);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtDomain);
            this.panel1.Controls.Add(this.cboDomain);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBusinessNo);
            this.panel1.Controls.Add(this.cboType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtClientName);
            this.panel1.Location = new System.Drawing.Point(13, 18);
            this.panel1.Size = new System.Drawing.Size(486, 432);
            // 
            // txtClientName
            // 
            this.txtClientName.isNumeric = false;
            this.txtClientName.isRequired = false;
            this.txtClientName.Location = new System.Drawing.Point(103, 32);
            this.txtClientName.MaxLength = 30;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.PlaceHolder = null;
            this.txtClientName.Size = new System.Drawing.Size(161, 23);
            this.txtClientName.TabIndex = 0;
            this.txtClientName.Tag = "거래처명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "거래처명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "분류";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "사업자번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "담당자 연락처";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "이메일";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(103, 102);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(80, 23);
            this.cboType.TabIndex = 2;
            // 
            // txtBusinessNo
            // 
            this.txtBusinessNo.isNumeric = false;
            this.txtBusinessNo.isRequired = false;
            this.txtBusinessNo.Location = new System.Drawing.Point(103, 66);
            this.txtBusinessNo.MaxLength = 9;
            this.txtBusinessNo.Name = "txtBusinessNo";
            this.txtBusinessNo.PlaceHolder = null;
            this.txtBusinessNo.Size = new System.Drawing.Size(161, 23);
            this.txtBusinessNo.TabIndex = 1;
            this.txtBusinessNo.Tag = "사업자번호";
            this.txtBusinessNo.Leave += new System.EventHandler(this.txtBusinessNo_Leave);
            // 
            // txtDomain
            // 
            this.txtDomain.isNumeric = false;
            this.txtDomain.isRequired = false;
            this.txtDomain.Location = new System.Drawing.Point(225, 325);
            this.txtDomain.MaxLength = 20;
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.PlaceHolder = null;
            this.txtDomain.Size = new System.Drawing.Size(121, 23);
            this.txtDomain.TabIndex = 46;
            this.txtDomain.Tag = "도메인";
            this.txtDomain.Leave += new System.EventHandler(this.txtDomain_Leave);
            // 
            // cboDomain
            // 
            this.cboDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDomain.FormattingEnabled = true;
            this.cboDomain.Location = new System.Drawing.Point(352, 325);
            this.cboDomain.Name = "cboDomain";
            this.cboDomain.Size = new System.Drawing.Size(121, 23);
            this.cboDomain.TabIndex = 8;
            this.cboDomain.SelectedIndexChanged += new System.EventHandler(this.cboDomain_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.isNumeric = false;
            this.txtEmail.isRequired = false;
            this.txtEmail.Location = new System.Drawing.Point(103, 325);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceHolder = null;
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Tag = "이메일";
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "@";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(398, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnZipCodeSearch
            // 
            this.btnZipCodeSearch.Location = new System.Drawing.Point(209, 148);
            this.btnZipCodeSearch.Name = "btnZipCodeSearch";
            this.btnZipCodeSearch.Size = new System.Drawing.Size(123, 23);
            this.btnZipCodeSearch.TabIndex = 3;
            this.btnZipCodeSearch.Text = "우편번호 검색";
            this.btnZipCodeSearch.UseVisualStyleBackColor = true;
            this.btnZipCodeSearch.Click += new System.EventHandler(this.btnZipCodeSearch_Click);
            // 
            // txtAddr2
            // 
            this.txtAddr2.isNumeric = false;
            this.txtAddr2.isRequired = false;
            this.txtAddr2.Location = new System.Drawing.Point(103, 207);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.PlaceHolder = null;
            this.txtAddr2.Size = new System.Drawing.Size(243, 23);
            this.txtAddr2.TabIndex = 54;
            // 
            // txtAddr1
            // 
            this.txtAddr1.isNumeric = false;
            this.txtAddr1.isRequired = false;
            this.txtAddr1.Location = new System.Drawing.Point(103, 178);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.PlaceHolder = null;
            this.txtAddr1.Size = new System.Drawing.Size(370, 23);
            this.txtAddr1.TabIndex = 52;
            this.txtAddr1.Tag = "주소";
            // 
            // txtAddrCode
            // 
            this.txtAddrCode.isNumeric = false;
            this.txtAddrCode.isRequired = false;
            this.txtAddrCode.Location = new System.Drawing.Point(103, 149);
            this.txtAddrCode.Name = "txtAddrCode";
            this.txtAddrCode.PlaceHolder = null;
            this.txtAddrCode.Size = new System.Drawing.Size(100, 23);
            this.txtAddrCode.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 55;
            this.label8.Text = "담당자";
            // 
            // txtMPhone
            // 
            this.txtMPhone.isNumeric = false;
            this.txtMPhone.isRequired = false;
            this.txtMPhone.Location = new System.Drawing.Point(103, 287);
            this.txtMPhone.MaxLength = 11;
            this.txtMPhone.Name = "txtMPhone";
            this.txtMPhone.PlaceHolder = null;
            this.txtMPhone.Size = new System.Drawing.Size(161, 23);
            this.txtMPhone.TabIndex = 5;
            this.txtMPhone.Tag = "담당자 연락처";
            this.txtMPhone.Leave += new System.EventHandler(this.txtMPhone_Leave);
            // 
            // txtManager
            // 
            this.txtManager.isNumeric = false;
            this.txtManager.isRequired = false;
            this.txtManager.Location = new System.Drawing.Point(102, 250);
            this.txtManager.MaxLength = 20;
            this.txtManager.Name = "txtManager";
            this.txtManager.PlaceHolder = null;
            this.txtManager.Size = new System.Drawing.Size(101, 23);
            this.txtManager.TabIndex = 4;
            this.txtManager.Tag = "담당자";
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Location = new System.Drawing.Point(108, 380);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(0, 15);
            this.lblMessage2.TabIndex = 59;
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Location = new System.Drawing.Point(108, 354);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(0, 15);
            this.lblMessage1.TabIndex = 58;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(108, 354);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 15);
            this.lblEmail.TabIndex = 57;
            // 
            // txtAddrDetail
            // 
            this.txtAddrDetail.isNumeric = false;
            this.txtAddrDetail.isRequired = false;
            this.txtAddrDetail.Location = new System.Drawing.Point(352, 207);
            this.txtAddrDetail.MaxLength = 30;
            this.txtAddrDetail.Name = "txtAddrDetail";
            this.txtAddrDetail.PlaceHolder = null;
            this.txtAddrDetail.Size = new System.Drawing.Size(121, 23);
            this.txtAddrDetail.TabIndex = 60;
            // 
            // btnBusinessNoCheck
            // 
            this.btnBusinessNoCheck.Location = new System.Drawing.Point(271, 66);
            this.btnBusinessNoCheck.Name = "btnBusinessNoCheck";
            this.btnBusinessNoCheck.Size = new System.Drawing.Size(75, 23);
            this.btnBusinessNoCheck.TabIndex = 62;
            this.btnBusinessNoCheck.Text = "중복확인";
            this.btnBusinessNoCheck.UseVisualStyleBackColor = true;
            this.btnBusinessNoCheck.Click += new System.EventHandler(this.btnBusinessNoCheck_Click);
            // 
            // popSaveClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 457);
            this.Name = "popSaveClient";
            this.Text = "거래처 등록";
            this.Load += new System.EventHandler(this.popSaveClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ccTextBox txtClientName;
        private ccTextBox txtBusinessNo;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private ccTextBox txtDomain;
        private System.Windows.Forms.ComboBox cboDomain;
        private ccTextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnZipCodeSearch;
        private ccTextBox txtAddr2;
        private ccTextBox txtAddr1;
        private ccTextBox txtAddrCode;
        private System.Windows.Forms.Label label8;
        private ccTextBox txtManager;
        private ccTextBox txtMPhone;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Label lblEmail;
        private ccTextBox txtAddrDetail;
        private System.Windows.Forms.Button btnBusinessNoCheck;
    }
}