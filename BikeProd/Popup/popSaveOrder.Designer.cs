
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
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddr = new BikeProd.ccTextBox();
            this.btnAddr = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddr);
            this.panel1.Controls.Add(this.numQty);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Controls.Add(this.btnAddr);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cboName);
            this.panel1.Controls.Add(this.cboModel);
            this.panel1.Controls.Add(this.cboCate);
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
            this.panel1.Size = new System.Drawing.Size(650, 546);
            // 
            // dtpdeliverDate
            // 
            this.dtpdeliverDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdeliverDate.Location = new System.Drawing.Point(412, 120);
            this.dtpdeliverDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpdeliverDate.Name = "dtpdeliverDate";
            this.dtpdeliverDate.Size = new System.Drawing.Size(121, 23);
            this.dtpdeliverDate.TabIndex = 25;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(163, 122);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(121, 23);
            this.dtpOrderDate.TabIndex = 24;
            // 
            // chkNull
            // 
            this.chkNull.AutoSize = true;
            this.chkNull.Location = new System.Drawing.Point(539, 122);
            this.chkNull.Margin = new System.Windows.Forms.Padding(2);
            this.chkNull.Name = "chkNull";
            this.chkNull.Size = new System.Drawing.Size(50, 19);
            this.chkNull.TabIndex = 26;
            this.chkNull.Text = "미정";
            this.chkNull.UseVisualStyleBackColor = true;
            // 
            // txtClientManager
            // 
            this.txtClientManager.isNumeric = false;
            this.txtClientManager.isRequired = false;
            this.txtClientManager.Location = new System.Drawing.Point(163, 85);
            this.txtClientManager.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientManager.Name = "txtClientManager";
            this.txtClientManager.PlaceHolder = null;
            this.txtClientManager.Size = new System.Drawing.Size(121, 23);
            this.txtClientManager.TabIndex = 23;
            this.txtClientManager.Tag = "고객담당자";
            // 
            // txtBusinessID
            // 
            this.txtBusinessID.isNumeric = false;
            this.txtBusinessID.isRequired = false;
            this.txtBusinessID.Location = new System.Drawing.Point(412, 52);
            this.txtBusinessID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusinessID.Name = "txtBusinessID";
            this.txtBusinessID.PlaceHolder = null;
            this.txtBusinessID.Size = new System.Drawing.Size(121, 23);
            this.txtBusinessID.TabIndex = 34;
            this.txtBusinessID.Tag = "고객ID";
            // 
            // txtManager
            // 
            this.txtManager.isNumeric = false;
            this.txtManager.isRequired = false;
            this.txtManager.Location = new System.Drawing.Point(412, 85);
            this.txtManager.Margin = new System.Windows.Forms.Padding(2);
            this.txtManager.Name = "txtManager";
            this.txtManager.PlaceHolder = null;
            this.txtManager.Size = new System.Drawing.Size(121, 23);
            this.txtManager.TabIndex = 22;
            this.txtManager.Tag = "주문담당자";
            // 
            // txtClient
            // 
            this.txtClient.isNumeric = false;
            this.txtClient.isRequired = false;
            this.txtClient.Location = new System.Drawing.Point(163, 52);
            this.txtClient.Margin = new System.Windows.Forms.Padding(2);
            this.txtClient.Name = "txtClient";
            this.txtClient.PlaceHolder = null;
            this.txtClient.Size = new System.Drawing.Size(121, 23);
            this.txtClient.TabIndex = 21;
            this.txtClient.Tag = "고객";
            this.txtClient.Enter += new System.EventHandler(this.txtClient_Enter);
            // 
            // txtOrderName
            // 
            this.txtOrderName.isNumeric = false;
            this.txtOrderName.isRequired = false;
            this.txtOrderName.Location = new System.Drawing.Point(163, 18);
            this.txtOrderName.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.PlaceHolder = null;
            this.txtOrderName.Size = new System.Drawing.Size(370, 23);
            this.txtOrderName.TabIndex = 20;
            this.txtOrderName.Tag = "주문서명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "출고 예정일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "주문 담당자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "주문 일자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "고객 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "고객 담당자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "고객";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "주문서명";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(433, 208);
            this.numQty.Margin = new System.Windows.Forms.Padding(2);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(40, 23);
            this.numQty.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(504, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(423, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvList
            // 
            this.dgvList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(78, 249);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(420, 229);
            this.dgvList.TabIndex = 42;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(491, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cboName
            // 
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(242, 207);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(186, 23);
            this.cboName.TabIndex = 37;
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(145, 208);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(91, 23);
            this.cboModel.TabIndex = 36;
            // 
            // cboCate
            // 
            this.cboCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(77, 208);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(62, 23);
            this.cboCate.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "주소";
            // 
            // txtAddr
            // 
            this.txtAddr.isNumeric = false;
            this.txtAddr.isRequired = false;
            this.txtAddr.Location = new System.Drawing.Point(163, 160);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.PlaceHolder = null;
            this.txtAddr.Size = new System.Drawing.Size(310, 23);
            this.txtAddr.TabIndex = 43;
            this.txtAddr.Tag = "주소";
            // 
            // btnAddr
            // 
            this.btnAddr.Location = new System.Drawing.Point(479, 160);
            this.btnAddr.Name = "btnAddr";
            this.btnAddr.Size = new System.Drawing.Size(110, 23);
            this.btnAddr.TabIndex = 39;
            this.btnAddr.Text = "우편번호 검색";
            this.btnAddr.UseVisualStyleBackColor = true;
            // 
            // popSaveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 595);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "popSaveOrder";
            this.Text = "popSaveOrder";
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
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnAddr;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.Label label8;
    }
}