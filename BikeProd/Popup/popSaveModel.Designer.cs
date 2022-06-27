namespace BikeProd
{
    partial class popSaveModel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SaveProduct = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLeadTime = new BikeProd.ccTextBox();
            this.btnProdCancel = new System.Windows.Forms.Button();
            this.btnSaveProd = new System.Windows.Forms.Button();
            this.btnUploadProdImg = new System.Windows.Forms.Button();
            this.txtProdPrice = new BikeProd.ccTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProdCategory = new System.Windows.Forms.ComboBox();
            this.cboIsFinished = new System.Windows.Forms.ComboBox();
            this.txtProdName = new BikeProd.ccTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbProd = new System.Windows.Forms.PictureBox();
            this.SavePart = new System.Windows.Forms.TabPage();
            this.txtUnit = new BikeProd.ccTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPartPrice = new BikeProd.ccTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClient = new BikeProd.ccTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPartCancel = new System.Windows.Forms.Button();
            this.btnSavePart = new System.Windows.Forms.Button();
            this.btnUploadPart = new System.Windows.Forms.Button();
            this.txtSafeInv = new BikeProd.ccTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPartCategory = new System.Windows.Forms.ComboBox();
            this.txtPartName = new BikeProd.ccTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ptbPart = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SaveProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProd)).BeginInit();
            this.SavePart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Size = new System.Drawing.Size(408, 204);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SaveProduct);
            this.tabControl1.Controls.Add(this.SavePart);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 197);
            this.tabControl1.TabIndex = 0;
            // 
            // SaveProduct
            // 
            this.SaveProduct.Controls.Add(this.label8);
            this.SaveProduct.Controls.Add(this.txtLeadTime);
            this.SaveProduct.Controls.Add(this.btnProdCancel);
            this.SaveProduct.Controls.Add(this.btnSaveProd);
            this.SaveProduct.Controls.Add(this.btnUploadProdImg);
            this.SaveProduct.Controls.Add(this.txtProdPrice);
            this.SaveProduct.Controls.Add(this.label2);
            this.SaveProduct.Controls.Add(this.cboProdCategory);
            this.SaveProduct.Controls.Add(this.cboIsFinished);
            this.SaveProduct.Controls.Add(this.txtProdName);
            this.SaveProduct.Controls.Add(this.label1);
            this.SaveProduct.Controls.Add(this.ptbProd);
            this.SaveProduct.Location = new System.Drawing.Point(4, 24);
            this.SaveProduct.Name = "SaveProduct";
            this.SaveProduct.Padding = new System.Windows.Forms.Padding(3);
            this.SaveProduct.Size = new System.Drawing.Size(392, 169);
            this.SaveProduct.TabIndex = 0;
            this.SaveProduct.Text = "제품 등록";
            this.SaveProduct.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(140, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Lead Time";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLeadTime
            // 
            this.txtLeadTime.isNumeric = true;
            this.txtLeadTime.isRequired = true;
            this.txtLeadTime.Location = new System.Drawing.Point(210, 77);
            this.txtLeadTime.Name = "txtLeadTime";
            this.txtLeadTime.PlaceHolder = null;
            this.txtLeadTime.Size = new System.Drawing.Size(171, 23);
            this.txtLeadTime.TabIndex = 4;
            this.txtLeadTime.Tag = "제품 가격";
            // 
            // btnProdCancel
            // 
            this.btnProdCancel.Location = new System.Drawing.Point(328, 140);
            this.btnProdCancel.Name = "btnProdCancel";
            this.btnProdCancel.Size = new System.Drawing.Size(53, 23);
            this.btnProdCancel.TabIndex = 9;
            this.btnProdCancel.Text = "취소";
            this.btnProdCancel.UseVisualStyleBackColor = true;
            this.btnProdCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveProd
            // 
            this.btnSaveProd.Location = new System.Drawing.Point(269, 140);
            this.btnSaveProd.Name = "btnSaveProd";
            this.btnSaveProd.Size = new System.Drawing.Size(53, 23);
            this.btnSaveProd.TabIndex = 8;
            this.btnSaveProd.Text = "등록";
            this.btnSaveProd.UseVisualStyleBackColor = true;
            this.btnSaveProd.Click += new System.EventHandler(this.btnSaveProd_Click);
            // 
            // btnUploadProdImg
            // 
            this.btnUploadProdImg.Location = new System.Drawing.Point(81, 140);
            this.btnUploadProdImg.Name = "btnUploadProdImg";
            this.btnUploadProdImg.Size = new System.Drawing.Size(53, 23);
            this.btnUploadProdImg.TabIndex = 7;
            this.btnUploadProdImg.Text = "업로드";
            this.btnUploadProdImg.UseVisualStyleBackColor = true;
            this.btnUploadProdImg.Click += new System.EventHandler(this.btnUploadProdImg_Click);
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.isNumeric = true;
            this.txtProdPrice.isRequired = true;
            this.txtProdPrice.Location = new System.Drawing.Point(210, 111);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.PlaceHolder = null;
            this.txtProdPrice.Size = new System.Drawing.Size(171, 23);
            this.txtProdPrice.TabIndex = 5;
            this.txtProdPrice.Tag = "제품 가격";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(140, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "가격";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboProdCategory
            // 
            this.cboProdCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdCategory.FormattingEnabled = true;
            this.cboProdCategory.Location = new System.Drawing.Point(303, 40);
            this.cboProdCategory.Name = "cboProdCategory";
            this.cboProdCategory.Size = new System.Drawing.Size(78, 23);
            this.cboProdCategory.TabIndex = 3;
            // 
            // cboIsFinished
            // 
            this.cboIsFinished.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsFinished.FormattingEnabled = true;
            this.cboIsFinished.Location = new System.Drawing.Point(210, 40);
            this.cboIsFinished.Name = "cboIsFinished";
            this.cboIsFinished.Size = new System.Drawing.Size(78, 23);
            this.cboIsFinished.TabIndex = 2;
            // 
            // txtProdName
            // 
            this.txtProdName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProdName.isNumeric = false;
            this.txtProdName.isRequired = true;
            this.txtProdName.Location = new System.Drawing.Point(210, 6);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.PlaceHolder = null;
            this.txtProdName.Size = new System.Drawing.Size(171, 23);
            this.txtProdName.TabIndex = 1;
            this.txtProdName.Tag = "제품명";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(140, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "제품명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptbProd
            // 
            this.ptbProd.Location = new System.Drawing.Point(6, 6);
            this.ptbProd.Name = "ptbProd";
            this.ptbProd.Size = new System.Drawing.Size(128, 128);
            this.ptbProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProd.TabIndex = 0;
            this.ptbProd.TabStop = false;
            // 
            // SavePart
            // 
            this.SavePart.Controls.Add(this.txtUnit);
            this.SavePart.Controls.Add(this.label7);
            this.SavePart.Controls.Add(this.txtPartPrice);
            this.SavePart.Controls.Add(this.label6);
            this.SavePart.Controls.Add(this.txtClient);
            this.SavePart.Controls.Add(this.label5);
            this.SavePart.Controls.Add(this.btnPartCancel);
            this.SavePart.Controls.Add(this.btnSavePart);
            this.SavePart.Controls.Add(this.btnUploadPart);
            this.SavePart.Controls.Add(this.txtSafeInv);
            this.SavePart.Controls.Add(this.label3);
            this.SavePart.Controls.Add(this.cboPartCategory);
            this.SavePart.Controls.Add(this.txtPartName);
            this.SavePart.Controls.Add(this.label4);
            this.SavePart.Controls.Add(this.ptbPart);
            this.SavePart.Location = new System.Drawing.Point(4, 24);
            this.SavePart.Name = "SavePart";
            this.SavePart.Padding = new System.Windows.Forms.Padding(3);
            this.SavePart.Size = new System.Drawing.Size(392, 169);
            this.SavePart.TabIndex = 1;
            this.SavePart.Text = "부품 등록";
            this.SavePart.UseVisualStyleBackColor = true;
            // 
            // txtUnit
            // 
            this.txtUnit.isNumeric = true;
            this.txtUnit.isRequired = true;
            this.txtUnit.Location = new System.Drawing.Point(331, 111);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PlaceHolder = null;
            this.txtUnit.Size = new System.Drawing.Size(50, 23);
            this.txtUnit.TabIndex = 11;
            this.txtUnit.Tag = "발주 단위";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(264, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "발주 단위";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPartPrice
            // 
            this.txtPartPrice.isNumeric = true;
            this.txtPartPrice.isRequired = true;
            this.txtPartPrice.Location = new System.Drawing.Point(210, 40);
            this.txtPartPrice.Name = "txtPartPrice";
            this.txtPartPrice.PlaceHolder = null;
            this.txtPartPrice.Size = new System.Drawing.Size(90, 23);
            this.txtPartPrice.TabIndex = 7;
            this.txtPartPrice.Tag = "가격";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(140, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "가격";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClient
            // 
            this.txtClient.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtClient.isNumeric = false;
            this.txtClient.isRequired = true;
            this.txtClient.Location = new System.Drawing.Point(210, 77);
            this.txtClient.Name = "txtClient";
            this.txtClient.PlaceHolder = null;
            this.txtClient.Size = new System.Drawing.Size(171, 23);
            this.txtClient.TabIndex = 9;
            this.txtClient.TabStop = false;
            this.txtClient.Tag = "거래처";
            this.txtClient.Click += new System.EventHandler(this.txtClient_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(140, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "거래처";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPartCancel
            // 
            this.btnPartCancel.Location = new System.Drawing.Point(328, 140);
            this.btnPartCancel.Name = "btnPartCancel";
            this.btnPartCancel.Size = new System.Drawing.Size(53, 23);
            this.btnPartCancel.TabIndex = 19;
            this.btnPartCancel.Text = "취소";
            this.btnPartCancel.UseVisualStyleBackColor = true;
            this.btnPartCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSavePart
            // 
            this.btnSavePart.Location = new System.Drawing.Point(269, 140);
            this.btnSavePart.Name = "btnSavePart";
            this.btnSavePart.Size = new System.Drawing.Size(53, 23);
            this.btnSavePart.TabIndex = 18;
            this.btnSavePart.Text = "등록";
            this.btnSavePart.UseVisualStyleBackColor = true;
            this.btnSavePart.Click += new System.EventHandler(this.btnSavePart_Click);
            // 
            // btnUploadPart
            // 
            this.btnUploadPart.Location = new System.Drawing.Point(81, 140);
            this.btnUploadPart.Name = "btnUploadPart";
            this.btnUploadPart.Size = new System.Drawing.Size(53, 23);
            this.btnUploadPart.TabIndex = 17;
            this.btnUploadPart.Text = "업로드";
            this.btnUploadPart.UseVisualStyleBackColor = true;
            this.btnUploadPart.Click += new System.EventHandler(this.btnUploadPart_Click);
            // 
            // txtSafeInv
            // 
            this.txtSafeInv.isNumeric = true;
            this.txtSafeInv.isRequired = true;
            this.txtSafeInv.Location = new System.Drawing.Point(210, 111);
            this.txtSafeInv.Name = "txtSafeInv";
            this.txtSafeInv.PlaceHolder = null;
            this.txtSafeInv.Size = new System.Drawing.Size(50, 23);
            this.txtSafeInv.TabIndex = 10;
            this.txtSafeInv.Tag = "안전 재고";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(140, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "안전 재고";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboPartCategory
            // 
            this.cboPartCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartCategory.FormattingEnabled = true;
            this.cboPartCategory.ItemHeight = 15;
            this.cboPartCategory.Location = new System.Drawing.Point(306, 40);
            this.cboPartCategory.Name = "cboPartCategory";
            this.cboPartCategory.Size = new System.Drawing.Size(75, 23);
            this.cboPartCategory.TabIndex = 8;
            // 
            // txtPartName
            // 
            this.txtPartName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPartName.isNumeric = false;
            this.txtPartName.isRequired = true;
            this.txtPartName.Location = new System.Drawing.Point(210, 6);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.PlaceHolder = null;
            this.txtPartName.Size = new System.Drawing.Size(171, 23);
            this.txtPartName.TabIndex = 6;
            this.txtPartName.Tag = "부품명";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(140, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "부품명";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptbPart
            // 
            this.ptbPart.Location = new System.Drawing.Point(6, 6);
            this.ptbPart.Name = "ptbPart";
            this.ptbPart.Size = new System.Drawing.Size(128, 128);
            this.ptbPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPart.TabIndex = 10;
            this.ptbPart.TabStop = false;
            // 
            // popSaveModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 247);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "popSaveModel";
            this.Text = "popSaveModel";
            this.Load += new System.EventHandler(this.popSaveModel_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.SaveProduct.ResumeLayout(false);
            this.SaveProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProd)).EndInit();
            this.SavePart.ResumeLayout(false);
            this.SavePart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SaveProduct;
        private ccTextBox txtProdPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProdCategory;
        private System.Windows.Forms.ComboBox cboIsFinished;
        private ccTextBox txtProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbProd;
        private System.Windows.Forms.TabPage SavePart;
        private System.Windows.Forms.Button btnUploadProdImg;
        private System.Windows.Forms.Button btnProdCancel;
        private System.Windows.Forms.Button btnSaveProd;
        private ccTextBox txtPartPrice;
        private System.Windows.Forms.Label label6;
        private ccTextBox txtClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPartCancel;
        private System.Windows.Forms.Button btnSavePart;
        private System.Windows.Forms.Button btnUploadPart;
        private ccTextBox txtSafeInv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPartCategory;
        private ccTextBox txtPartName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptbPart;
        private ccTextBox txtUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ccTextBox txtLeadTime;
    }
}