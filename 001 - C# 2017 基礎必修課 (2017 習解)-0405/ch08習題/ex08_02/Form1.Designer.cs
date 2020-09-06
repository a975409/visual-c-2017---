namespace ex08_02
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.Pic3 = new System.Windows.Forms.PictureBox();
            this.Pic4 = new System.Windows.Forms.PictureBox();
            this.Pic5 = new System.Windows.Forms.PictureBox();
            this.Pic6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(284, 96);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 32);
            this.BtnStart.TabIndex = 63;
            this.BtnStart.Text = "開獎";
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Pic1
            // 
            this.Pic1.Location = new System.Drawing.Point(25, 19);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(54, 53);
            this.Pic1.TabIndex = 62;
            this.Pic1.TabStop = false;
            // 
            // Pic2
            // 
            this.Pic2.Location = new System.Drawing.Point(81, 19);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(54, 53);
            this.Pic2.TabIndex = 57;
            this.Pic2.TabStop = false;
            // 
            // Pic3
            // 
            this.Pic3.Location = new System.Drawing.Point(137, 19);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(54, 53);
            this.Pic3.TabIndex = 58;
            this.Pic3.TabStop = false;
            // 
            // Pic4
            // 
            this.Pic4.Location = new System.Drawing.Point(193, 19);
            this.Pic4.Name = "Pic4";
            this.Pic4.Size = new System.Drawing.Size(54, 53);
            this.Pic4.TabIndex = 61;
            this.Pic4.TabStop = false;
            // 
            // Pic5
            // 
            this.Pic5.Location = new System.Drawing.Point(249, 19);
            this.Pic5.Name = "Pic5";
            this.Pic5.Size = new System.Drawing.Size(54, 53);
            this.Pic5.TabIndex = 59;
            this.Pic5.TabStop = false;
            // 
            // Pic6
            // 
            this.Pic6.Location = new System.Drawing.Point(305, 19);
            this.Pic6.Name = "Pic6";
            this.Pic6.Size = new System.Drawing.Size(54, 53);
            this.Pic6.TabIndex = 60;
            this.Pic6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 151);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.Pic3);
            this.Controls.Add(this.Pic4);
            this.Controls.Add(this.Pic5);
            this.Controls.Add(this.Pic6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnStart;
        internal System.Windows.Forms.PictureBox Pic1;
        internal System.Windows.Forms.PictureBox Pic2;
        internal System.Windows.Forms.PictureBox Pic3;
        internal System.Windows.Forms.PictureBox Pic4;
        internal System.Windows.Forms.PictureBox Pic5;
        internal System.Windows.Forms.PictureBox Pic6;
    }
}

