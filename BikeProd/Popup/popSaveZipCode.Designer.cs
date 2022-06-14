
namespace BikeProd
{
    partial class popSaveZipCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddrSearch = new BikeProd.ccTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btanSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddr2 = new BikeProd.ccTextBox();
            this.txtAddr1 = new BikeProd.ccTextBox();
            this.txtZipCode = new BikeProd.ccTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddr2);
            this.panel1.Controls.Add(this.txtAddr1);
            this.panel1.Controls.Add(this.txtZipCode);
            this.panel1.Controls.Add(this.btanSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtAddrSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Size = new System.Drawing.Size(489, 480);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "도로명 / 지번주소";
            // 
            // txtAddrSearch
            // 
            this.txtAddrSearch.isNumeric = false;
            this.txtAddrSearch.isRequired = false;
            this.txtAddrSearch.Location = new System.Drawing.Point(153, 14);
            this.txtAddrSearch.Name = "txtAddrSearch";
            this.txtAddrSearch.PlaceHolder = null;
            this.txtAddrSearch.Size = new System.Drawing.Size(222, 23);
            this.txtAddrSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(383, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(464, 289);
            this.dataGridView1.TabIndex = 3;
            // 
            // btanSave
            // 
            this.btanSave.Location = new System.Drawing.Point(383, 433);
            this.btanSave.Name = "btanSave";
            this.btanSave.Size = new System.Drawing.Size(93, 33);
            this.btanSave.TabIndex = 57;
            this.btanSave.Text = "주소 등록";
            this.btanSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "도로명 주소";
            // 
            // txtAddr2
            // 
            this.txtAddr2.isNumeric = false;
            this.txtAddr2.isRequired = false;
            this.txtAddr2.Location = new System.Drawing.Point(125, 389);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.PlaceHolder = null;
            this.txtAddr2.Size = new System.Drawing.Size(305, 23);
            this.txtAddr2.TabIndex = 60;
            // 
            // txtAddr1
            // 
            this.txtAddr1.isNumeric = false;
            this.txtAddr1.isRequired = false;
            this.txtAddr1.Location = new System.Drawing.Point(125, 360);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.PlaceHolder = null;
            this.txtAddr1.Size = new System.Drawing.Size(211, 23);
            this.txtAddr1.TabIndex = 59;
            // 
            // txtZipCode
            // 
            this.txtZipCode.isNumeric = false;
            this.txtZipCode.isRequired = false;
            this.txtZipCode.Location = new System.Drawing.Point(342, 360);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.PlaceHolder = null;
            this.txtZipCode.Size = new System.Drawing.Size(88, 23);
            this.txtZipCode.TabIndex = 58;
            // 
            // popSaveZipCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 510);
            this.Name = "popSaveZipCode";
            this.Text = "popSaveZipCode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private ccTextBox txtAddrSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btanSave;
        private System.Windows.Forms.Label label3;
        private ccTextBox txtAddr2;
        private ccTextBox txtAddr1;
        private ccTextBox txtZipCode;
    }
}