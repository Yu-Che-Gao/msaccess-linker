namespace msaccess_linker
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.addTableBtn = new System.Windows.Forms.Button();
            this.schemaComboBox = new System.Windows.Forms.ComboBox();
            this.newTableText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.schemaLabel = new System.Windows.Forms.Label();
            this.schemaNameText = new System.Windows.Forms.TextBox();
            this.schemaContentText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addSchemaBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableGridView = new System.Windows.Forms.DataGridView();
            this.tableSelectComboBox = new System.Windows.Forms.ComboBox();
            this.存取資料表 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.exportDBBtn = new System.Windows.Forms.Button();
            this.schemaPageOpenBtn = new System.Windows.Forms.Button();
            this.importDBBtn = new System.Windows.Forms.Button();
            this.previewTableGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.connComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.simpleQuery = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.editPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.updateEditBtn = new System.Windows.Forms.Button();
            this.insertEditBtn = new System.Windows.Forms.Button();
            this.clearEditBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.queryShowGridView = new System.Windows.Forms.DataGridView();
            this.selectProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.antennaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.componentNumTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.openAccessDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveAccessDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridView)).BeginInit();
            this.存取資料表.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewTableGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryShowGridView)).BeginInit();
            this.selectProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTableBtn
            // 
            this.addTableBtn.Location = new System.Drawing.Point(156, 198);
            this.addTableBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTableBtn.Name = "addTableBtn";
            this.addTableBtn.Size = new System.Drawing.Size(198, 38);
            this.addTableBtn.TabIndex = 0;
            this.addTableBtn.Text = "新增資料表";
            this.addTableBtn.UseVisualStyleBackColor = true;
            this.addTableBtn.Click += new System.EventHandler(this.addTableBtn_Click);
            // 
            // schemaComboBox
            // 
            this.schemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemaComboBox.FormattingEnabled = true;
            this.schemaComboBox.Location = new System.Drawing.Point(156, 55);
            this.schemaComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schemaComboBox.Name = "schemaComboBox";
            this.schemaComboBox.Size = new System.Drawing.Size(198, 28);
            this.schemaComboBox.TabIndex = 3;
            this.schemaComboBox.SelectedIndexChanged += new System.EventHandler(this.schemaComboBox_SelectedIndexChanged);
            // 
            // newTableText
            // 
            this.newTableText.Location = new System.Drawing.Point(156, 159);
            this.newTableText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newTableText.Name = "newTableText";
            this.newTableText.Size = new System.Drawing.Size(198, 29);
            this.newTableText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "新資料表名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "選擇欄位模組";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.schemaLabel);
            this.groupBox1.Controls.Add(this.schemaComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addTableBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.newTableText);
            this.groupBox1.Location = new System.Drawing.Point(420, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(373, 247);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增資料表";
            // 
            // schemaLabel
            // 
            this.schemaLabel.AutoSize = true;
            this.schemaLabel.Location = new System.Drawing.Point(43, 110);
            this.schemaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schemaLabel.Name = "schemaLabel";
            this.schemaLabel.Size = new System.Drawing.Size(0, 20);
            this.schemaLabel.TabIndex = 8;
            // 
            // schemaNameText
            // 
            this.schemaNameText.Location = new System.Drawing.Point(129, 49);
            this.schemaNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schemaNameText.Name = "schemaNameText";
            this.schemaNameText.Size = new System.Drawing.Size(198, 29);
            this.schemaNameText.TabIndex = 9;
            // 
            // schemaContentText
            // 
            this.schemaContentText.Location = new System.Drawing.Point(129, 119);
            this.schemaContentText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schemaContentText.Name = "schemaContentText";
            this.schemaContentText.Size = new System.Drawing.Size(198, 29);
            this.schemaContentText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "模組名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "模組語法";
            // 
            // addSchemaBtn
            // 
            this.addSchemaBtn.Location = new System.Drawing.Point(129, 158);
            this.addSchemaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addSchemaBtn.Name = "addSchemaBtn";
            this.addSchemaBtn.Size = new System.Drawing.Size(198, 38);
            this.addSchemaBtn.TabIndex = 8;
            this.addSchemaBtn.Text = "新增模組";
            this.addSchemaBtn.UseVisualStyleBackColor = true;
            this.addSchemaBtn.Click += new System.EventHandler(this.addSchemaBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.schemaNameText);
            this.groupBox2.Controls.Add(this.addSchemaBtn);
            this.groupBox2.Controls.Add(this.schemaContentText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(810, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(351, 238);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "快速新增模組";
            // 
            // tableGridView
            // 
            this.tableGridView.AllowUserToAddRows = false;
            this.tableGridView.AllowUserToDeleteRows = false;
            this.tableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGridView.Location = new System.Drawing.Point(33, 80);
            this.tableGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableGridView.Name = "tableGridView";
            this.tableGridView.ReadOnly = true;
            this.tableGridView.RowTemplate.Height = 24;
            this.tableGridView.Size = new System.Drawing.Size(768, 327);
            this.tableGridView.TabIndex = 13;
            this.tableGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableGridView_CellMouseClick);
            // 
            // tableSelectComboBox
            // 
            this.tableSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableSelectComboBox.FormattingEnabled = true;
            this.tableSelectComboBox.Location = new System.Drawing.Point(125, 22);
            this.tableSelectComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableSelectComboBox.Name = "tableSelectComboBox";
            this.tableSelectComboBox.Size = new System.Drawing.Size(198, 28);
            this.tableSelectComboBox.TabIndex = 14;
            this.tableSelectComboBox.SelectedValueChanged += new System.EventHandler(this.tableSelectComboBox_SelectedValueChanged);
            // 
            // 存取資料表
            // 
            this.存取資料表.Controls.Add(this.tabPage1);
            this.存取資料表.Controls.Add(this.tabPage2);
            this.存取資料表.Controls.Add(this.tabPage3);
            this.存取資料表.Controls.Add(this.tabPage4);
            this.存取資料表.Location = new System.Drawing.Point(24, 18);
            this.存取資料表.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.存取資料表.Name = "存取資料表";
            this.存取資料表.SelectedIndex = 0;
            this.存取資料表.Size = new System.Drawing.Size(1160, 462);
            this.存取資料表.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.exportDBBtn);
            this.tabPage1.Controls.Add(this.schemaPageOpenBtn);
            this.tabPage1.Controls.Add(this.importDBBtn);
            this.tabPage1.Controls.Add(this.previewTableGridView);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.connComboBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1152, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "管理資料庫";
            // 
            // exportDBBtn
            // 
            this.exportDBBtn.Location = new System.Drawing.Point(22, 96);
            this.exportDBBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exportDBBtn.Name = "exportDBBtn";
            this.exportDBBtn.Size = new System.Drawing.Size(373, 38);
            this.exportDBBtn.TabIndex = 14;
            this.exportDBBtn.Text = "匯出access檔案";
            this.exportDBBtn.UseVisualStyleBackColor = true;
            this.exportDBBtn.Click += new System.EventHandler(this.exportDBBtn_Click);
            // 
            // schemaPageOpenBtn
            // 
            this.schemaPageOpenBtn.Location = new System.Drawing.Point(420, 267);
            this.schemaPageOpenBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schemaPageOpenBtn.Name = "schemaPageOpenBtn";
            this.schemaPageOpenBtn.Size = new System.Drawing.Size(741, 148);
            this.schemaPageOpenBtn.TabIndex = 13;
            this.schemaPageOpenBtn.Text = "模組管理";
            this.schemaPageOpenBtn.UseVisualStyleBackColor = true;
            this.schemaPageOpenBtn.Click += new System.EventHandler(this.schemaPageOpenBtn_Click);
            // 
            // importDBBtn
            // 
            this.importDBBtn.Location = new System.Drawing.Point(22, 48);
            this.importDBBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.importDBBtn.Name = "importDBBtn";
            this.importDBBtn.Size = new System.Drawing.Size(373, 38);
            this.importDBBtn.TabIndex = 3;
            this.importDBBtn.Text = "匯入access檔案";
            this.importDBBtn.UseVisualStyleBackColor = true;
            this.importDBBtn.Click += new System.EventHandler(this.importDBBtn_Click);
            // 
            // previewTableGridView
            // 
            this.previewTableGridView.AllowUserToAddRows = false;
            this.previewTableGridView.AllowUserToDeleteRows = false;
            this.previewTableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previewTableGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.previewTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previewTableGridView.Location = new System.Drawing.Point(22, 155);
            this.previewTableGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previewTableGridView.Name = "previewTableGridView";
            this.previewTableGridView.ReadOnly = true;
            this.previewTableGridView.RowTemplate.Height = 24;
            this.previewTableGridView.Size = new System.Drawing.Size(373, 260);
            this.previewTableGridView.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "目前連線資料庫";
            // 
            // connComboBox
            // 
            this.connComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connComboBox.FormattingEnabled = true;
            this.connComboBox.Location = new System.Drawing.Point(179, 10);
            this.connComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connComboBox.Name = "connComboBox";
            this.connComboBox.Size = new System.Drawing.Size(216, 28);
            this.connComboBox.TabIndex = 0;
            this.connComboBox.SelectedValueChanged += new System.EventHandler(this.connComboBox_SelectedValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.simpleQuery);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tableSelectComboBox);
            this.tabPage2.Controls.Add(this.tableGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1152, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "資料檢視";
            // 
            // simpleQuery
            // 
            this.simpleQuery.Enabled = false;
            this.simpleQuery.Location = new System.Drawing.Point(488, 21);
            this.simpleQuery.Name = "simpleQuery";
            this.simpleQuery.Size = new System.Drawing.Size(140, 29);
            this.simpleQuery.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "快速查詢";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.editPanel);
            this.groupBox3.Controls.Add(this.updateEditBtn);
            this.groupBox3.Controls.Add(this.insertEditBtn);
            this.groupBox3.Controls.Add(this.clearEditBtn);
            this.groupBox3.Location = new System.Drawing.Point(824, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 385);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "編輯區";
            // 
            // editPanel
            // 
            this.editPanel.AutoScroll = true;
            this.editPanel.Location = new System.Drawing.Point(23, 29);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(258, 303);
            this.editPanel.TabIndex = 4;
            // 
            // updateEditBtn
            // 
            this.updateEditBtn.Enabled = false;
            this.updateEditBtn.Location = new System.Drawing.Point(200, 338);
            this.updateEditBtn.Name = "updateEditBtn";
            this.updateEditBtn.Size = new System.Drawing.Size(81, 30);
            this.updateEditBtn.TabIndex = 3;
            this.updateEditBtn.Text = "更改資料";
            this.updateEditBtn.UseVisualStyleBackColor = true;
            this.updateEditBtn.Click += new System.EventHandler(this.updateEditBtn_Click);
            // 
            // insertEditBtn
            // 
            this.insertEditBtn.Location = new System.Drawing.Point(111, 338);
            this.insertEditBtn.Name = "insertEditBtn";
            this.insertEditBtn.Size = new System.Drawing.Size(82, 30);
            this.insertEditBtn.TabIndex = 2;
            this.insertEditBtn.Text = "新增資料";
            this.insertEditBtn.UseVisualStyleBackColor = true;
            this.insertEditBtn.Click += new System.EventHandler(this.insertEditBtn_Click);
            // 
            // clearEditBtn
            // 
            this.clearEditBtn.Location = new System.Drawing.Point(23, 338);
            this.clearEditBtn.Name = "clearEditBtn";
            this.clearEditBtn.Size = new System.Drawing.Size(82, 30);
            this.clearEditBtn.TabIndex = 1;
            this.clearEditBtn.Text = "清除內容";
            this.clearEditBtn.UseVisualStyleBackColor = true;
            this.clearEditBtn.Click += new System.EventHandler(this.clearEditBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "資料表名稱";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.selectProductPanel);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1152, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "庫存查詢";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.queryShowGridView);
            this.groupBox4.Location = new System.Drawing.Point(301, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(642, 316);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "結果顯示區";
            // 
            // queryShowGridView
            // 
            this.queryShowGridView.AllowUserToAddRows = false;
            this.queryShowGridView.AllowUserToDeleteRows = false;
            this.queryShowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryShowGridView.Location = new System.Drawing.Point(31, 32);
            this.queryShowGridView.Name = "queryShowGridView";
            this.queryShowGridView.ReadOnly = true;
            this.queryShowGridView.RowTemplate.Height = 24;
            this.queryShowGridView.Size = new System.Drawing.Size(593, 265);
            this.queryShowGridView.TabIndex = 7;
            // 
            // selectProductPanel
            // 
            this.selectProductPanel.Controls.Add(this.label9);
            this.selectProductPanel.Controls.Add(this.companyNameTextBox);
            this.selectProductPanel.Controls.Add(this.label10);
            this.selectProductPanel.Controls.Add(this.antennaTextBox);
            this.selectProductPanel.Controls.Add(this.label8);
            this.selectProductPanel.Controls.Add(this.componentNumTextBox);
            this.selectProductPanel.Location = new System.Drawing.Point(21, 26);
            this.selectProductPanel.Name = "selectProductPanel";
            this.selectProductPanel.Size = new System.Drawing.Size(205, 233);
            this.selectProductPanel.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "廠商名稱";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.companyNameTextBox.Location = new System.Drawing.Point(82, 3);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 29);
            this.companyNameTextBox.TabIndex = 3;
            this.companyNameTextBox.TextChanged += new System.EventHandler(this.companyNameTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "天線編號";
            // 
            // antennaTextBox
            // 
            this.antennaTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.antennaTextBox.Location = new System.Drawing.Point(82, 38);
            this.antennaTextBox.Name = "antennaTextBox";
            this.antennaTextBox.Size = new System.Drawing.Size(100, 29);
            this.antennaTextBox.TabIndex = 4;
            this.antennaTextBox.TextChanged += new System.EventHandler(this.antennaTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "零件編號";
            // 
            // componentNumTextBox
            // 
            this.componentNumTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.componentNumTextBox.Location = new System.Drawing.Point(82, 73);
            this.componentNumTextBox.Name = "componentNumTextBox";
            this.componentNumTextBox.Size = new System.Drawing.Size(100, 29);
            this.componentNumTextBox.TabIndex = 0;
            this.componentNumTextBox.TextChanged += new System.EventHandler(this.componentNumTextBox_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1152, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "版本資訊";
            // 
            // openAccessDialog
            // 
            this.openAccessDialog.FileName = "openFileDialog1";
            this.openAccessDialog.Filter = "Access檔案(*.mdb)|";
            // 
            // saveAccessDialog
            // 
            this.saveAccessDialog.Filter = "Access檔案(*.mdb)|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 494);
            this.Controls.Add(this.存取資料表);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "庫存管理系統";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridView)).EndInit();
            this.存取資料表.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewTableGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryShowGridView)).EndInit();
            this.selectProductPanel.ResumeLayout(false);
            this.selectProductPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTableBtn;
        private System.Windows.Forms.ComboBox schemaComboBox;
        private System.Windows.Forms.TextBox newTableText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox schemaNameText;
        private System.Windows.Forms.TextBox schemaContentText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addSchemaBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tableGridView;
        private System.Windows.Forms.ComboBox tableSelectComboBox;
        private System.Windows.Forms.TabControl 存取資料表;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox connComboBox;
        private System.Windows.Forms.DataGridView previewTableGridView;
        private System.Windows.Forms.Button importDBBtn;
        private System.Windows.Forms.Button schemaPageOpenBtn;
        private System.Windows.Forms.Label schemaLabel;
        private System.Windows.Forms.Button exportDBBtn;
        private System.Windows.Forms.OpenFileDialog openAccessDialog;
        private System.Windows.Forms.SaveFileDialog saveAccessDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updateEditBtn;
        private System.Windows.Forms.Button insertEditBtn;
        private System.Windows.Forms.Button clearEditBtn;
        private System.Windows.Forms.FlowLayoutPanel editPanel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox simpleQuery;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel selectProductPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox antennaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox componentNumTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView queryShowGridView;
    }
}

