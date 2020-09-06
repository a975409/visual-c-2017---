namespace Song
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
            this.TxtMsg = new System.Windows.Forms.TextBox();
            this.BtnSortNo = new System.Windows.Forms.Button();
            this.BtnSortSong = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSinger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtMsg
            // 
            this.TxtMsg.Location = new System.Drawing.Point(12, 12);
            this.TxtMsg.Multiline = true;
            this.TxtMsg.Name = "TxtMsg";
            this.TxtMsg.ReadOnly = true;
            this.TxtMsg.Size = new System.Drawing.Size(283, 225);
            this.TxtMsg.TabIndex = 0;
            // 
            // BtnSortNo
            // 
            this.BtnSortNo.Location = new System.Drawing.Point(316, 13);
            this.BtnSortNo.Name = "BtnSortNo";
            this.BtnSortNo.Size = new System.Drawing.Size(75, 23);
            this.BtnSortNo.TabIndex = 1;
            this.BtnSortNo.Text = "依排名排序";
            this.BtnSortNo.UseVisualStyleBackColor = true;
            this.BtnSortNo.Click += new System.EventHandler(this.BtnSortNo_Click);
            // 
            // BtnSortSong
            // 
            this.BtnSortSong.Location = new System.Drawing.Point(316, 59);
            this.BtnSortSong.Name = "BtnSortSong";
            this.BtnSortSong.Size = new System.Drawing.Size(75, 23);
            this.BtnSortSong.TabIndex = 1;
            this.BtnSortSong.Text = "依歌曲排序";
            this.BtnSortSong.UseVisualStyleBackColor = true;
            this.BtnSortSong.Click += new System.EventHandler(this.BtnSortSong_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(316, 107);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "查詢歌手";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSinger
            // 
            this.TxtSinger.Location = new System.Drawing.Point(316, 147);
            this.TxtSinger.Name = "TxtSinger";
            this.TxtSinger.Size = new System.Drawing.Size(100, 22);
            this.TxtSinger.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 263);
            this.Controls.Add(this.TxtSinger);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnSortSong);
            this.Controls.Add(this.BtnSortNo);
            this.Controls.Add(this.TxtMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMsg;
        private System.Windows.Forms.Button BtnSortNo;
        private System.Windows.Forms.Button BtnSortSong;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSinger;
    }
}

