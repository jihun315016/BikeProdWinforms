
namespace BikeProd
{
    partial class popSaveOrder
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
            this.dtpdeliverDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.chkNull = new System.Windows.Forms.CheckBox();
            this.txtClientManager = new BikeProd.ccTextBox();
            this.txtBusinessID = new BikeProd.ccTextBox();
            this.txtManager = new BikeProd.ccTextBox();
            this.txtClient = new BikeProd.ccTextBox();
            this.txtOrderName = new BikeProd.ccTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddr = new BikeProd.ccTextBox();
            this.btnAddr = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numQty);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cboName);
            this.panel1.Controls.Add(this.cboModel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtAddr);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Controls.Add(this.btnAddr);
            this.panel1.Controls.Add(this.dtpdeliverDate);
            this.panel1.Controls.Add(this.dtpOrderDate);
            this.panel1.Controls.Add(this.chkNull);
            this.panel1.Controls.Add(this.txtClientManager);
            this.panel1.Controls.Add(this.txtBusinessID);
            this.panel1.Controls.Add(this.txtManager);
            this.panel1.Controls.Add(this.txtClient);
            this.panel1.Controls.Add(this.txtOrderName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(836, 728);
            // 
            // dtpdeliverDate
            // 
            this.dtpdeliverDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdeliverDate.Location = new System.Drawing.Point(530, 160);
            this.dtpdeliverDate.Name = "dtpdeliverDate";
            this.dtpdeliverDate.Size = new System.Drawing.Size(154, 27);
            this.dtpdeliverDate.TabIndex = 25;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(210, 163);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(154, 27);
            this.dtpOrderDate.TabIndex = 24;
            // 
            // chkNull
            // 
            this.chkNull.AutoSize = true;
            this.chkNull.Location = new System.Drawing.Point(693, 163);
            this.chkNull.Name = "chkNull";
            this.chkNull.Size = new System.Drawing.Size(61, 24);
            this.chkNull.TabIndex = 26;
            this.chkNull.Text = "미정";
            this.chkNull.UseVisualStyleBackColor = true;
            this.chkNull.CheckedChanged += new System.EventHandler(this.chkNull_CheckedChanged);
            // 
            // txtClientManager
            // 
            this.txtClientManager.isNumeric = false;
            this.txtClientManager.isRequired = false;
            this.txtClientManager.Location = new System.Drawing.Point(210, 113);
            this.txtClientManager.Name = "txtClientManager";
            this.txtClientManager.PlaceHolder = null;
            this.txtClientManager.Size = new System.Drawing.Size(154, 27);
            this.txtClientManager.TabIndex = 23;
            this.txtClientManager.Tag = "고객담당자";
            // 
            // txtBusinessID
            // 
            this.txtBusinessID.isNumeric = false;
            this.txtBusinessID.isRequired = false;
            this.txtBusinessID.Location = new System.Drawing.Point(530, 69);
            this.txtBusinessID.Name = "txtBusinessID";
            this.txtBusinessID.PlaceHolder = null;
            this.txtBusinessID.Size = new System.Drawing.Size(154, 27);
            this.txtBusinessID.TabIndex = 34;
            this.txtBusinessID.Tag = "고객ID";
            // 
            // txtManager
            // 
            this.txtManager.isNumeric = false;
            this.txtManager.isRequired = false;
            this.txtManager.Location = new System.Drawing.Point(530, 113);
            this.txtManager.Name = "txtManager";
            this.txtManager.PlaceHolder = null;
            this.txtManager.Size = new System.Drawing.Size(154, 27);
            this.txtManager.TabIndex = 22;
            this.txtManager.Tag = "주문담당자";
            // 
            // txtClient
            // 
            this.txtClient.isNumeric = false;
            this.txtClient.isRequired = false;
            this.txtClient.Location = new System.Drawing.Point(210, 69);
            this.txtClient.Name = "txtClient";
            this.txtClient.PlaceHolder = null;
            this.txtClient.Size = new System.Drawing.Size(154, 27);
            this.txtClient.TabIndex = 21;
            this.txtClient.Tag = "고객";
            this.txtClient.Enter += new System.EventHandler(this.txtClient_Enter);
            // 
            // txtOrderName
            // 
            this.txtOrderName.isNumeric = false;
            this.txtOrderName.isRequired = false;
            this.txtOrderName.Location = new System.Drawing.Point(210, 24);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.PlaceHolder = null;
            this.txtOrderName.Size = new System.Drawing.Size(475, 27);
            this.txtOrderName.TabIndex = 20;
            this.txtOrderName.Tag = "주문서명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "출고 예정일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "주문 담당자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "주문 일자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "고객 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "고객 담당자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "고객";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "주문서명";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(648, 671);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 671);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "주소";
            // 
            // txtAddr
            // 
            this.txtAddr.isNumeric = false;
            this.txtAddr.isRequired = false;
            this.txtAddr.Location = new System.Drawing.Point(210, 213);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.PlaceHolder = null;
            this.txtAddr.Size = new System.Drawing.Size(397, 70);
            this.txtAddr.TabIndex = 43;
            this.txtAddr.Tag = "주소";
            // 
            // btnAddr
            // 
            this.btnAddr.Location = new System.Drawing.Point(616, 213);
            this.btnAddr.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddr.Name = "btnAddr";
            this.btnAddr.Size = new System.Drawing.Size(141, 31);
            this.btnAddr.TabIndex = 39;
            this.btnAddr.Text = "우편번호 검색";
            this.btnAddr.UseVisualStyleBackColor = true;
            this.btnAddr.Click += new System.EventHandler(this.btnAddr_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(510, 313);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(51, 27);
            this.numQty.TabIndex = 46;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(685, 309);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 31);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(600, 309);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 31);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboName
            // 
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(265, 312);
            this.cboName.Margin = new System.Windows.Forms.Padding(4);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(238, 28);
            this.cboName.TabIndex = 45;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.cboName_SelectedIndexChanged);
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(140, 313);
            this.cboModel.Margin = new System.Windows.Forms.Padding(4);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(116, 28);
            this.cboModel.TabIndex = 44;
            this.cboModel.SelectedIndexChanged += new System.EventHandler(this.cboModel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "제품";
            // 
            // dgvList
            // 
            this.dgvList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(100, 368);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(540, 256);
            this.dgvList.TabIndex = 42;
            // 
            // popSaveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 793);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "popSaveOrder";
            this.Text = "제품";
            this.Load += new System.EventHandler(this.popSaveOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpdeliverDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.CheckBox chkNull;
        private ccTextBox txtClientManager;
        private ccTextBox txtBusinessID;
        private ccTextBox txtManager;
        private ccTextBox txtClient;
        private ccTextBox txtOrderName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ccTextBox txtAddr;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvList;
    }
}