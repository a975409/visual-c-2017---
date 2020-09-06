namespace ex06_05
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
            this.ClbStyle = new System.Windows.Forms.CheckedListBox();
            this.LblWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClbStyle
            // 
            this.ClbStyle.FormattingEnabled = true;
            this.ClbStyle.Location = new System.Drawing.Point(210, 24);
            this.ClbStyle.Name = "ClbStyle";
            this.ClbStyle.Size = new System.Drawing.Size(76, 72);
            this.ClbStyle.TabIndex = 13;
            this.ClbStyle.SelectedIndexChanged += new System.EventHandler(this.ClbStyle_SelectedIndexChanged);
            // 
            // LblWord
            // 
            this.LblWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblWord.Font = new System.Drawing.Font("新細明體", 20F);
            this.LblWord.Location = new System.Drawing.Point(18, 24);
            this.LblWord.Name = "LblWord";
            this.LblWord.Size = new System.Drawing.Size(186, 57);
            this.LblWord.TabIndex = 12;
            this.LblWord.Text = "Visual C#";
            this.LblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 121);
            this.Controls.Add(this.ClbStyle);
            this.Controls.Add(this.LblWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.CheckedListBox ClbStyle;
        internal System.Windows.Forms.Label LblWord;
    }
}

