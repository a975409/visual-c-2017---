namespace ex09_04
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
            this.PicZoom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // PicZoom
            // 
            this.PicZoom.Location = new System.Drawing.Point(80, 80);
            this.PicZoom.Name = "PicZoom";
            this.PicZoom.Size = new System.Drawing.Size(125, 100);
            this.PicZoom.TabIndex = 1;
            this.PicZoom.TabStop = false;
            this.PicZoom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicZoom_MouseDown);
            this.PicZoom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicZoom_MouseMove);
            this.PicZoom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicZoom_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PicZoom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicZoom;
    }
}

