namespace Picture
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
            this.PicDemo1 = new System.Windows.Forms.PictureBox();
            this.PicDemo2 = new System.Windows.Forms.PictureBox();
            this.PicDemo3 = new System.Windows.Forms.PictureBox();
            this.PicDemo4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PicShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).BeginInit();
            this.SuspendLayout();
            // 
            // PicDemo1
            // 
            this.PicDemo1.Location = new System.Drawing.Point(28, 28);
            this.PicDemo1.Name = "PicDemo1";
            this.PicDemo1.Size = new System.Drawing.Size(39, 26);
            this.PicDemo1.TabIndex = 0;
            this.PicDemo1.TabStop = false;
            this.PicDemo1.Click += new System.EventHandler(this.PicDemo1_Click);
            // 
            // PicDemo2
            // 
            this.PicDemo2.Location = new System.Drawing.Point(83, 28);
            this.PicDemo2.Name = "PicDemo2";
            this.PicDemo2.Size = new System.Drawing.Size(39, 26);
            this.PicDemo2.TabIndex = 0;
            this.PicDemo2.TabStop = false;
            this.PicDemo2.Click += new System.EventHandler(this.PicDemo2_Click);
            // 
            // PicDemo3
            // 
            this.PicDemo3.Location = new System.Drawing.Point(138, 28);
            this.PicDemo3.Name = "PicDemo3";
            this.PicDemo3.Size = new System.Drawing.Size(39, 26);
            this.PicDemo3.TabIndex = 0;
            this.PicDemo3.TabStop = false;
            this.PicDemo3.Click += new System.EventHandler(this.PicDemo3_Click);
            // 
            // PicDemo4
            // 
            this.PicDemo4.Location = new System.Drawing.Point(193, 28);
            this.PicDemo4.Name = "PicDemo4";
            this.PicDemo4.Size = new System.Drawing.Size(39, 26);
            this.PicDemo4.TabIndex = 0;
            this.PicDemo4.TabStop = false;
            this.PicDemo4.Click += new System.EventHandler(this.PicDemo4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // PicShow
            // 
            this.PicShow.Location = new System.Drawing.Point(28, 75);
            this.PicShow.Name = "PicShow";
            this.PicShow.Size = new System.Drawing.Size(250, 200);
            this.PicShow.TabIndex = 3;
            this.PicShow.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 290);
            this.Controls.Add(this.PicShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicDemo4);
            this.Controls.Add(this.PicDemo3);
            this.Controls.Add(this.PicDemo2);
            this.Controls.Add(this.PicDemo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDemo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicDemo1;
        private System.Windows.Forms.PictureBox PicDemo2;
        private System.Windows.Forms.PictureBox PicDemo3;
        private System.Windows.Forms.PictureBox PicDemo4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicShow;
    }
}

