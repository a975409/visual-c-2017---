namespace NT_to_US
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
            this.TxtDollor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbNTtoUS = new System.Windows.Forms.RadioButton();
            this.RdbUStoNT = new System.Windows.Forms.RadioButton();
            this.LblMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入金額";
            // 
            // TxtDollor
            // 
            this.TxtDollor.Location = new System.Drawing.Point(25, 47);
            this.TxtDollor.Name = "TxtDollor";
            this.TxtDollor.Size = new System.Drawing.Size(100, 22);
            this.TxtDollor.TabIndex = 1;
            this.TxtDollor.Enter += new System.EventHandler(this.TxtDollor_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "請輸入美金匯率";
            // 
            // TxtRate
            // 
            this.TxtRate.Location = new System.Drawing.Point(163, 47);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.Size = new System.Drawing.Size(100, 22);
            this.TxtRate.TabIndex = 1;
            this.TxtRate.Enter += new System.EventHandler(this.TxtRate_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbUStoNT);
            this.groupBox1.Controls.Add(this.RdbNTtoUS);
            this.groupBox1.Location = new System.Drawing.Point(25, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請選擇";
            // 
            // RdbNTtoUS
            // 
            this.RdbNTtoUS.AutoSize = true;
            this.RdbNTtoUS.Location = new System.Drawing.Point(7, 22);
            this.RdbNTtoUS.Name = "RdbNTtoUS";
            this.RdbNTtoUS.Size = new System.Drawing.Size(83, 16);
            this.RdbNTtoUS.TabIndex = 0;
            this.RdbNTtoUS.TabStop = true;
            this.RdbNTtoUS.Text = "台幣換美金";
            this.RdbNTtoUS.UseVisualStyleBackColor = true;
            this.RdbNTtoUS.CheckedChanged += new System.EventHandler(this.RdbNTtoUS_CheckedChanged);
            // 
            // RdbUStoNT
            // 
            this.RdbUStoNT.AutoSize = true;
            this.RdbUStoNT.Location = new System.Drawing.Point(138, 22);
            this.RdbUStoNT.Name = "RdbUStoNT";
            this.RdbUStoNT.Size = new System.Drawing.Size(83, 16);
            this.RdbUStoNT.TabIndex = 0;
            this.RdbUStoNT.TabStop = true;
            this.RdbUStoNT.Text = "美金換台幣";
            this.RdbUStoNT.UseVisualStyleBackColor = true;
            this.RdbUStoNT.CheckedChanged += new System.EventHandler(this.RdbUStoNT_CheckedChanged);
            // 
            // LblMsg
            // 
            this.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMsg.Location = new System.Drawing.Point(25, 161);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(238, 38);
            this.LblMsg.TabIndex = 3;
            this.LblMsg.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 230);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtRate);
            this.Controls.Add(this.TxtDollor);
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
        private System.Windows.Forms.TextBox TxtDollor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbUStoNT;
        private System.Windows.Forms.RadioButton RdbNTtoUS;
        private System.Windows.Forms.Label LblMsg;
    }
}

