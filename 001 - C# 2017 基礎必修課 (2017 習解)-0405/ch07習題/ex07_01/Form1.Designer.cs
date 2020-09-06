namespace ex07_01
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
            this.Label1 = new System.Windows.Forms.Label();
            this.LlblCalc = new System.Windows.Forms.LinkLabel();
            this.LlblEmail = new System.Windows.Forms.LinkLabel();
            this.LlblGoogle = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 12);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "請選擇超連結";
            // 
            // LlblCalc
            // 
            this.LlblCalc.AutoSize = true;
            this.LlblCalc.Location = new System.Drawing.Point(47, 142);
            this.LlblCalc.Name = "LlblCalc";
            this.LlblCalc.Size = new System.Drawing.Size(41, 12);
            this.LlblCalc.TabIndex = 18;
            this.LlblCalc.TabStop = true;
            this.LlblCalc.Text = "小算盤";
            this.LlblCalc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblCalc_LinkClicked);
            // 
            // LlblEmail
            // 
            this.LlblEmail.AutoSize = true;
            this.LlblEmail.Location = new System.Drawing.Point(47, 95);
            this.LlblEmail.Name = "LlblEmail";
            this.LlblEmail.Size = new System.Drawing.Size(53, 12);
            this.LlblEmail.TabIndex = 17;
            this.LlblEmail.TabStop = true;
            this.LlblEmail.Text = "寫信給我";
            this.LlblEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblEmail_LinkClicked);
            // 
            // LlblGoogle
            // 
            this.LlblGoogle.AutoSize = true;
            this.LlblGoogle.Location = new System.Drawing.Point(47, 49);
            this.LlblGoogle.Name = "LlblGoogle";
            this.LlblGoogle.Size = new System.Drawing.Size(63, 12);
            this.LlblGoogle.TabIndex = 16;
            this.LlblGoogle.TabStop = true;
            this.LlblGoogle.Text = "Google網站";
            this.LlblGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblGoogle_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 191);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LlblCalc);
            this.Controls.Add(this.LlblEmail);
            this.Controls.Add(this.LlblGoogle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.LinkLabel LlblCalc;
        internal System.Windows.Forms.LinkLabel LlblEmail;
        internal System.Windows.Forms.LinkLabel LlblGoogle;
    }
}

