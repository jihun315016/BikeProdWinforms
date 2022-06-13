namespace BikeProd.Popup
{
    partial class popProduction
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.txtProdName = new BikeProd.ccTextBox();
            this.txtProdCode = new BikeProd.ccTextBox();
            this.txtModel = new BikeProd.ccTextBox();
            this.txtLeadTime = new BikeProd.ccTextBox();
            this.txtQty = new BikeProd.ccTextBox();
            this.txtClient = new BikeProd.ccTextBox();
            this.txtBusniessNo = new BikeProd.ccTextBox();
            this.txtFromDate = new BikeProd.ccTextBox();
            this.txtToDate = new BikeProd.ccTextBox();
            this.cboTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboTeam);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.txtToDate);
            this.panel1.Controls.Add(this.txtFromDate);
            this.panel1.Controls.Add(this.txtBusniessNo);
            this.panel1.Controls.Add(this.txtClient);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.txtLeadTime);
            this.panel1.Controls.Add(this.txtProdCode);
            this.panel1.Controls.Add(this.txtProdName);
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Location = new System.Drawing.Point(26, 24);
            this.panel1.Size = new System.Drawing.Size(522, 727);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(13, 16);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 27;
            this.dgvList.Size = new System.Drawing.Size(494, 250);
            this.dgvList.TabIndex = 0;
            // 
            // txtProdName
            // 
            this.txtProdName.isNumeric = false;
            this.txtProdName.isRequired = false;
            this.txtProdName.Location = new System.Drawing.Point(54, 285);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.PlaceHolder = null;
            this.txtProdName.Size = new System.Drawing.Size(100, 27);
            this.txtProdName.TabIndex = 1;
            // 
            // txtProdCode
            // 
            this.txtProdCode.isNumeric = false;
            this.txtProdCode.isRequired = false;
            this.txtProdCode.Location = new System.Drawing.Point(212, 285);
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.PlaceHolder = null;
            this.txtProdCode.Size = new System.Drawing.Size(100, 27);
            this.txtProdCode.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.isNumeric = false;
            this.txtModel.isRequired = false;
            this.txtModel.Location = new System.Drawing.Point(372, 285);
            this.txtModel.Name = "txtModel";
            this.txtModel.PlaceHolder = null;
            this.txtModel.Size = new System.Drawing.Size(100, 27);
            this.txtModel.TabIndex = 1;
            // 
            // txtLeadTime
            // 
            this.txtLeadTime.isNumeric = false;
            this.txtLeadTime.isRequired = false;
            this.txtLeadTime.Location = new System.Drawing.Point(212, 332);
            this.txtLeadTime.Name = "txtLeadTime";
            this.txtLeadTime.PlaceHolder = null;
            this.txtLeadTime.Size = new System.Drawing.Size(100, 27);
            this.txtLeadTime.TabIndex = 1;
            // 
            // txtQty
            // 
            this.txtQty.isNumeric = false;
            this.txtQty.isRequired = false;
            this.txtQty.Location = new System.Drawing.Point(372, 332);
            this.txtQty.Name = "txtQty";
            this.txtQty.PlaceHolder = null;
            this.txtQty.Size = new System.Drawing.Size(100, 27);
            this.txtQty.TabIndex = 1;
            // 
            // txtClient
            // 
            this.txtClient.isNumeric = false;
            this.txtClient.isRequired = false;
            this.txtClient.Location = new System.Drawing.Point(52, 403);
            this.txtClient.Name = "txtClient";
            this.txtClient.PlaceHolder = null;
            this.txtClient.Size = new System.Drawing.Size(100, 27);
            this.txtClient.TabIndex = 1;
            // 
            // txtBusniessNo
            // 
            this.txtBusniessNo.isNumeric = false;
            this.txtBusniessNo.isRequired = false;
            this.txtBusniessNo.Location = new System.Drawing.Point(212, 403);
            this.txtBusniessNo.Name = "txtBusniessNo";
            this.txtBusniessNo.PlaceHolder = null;
            this.txtBusniessNo.Size = new System.Drawing.Size(260, 27);
            this.txtBusniessNo.TabIndex = 1;
            // 
            // txtFromDate
            // 
            this.txtFromDate.isNumeric = false;
            this.txtFromDate.isRequired = false;
            this.txtFromDate.Location = new System.Drawing.Point(212, 449);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.PlaceHolder = null;
            this.txtFromDate.Size = new System.Drawing.Size(260, 27);
            this.txtFromDate.TabIndex = 1;
            // 
            // txtToDate
            // 
            this.txtToDate.isNumeric = false;
            this.txtToDate.isRequired = false;
            this.txtToDate.Location = new System.Drawing.Point(212, 498);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.PlaceHolder = null;
            this.txtToDate.Size = new System.Drawing.Size(260, 27);
            this.txtToDate.TabIndex = 1;
            // 
            // cboTeam
            // 
            this.cboTeam.FormattingEnabled = true;
            this.cboTeam.Location = new System.Drawing.Point(315, 550);
            this.cboTeam.Name = "cboTeam";
            this.cboTeam.Size = new System.Drawing.Size(157, 28);
            this.cboTeam.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "작업 지시일";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "납품 예정일";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 618);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = " 등록";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(397, 618);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lead TIme";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // popProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 787);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "popProduction";
            this.Text = "popProduction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTeam;
        private ccTextBox txtModel;
        private ccTextBox txtToDate;
        private ccTextBox txtFromDate;
        private ccTextBox txtBusniessNo;
        private ccTextBox txtClient;
        private ccTextBox txtQty;
        private ccTextBox txtLeadTime;
        private ccTextBox txtProdCode;
        private ccTextBox txtProdName;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label3;
    }
}