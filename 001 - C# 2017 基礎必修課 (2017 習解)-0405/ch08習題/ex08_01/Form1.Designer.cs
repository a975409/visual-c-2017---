namespace ex08_01
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
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(168, 103);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 32);
            this.BtnStart.TabIndex = 44;
            this.BtnStart.Text = "開獎";
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Pic1
            // 
            this.Pic1.Location = new System.Drawing.Point(21, 25);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(54, 53);
            this.Pic1.TabIndex = 43;
            this.Pic1.TabStop = false;
            // 
            // Pic2
            // 
            this.Pic2.Location = new System.Drawing.Point(77, 25);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(54, 53);
            this.Pic2.TabIndex = 40;
            this.Pic2.TabStop = false;
            // 
            // Pic3
            // 
            this.Pic3.Location = new System.Drawing.Point(133, 25);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(54, 53);
            this.Pic3.TabIndex = 41;
            this.Pic3.TabStop = false;
            // 
            // Pic4
            // 
            this.Pic4.Location = new System.Drawing.Point(189, 25);
            this.Pic4.Name = "Pic4";
            this.Pic4.Size = new System.Drawing.Size(54, 53);
            this.Pic4.TabIndex = 42;
            this.Pic4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 161);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.Pic3);
            this.Controls.Add(this.Pic4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnStart;
        internal System.Windows.Forms.PictureBox Pic1;
        internal System.Windows.Forms.PictureBox Pic2;
        internal System.Windows.Forms.PictureBox Pic3;
        internal System.Windows.Forms.PictureBox Pic4;
    }
}

