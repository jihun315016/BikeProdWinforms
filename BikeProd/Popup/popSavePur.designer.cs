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
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPurName = new BikeProd.ccTextBox();
            this.txtBusiness = new BikeProd.ccTextBox();
            this.txtManager = new BikeProd.ccTextBox();
            this.txtBusinessID = new BikeProd.ccTextBox();
            this.txtSubManager = new BikeProd.ccTextBox();
            this.chkNull = new System.Windows.Forms.CheckBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.dtpPurDate = new System.Windows.Forms.DateTimePicker();
            this.dtpAliveDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(780, 237);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "거래처";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "발주서명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "거래처 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "거래처 담당자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "발주 담당자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "발주 일자";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "입고 예정일";
            // 
            // cboCate
            // 
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(60, 270);
            this.cboCate.Margin = new System.Windows.Forms.Padding(4);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(154, 28);
            this.cboCate.TabIndex = 8;
            this.cboCate.SelectedIndexChanged += new System.EventHandler(this.cboCate_SelectedIndexChanged);
            // 
            // cboModel
            // 
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(223, 270);
            this.cboModel.Margin = new System.Windows.Forms.Padding(4);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(154, 28);
            this.cboModel.TabIndex = 9;
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(386, 270);
            this.cboName.Margin = new System.Windows.Forms.Padding(4);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(154, 28);
            this.cboName.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(707, 270);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "추가";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 306);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(780, 305);
            this.dataGridView1.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 653);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "등록";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 653);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "취소";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtPurName
            // 
            this.txtPurName.isNumeric = false;
            this.txtPurName.isRequired = false;
            this.txtPurName.Location = new System.Drawing.Point(200, 32);
            this.txtPurName.Name = "txtPurName";
            this.txtPurName.PlaceHolder = null;
            this.txtPurName.Size = new System.Drawing.Size(475, 27);
            this.txtPurName.TabIndex = 0;
            // 
            // txtBusiness
            // 
            this.txtBusiness.isNumeric = false;
            this.txtBusiness.isRequired = false;
            this.txtBusiness.Location = new System.Drawing.Point(200, 77);
            this.txtBusiness.Name = "txtBusiness";
            this.txtBusiness.PlaceHolder = null;
            this.txtBusiness.Size = new System.Drawing.Size(154, 27);
            this.txtBusiness.TabIndex = 1;
            this.txtBusiness.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBusiness_MouseClick);
            this.txtBusiness.TextChanged += new System.EventHandler(this.txtBusiness_TextChanged);
            this.txtBusiness.Enter += new System.EventHandler(this.txtBusiness_Enter);
            // 
            // txtManager
            // 
            this.txtManager.isNumeric = false;
            this.txtManager.isRequired = false;
            this.txtManager.Location = new System.Drawing.Point(200, 122);
            this.txtManager.Name = "txtManager";
            this.txtManager.PlaceHolder = null;
            this.txtManager.Size = new System.Drawing.Size(154, 27);
            this.txtManager.TabIndex = 3;
            // 
            // txtBusinessID
            // 
            this.txtBusinessID.isNumeric = false;
            this.txtBusinessID.isRequired = false;
            this.txtBusinessID.Location = new System.Drawing.Point(521, 77);
            this.txtBusinessID.Name = "txtBusinessID";
            this.txtBusinessID.PlaceHolder = null;
            this.txtBusinessID.Size = new System.Drawing.Size(154, 27);
            this.txtBusinessID.TabIndex = 19;
            // 
            // txtSubManager
            // 
            this.txtSubManager.isNumeric = false;
            this.txtSubManager.isRequired = false;
            this.txtSubManager.Location = new System.Drawing.Point(521, 122);
            this.txtSubManager.Name = "txtSubManager";
            this.txtSubManager.PlaceHolder = null;
            this.txtSubManager.Size = new System.Drawing.Size(154, 27);
            this.txtSubManager.TabIndex = 4;
            // 
            // chkNull
            // 
            this.chkNull.AutoSize = true;
            this.chkNull.Location = new System.Drawing.Point(684, 171);
            this.chkNull.Name = "chkNull";
            this.chkNull.Size = new System.Drawing.Size(61, 24);
            this.chkNull.TabIndex = 7;
            this.chkNull.Text = "미정";
            this.chkNull.UseVisualStyleBackColor = true;
            this.chkNull.CheckedChanged += new System.EventHandler(this.chkNull_CheckedChanged);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(547, 270);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(132, 27);
            this.numQty.TabIndex = 11;
            // 
            // dtpPurDate
            // 
            this.dtpPurDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurDate.Location = new System.Drawing.Point(200, 171);
            this.dtpPurDate.Name = "dtpPurDate";
            this.dtpPurDate.Size = new System.Drawing.Size(154, 27);
            this.dtpPurDate.TabIndex = 5;
            // 
            // dtpAliveDate
            // 
            this.dtpAliveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAliveDate.Location = new System.Drawing.Point(521, 168);
            this.dtpAliveDate.Name = "dtpAliveDate";
            this.dtpAliveDate.Size = new System.Drawing.Size(154, 27);
            this.dtpAliveDate.TabIndex = 6;
            // 
            // popSavePur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 700);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.cboModel);
            this.Controls.Add(this.cboCate);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "popSavePur";
            this.Text = "popAddBalJu";
            this.Load += new System.EventHandler(this.popAddBalJu_Load);
            this.Controls.SetChildIndex(this.DescriptLabel2, 0);
            this.Controls.SetChildIndex(this.DescriptLabel1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.cboCate, 0);
            this.Controls.SetChildIndex(this.cboModel, 0);
            this.Controls.SetChildIndex(this.cboName, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.numQty, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkNull;
        private ccTextBox txtSubManager;
        private ccTextBox txtBusinessID;
        private ccTextBox txtManager;
        private ccTextBox txtBusiness;
        private ccTextBox txtPurName;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.DateTimePicker dtpAliveDate;
        private System.Windows.Forms.DateTimePicker dtpPurDate;
    }
}