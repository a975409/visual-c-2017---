namespace ex07_02
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
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TkbBlue = new System.Windows.Forms.TrackBar();
            this.TkbGreen = new System.Windows.Forms.TrackBar();
            this.TkbRed = new System.Windows.Forms.TrackBar();
            this.LblColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TkbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkbRed)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(17, 182);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(17, 12);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "藍";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(14, 139);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(17, 12);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "綠";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(14, 104);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(17, 12);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "紅";
            // 
            // TkbBlue
            // 
            this.TkbBlue.Location = new System.Drawing.Point(41, 174);
            this.TkbBlue.Maximum = 255;
            this.TkbBlue.Name = "TkbBlue";
            this.TkbBlue.Size = new System.Drawing.Size(218, 45);
            this.TkbBlue.TabIndex = 31;
            this.TkbBlue.TickFrequency = 10;
            this.TkbBlue.Scroll += new System.EventHandler(this.TkbBlue_Scroll);
            // 
            // TkbGreen
            // 
            this.TkbGreen.Location = new System.Drawing.Point(41, 135);
            this.TkbGreen.Maximum = 255;
            this.TkbGreen.Name = "TkbGreen";
            this.TkbGreen.Size = new System.Drawing.Size(218, 45);
            this.TkbGreen.TabIndex = 30;
            this.TkbGreen.TickFrequency = 10;
            this.TkbGreen.Scroll += new System.EventHandler(this.TkbGreen_Scroll);
            // 
            // TkbRed
            // 
            this.TkbRed.Location = new System.Drawing.Point(41, 96);
            this.TkbRed.Maximum = 255;
            this.TkbRed.Name = "TkbRed";
            this.TkbRed.Size = new System.Drawing.Size(218, 45);
            this.TkbRed.TabIndex = 29;
            this.TkbRed.TickFrequency = 10;
            this.TkbRed.Scroll += new System.EventHandler(this.TkbRed_Scroll);
            // 
            // LblColor
            // 
            this.LblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblColor.Location = new System.Drawing.Point(41, 9);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(218, 73);
            this.LblColor.TabIndex = 28;
            this.LblColor.Text = "Label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TkbBlue);
            this.Controls.Add(this.TkbGreen);
            this.Controls.Add(this.TkbRed);
            this.Controls.Add(this.LblColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TkbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkbRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TrackBar TkbBlue;
        internal System.Windows.Forms.TrackBar TkbGreen;
        internal System.Windows.Forms.TrackBar TkbRed;
        internal System.Windows.Forms.Label LblColor;
    }
}

