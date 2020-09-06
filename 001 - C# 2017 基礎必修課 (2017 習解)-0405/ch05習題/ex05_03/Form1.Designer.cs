namespace ex05_03
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.PicUfo = new System.Windows.Forms.PictureBox();
            this.BtnSmall = new System.Windows.Forms.Button();
            this.BtnLarge = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicUfo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "up.jpg");
            this.imgIcon.Images.SetKeyName(1, "down.jpg");
            this.imgIcon.Images.SetKeyName(2, "left.jpg");
            this.imgIcon.Images.SetKeyName(3, "right.jpg");
            this.imgIcon.Images.SetKeyName(4, "large.jpg");
            this.imgIcon.Images.SetKeyName(5, "small.jpg");
            // 
            // PicUfo
            // 
            this.PicUfo.Image = global::ex05_03.Properties.Resources.飛碟;
            this.PicUfo.Location = new System.Drawing.Point(202, 138);
            this.PicUfo.Name = "PicUfo";
            this.PicUfo.Size = new System.Drawing.Size(60, 60);
            this.PicUfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUfo.TabIndex = 41;
            this.PicUfo.TabStop = false;
            // 
            // BtnSmall
            // 
            this.BtnSmall.ImageIndex = 5;
            this.BtnSmall.ImageList = this.imgIcon;
            this.BtnSmall.Location = new System.Drawing.Point(410, 315);
            this.BtnSmall.Name = "BtnSmall";
            this.BtnSmall.Size = new System.Drawing.Size(32, 32);
            this.BtnSmall.TabIndex = 40;
            this.BtnSmall.UseVisualStyleBackColor = true;
            this.BtnSmall.Click += new System.EventHandler(this.BtnSmall_Click);
            // 
            // BtnLarge
            // 
            this.BtnLarge.ImageIndex = 4;
            this.BtnLarge.ImageList = this.imgIcon;
            this.BtnLarge.Location = new System.Drawing.Point(373, 315);
            this.BtnLarge.Name = "BtnLarge";
            this.BtnLarge.Size = new System.Drawing.Size(32, 32);
            this.BtnLarge.TabIndex = 39;
            this.BtnLarge.UseVisualStyleBackColor = true;
            this.BtnLarge.Click += new System.EventHandler(this.BtnLarge_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.ImageIndex = 3;
            this.BtnRight.ImageList = this.imgIcon;
            this.BtnRight.Location = new System.Drawing.Point(448, 315);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(32, 32);
            this.BtnRight.TabIndex = 38;
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.ImageIndex = 2;
            this.BtnLeft.ImageList = this.imgIcon;
            this.BtnLeft.Location = new System.Drawing.Point(335, 315);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(32, 32);
            this.BtnLeft.TabIndex = 37;
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.ImageIndex = 1;
            this.BtnDown.ImageList = this.imgIcon;
            this.BtnDown.Location = new System.Drawing.Point(392, 353);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(32, 32);
            this.BtnDown.TabIndex = 36;
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.ImageIndex = 0;
            this.BtnUp.ImageList = this.imgIcon;
            this.BtnUp.Location = new System.Drawing.Point(392, 277);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(32, 32);
            this.BtnUp.TabIndex = 35;
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.PicUfo);
            this.Controls.Add(this.BtnSmall);
            this.Controls.Add(this.BtnLarge);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.BtnUp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicUfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imgIcon;
        internal System.Windows.Forms.PictureBox PicUfo;
        internal System.Windows.Forms.Button BtnSmall;
        internal System.Windows.Forms.Button BtnLarge;
        internal System.Windows.Forms.Button BtnRight;
        internal System.Windows.Forms.Button BtnLeft;
        internal System.Windows.Forms.Button BtnDown;
        internal System.Windows.Forms.Button BtnUp;
    }
}

