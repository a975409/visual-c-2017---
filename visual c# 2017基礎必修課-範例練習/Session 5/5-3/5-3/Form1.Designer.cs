namespace _5_3
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
            this.PicUFO = new System.Windows.Forms.PictureBox();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnSmall = new System.Windows.Forms.Button();
            this.BtnLarge = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicUFO)).BeginInit();
            this.SuspendLayout();
            // 
            // PicUFO
            // 
            this.PicUFO.Image = global::_5_3.Properties.Resources.飛碟;
            this.PicUFO.Location = new System.Drawing.Point(353, 12);
            this.PicUFO.Name = "PicUFO";
            this.PicUFO.Size = new System.Drawing.Size(60, 60);
            this.PicUFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUFO.TabIndex = 1;
            this.PicUFO.TabStop = false;
            // 
            // BtnRight
            // 
            this.BtnRight.AutoSize = true;
            this.BtnRight.Image = global::_5_3.Properties.Resources.right;
            this.BtnRight.Location = new System.Drawing.Point(750, 357);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(38, 38);
            this.BtnRight.TabIndex = 0;
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.AutoSize = true;
            this.BtnLeft.Image = global::_5_3.Properties.Resources.left;
            this.BtnLeft.Location = new System.Drawing.Point(618, 357);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(38, 38);
            this.BtnLeft.TabIndex = 0;
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnSmall
            // 
            this.BtnSmall.AutoSize = true;
            this.BtnSmall.Image = global::_5_3.Properties.Resources.small;
            this.BtnSmall.Location = new System.Drawing.Point(706, 357);
            this.BtnSmall.Name = "BtnSmall";
            this.BtnSmall.Size = new System.Drawing.Size(38, 38);
            this.BtnSmall.TabIndex = 0;
            this.BtnSmall.UseVisualStyleBackColor = true;
            this.BtnSmall.Click += new System.EventHandler(this.BtnSmall_Click);
            // 
            // BtnLarge
            // 
            this.BtnLarge.AutoSize = true;
            this.BtnLarge.Image = global::_5_3.Properties.Resources.large;
            this.BtnLarge.Location = new System.Drawing.Point(662, 357);
            this.BtnLarge.Name = "BtnLarge";
            this.BtnLarge.Size = new System.Drawing.Size(38, 38);
            this.BtnLarge.TabIndex = 0;
            this.BtnLarge.UseVisualStyleBackColor = true;
            this.BtnLarge.Click += new System.EventHandler(this.BtnLarge_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.AutoSize = true;
            this.BtnDown.Image = global::_5_3.Properties.Resources.down;
            this.BtnDown.Location = new System.Drawing.Point(683, 401);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(38, 38);
            this.BtnDown.TabIndex = 0;
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.AutoSize = true;
            this.BtnUp.Image = global::_5_3.Properties.Resources.up;
            this.BtnUp.Location = new System.Drawing.Point(683, 313);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(38, 38);
            this.BtnUp.TabIndex = 0;
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicUFO);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.BtnSmall);
            this.Controls.Add(this.BtnLarge);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.BtnUp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicUFO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLarge;
        private System.Windows.Forms.Button BtnSmall;
        private System.Windows.Forms.PictureBox PicUFO;
    }
}

