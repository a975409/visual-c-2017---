namespace ex03_01
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
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnBlack = new System.Windows.Forms.Button();
            this.BtnYellow = new System.Windows.Forms.Button();
            this.BtnRed = new System.Windows.Forms.Button();
            this.BtnBlue = new System.Windows.Forms.Button();
            this.BtnBold = new System.Windows.Forms.Button();
            this.BtnItalic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.Location = new System.Drawing.Point(82, 28);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(212, 48);
            this.LblMsg.TabIndex = 0;
            this.LblMsg.Text = "金雞報喜";
            // 
            // BtnBlack
            // 
            this.BtnBlack.Location = new System.Drawing.Point(34, 101);
            this.BtnBlack.Name = "BtnBlack";
            this.BtnBlack.Size = new System.Drawing.Size(75, 23);
            this.BtnBlack.TabIndex = 1;
            this.BtnBlack.Text = "黑底";
            this.BtnBlack.UseVisualStyleBackColor = true;
            this.BtnBlack.Click += new System.EventHandler(this.BtnBlack_Click);
            // 
            // BtnYellow
            // 
            this.BtnYellow.Location = new System.Drawing.Point(34, 139);
            this.BtnYellow.Name = "BtnYellow";
            this.BtnYellow.Size = new System.Drawing.Size(75, 23);
            this.BtnYellow.TabIndex = 1;
            this.BtnYellow.Text = "黃底";
            this.BtnYellow.UseVisualStyleBackColor = true;
            this.BtnYellow.Click += new System.EventHandler(this.BtnYellow_Click);
            // 
            // BtnRed
            // 
            this.BtnRed.ForeColor = System.Drawing.Color.Black;
            this.BtnRed.Location = new System.Drawing.Point(145, 101);
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.Size = new System.Drawing.Size(75, 23);
            this.BtnRed.TabIndex = 1;
            this.BtnRed.Text = "紅字";
            this.BtnRed.UseVisualStyleBackColor = true;
            this.BtnRed.Click += new System.EventHandler(this.BtnRed_Click);
            // 
            // BtnBlue
            // 
            this.BtnBlue.Location = new System.Drawing.Point(145, 139);
            this.BtnBlue.Name = "BtnBlue";
            this.BtnBlue.Size = new System.Drawing.Size(75, 23);
            this.BtnBlue.TabIndex = 1;
            this.BtnBlue.Text = "藍字";
            this.BtnBlue.UseVisualStyleBackColor = true;
            this.BtnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
            // 
            // BtnBold
            // 
            this.BtnBold.Location = new System.Drawing.Point(249, 101);
            this.BtnBold.Name = "BtnBold";
            this.BtnBold.Size = new System.Drawing.Size(75, 23);
            this.BtnBold.TabIndex = 1;
            this.BtnBold.Text = "粗體";
            this.BtnBold.UseVisualStyleBackColor = true;
            this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // BtnItalic
            // 
            this.BtnItalic.Location = new System.Drawing.Point(249, 139);
            this.BtnItalic.Name = "BtnItalic";
            this.BtnItalic.Size = new System.Drawing.Size(75, 23);
            this.BtnItalic.TabIndex = 1;
            this.BtnItalic.Text = "斜體";
            this.BtnItalic.UseVisualStyleBackColor = true;
            this.BtnItalic.Click += new System.EventHandler(this.BtnItalic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 189);
            this.Controls.Add(this.BtnYellow);
            this.Controls.Add(this.BtnItalic);
            this.Controls.Add(this.BtnBlue);
            this.Controls.Add(this.BtnBold);
            this.Controls.Add(this.BtnRed);
            this.Controls.Add(this.BtnBlack);
            this.Controls.Add(this.LblMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Button BtnBlack;
        private System.Windows.Forms.Button BtnYellow;
        private System.Windows.Forms.Button BtnRed;
        private System.Windows.Forms.Button BtnBlue;
        private System.Windows.Forms.Button BtnBold;
        private System.Windows.Forms.Button BtnItalic;
    }
}

