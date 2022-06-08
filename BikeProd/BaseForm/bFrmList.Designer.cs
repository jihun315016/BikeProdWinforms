namespace BikeProd
{
    partial class bFrmList
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DescriptLabel3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptLabel4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DescriptLabel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.DescriptLabel4);
            this.splitContainer1.Size = new System.Drawing.Size(1144, 601);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 8;
            // 
            // DescriptLabel3
            // 
            this.DescriptLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DescriptLabel3.AutoSize = true;
            this.DescriptLabel3.Location = new System.Drawing.Point(25, 48);
            this.DescriptLabel3.Name = "DescriptLabel3";
            this.DescriptLabel3.Size = new System.Drawing.Size(282, 15);
            this.DescriptLabel3.TabIndex = 1;
            this.DescriptLabel3.Text = "필터 / 라벨 컨트롤 Location, Anchor : Bottom, Left";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 446);
            this.panel1.TabIndex = 2;
            // 
            // DescriptLabel4
            // 
            this.DescriptLabel4.AutoSize = true;
            this.DescriptLabel4.Location = new System.Drawing.Point(958, 476);
            this.DescriptLabel4.Name = "DescriptLabel4";
            this.DescriptLabel4.Size = new System.Drawing.Size(160, 15);
            this.DescriptLabel4.TabIndex = 1;
            this.DescriptLabel4.Text = "버튼 Anchor : Bottom, Right";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "그리드뷰 Anchor : Bottom, Right";
            // 
            // bFrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "bFrmList";
            this.Text = "bFrmList";
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.DescriptLabel2, 0);
            this.Controls.SetChildIndex(this.DescriptLabel1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label DescriptLabel3;
        private System.Windows.Forms.Label DescriptLabel4;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}