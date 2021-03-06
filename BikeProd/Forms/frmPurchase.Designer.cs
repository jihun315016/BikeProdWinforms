namespace BikeProd
{
    partial class frmPurchase
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
            this.txtSearch = new BikeProd.ccTextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cboStateFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAliveDate = new BikeProd.ccTextBox();
            this.txtPurDate = new BikeProd.ccTextBox();
            this.txtState = new BikeProd.ccTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtClient = new BikeProd.ccTextBox();
            this.txtAddress = new BikeProd.ccTextBox();
            this.txtManager = new BikeProd.ccTextBox();
            this.txtSubManager = new BikeProd.ccTextBox();
            this.txtPurName = new BikeProd.ccTextBox();
            this.txtBusinessNo = new BikeProd.ccTextBox();
            this.txtPurNo = new BikeProd.ccTextBox();
            this.dgvList2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label13 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptLabel1
            // 
            this.DescriptLabel1.Location = new System.Drawing.Point(639, 9);
            this.DescriptLabel1.Visible = false;
            // 
            // DescriptLabel2
            // 
            this.DescriptLabel2.Location = new System.Drawing.Point(467, 9);
            this.DescriptLabel2.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.isNumeric = false;
            this.txtSearch.isRequired = false;
            this.txtSearch.Location = new System.Drawing.Point(110, 136);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolder = null;
            this.txtSearch.Size = new System.Drawing.Size(220, 23);
            this.txtSearch.TabIndex = 26;
            // 
            // dgvList
            // 
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(42, 176);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 27;
            this.dgvList.Size = new System.Drawing.Size(509, 371);
            this.dgvList.TabIndex = 23;
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvList_CellFormatting_1);
            this.dgvList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseDoubleClick);
            // 
            // cboStateFilter
            // 
            this.cboStateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStateFilter.FormattingEnabled = true;
            this.cboStateFilter.Location = new System.Drawing.Point(335, 103);
            this.cboStateFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboStateFilter.Name = "cboStateFilter";
            this.cboStateFilter.Size = new System.Drawing.Size(89, 23);
            this.cboStateFilter.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(334, 136);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 25);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "거래처";
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWarehouse.Location = new System.Drawing.Point(235, 569);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(111, 46);
            this.btnWarehouse.TabIndex = 24;
            this.btnWarehouse.Text = "입고완료";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "발주 일자";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(354, 569);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 46);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "주문취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(233, 105);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(97, 23);
            this.dtpTo.TabIndex = 19;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(110, 105);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(97, 23);
            this.dtpFrom.TabIndex = 20;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "~";
            // 
            // txtAliveDate
            // 
            this.txtAliveDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAliveDate.isNumeric = false;
            this.txtAliveDate.isRequired = false;
            this.txtAliveDate.Location = new System.Drawing.Point(140, 151);
            this.txtAliveDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAliveDate.Name = "txtAliveDate";
            this.txtAliveDate.PlaceHolder = null;
            this.txtAliveDate.Size = new System.Drawing.Size(120, 23);
            this.txtAliveDate.TabIndex = 47;
            // 
            // txtPurDate
            // 
            this.txtPurDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPurDate.isNumeric = false;
            this.txtPurDate.isRequired = false;
            this.txtPurDate.Location = new System.Drawing.Point(140, 120);
            this.txtPurDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPurDate.Name = "txtPurDate";
            this.txtPurDate.PlaceHolder = null;
            this.txtPurDate.Size = new System.Drawing.Size(120, 23);
            this.txtPurDate.TabIndex = 46;
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtState.isNumeric = false;
            this.txtState.isRequired = false;
            this.txtState.Location = new System.Drawing.Point(399, 70);
            this.txtState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtState.Name = "txtState";
            this.txtState.PlaceHolder = "상태";
            this.txtState.Size = new System.Drawing.Size(79, 23);
            this.txtState.TabIndex = 45;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(218, 572);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 61);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "발주서 등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtClient
            // 
            this.txtClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClient.isNumeric = false;
            this.txtClient.isRequired = false;
            this.txtClient.Location = new System.Drawing.Point(373, 21);
            this.txtClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClient.Name = "txtClient";
            this.txtClient.PlaceHolder = null;
            this.txtClient.Size = new System.Drawing.Size(141, 23);
            this.txtClient.TabIndex = 42;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.isNumeric = false;
            this.txtAddress.isRequired = false;
            this.txtAddress.Location = new System.Drawing.Point(140, 186);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceHolder = null;
            this.txtAddress.Size = new System.Drawing.Size(379, 45);
            this.txtAddress.TabIndex = 41;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtManager
            // 
            this.txtManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtManager.isNumeric = false;
            this.txtManager.isRequired = false;
            this.txtManager.Location = new System.Drawing.Point(388, 147);
            this.txtManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtManager.Name = "txtManager";
            this.txtManager.PlaceHolder = null;
            this.txtManager.Size = new System.Drawing.Size(141, 23);
            this.txtManager.TabIndex = 40;
            // 
            // txtSubManager
            // 
            this.txtSubManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubManager.isNumeric = false;
            this.txtSubManager.isRequired = false;
            this.txtSubManager.Location = new System.Drawing.Point(388, 120);
            this.txtSubManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubManager.Name = "txtSubManager";
            this.txtSubManager.PlaceHolder = null;
            this.txtSubManager.Size = new System.Drawing.Size(141, 23);
            this.txtSubManager.TabIndex = 39;
            // 
            // txtPurName
            // 
            this.txtPurName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPurName.isNumeric = false;
            this.txtPurName.isRequired = false;
            this.txtPurName.Location = new System.Drawing.Point(140, 87);
            this.txtPurName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPurName.Name = "txtPurName";
            this.txtPurName.PlaceHolder = null;
            this.txtPurName.Size = new System.Drawing.Size(195, 23);
            this.txtPurName.TabIndex = 38;
            // 
            // txtBusinessNo
            // 
            this.txtBusinessNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusinessNo.isNumeric = false;
            this.txtBusinessNo.isRequired = false;
            this.txtBusinessNo.Location = new System.Drawing.Point(140, 57);
            this.txtBusinessNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBusinessNo.Name = "txtBusinessNo";
            this.txtBusinessNo.PlaceHolder = null;
            this.txtBusinessNo.Size = new System.Drawing.Size(195, 23);
            this.txtBusinessNo.TabIndex = 44;
            // 
            // txtPurNo
            // 
            this.txtPurNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPurNo.isNumeric = false;
            this.txtPurNo.isRequired = false;
            this.txtPurNo.Location = new System.Drawing.Point(140, 24);
            this.txtPurNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPurNo.Name = "txtPurNo";
            this.txtPurNo.PlaceHolder = null;
            this.txtPurNo.Size = new System.Drawing.Size(141, 23);
            this.txtPurNo.TabIndex = 37;
            // 
            // dgvList2
            // 
            this.dgvList2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvList2.ColumnHeadersHeight = 29;
            this.dgvList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList2.Location = new System.Drawing.Point(119, 3);
            this.dgvList2.Name = "dgvList2";
            this.dgvList2.RowHeadersWidth = 51;
            this.dgvList2.RowTemplate.Height = 23;
            this.dgvList2.Size = new System.Drawing.Size(379, 276);
            this.dgvList2.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 189);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "주소";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 154);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "발주 담당자";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "입고 예정일";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "거래처 담당자";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "발주 일자";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "발주서명";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "사업자 번호";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "입고처";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "발주 번호";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel1.Controls.Add(this.cboStateFilter);
            this.splitContainer1.Panel1.Controls.Add(this.dgvList);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnWarehouse);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.dtpTo);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFrom);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1301, 635);
            this.splitContainer1.SplitterDistance = 711;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(711, 59);
            this.label13.TabIndex = 28;
            this.label13.Text = "발주";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(397, 137);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(58, 23);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtAliveDate);
            this.panel1.Controls.Add(this.txtPurDate);
            this.panel1.Controls.Add(this.txtState);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtClient);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtManager);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSubManager);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPurName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtBusinessNo);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtPurNo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(26, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 262);
            this.panel1.TabIndex = 48;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.10298F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.89702F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(587, 635);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvList2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 268);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 283);
            this.panel2.TabIndex = 44;
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 635);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmPurchase";
            this.Text = "발주";
            this.Activated += new System.EventHandler(this.frmPurchase_Activated);
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.DescriptLabel1, 0);
            this.Controls.SetChildIndex(this.DescriptLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ccTextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ComboBox cboStateFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private ccTextBox txtAliveDate;
        private ccTextBox txtPurDate;
        private ccTextBox txtState;
        private System.Windows.Forms.Button btnAdd;
        private ccTextBox txtClient;
        private ccTextBox txtAddress;
        private ccTextBox txtManager;
        private ccTextBox txtSubManager;
        private ccTextBox txtPurName;
        private ccTextBox txtBusinessNo;
        private ccTextBox txtPurNo;
        private System.Windows.Forms.DataGridView dgvList2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}