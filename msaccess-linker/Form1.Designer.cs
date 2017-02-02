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
            this.schemaLabel = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addTableBtn
            // 
            this.addTableBtn.Location = new System.Drawing.Point(109, 104);
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
            this.schemaComboBox.Location = new System.Drawing.Point(109, 32);
            this.schemaComboBox.Name = "schemaComboBox";
            this.schemaComboBox.Size = new System.Drawing.Size(121, 20);
            this.schemaComboBox.TabIndex = 3;
            this.schemaComboBox.SelectedIndexChanged += new System.EventHandler(this.schemaComboBox_SelectedIndexChanged);
            // 
            // schemaLabel
            // 
            this.schemaLabel.AutoSize = true;
            this.schemaLabel.Location = new System.Drawing.Point(256, 35);
            this.schemaLabel.Name = "schemaLabel";
            this.schemaLabel.Size = new System.Drawing.Size(33, 12);
            this.schemaLabel.TabIndex = 4;
            this.schemaLabel.Text = "label1";
            // 
            // newTableText
            // 
            this.newTableText.Location = new System.Drawing.Point(109, 66);
            this.newTableText.Name = "newTableText";
            this.newTableText.Size = new System.Drawing.Size(121, 22);
            this.newTableText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 76);
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
            this.groupBox1.Controls.Add(this.schemaComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addTableBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.schemaLabel);
            this.groupBox1.Controls.Add(this.newTableText);
            this.groupBox1.Location = new System.Drawing.Point(26, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 155);
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
            this.label4.Text = "模組內容";
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
            this.groupBox2.Location = new System.Drawing.Point(26, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 173);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新增模組";
            // 
            // tableGridView
            // 
            this.tableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGridView.Location = new System.Drawing.Point(54, 509);
            this.tableGridView.Name = "tableGridView";
            this.tableGridView.RowTemplate.Height = 24;
            this.tableGridView.Size = new System.Drawing.Size(369, 134);
            this.tableGridView.TabIndex = 13;
            // 
            // tableSelectComboBox
            // 
            this.tableSelectComboBox.FormattingEnabled = true;
            this.tableSelectComboBox.Location = new System.Drawing.Point(54, 471);
            this.tableSelectComboBox.Name = "tableSelectComboBox";
            this.tableSelectComboBox.Size = new System.Drawing.Size(121, 20);
            this.tableSelectComboBox.TabIndex = 14;
            this.tableSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.tableSelectComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 687);
            this.Controls.Add(this.tableSelectComboBox);
            this.Controls.Add(this.tableGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTableBtn;
        private System.Windows.Forms.ComboBox schemaComboBox;
        private System.Windows.Forms.Label schemaLabel;
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
    }
}

