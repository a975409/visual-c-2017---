namespace ex04_3
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
            this.TxtMoney = new System.Windows.Forms.TextBox();
            this.TxtRate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbNT2US = new System.Windows.Forms.RadioButton();
            this.RdbUS2NT = new System.Windows.Forms.RadioButton();
            this.LblMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入美金匯率";
            // 
            // TxtMoney
            // 
            this.TxtMoney.Location = new System.Drawing.Point(15, 40);
            this.TxtMoney.Name = "TxtMoney";
            this.TxtMoney.Size = new System.Drawing.Size(100, 22);
            this.TxtMoney.TabIndex = 2;
            // 
            // TxtRate
            // 
            this.TxtRate.Location = new System.Drawing.Point(128, 40);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.Size = new System.Drawing.Size(100, 22);
            this.TxtRate.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbUS2NT);
            this.groupBox1.Controls.Add(this.RdbNT2US);
            this.groupBox1.Location = new System.Drawing.Point(15, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 61);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請選擇";
            // 
            // RdbNT2US
            // 
            this.RdbNT2US.AutoSize = true;
            this.RdbNT2US.Location = new System.Drawing.Point(11, 27);
            this.RdbNT2US.Name = "RdbNT2US";
            this.RdbNT2US.Size = new System.Drawing.Size(83, 16);
            this.RdbNT2US.TabIndex = 0;
            this.RdbNT2US.TabStop = true;
            this.RdbNT2US.Text = "台幣換美金";
            this.RdbNT2US.UseVisualStyleBackColor = true;
            this.RdbNT2US.Click += new System.EventHandler(this.RdbNT2US_Click);
            // 
            // RdbUS2NT
            // 
            this.RdbUS2NT.AutoSize = true;
            this.RdbUS2NT.Location = new System.Drawing.Point(113, 29);
            this.RdbUS2NT.Name = "RdbUS2NT";
            this.RdbUS2NT.Size = new System.Drawing.Size(83, 16);
            this.RdbUS2NT.TabIndex = 1;
            this.RdbUS2NT.TabStop = true;
            this.RdbUS2NT.Text = "美金換台幣";
            this.RdbUS2NT.UseVisualStyleBackColor = true;
            this.RdbUS2NT.Click += new System.EventHandler(this.RdbUS2NT_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(15, 153);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(33, 12);
            this.LblMsg.TabIndex = 5;
            this.LblMsg.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 181);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtRate);
            this.Controls.Add(this.TxtMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMoney;
        private System.Windows.Forms.TextBox TxtRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbUS2NT;
        private System.Windows.Forms.RadioButton RdbNT2US;
        private System.Windows.Forms.Label LblMsg;
    }
}

