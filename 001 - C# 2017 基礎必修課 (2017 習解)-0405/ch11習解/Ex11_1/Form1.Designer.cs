namespace Ex11_1
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
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnBColor = new System.Windows.Forms.Button();
            this.BtnFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.ShowColor = true;
            this.fontDialog1.ShowHelp = true;
            // 
            // LblMsg
            // 
            this.LblMsg.Location = new System.Drawing.Point(12, 19);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(200, 67);
            this.LblMsg.TabIndex = 4;
            this.LblMsg.Text = "label1";
            this.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBColor
            // 
            this.BtnBColor.Location = new System.Drawing.Point(121, 108);
            this.BtnBColor.Name = "BtnBColor";
            this.BtnBColor.Size = new System.Drawing.Size(85, 23);
            this.BtnBColor.TabIndex = 7;
            this.BtnBColor.Text = "設定背景顏色";
            this.BtnBColor.UseVisualStyleBackColor = true;
            this.BtnBColor.Click += new System.EventHandler(this.BtnBColor_Click);
            // 
            // BtnFont
            // 
            this.BtnFont.Location = new System.Drawing.Point(20, 108);
            this.BtnFont.Name = "BtnFont";
            this.BtnFont.Size = new System.Drawing.Size(84, 23);
            this.BtnFont.TabIndex = 6;
            this.BtnFont.Text = "設定字型";
            this.BtnFont.UseVisualStyleBackColor = true;
            this.BtnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 143);
            this.Controls.Add(this.BtnBColor);
            this.Controls.Add(this.BtnFont);
            this.Controls.Add(this.LblMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Button BtnBColor;
        private System.Windows.Forms.Button BtnFont;
    }
}

