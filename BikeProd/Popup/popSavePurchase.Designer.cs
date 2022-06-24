namespace BikeProd
{
    partial class popSavePur
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
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPurName = new BikeProd.ccTextBox();
            this.txtBusiness = new BikeProd.ccTextBox();
            this.txtManager = new BikeProd.ccTextBox();
            this.txtBusinessID = new BikeProd.ccTextBox();
            this.txtSubManager = new BikeProd.ccTextBox();
            this.chkNull = new System.Windows.Forms.CheckBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.dtpPurDate = new System.Windows.Forms.DateTimePicker();
            this.dtpAliveDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtpAliveDate);
            this.panel1.Controls.Add(this.dtpPurDate);
            this.panel1.Controls.Add(this.chkNull);
            this.panel1.Controls.Add(this.txtSubManager);
            this.panel1.Controls.Add(this.txtBusinessID);
            this.panel1.Controls.Add(this.txtManager);
            this.panel1.Controls.Add(this.txtBusiness);
            this.panel1.Controls.Add(this.txtPurName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(84, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(706, 199);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "거래처";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "발주서명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "거래처 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "거래처 담당자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "발주 담당자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "발주 일자";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "입고 예정일";
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(167, 256);
            this.cboModel.Margin = new System.Windows.Forms.Padding(4);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(116, 28);
            this.cboModel.TabIndex = 7;
            this.cboModel.SelectedIndexChanged += new System.EventHandler(this.cboModel_SelectedIndexChanged);
            // 
            // cboName
            // 
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(292, 255);
            this.cboName.Margin = new System.Windows.Forms.Padding(4);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(238, 28);
            this.cboName.TabIndex = 8;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.cboName_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(627, 252);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 31);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvList
            // 
            this.dgvList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(84, 307);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(706, 305);
            this.dgvList.TabIndex = 29;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(618, 653);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(723, 653);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPurName
            // 
            this.txtPurName.isNumeric = false;
            this.txtPurName.isRequired = false;
            this.txtPurName.Location = new System.Drawing.Point(144, 17);
            this.txtPurName.Name = "txtPurName";
            this.txtPurName.PlaceHolder = null;
            this.txtPurName.Size = new System.Drawing.Size(475, 27);
            this.txtPurName.TabIndex = 0;
            this.txtPurName.Tag = "발주서명";
            // 
            // txtBusiness
            // 
            this.txtBusiness.isNumeric = false;
            this.txtBusiness.isRequired = false;
            this.txtBusiness.Location = new System.Drawing.Point(144, 61);
            this.txtBusiness.Name = "txtBusiness";
            this.txtBusiness.PlaceHolder = null;
            this.txtBusiness.Size = new System.Drawing.Size(154, 27);
            this.txtBusiness.TabIndex = 1;
            this.txtBusiness.Tag = "거래처명";
            this.txtBusiness.TextChanged += new System.EventHandler(this.txtBusiness_TextChanged);
            this.txtBusiness.Enter += new System.EventHandler(this.txtBusiness_Enter);
            // 
            // txtManager
            // 
            this.txtManager.isNumeric = false;
            this.txtManager.isRequired = false;
            this.txtManager.Location = new System.Drawing.Point(464, 107);
            this.txtManager.Name = "txtManager";
            this.txtManager.PlaceHolder = null;
            this.txtManager.Size = new System.Drawing.Size(154, 27);
            this.txtManager.TabIndex = 4;
            this.txtManager.Tag = "거래처담당자";
            // 
            // txtBusinessID
            // 
            this.txtBusinessID.isNumeric = false;
            this.txtBusinessID.isRequired = false;
            this.txtBusinessID.Location = new System.Drawing.Point(464, 61);
            this.txtBusinessID.Name = "txtBusinessID";
            this.txtBusinessID.PlaceHolder = null;
            this.txtBusinessID.Size = new System.Drawing.Size(154, 27);
            this.txtBusinessID.TabIndex = 2;
            this.txtBusinessID.Tag = "거래처ID";
            // 
            // txtSubManager
            // 
            this.txtSubManager.isNumeric = false;
            this.txtSubManager.isRequired = false;
            this.txtSubManager.Location = new System.Drawing.Point(144, 107);
            this.txtSubManager.Name = "txtSubManager";
            this.txtSubManager.PlaceHolder = null;
            this.txtSubManager.Size = new System.Drawing.Size(154, 27);
            this.txtSubManager.TabIndex = 3;
            this.txtSubManager.Tag = "발주담당자";
            // 
            // chkNull
            // 
            this.chkNull.AutoSize = true;
            this.chkNull.Location = new System.Drawing.Point(627, 156);
            this.chkNull.Name = "chkNull";
            this.chkNull.Size = new System.Drawing.Size(61, 24);
            this.chkNull.TabIndex = 7;
            this.chkNull.Text = "미정";
            this.chkNull.UseVisualStyleBackColor = true;
            this.chkNull.CheckedChanged += new System.EventHandler(this.chkNull_CheckedChanged);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(537, 256);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(51, 27);
            this.numQty.TabIndex = 9;
            // 
            // dtpPurDate
            // 
            this.dtpPurDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurDate.Location = new System.Drawing.Point(144, 156);
            this.dtpPurDate.Name = "dtpPurDate";
            this.dtpPurDate.Size = new System.Drawing.Size(154, 27);
            this.dtpPurDate.TabIndex = 5;
            // 
            // dtpAliveDate
            // 
            this.dtpAliveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAliveDate.Location = new System.Drawing.Point(464, 153);
            this.dtpAliveDate.Name = "dtpAliveDate";
            this.dtpAliveDate.Size = new System.Drawing.Size(154, 27);
            this.dtpAliveDate.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(712, 252);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 31);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "부품";
            // 
            // popSavePur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 700);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.cboModel);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "popSavePur";
            this.Text = "발주등록";
            this.Load += new System.EventHandler(this.popSavePur_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.popSavePur_KeyPress);
            this.Controls.SetChildIndex(this.DescriptLabel2, 0);
            this.Controls.SetChildIndex(this.DescriptLabel1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.cboModel, 0);
            this.Controls.SetChildIndex(this.cboName, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.dgvList, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.numQty, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkNull;
        private ccTextBox txtSubManager;
        private ccTextBox txtBusinessID;
        private ccTextBox txtManager;
        private ccTextBox txtBusiness;
        private ccTextBox txtPurName;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.DateTimePicker dtpAliveDate;
        private System.Windows.Forms.DateTimePicker dtpPurDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label8;
    }
}