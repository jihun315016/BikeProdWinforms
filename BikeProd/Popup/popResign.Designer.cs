namespace BikeProd
{
    partial class popResign
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
            this.dtpResign = new System.Windows.Forms.DateTimePicker();
            this.btnResign = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResign);
            this.panel1.Controls.Add(this.dtpResign);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Size = new System.Drawing.Size(361, 226);
            // 
            // dtpResign
            // 
            this.dtpResign.Checked = false;
            this.dtpResign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpResign.Location = new System.Drawing.Point(103, 47);
            this.dtpResign.Name = "dtpResign";
            this.dtpResign.Size = new System.Drawing.Size(144, 23);
            this.dtpResign.TabIndex = 0;
            this.dtpResign.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
            // 
            // btnResign
            // 
            this.btnResign.Location = new System.Drawing.Point(133, 160);
            this.btnResign.Name = "btnResign";
            this.btnResign.Size = new System.Drawing.Size(86, 37);
            this.btnResign.TabIndex = 1;
            this.btnResign.Text = "퇴사";
            this.btnResign.UseVisualStyleBackColor = true;
            this.btnResign.Click += new System.EventHandler(this.btnResign_Click_1);
            // 
            // popResign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 276);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "popResign";
            this.Text = "퇴사";
            this.Load += new System.EventHandler(this.popResign_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResign;
        private System.Windows.Forms.DateTimePicker dtpResign;
    }
}