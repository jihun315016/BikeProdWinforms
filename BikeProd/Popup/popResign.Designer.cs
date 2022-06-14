
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
            // 
            // dtpResign
            // 
            this.dtpResign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpResign.Location = new System.Drawing.Point(88, 82);
            this.dtpResign.Name = "dtpResign";
            this.dtpResign.Size = new System.Drawing.Size(200, 23);
            this.dtpResign.TabIndex = 0;
            // 
            // btnResign
            // 
            this.btnResign.Location = new System.Drawing.Point(152, 147);
            this.btnResign.Name = "btnResign";
            this.btnResign.Size = new System.Drawing.Size(75, 23);
            this.btnResign.TabIndex = 1;
            this.btnResign.Text = "퇴사";
            this.btnResign.UseVisualStyleBackColor = true;
            this.btnResign.Click += new System.EventHandler(this.btnResign_Click);
            // 
            // popResign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 336);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "popResign";
            this.Text = "popReign";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResign;
        private System.Windows.Forms.DateTimePicker dtpResign;
    }
}