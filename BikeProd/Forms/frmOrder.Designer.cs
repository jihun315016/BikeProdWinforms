
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
            this.btnReset = new System.Windows.Forms.Button();
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
            this.dgvList3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).BeginInit();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList3)).BeginInit();
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
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.isNumeric = false;
            this.txtSearch.isRequired = false;
            this.txtSearch.Location = new System.Drawing.Point(166, 50);
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
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(136, 90);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 27;
            this.dgvList.Size = new System.Drawing.Size(438, 492);
            this.dgvList.TabIndex = 23;
            // 
            // cboStateFilter
            // 
            this.cboStateFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboStateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStateFilter.FormattingEnabled = true;
            this.cboStateFilter.Location = new System.Drawing.Point(391, 17);
            this.cboStateFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cboStateFilter.Name = "cboStateFilter";
            this.cboStateFilter.Size = new System.Drawing.Size(89, 23);
            this.cboStateFilter.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(390, 50);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 25);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "거래처";
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWarehouse.Location = new System.Drawing.Point(190, 603);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(111, 46);
            this.btnWarehouse.TabIndex = 24;
            this.btnWarehouse.Text = "출고완료";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "주문 일자";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(310, 603);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 46);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "주문취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(289, 19);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(97, 23);
            this.dtpTo.TabIndex = 19;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(165, 19);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(97, 23);
            this.dtpFrom.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "~";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(1308, 669);
            this.splitContainer1.SplitterDistance = 618;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 48;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Location = new System.Drawing.Point(453, 51);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(58, 23);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpOrderDetail);
            this.tabControl.Controls.Add(this.tpList);
            this.tabControl.Location = new System.Drawing.Point(21, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(654, 540);
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
            this.tpOrderDetail.Location = new System.Drawing.Point(4, 24);
            this.tpOrderDetail.Name = "tpOrderDetail";
            this.tpOrderDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrderDetail.Size = new System.Drawing.Size(646, 512);
            this.tpOrderDetail.TabIndex = 0;
            this.tpOrderDetail.Text = "주문상세";
            this.tpOrderDetail.UseVisualStyleBackColor = true;
            // 
            // dgvList2
            // 
            this.dgvList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList2.Location = new System.Drawing.Point(73, 245);
            this.dgvList2.Name = "dgvList2";
            this.dgvList2.RowTemplate.Height = 23;
            this.dgvList2.Size = new System.Drawing.Size(470, 247);
            this.dgvList2.TabIndex = 67;
            // 
            // txtAliveDate
            // 
            this.txtAliveDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAliveDate.isNumeric = false;
            this.txtAliveDate.isRequired = false;
            this.txtAliveDate.Location = new System.Drawing.Point(154, 150);
            this.txtAliveDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtAliveDate.Name = "txtAliveDate";
            this.txtAliveDate.PlaceHolder = null;
            this.txtAliveDate.Size = new System.Drawing.Size(120, 23);
            this.txtAliveDate.TabIndex = 66;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOrderDate.isNumeric = false;
            this.txtOrderDate.isRequired = false;
            this.txtOrderDate.Location = new System.Drawing.Point(154, 119);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.PlaceHolder = null;
            this.txtOrderDate.Size = new System.Drawing.Size(120, 23);
            this.txtOrderDate.TabIndex = 65;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.isNumeric = false;
            this.txtAddress.isRequired = false;
            this.txtAddress.Location = new System.Drawing.Point(155, 185);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceHolder = null;
            this.txtAddress.Size = new System.Drawing.Size(388, 45);
            this.txtAddress.TabIndex = 61;
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtState.isNumeric = false;
            this.txtState.isRequired = false;
            this.txtState.Location = new System.Drawing.Point(464, 87);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.Name = "txtState";
            this.txtState.PlaceHolder = "상태";
            this.txtState.Size = new System.Drawing.Size(79, 23);
            this.txtState.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "주문 번호";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 56;
            this.label10.Text = "고객사";
            // 
            // txtClient
            // 
            this.txtClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClient.isNumeric = false;
            this.txtClient.isRequired = false;
            this.txtClient.Location = new System.Drawing.Point(387, 20);
            this.txtClient.Margin = new System.Windows.Forms.Padding(2);
            this.txtClient.Name = "txtClient";
            this.txtClient.PlaceHolder = null;
            this.txtClient.Size = new System.Drawing.Size(141, 23);
            this.txtClient.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "사업자 번호";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "주문서명";
            // 
            // txtManager
            // 
            this.txtManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtManager.isNumeric = false;
            this.txtManager.isRequired = false;
            this.txtManager.Location = new System.Drawing.Point(401, 119);
            this.txtManager.Margin = new System.Windows.Forms.Padding(2);
            this.txtManager.Name = "txtManager";
            this.txtManager.PlaceHolder = null;
            this.txtManager.Size = new System.Drawing.Size(141, 23);
            this.txtManager.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "주문 일자";
            // 
            // txtSubManager
            // 
            this.txtSubManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubManager.isNumeric = false;
            this.txtSubManager.isRequired = false;
            this.txtSubManager.Location = new System.Drawing.Point(401, 149);
            this.txtSubManager.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubManager.Name = "txtSubManager";
            this.txtSubManager.PlaceHolder = null;
            this.txtSubManager.Size = new System.Drawing.Size(141, 23);
            this.txtSubManager.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 52;
            this.label11.Text = "거래처 담당자";
            // 
            // txtOrderName
            // 
            this.txtOrderName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOrderName.isNumeric = false;
            this.txtOrderName.isRequired = false;
            this.txtOrderName.Location = new System.Drawing.Point(154, 86);
            this.txtOrderName.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.PlaceHolder = null;
            this.txtOrderName.Size = new System.Drawing.Size(264, 23);
            this.txtOrderName.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "출고 예정일";
            // 
            // txtBusinessNo
            // 
            this.txtBusinessNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusinessNo.isNumeric = false;
            this.txtBusinessNo.isRequired = false;
            this.txtBusinessNo.Location = new System.Drawing.Point(154, 56);
            this.txtBusinessNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusinessNo.Name = "txtBusinessNo";
            this.txtBusinessNo.PlaceHolder = null;
            this.txtBusinessNo.Size = new System.Drawing.Size(264, 23);
            this.txtBusinessNo.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 153);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 54;
            this.label12.Text = "주문 담당자";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOrderNo.isNumeric = false;
            this.txtOrderNo.isRequired = false;
            this.txtOrderNo.Location = new System.Drawing.Point(154, 23);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.PlaceHolder = null;
            this.txtOrderNo.Size = new System.Drawing.Size(141, 23);
            this.txtOrderNo.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 189);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "주소";
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dgvList3);
            this.tpList.Location = new System.Drawing.Point(4, 24);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(646, 512);
            this.tpList.TabIndex = 1;
            this.tpList.Text = "자재목록";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // dgvList3
            // 
            this.dgvList3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList3.Location = new System.Drawing.Point(3, 3);
            this.dgvList3.Name = "dgvList3";
            this.dgvList3.RowTemplate.Height = 23;
            this.dgvList3.Size = new System.Drawing.Size(640, 506);
            this.dgvList3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(332, 603);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "주문서 등록";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 669);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmOrder";
            this.Text = "주문";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.Controls.SetChildIndex(this.DescriptLabel2, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.DescriptLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tpOrderDetail.ResumeLayout(false);
            this.tpOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).EndInit();
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList3)).EndInit();
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
        private System.Windows.Forms.Button button1;
    }
}