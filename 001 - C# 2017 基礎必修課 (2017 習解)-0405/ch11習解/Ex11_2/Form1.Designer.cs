namespace Ex11_2
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Rtxt = new System.Windows.Forms.RichTextBox();
            this.BtnFile = new System.Windows.Forms.Button();
            this.BtnCancelItem = new System.Windows.Forms.Button();
            this.BtnItem = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Rtxt
            // 
            this.Rtxt.Location = new System.Drawing.Point(12, 51);
            this.Rtxt.Name = "Rtxt";
            this.Rtxt.Size = new System.Drawing.Size(399, 198);
            this.Rtxt.TabIndex = 12;
            this.Rtxt.Text = "";
            // 
            // BtnFile
            // 
            this.BtnFile.Location = new System.Drawing.Point(337, 12);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(75, 23);
            this.BtnFile.TabIndex = 17;
            this.BtnFile.Text = "載入檔案";
            this.BtnFile.UseVisualStyleBackColor = true;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // BtnCancelItem
            // 
            this.BtnCancelItem.Location = new System.Drawing.Point(256, 12);
            this.BtnCancelItem.Name = "BtnCancelItem";
            this.BtnCancelItem.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelItem.TabIndex = 16;
            this.BtnCancelItem.Text = "取消項目";
            this.BtnCancelItem.UseVisualStyleBackColor = true;
            this.BtnCancelItem.Click += new System.EventHandler(this.BtnCancelItem_Click);
            // 
            // BtnItem
            // 
            this.BtnItem.Location = new System.Drawing.Point(175, 12);
            this.BtnItem.Name = "BtnItem";
            this.BtnItem.Size = new System.Drawing.Size(75, 23);
            this.BtnItem.TabIndex = 15;
            this.BtnItem.Text = "設定項目";
            this.BtnItem.UseVisualStyleBackColor = true;
            this.BtnItem.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(94, 12);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(75, 23);
            this.BtnColor.TabIndex = 14;
            this.BtnColor.Text = "設定色彩";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnFont
            // 
            this.BtnFont.Location = new System.Drawing.Point(13, 12);
            this.BtnFont.Name = "BtnFont";
            this.BtnFont.Size = new System.Drawing.Size(75, 23);
            this.BtnFont.TabIndex = 13;
            this.BtnFont.Text = " 設定字型";
            this.BtnFont.UseVisualStyleBackColor = true;
            this.BtnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 261);
            this.Controls.Add(this.BtnFile);
            this.Controls.Add(this.BtnCancelItem);
            this.Controls.Add(this.BtnItem);
            this.Controls.Add(this.BtnColor);
            this.Controls.Add(this.BtnFont);
            this.Controls.Add(this.Rtxt);
            this.Name = "Form1";
            this.Text = "簡易文書編輯器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox Rtxt;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Button BtnCancelItem;
        private System.Windows.Forms.Button BtnItem;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnFont;
    }
}

