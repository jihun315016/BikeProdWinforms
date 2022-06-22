
namespace BikeProd
{
    partial class frmOrder
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label13 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpOrderDetail = new System.Windows.Forms.TabPage();
            this.dgvList2 = new System.Windows.Forms.DataGridView();
            this.txtAliveDate = new BikeProd.ccTextBox();
            this.txtOrderDate = new BikeProd.ccTextBox();
            this.txtAddress = new BikeProd.ccTextBox();
            this.txtState = new BikeProd.ccTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClient = new BikeProd.ccTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtManager = new BikeProd.ccTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubManager = new BikeProd.ccTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOrderName = new BikeProd.ccTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBusinessNo = new BikeProd.ccTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrderNo = new BikeProd.ccTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tpList = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvList3 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvList4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).BeginInit();
            this.tpList.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList4)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptLabel1
            // 
            this.DescriptLabel1.Location = new System.Drawing.Point(822, 12);
            this.DescriptLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptLabel1.Visible = false;
            // 
            // DescriptLabel2
            // 
            this.DescriptLabel2.Location = new System.Drawing.Point(600, 12);
            this.DescriptLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptLabel2.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.isNumeric = false;
            this.txtSearch.isRequired = false;
            this.txtSearch.Location = new System.Drawing.Point(140, 160);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolder = null;
            this.txtSearch.Size = new System.Drawing.Size(282, 27);
            this.txtSearch.TabIndex = 26;
            // 
            // dgvList
            // 
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(66, 217);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 27;
            this.dgvList.Size = new System.Drawing.Size(707, 495);
            this.dgvList.TabIndex = 23;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvList_CellFormatting);
            this.dgvList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseDoubleClick);
            // 
            // cboStateFilter
            // 
            this.cboStateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStateFilter.FormattingEnabled = true;
            this.cboStateFilter.Location = new System.Drawing.Point(431, 115);
            this.cboStateFilter.Name = "cboStateFilter";
            this.cboStateFilter.Size = new System.Drawing.Size(113, 28);
            this.cboStateFilter.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(428, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "거래처";
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWarehouse.Location = new System.Drawing.Point(315, 806);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(143, 61);
            this.btnWarehouse.TabIndex = 24;
            this.btnWarehouse.Text = "출고완료";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "주문 일자";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(469, 806);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 61);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "주문취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(300, 117);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(124, 27);
            this.dtpTo.TabIndex = 19;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(140, 117);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(124, 27);
            this.dtpFrom.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "~";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1682, 892);
            this.splitContainer1.SplitterDistance = 970;
            this.splitContainer1.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(970, 78);
            this.label13.TabIndex = 29;
            this.label13.Text = "주문";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(509, 160);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 31);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.89238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.10762F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 892);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 787);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 102);
            this.panel1.TabIndex = 68;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(265, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 61);
            this.button1.TabIndex = 26;
            this.button1.Text = "주문서 등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpOrderDetail);
            this.tabControl.Controls.Add(this.tpList);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(4, 4);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(700, 776);
            this.tabControl.TabIndex = 0;
            // 
            // tpOrderDetail
            // 
            this.tpOrderDetail.Controls.Add(this.dgvList2);
            this.tpOrderDetail.Controls.Add(this.txtAliveDate);
            this.tpOrderDetail.Controls.Add(this.txtOrderDate);
            this.tpOrderDetail.Controls.Add(this.txtAddress);
            this.tpOrderDetail.Controls.Add(this.txtState);
            this.tpOrderDetail.Controls.Add(this.label4);
            this.tpOrderDetail.Controls.Add(this.label10);
            this.tpOrderDetail.Controls.Add(this.txtClient);
            this.tpOrderDetail.Controls.Add(this.label5);
            this.tpOrderDetail.Controls.Add(this.label6);
            this.tpOrderDetail.Controls.Add(this.txtManager);
            this.tpOrderDetail.Controls.Add(this.label7);
            this.tpOrderDetail.Controls.Add(this.txtSubManager);
            this.tpOrderDetail.Controls.Add(this.label11);
            this.tpOrderDetail.Controls.Add(this.txtOrderName);
            this.tpOrderDetail.Controls.Add(this.label8);
            this.tpOrderDetail.Controls.Add(this.txtBusinessNo);
            this.tpOrderDetail.Controls.Add(this.label12);
            this.tpOrderDetail.Controls.Add(this.txtOrderNo);
            this.tpOrderDetail.Controls.Add(this.label9);
            this.tpOrderDetail.Location = new System.Drawing.Point(4, 29);
            this.tpOrderDetail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpOrderDetail.Name = "tpOrderDetail";
            this.tpOrderDetail.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpOrderDetail.Size = new System.Drawing.Size(692, 743);
            this.tpOrderDetail.TabIndex = 0;
            this.tpOrderDetail.Text = "주문상세";
            this.tpOrderDetail.UseVisualStyleBackColor = true;
            // 
            // dgvList2
            // 
            this.dgvList2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList2.Location = new System.Drawing.Point(175, 313);
            this.dgvList2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvList2.Name = "dgvList2";
            this.dgvList2.RowHeadersWidth = 51;
            this.dgvList2.RowTemplate.Height = 23;
            this.dgvList2.Size = new System.Drawing.Size(411, 375);
            this.dgvList2.TabIndex = 67;
            // 
            // txtAliveDate
            // 
            this.txtAliveDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAliveDate.isNumeric = false;
            this.txtAliveDate.isRequired = false;
            this.txtAliveDate.Location = new System.Drawing.Point(128, 200);
            this.txtAliveDate.Name = "txtAliveDate";
            this.txtAliveDate.PlaceHolder = null;
            this.txtAliveDate.Size = new System.Drawing.Size(153, 27);
            this.txtAliveDate.TabIndex = 66;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOrderDate.isNumeric = false;
            this.txtOrderDate.isRequired = false;
            this.txtOrderDate.Location = new System.Drawing.Point(128, 159);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.PlaceHolder = null;
            this.txtOrderDate.Size = new System.Drawing.Size(153, 27);
            this.txtOrderDate.TabIndex = 65;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.isNumeric = false;
            this.txtAddress.isRequired = false;
            this.txtAddress.Location = new System.Drawing.Point(130, 247);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceHolder = null;
            this.txtAddress.Size = new System.Drawing.Size(498, 59);
            this.txtAddress.TabIndex = 61;
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtState.isNumeric = false;
            this.txtState.isRequired = false;
            this.txtState.Location = new System.Drawing.Point(527, 116);
            this.txtState.Name = "txtState";
            this.txtState.PlaceHolder = "상태";
            this.txtState.Size = new System.Drawing.Size(100, 27);
            this.txtState.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "주문 번호";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "고객사";
            // 
            // txtClient
            // 
            this.txtClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClient.isNumeric = false;
            this.txtClient.isRequired = false;
            this.txtClient.Location = new System.Drawing.Point(428, 27);
            this.txtClient.Name = "txtClient";
            this.txtClient.PlaceHolder = null;
            this.txtClient.Size = new System.Drawing.Size(180, 27);
            this.txtClient.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "사업자 번호";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "주문서명";
            // 
            // txtManager
            // 
            this.txtManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtManager.isNumeric = false;
            this.txtManager.isRequired = false;
            this.txtManager.Location = new System.Drawing.Point(447, 204);
            this.txtManager.Name = "txtManager";
            this.txtManager.PlaceHolder = null;
            this.txtManager.Size = new System.Drawing.Size(180, 27);
            this.txtManager.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "주문 일자";
            // 
            // txtSubManager
            // 
            this.txtSubManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubManager.isNumeric = false;
            this.txtSubManager.isRequired = false;
            this.txtSubManager.Location = new System.Drawing.Point(447, 163);
            this.txtSubManager.Name = "txtSubManager";
            this.txtSubManager.PlaceHolder = null;
            this.txtSubManager.Size = new System.Drawing.Size(180, 27);
            this.txtSubManager.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "거래처 담당자";
            // 
            // txtOrderName
            // 
            this.txtOrderName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOrderName.isNumeric = false;
            this.txtOrderName.isRequired = false;
            this.txtOrderName.Location = new System.Drawing.Point(128, 115);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.PlaceHolder = null;
            this.txtOrderName.Size = new System.Drawing.Size(338, 27);
            this.txtOrderName.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "출고 예정일";
            // 
            // txtBusinessNo
            // 
            this.txtBusinessNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusinessNo.isNumeric = false;
            this.txtBusinessNo.isRequired = false;
            this.txtBusinessNo.Location = new System.Drawing.Point(128, 75);
            this.txtBusinessNo.Name = "txtBusinessNo";
            this.txtBusinessNo.PlaceHolder = null;
            this.txtBusinessNo.Size = new System.Drawing.Size(338, 27);
            this.txtBusinessNo.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "주문 담당자";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOrderNo.isNumeric = false;
            this.txtOrderNo.isRequired = false;
            this.txtOrderNo.Location = new System.Drawing.Point(128, 31);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.PlaceHolder = null;
            this.txtOrderNo.Size = new System.Drawing.Size(180, 27);
            this.txtOrderNo.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "주소";
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.tableLayoutPanel2);
            this.tpList.Location = new System.Drawing.Point(4, 29);
            this.tpList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpList.Size = new System.Drawing.Size(691, 743);
            this.tpList.TabIndex = 1;
            this.tpList.Text = "자재목록";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(681, 733);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvList3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(673, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주문 제품";
            // 
            // dgvList3
            // 
            this.dgvList3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList3.Location = new System.Drawing.Point(14, 29);
            this.dgvList3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvList3.Name = "dgvList3";
            this.dgvList3.RowHeadersWidth = 51;
            this.dgvList3.RowTemplate.Height = 23;
            this.dgvList3.Size = new System.Drawing.Size(832, 307);
            this.dgvList3.TabIndex = 0;
            this.dgvList3.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList3_CellContentDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvList4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 370);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(673, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "자재 리스트";
            // 
            // dgvList4
            // 
            this.dgvList4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList4.Location = new System.Drawing.Point(14, 29);
            this.dgvList4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvList4.Name = "dgvList4";
            this.dgvList4.RowHeadersWidth = 51;
            this.dgvList4.RowTemplate.Height = 23;
            this.dgvList4.Size = new System.Drawing.Size(832, 307);
            this.dgvList4.TabIndex = 0;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 892);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmOrder";
            this.Text = "주문";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.Controls.SetChildIndex(this.DescriptLabel1, 0);
            this.Controls.SetChildIndex(this.DescriptLabel2, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tpOrderDetail.ResumeLayout(false);
            this.tpOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).EndInit();
            this.tpList.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList4)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpOrderDetail;
        private System.Windows.Forms.DataGridView dgvList2;
        private ccTextBox txtAliveDate;
        private ccTextBox txtOrderDate;
        private ccTextBox txtAddress;
        private ccTextBox txtState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private ccTextBox txtClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ccTextBox txtManager;
        private System.Windows.Forms.Label label7;
        private ccTextBox txtSubManager;
        private System.Windows.Forms.Label label11;
        private ccTextBox txtOrderName;
        private System.Windows.Forms.Label label8;
        private ccTextBox txtBusinessNo;
        private System.Windows.Forms.Label label12;
        private ccTextBox txtOrderNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.DataGridView dgvList3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvList4;
    }
}