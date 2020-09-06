namespace ex09_02
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
            this.PicTra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicTra)).BeginInit();
            this.SuspendLayout();
            // 
            // PicTra
            // 
            this.PicTra.Location = new System.Drawing.Point(35, 36);
            this.PicTra.Name = "PicTra";
            this.PicTra.Size = new System.Drawing.Size(84, 99);
            this.PicTra.TabIndex = 3;
            this.PicTra.TabStop = false;
            this.PicTra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicTra_MouseDown);
            this.PicTra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicTra_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 171);
            this.Controls.Add(this.PicTra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicTra;
    }
}

