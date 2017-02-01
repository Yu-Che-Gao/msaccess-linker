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
            this.tableNameText = new System.Windows.Forms.TextBox();
            this.schemaText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addTableBtn
            // 
            this.addTableBtn.Location = new System.Drawing.Point(80, 58);
            this.addTableBtn.Name = "addTableBtn";
            this.addTableBtn.Size = new System.Drawing.Size(75, 23);
            this.addTableBtn.TabIndex = 0;
            this.addTableBtn.Text = "新增資料表";
            this.addTableBtn.UseVisualStyleBackColor = true;
            this.addTableBtn.Click += new System.EventHandler(this.addTableBtn_Click);
            // 
            // tableNameText
            // 
            this.tableNameText.Location = new System.Drawing.Point(260, 93);
            this.tableNameText.Name = "tableNameText";
            this.tableNameText.Size = new System.Drawing.Size(100, 22);
            this.tableNameText.TabIndex = 1;
            // 
            // schemaText
            // 
            this.schemaText.Location = new System.Drawing.Point(260, 166);
            this.schemaText.Name = "schemaText";
            this.schemaText.Size = new System.Drawing.Size(100, 22);
            this.schemaText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 489);
            this.Controls.Add(this.schemaText);
            this.Controls.Add(this.tableNameText);
            this.Controls.Add(this.addTableBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTableBtn;
        private System.Windows.Forms.TextBox tableNameText;
        private System.Windows.Forms.TextBox schemaText;
    }
}

