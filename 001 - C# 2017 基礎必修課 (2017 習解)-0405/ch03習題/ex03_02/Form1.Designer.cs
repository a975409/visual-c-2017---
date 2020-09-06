namespace ex03_02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblReturn = new System.Windows.Forms.Label();
            this.TxtMoney = new System.Windows.Forms.TextBox();
            this.TxtRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本金：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "年利率：";
            // 
            // LblReturn
            // 
            this.LblReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblReturn.Location = new System.Drawing.Point(76, 88);
            this.LblReturn.Name = "LblReturn";
            this.LblReturn.Size = new System.Drawing.Size(100, 22);
            this.LblReturn.TabIndex = 2;
            // 
            // TxtMoney
            // 
            this.TxtMoney.Location = new System.Drawing.Point(76, 16);
            this.TxtMoney.Name = "TxtMoney";
            this.TxtMoney.Size = new System.Drawing.Size(100, 22);
            this.TxtMoney.TabIndex = 3;
            this.TxtMoney.Text = "10000";
            this.TxtMoney.TextChanged += new System.EventHandler(this.TxtMoney_TextChanged);
            // 
            // TxtRate
            // 
            this.TxtRate.Location = new System.Drawing.Point(76, 51);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.Size = new System.Drawing.Size(100, 22);
            this.TxtRate.TabIndex = 4;
            this.TxtRate.TextChanged += new System.EventHandler(this.TxtRate_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "%";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(182, 88);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "結束";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "利息：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 136);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRate);
            this.Controls.Add(this.TxtMoney);
            this.Controls.Add(this.LblReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblReturn;
        private System.Windows.Forms.TextBox TxtMoney;
        private System.Windows.Forms.TextBox TxtRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label3;
    }
}

