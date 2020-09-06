namespace switch01
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
            this.LblIncome = new System.Windows.Forms.Label();
            this.LblGrade = new System.Windows.Forms.Label();
            this.LblTaxRate = new System.Windows.Forms.Label();
            this.LblDiscount = new System.Windows.Forms.Label();
            this.LblTax = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.TxtNetIncome = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "****所得稅試算表****";
            // 
            // LblIncome
            // 
            this.LblIncome.AutoSize = true;
            this.LblIncome.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblIncome.Location = new System.Drawing.Point(27, 98);
            this.LblIncome.Name = "LblIncome";
            this.LblIncome.Size = new System.Drawing.Size(195, 24);
            this.LblIncome.TabIndex = 1;
            this.LblIncome.Text = "1.全年所得淨額：";
            // 
            // LblGrade
            // 
            this.LblGrade.AutoSize = true;
            this.LblGrade.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblGrade.Location = new System.Drawing.Point(27, 141);
            this.LblGrade.Name = "LblGrade";
            this.LblGrade.Size = new System.Drawing.Size(135, 24);
            this.LblGrade.TabIndex = 1;
            this.LblGrade.Text = "2.級      距：";
            // 
            // LblTaxRate
            // 
            this.LblTaxRate.AutoSize = true;
            this.LblTaxRate.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblTaxRate.Location = new System.Drawing.Point(27, 184);
            this.LblTaxRate.Name = "LblTaxRate";
            this.LblTaxRate.Size = new System.Drawing.Size(147, 24);
            this.LblTaxRate.TabIndex = 1;
            this.LblTaxRate.Text = "3.所得稅率：";
            // 
            // LblDiscount
            // 
            this.LblDiscount.AutoSize = true;
            this.LblDiscount.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblDiscount.Location = new System.Drawing.Point(27, 227);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(147, 24);
            this.LblDiscount.TabIndex = 1;
            this.LblDiscount.Text = "4.累進差額：";
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblTax.Location = new System.Drawing.Point(27, 270);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(147, 24);
            this.LblTax.TabIndex = 1;
            this.LblTax.Text = "5.應繳稅額：";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(29, 316);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(65, 12);
            this.LblMsg.TabIndex = 2;
            this.LblMsg.Text = "提示訊息：";
            // 
            // TxtNetIncome
            // 
            this.TxtNetIncome.Location = new System.Drawing.Point(218, 98);
            this.TxtNetIncome.Name = "TxtNetIncome";
            this.TxtNetIncome.Size = new System.Drawing.Size(190, 22);
            this.TxtNetIncome.TabIndex = 3;
            this.TxtNetIncome.Enter += new System.EventHandler(this.TxtNetIncome_Enter);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(424, 96);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "試算";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Location = new System.Drawing.Point(424, 141);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(75, 23);
            this.BtnEnd.TabIndex = 4;
            this.BtnEnd.Text = "結束";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 369);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtNetIncome);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.LblTax);
            this.Controls.Add(this.LblDiscount);
            this.Controls.Add(this.LblTaxRate);
            this.Controls.Add(this.LblGrade);
            this.Controls.Add(this.LblIncome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblIncome;
        private System.Windows.Forms.Label LblGrade;
        private System.Windows.Forms.Label LblTaxRate;
        private System.Windows.Forms.Label LblDiscount;
        private System.Windows.Forms.Label LblTax;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.TextBox TxtNetIncome;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnEnd;
    }
}

