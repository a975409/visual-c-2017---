namespace ex06_02
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
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.LstRight = new System.Windows.Forms.ListBox();
            this.LstLeft = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHelp
            // 
            this.BtnHelp.Location = new System.Drawing.Point(205, 27);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(75, 23);
            this.BtnHelp.TabIndex = 41;
            this.BtnHelp.Text = "說明";
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Location = new System.Drawing.Point(108, 131);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(75, 23);
            this.BtnLeft.TabIndex = 40;
            this.BtnLeft.Text = "<---";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Location = new System.Drawing.Point(108, 89);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(75, 23);
            this.BtnRight.TabIndex = 39;
            this.BtnRight.Text = "--->";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // LstRight
            // 
            this.LstRight.Font = new System.Drawing.Font("新細明體", 16F);
            this.LstRight.FormattingEnabled = true;
            this.LstRight.ItemHeight = 21;
            this.LstRight.Location = new System.Drawing.Point(189, 78);
            this.LstRight.Name = "LstRight";
            this.LstRight.Size = new System.Drawing.Size(92, 109);
            this.LstRight.TabIndex = 38;
            // 
            // LstLeft
            // 
            this.LstLeft.Font = new System.Drawing.Font("新細明體", 16F);
            this.LstLeft.FormattingEnabled = true;
            this.LstLeft.ItemHeight = 21;
            this.LstLeft.Location = new System.Drawing.Point(13, 78);
            this.LstLeft.Name = "LstLeft";
            this.LstLeft.Size = new System.Drawing.Size(91, 109);
            this.LstLeft.TabIndex = 37;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.Label1.Location = new System.Drawing.Point(79, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 27);
            this.Label1.TabIndex = 36;
            this.Label1.Text = "農夫過河";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 211);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.LstRight);
            this.Controls.Add(this.LstLeft);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnHelp;
        internal System.Windows.Forms.Button BtnLeft;
        internal System.Windows.Forms.Button BtnRight;
        internal System.Windows.Forms.ListBox LstRight;
        internal System.Windows.Forms.ListBox LstLeft;
        internal System.Windows.Forms.Label Label1;
    }
}

