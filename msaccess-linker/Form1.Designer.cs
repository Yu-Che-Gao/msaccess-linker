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
            this.importDB = new System.Windows.Forms.Button();
            this.previewTableGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.connComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.schemaPageOpenBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.schemaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridView)).BeginInit();
            this.存取資料表.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewTableGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTableBtn
            // 
            this.addTableBtn.Location = new System.Drawing.Point(120, 147);
            this.addTableBtn.Name = "addTableBtn";
            this.addTableBtn.Size = new System.Drawing.Size(121, 23);
            this.addTableBtn.TabIndex = 0;
            this.addTableBtn.Text = "新增資料表";
            this.addTableBtn.UseVisualStyleBackColor = true;
            this.addTableBtn.Click += new System.EventHandler(this.addTableBtn_Click);
            // 
            // schemaComboBox
            // 
            this.schemaComboBox.FormattingEnabled = true;
            this.schemaComboBox.Location = new System.Drawing.Point(120, 32);
            this.schemaComboBox.Name = "schemaComboBox";
            this.schemaComboBox.Size = new System.Drawing.Size(121, 20);
            this.schemaComboBox.TabIndex = 3;
            this.schemaComboBox.SelectedIndexChanged += new System.EventHandler(this.schemaComboBox_SelectedIndexChanged);
            // 
            // newTableText
            // 
            this.newTableText.Location = new System.Drawing.Point(120, 94);
            this.newTableText.Name = "newTableText";
            this.newTableText.Size = new System.Drawing.Size(121, 22);
            this.newTableText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "新資料表名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
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
            this.groupBox1.Location = new System.Drawing.Point(287, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 188);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增資料表";
            // 
            // schemaNameText
            // 
            this.schemaNameText.Location = new System.Drawing.Point(120, 40);
            this.schemaNameText.Name = "schemaNameText";
            this.schemaNameText.Size = new System.Drawing.Size(121, 22);
            this.schemaNameText.TabIndex = 9;
            // 
            // schemaContentText
            // 
            this.schemaContentText.Location = new System.Drawing.Point(120, 82);
            this.schemaContentText.Name = "schemaContentText";
            this.schemaContentText.Size = new System.Drawing.Size(121, 22);
            this.schemaContentText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "模組名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "模組語法";
            // 
            // addSchemaBtn
            // 
            this.addSchemaBtn.Location = new System.Drawing.Point(120, 128);
            this.addSchemaBtn.Name = "addSchemaBtn";
            this.addSchemaBtn.Size = new System.Drawing.Size(121, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(287, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 173);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "快速新增模組";
            // 
            // tableGridView
            // 
            this.tableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGridView.Location = new System.Drawing.Point(23, 88);
            this.tableGridView.Name = "tableGridView";
            this.tableGridView.RowTemplate.Height = 24;
            this.tableGridView.Size = new System.Drawing.Size(300, 134);
            this.tableGridView.TabIndex = 13;
            // 
            // tableSelectComboBox
            // 
            this.tableSelectComboBox.FormattingEnabled = true;
            this.tableSelectComboBox.Location = new System.Drawing.Point(23, 50);
            this.tableSelectComboBox.Name = "tableSelectComboBox";
            this.tableSelectComboBox.Size = new System.Drawing.Size(121, 20);
            this.tableSelectComboBox.TabIndex = 14;
            this.tableSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.tableSelectComboBox_SelectedIndexChanged);
            // 
            // 存取資料表
            // 
            this.存取資料表.Controls.Add(this.tabPage1);
            this.存取資料表.Controls.Add(this.tabPage2);
            this.存取資料表.Location = new System.Drawing.Point(12, 12);
            this.存取資料表.Name = "存取資料表";
            this.存取資料表.SelectedIndex = 0;
            this.存取資料表.Size = new System.Drawing.Size(973, 641);
            this.存取資料表.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.schemaPageOpenBtn);
            this.tabPage1.Controls.Add(this.importDB);
            this.tabPage1.Controls.Add(this.previewTableGridView);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.connComboBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(965, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "管理資料庫";
            // 
            // importDB
            // 
            this.importDB.Location = new System.Drawing.Point(23, 53);
            this.importDB.Name = "importDB";
            this.importDB.Size = new System.Drawing.Size(224, 23);
            this.importDB.TabIndex = 3;
            this.importDB.Text = "匯入access檔案";
            this.importDB.UseVisualStyleBackColor = true;
            // 
            // previewTableGridView
            // 
            this.previewTableGridView.AllowUserToAddRows = false;
            this.previewTableGridView.AllowUserToDeleteRows = false;
            this.previewTableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previewTableGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.previewTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previewTableGridView.Location = new System.Drawing.Point(23, 93);
            this.previewTableGridView.Name = "previewTableGridView";
            this.previewTableGridView.ReadOnly = true;
            this.previewTableGridView.RowTemplate.Height = 24;
            this.previewTableGridView.Size = new System.Drawing.Size(224, 511);
            this.previewTableGridView.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "目前連線資料庫";
            // 
            // connComboBox
            // 
            this.connComboBox.FormattingEnabled = true;
            this.connComboBox.Location = new System.Drawing.Point(116, 27);
            this.connComboBox.Name = "connComboBox";
            this.connComboBox.Size = new System.Drawing.Size(131, 20);
            this.connComboBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tableSelectComboBox);
            this.tabPage2.Controls.Add(this.tableGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "資料檢視";
            // 
            // schemaPageOpenBtn
            // 
            this.schemaPageOpenBtn.Location = new System.Drawing.Point(287, 432);
            this.schemaPageOpenBtn.Name = "schemaPageOpenBtn";
            this.schemaPageOpenBtn.Size = new System.Drawing.Size(328, 172);
            this.schemaPageOpenBtn.TabIndex = 13;
            this.schemaPageOpenBtn.Text = "模組管理";
            this.schemaPageOpenBtn.UseVisualStyleBackColor = true;
            this.schemaPageOpenBtn.Click += new System.EventHandler(this.schemaPageOpenBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(266, 550);
            this.dataGridView1.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(656, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 577);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "新資料表預覽";
            // 
            // schemaLabel
            // 
            this.schemaLabel.AutoSize = true;
            this.schemaLabel.Location = new System.Drawing.Point(26, 66);
            this.schemaLabel.Name = "schemaLabel";
            this.schemaLabel.Size = new System.Drawing.Size(0, 12);
            this.schemaLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 663);
            this.Controls.Add(this.存取資料表);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.Button importDB;
        private System.Windows.Forms.Button schemaPageOpenBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label schemaLabel;
    }
}

