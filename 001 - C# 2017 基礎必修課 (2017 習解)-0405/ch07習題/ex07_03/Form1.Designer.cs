namespace ex07_03
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
            this.McaMonth = new System.Windows.Forms.MonthCalendar();
            this.PicMonth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("新細明體", 32F);
            this.Label1.Location = new System.Drawing.Point(304, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 43);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "月曆";
            // 
            // McaMonth
            // 
            this.McaMonth.Location = new System.Drawing.Point(228, 67);
            this.McaMonth.Name = "McaMonth";
            this.McaMonth.TabIndex = 13;
            this.McaMonth.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.McaMonth_DateChanged);
            // 
            // PicMonth
            // 
            this.PicMonth.Location = new System.Drawing.Point(16, 29);
            this.PicMonth.Name = "PicMonth";
            this.PicMonth.Size = new System.Drawing.Size(200, 200);
            this.PicMonth.TabIndex = 12;
            this.PicMonth.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 241);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.McaMonth);
            this.Controls.Add(this.PicMonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.MonthCalendar McaMonth;
        internal System.Windows.Forms.PictureBox PicMonth;
    }
}

