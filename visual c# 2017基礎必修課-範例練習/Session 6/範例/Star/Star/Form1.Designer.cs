namespace Star
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
            this.LblScore = new System.Windows.Forms.Label();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(24, 26);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(33, 12);
            this.LblScore.TabIndex = 0;
            this.LblScore.Text = "label1";
            // 
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(26, 58);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(100, 22);
            this.TxtScore.TabIndex = 1;
            this.TxtScore.Enter += new System.EventHandler(this.TxtScore_Enter);
            // 
            // LblMsg
            // 
            this.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMsg.Location = new System.Drawing.Point(26, 97);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(354, 170);
            this.LblMsg.TabIndex = 2;
            this.LblMsg.Text = "label1";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(305, 58);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(305, 279);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "重新";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 314);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.LblScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnReset;
    }
}

