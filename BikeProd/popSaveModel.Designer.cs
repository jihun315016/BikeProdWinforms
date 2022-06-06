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
            this.btnProdCancel = new System.Windows.Forms.Button();
            this.btnSaveProd = new System.Windows.Forms.Button();
            this.btnUploadProdImg = new System.Windows.Forms.Button();
            this.ccTxtProdPrice = new BikeProd.ccTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProdCategory = new System.Windows.Forms.ComboBox();
            this.cmbIsFinished = new System.Windows.Forms.ComboBox();
            this.ccTxtProdName = new BikeProd.ccTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SavePart = new System.Windows.Forms.TabPage();
            this.ccTxtUnit = new BikeProd.ccTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ccTxtPartPrice = new BikeProd.ccTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ccTxtClient = new BikeProd.ccTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPartCancel = new System.Windows.Forms.Button();
            this.btnSavePart = new System.Windows.Forms.Button();
            this.btnUploadPart = new System.Windows.Forms.Button();
            this.ccTxtSafeInv = new BikeProd.ccTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPartCategory = new System.Windows.Forms.ComboBox();
            this.ccTxtPartName = new BikeProd.ccTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SaveProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SavePart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.SaveProduct.Controls.Add(this.btnProdCancel);
            this.SaveProduct.Controls.Add(this.btnSaveProd);
            this.SaveProduct.Controls.Add(this.btnUploadProdImg);
            this.SaveProduct.Controls.Add(this.ccTxtProdPrice);
            this.SaveProduct.Controls.Add(this.label2);
            this.SaveProduct.Controls.Add(this.cmbProdCategory);
            this.SaveProduct.Controls.Add(this.cmbIsFinished);
            this.SaveProduct.Controls.Add(this.ccTxtProdName);
            this.SaveProduct.Controls.Add(this.label1);
            this.SaveProduct.Controls.Add(this.pictureBox1);
            this.SaveProduct.Location = new System.Drawing.Point(4, 24);
            this.SaveProduct.Name = "SaveProduct";
            this.SaveProduct.Padding = new System.Windows.Forms.Padding(3);
            this.SaveProduct.Size = new System.Drawing.Size(392, 169);
            this.SaveProduct.TabIndex = 0;
            this.SaveProduct.Text = "제품 등록";
            this.SaveProduct.UseVisualStyleBackColor = true;
            // 
            // btnProdCancel
            // 
            this.btnProdCancel.Location = new System.Drawing.Point(325, 140);
            this.btnProdCancel.Name = "btnProdCancel";
            this.btnProdCancel.Size = new System.Drawing.Size(53, 23);
            this.btnProdCancel.TabIndex = 9;
            this.btnProdCancel.Text = "취소";
            this.btnProdCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveProd
            // 
            this.btnSaveProd.Location = new System.Drawing.Point(266, 140);
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
            // ccTxtProdPrice
            // 
            this.ccTxtProdPrice.isNumeric = true;
            this.ccTxtProdPrice.isRequired = true;
            this.ccTxtProdPrice.Location = new System.Drawing.Point(207, 111);
            this.ccTxtProdPrice.Name = "ccTxtProdPrice";
            this.ccTxtProdPrice.PlaceHolder = null;
            this.ccTxtProdPrice.Size = new System.Drawing.Size(171, 23);
            this.ccTxtProdPrice.TabIndex = 6;
            this.ccTxtProdPrice.Tag = "제품 가격";
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
            // cmbProdCategory
            // 
            this.cmbProdCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdCategory.FormattingEnabled = true;
            this.cmbProdCategory.Location = new System.Drawing.Point(207, 77);
            this.cmbProdCategory.Name = "cmbProdCategory";
            this.cmbProdCategory.Size = new System.Drawing.Size(171, 23);
            this.cmbProdCategory.TabIndex = 4;
            // 
            // cmbIsFinished
            // 
            this.cmbIsFinished.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsFinished.FormattingEnabled = true;
            this.cmbIsFinished.Location = new System.Drawing.Point(207, 40);
            this.cmbIsFinished.Name = "cmbIsFinished";
            this.cmbIsFinished.Size = new System.Drawing.Size(171, 23);
            this.cmbIsFinished.TabIndex = 3;
            // 
            // ccTxtProdName
            // 
            this.ccTxtProdName.ForeColor = System.Drawing.Color.Gray;
            this.ccTxtProdName.isNumeric = false;
            this.ccTxtProdName.isRequired = true;
            this.ccTxtProdName.Location = new System.Drawing.Point(207, 6);
            this.ccTxtProdName.Name = "ccTxtProdName";
            this.ccTxtProdName.PlaceHolder = null;
            this.ccTxtProdName.Size = new System.Drawing.Size(171, 23);
            this.ccTxtProdName.TabIndex = 2;
            this.ccTxtProdName.Tag = "제품명";
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SavePart
            // 
            this.SavePart.Controls.Add(this.ccTxtUnit);
            this.SavePart.Controls.Add(this.label7);
            this.SavePart.Controls.Add(this.ccTxtPartPrice);
            this.SavePart.Controls.Add(this.label6);
            this.SavePart.Controls.Add(this.ccTxtClient);
            this.SavePart.Controls.Add(this.label5);
            this.SavePart.Controls.Add(this.btnPartCancel);
            this.SavePart.Controls.Add(this.btnSavePart);
            this.SavePart.Controls.Add(this.btnUploadPart);
            this.SavePart.Controls.Add(this.ccTxtSafeInv);
            this.SavePart.Controls.Add(this.label3);
            this.SavePart.Controls.Add(this.cmbPartCategory);
            this.SavePart.Controls.Add(this.ccTxtPartName);
            this.SavePart.Controls.Add(this.label4);
            this.SavePart.Controls.Add(this.pictureBox2);
            this.SavePart.Location = new System.Drawing.Point(4, 24);
            this.SavePart.Name = "SavePart";
            this.SavePart.Padding = new System.Windows.Forms.Padding(3);
            this.SavePart.Size = new System.Drawing.Size(392, 169);
            this.SavePart.TabIndex = 1;
            this.SavePart.Text = "부품 등록";
            this.SavePart.UseVisualStyleBackColor = true;
            // 
            // ccTxtUnit
            // 
            this.ccTxtUnit.isNumeric = false;
            this.ccTxtUnit.isRequired = false;
            this.ccTxtUnit.Location = new System.Drawing.Point(328, 111);
            this.ccTxtUnit.Name = "ccTxtUnit";
            this.ccTxtUnit.PlaceHolder = null;
            this.ccTxtUnit.Size = new System.Drawing.Size(50, 23);
            this.ccTxtUnit.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(261, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "발주 단위";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ccTxtPartPrice
            // 
            this.ccTxtPartPrice.isNumeric = false;
            this.ccTxtPartPrice.isRequired = false;
            this.ccTxtPartPrice.Location = new System.Drawing.Point(207, 40);
            this.ccTxtPartPrice.Name = "ccTxtPartPrice";
            this.ccTxtPartPrice.PlaceHolder = null;
            this.ccTxtPartPrice.Size = new System.Drawing.Size(90, 23);
            this.ccTxtPartPrice.TabIndex = 23;
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
            // ccTxtClient
            // 
            this.ccTxtClient.ForeColor = System.Drawing.Color.Gray;
            this.ccTxtClient.isNumeric = false;
            this.ccTxtClient.isRequired = false;
            this.ccTxtClient.Location = new System.Drawing.Point(207, 77);
            this.ccTxtClient.Name = "ccTxtClient";
            this.ccTxtClient.PlaceHolder = null;
            this.ccTxtClient.Size = new System.Drawing.Size(171, 23);
            this.ccTxtClient.TabIndex = 21;
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
            this.btnPartCancel.Location = new System.Drawing.Point(325, 140);
            this.btnPartCancel.Name = "btnPartCancel";
            this.btnPartCancel.Size = new System.Drawing.Size(53, 23);
            this.btnPartCancel.TabIndex = 19;
            this.btnPartCancel.Text = "취소";
            this.btnPartCancel.UseVisualStyleBackColor = true;
            // 
            // btnSavePart
            // 
            this.btnSavePart.Location = new System.Drawing.Point(266, 140);
            this.btnSavePart.Name = "btnSavePart";
            this.btnSavePart.Size = new System.Drawing.Size(53, 23);
            this.btnSavePart.TabIndex = 18;
            this.btnSavePart.Text = "등록";
            this.btnSavePart.UseVisualStyleBackColor = true;
            // 
            // btnUploadPart
            // 
            this.btnUploadPart.Location = new System.Drawing.Point(81, 140);
            this.btnUploadPart.Name = "btnUploadPart";
            this.btnUploadPart.Size = new System.Drawing.Size(53, 23);
            this.btnUploadPart.TabIndex = 17;
            this.btnUploadPart.Text = "업로드";
            this.btnUploadPart.UseVisualStyleBackColor = true;
            // 
            // ccTxtSafeInv
            // 
            this.ccTxtSafeInv.isNumeric = false;
            this.ccTxtSafeInv.isRequired = false;
            this.ccTxtSafeInv.Location = new System.Drawing.Point(207, 111);
            this.ccTxtSafeInv.Name = "ccTxtSafeInv";
            this.ccTxtSafeInv.PlaceHolder = null;
            this.ccTxtSafeInv.Size = new System.Drawing.Size(50, 23);
            this.ccTxtSafeInv.TabIndex = 16;
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
            // cmbPartCategory
            // 
            this.cmbPartCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartCategory.FormattingEnabled = true;
            this.cmbPartCategory.Location = new System.Drawing.Point(303, 40);
            this.cmbPartCategory.Name = "cmbPartCategory";
            this.cmbPartCategory.Size = new System.Drawing.Size(75, 23);
            this.cmbPartCategory.TabIndex = 13;
            // 
            // ccTxtPartName
            // 
            this.ccTxtPartName.ForeColor = System.Drawing.Color.Gray;
            this.ccTxtPartName.isNumeric = false;
            this.ccTxtPartName.isRequired = false;
            this.ccTxtPartName.Location = new System.Drawing.Point(207, 6);
            this.ccTxtPartName.Name = "ccTxtPartName";
            this.ccTxtPartName.PlaceHolder = null;
            this.ccTxtPartName.Size = new System.Drawing.Size(171, 23);
            this.ccTxtPartName.TabIndex = 12;
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
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SavePart.ResumeLayout(false);
            this.SavePart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SaveProduct;
        private ccTextBox ccTxtProdPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProdCategory;
        private System.Windows.Forms.ComboBox cmbIsFinished;
        private ccTextBox ccTxtProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage SavePart;
        private System.Windows.Forms.Button btnUploadProdImg;
        private System.Windows.Forms.Button btnProdCancel;
        private System.Windows.Forms.Button btnSaveProd;
        private ccTextBox ccTxtPartPrice;
        private System.Windows.Forms.Label label6;
        private ccTextBox ccTxtClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPartCancel;
        private System.Windows.Forms.Button btnSavePart;
        private System.Windows.Forms.Button btnUploadPart;
        private ccTextBox ccTxtSafeInv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPartCategory;
        private ccTextBox ccTxtPartName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ccTextBox ccTxtUnit;
        private System.Windows.Forms.Label label7;
    }
}