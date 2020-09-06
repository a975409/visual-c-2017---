namespace Off
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblPay = new System.Windows.Forms.Label();
            this.TxtBuy = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入消費金額：";
            // 
            // LblPay
            // 
            this.LblPay.AutoSize = true;
            this.LblPay.Location = new System.Drawing.Point(23, 65);
            this.LblPay.Name = "LblPay";
            this.LblPay.Size = new System.Drawing.Size(65, 12);
            this.LblPay.TabIndex = 0;
            this.LblPay.Text = "實付金額：";
            // 
            // TxtBuy
            // 
            this.TxtBuy.Location = new System.Drawing.Point(118, 27);
            this.TxtBuy.Name = "TxtBuy";
            this.TxtBuy.Size = new System.Drawing.Size(100, 22);
            this.TxtBuy.TabIndex = 1;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(178, 60);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 106);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtBuy);
            this.Controls.Add(this.LblPay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPay;
        private System.Windows.Forms.TextBox TxtBuy;
        private System.Windows.Forms.Button BtnOK;
    }
}

