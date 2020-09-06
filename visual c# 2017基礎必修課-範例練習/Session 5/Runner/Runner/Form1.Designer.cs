namespace Runner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TmrRun = new System.Windows.Forms.Timer(this.components);
            this.ImgRun = new System.Windows.Forms.ImageList(this.components);
            this.TmrMove = new System.Windows.Forms.Timer(this.components);
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnRun = new System.Windows.Forms.Button();
            this.PicRun = new System.Windows.Forms.PictureBox();
            this.ImgButton = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicRun)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrRun
            // 
            this.TmrRun.Tick += new System.EventHandler(this.TmrRun_Tick);
            // 
            // ImgRun
            // 
            this.ImgRun.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgRun.ImageStream")));
            this.ImgRun.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgRun.Images.SetKeyName(0, "man1.gif");
            this.ImgRun.Images.SetKeyName(1, "man2.gif");
            this.ImgRun.Images.SetKeyName(2, "man3.gif");
            this.ImgRun.Images.SetKeyName(3, "man4.gif");
            // 
            // TmrMove
            // 
            this.TmrMove.Tick += new System.EventHandler(this.TmrMove_Tick);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(249, 88);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(25, 25);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(218, 88);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(25, 25);
            this.BtnRun.TabIndex = 1;
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // PicRun
            // 
            this.PicRun.Location = new System.Drawing.Point(220, 30);
            this.PicRun.Name = "PicRun";
            this.PicRun.Size = new System.Drawing.Size(45, 45);
            this.PicRun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRun.TabIndex = 0;
            this.PicRun.TabStop = false;
            // 
            // ImgButton
            // 
            this.ImgButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgButton.ImageStream")));
            this.ImgButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgButton.Images.SetKeyName(0, "start.bmp");
            this.ImgButton.Images.SetKeyName(1, "stop.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.PicRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicRun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicRun;
        private System.Windows.Forms.Timer TmrRun;
        private System.Windows.Forms.ImageList ImgRun;
        private System.Windows.Forms.Timer TmrMove;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.ImageList ImgButton;
    }
}

