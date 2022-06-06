namespace BikeProd
{
    partial class baseCommon
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
            this.DescriptLabel1 = new System.Windows.Forms.Label();
            this.DescriptLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DescriptLabel1
            // 
            this.DescriptLabel1.AutoSize = true;
            this.DescriptLabel1.Location = new System.Drawing.Point(3, 0);
            this.DescriptLabel1.Name = "DescriptLabel1";
            this.DescriptLabel1.Size = new System.Drawing.Size(153, 15);
            this.DescriptLabel1.TabIndex = 5;
            this.DescriptLabel1.Text = "기본 글꼴 : 맑은 고딕 / 9pt";
            // 
            // DescriptLabel2
            // 
            this.DescriptLabel2.AutoSize = true;
            this.DescriptLabel2.Location = new System.Drawing.Point(179, 2);
            this.DescriptLabel2.Name = "DescriptLabel2";
            this.DescriptLabel2.Size = new System.Drawing.Size(153, 15);
            this.DescriptLabel2.TabIndex = 7;
            this.DescriptLabel2.Text = "개발 환경 폼 Size 동일하게";
            // 
            // baseCommon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.DescriptLabel2);
            this.Controls.Add(this.DescriptLabel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "baseCommon";
            this.Text = "baseCommon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label DescriptLabel1;
        protected System.Windows.Forms.Label DescriptLabel2;
    }
}