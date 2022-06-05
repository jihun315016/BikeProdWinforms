namespace BikeProd
{
    partial class bFrmListAndDetail
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DescriptLabel4 = new System.Windows.Forms.Label();
            this.DescriptLabel5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1144, 601);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 8;
            // 
            // DescriptLabel3
            // 
            this.DescriptLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DescriptLabel3.AutoSize = true;
            this.DescriptLabel3.Location = new System.Drawing.Point(25, 48);
            this.DescriptLabel3.Name = "DescriptLabel3";
            this.DescriptLabel3.Size = new System.Drawing.Size(158, 15);
            this.DescriptLabel3.TabIndex = 0;
            this.DescriptLabel3.Text = "필터 / 라벨 컨트롤 Location";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DescriptLabel4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DescriptLabel5);
            this.splitContainer2.Size = new System.Drawing.Size(1144, 530);
            this.splitContainer2.SplitterDistance = 776;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // DescriptLabel4
            // 
            this.DescriptLabel4.AutoSize = true;
            this.DescriptLabel4.Location = new System.Drawing.Point(25, 15);
            this.DescriptLabel4.Name = "DescriptLabel4";
            this.DescriptLabel4.Size = new System.Drawing.Size(109, 15);
            this.DescriptLabel4.TabIndex = 1;
            this.DescriptLabel4.Text = "그리드 뷰 Location";
            // 
            // DescriptLabel5
            // 
            this.DescriptLabel5.AutoSize = true;
            this.DescriptLabel5.Location = new System.Drawing.Point(25, 15);
            this.DescriptLabel5.Name = "DescriptLabel5";
            this.DescriptLabel5.Size = new System.Drawing.Size(149, 15);
            this.DescriptLabel5.TabIndex = 3;
            this.DescriptLabel5.Text = "컨트롤 배치 시작 Location";
            // 
            // bFrmListAndDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.splitContainer1);
            this.Name = "bFrmListAndDetail";
            this.Text = "bFrmListAndDetail";
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.DescriptLabel1, 0);
            this.Controls.SetChildIndex(this.DescriptLabel2, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.SplitContainer splitContainer1;
        protected System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label DescriptLabel3;
        private System.Windows.Forms.Label DescriptLabel4;
        private System.Windows.Forms.Label DescriptLabel5;
    }
}