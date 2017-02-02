namespace msaccess_linker
{
    partial class SchemaManagePage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fieldNameTextBox = new System.Windows.Forms.TextBox();
            this.AddFieldBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.schemaNameTextBox = new System.Windows.Forms.TextBox();
            this.left2RightBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.schemaListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fieldNameTextBox);
            this.groupBox1.Controls.Add(this.AddFieldBtn);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.schemaNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(359, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "定義模組";
            // 
            // fieldNameTextBox
            // 
            this.fieldNameTextBox.Location = new System.Drawing.Point(40, 404);
            this.fieldNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fieldNameTextBox.Name = "fieldNameTextBox";
            this.fieldNameTextBox.Size = new System.Drawing.Size(171, 29);
            this.fieldNameTextBox.TabIndex = 4;
            // 
            // AddFieldBtn
            // 
            this.AddFieldBtn.Location = new System.Drawing.Point(220, 400);
            this.AddFieldBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddFieldBtn.Name = "AddFieldBtn";
            this.AddFieldBtn.Size = new System.Drawing.Size(94, 34);
            this.AddFieldBtn.TabIndex = 3;
            this.AddFieldBtn.Text = "新增欄位";
            this.AddFieldBtn.UseVisualStyleBackColor = true;
            this.AddFieldBtn.Click += new System.EventHandler(this.AddFieldBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(274, 312);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "模組名稱";
            // 
            // schemaNameTextBox
            // 
            this.schemaNameTextBox.Location = new System.Drawing.Point(150, 32);
            this.schemaNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schemaNameTextBox.Name = "schemaNameTextBox";
            this.schemaNameTextBox.Size = new System.Drawing.Size(164, 29);
            this.schemaNameTextBox.TabIndex = 0;
            // 
            // left2RightBtn
            // 
            this.left2RightBtn.Location = new System.Drawing.Point(417, 259);
            this.left2RightBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.left2RightBtn.Name = "left2RightBtn";
            this.left2RightBtn.Size = new System.Drawing.Size(96, 39);
            this.left2RightBtn.TabIndex = 1;
            this.left2RightBtn.Text = ">";
            this.left2RightBtn.UseVisualStyleBackColor = true;
            this.left2RightBtn.Click += new System.EventHandler(this.left2RightBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.schemaListBox);
            this.groupBox2.Location = new System.Drawing.Point(548, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(473, 453);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "現有模組";
            // 
            // schemaListBox
            // 
            this.schemaListBox.FormattingEnabled = true;
            this.schemaListBox.ItemHeight = 20;
            this.schemaListBox.Location = new System.Drawing.Point(27, 35);
            this.schemaListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schemaListBox.Name = "schemaListBox";
            this.schemaListBox.Size = new System.Drawing.Size(434, 404);
            this.schemaListBox.TabIndex = 0;
            // 
            // SchemaManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.left2RightBtn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SchemaManagePage";
            this.Text = "模組管理";
            this.Load += new System.EventHandler(this.SchemaManagePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox schemaNameTextBox;
        private System.Windows.Forms.Button left2RightBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox schemaListBox;
        private System.Windows.Forms.TextBox fieldNameTextBox;
        private System.Windows.Forms.Button AddFieldBtn;
    }
}