namespace Ex12_2
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
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnLoop = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(63, 62);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(64, 22);
            this.BtnStop.TabIndex = 47;
            this.BtnStop.Text = "停止";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnLoop
            // 
            this.BtnLoop.Location = new System.Drawing.Point(183, 22);
            this.BtnLoop.Name = "BtnLoop";
            this.BtnLoop.Size = new System.Drawing.Size(64, 22);
            this.BtnLoop.TabIndex = 46;
            this.BtnLoop.Text = "重複";
            this.BtnLoop.UseVisualStyleBackColor = true;
            this.BtnLoop.Click += new System.EventHandler(this.BtnLoop_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(104, 22);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(64, 22);
            this.BtnPlay.TabIndex = 45;
            this.BtnPlay.Text = "播放";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(21, 22);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(64, 22);
            this.BtnOpen.TabIndex = 44;
            this.BtnOpen.Text = "開檔";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnEnd
            // 
            this.BtnEnd.Location = new System.Drawing.Point(142, 62);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(64, 22);
            this.BtnEnd.TabIndex = 48;
            this.BtnEnd.Text = "結束";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 109);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnLoop);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnOpen);
            this.Name = "Form1";
            this.Text = "語音檔播放器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnLoop;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnEnd;
    }
}

