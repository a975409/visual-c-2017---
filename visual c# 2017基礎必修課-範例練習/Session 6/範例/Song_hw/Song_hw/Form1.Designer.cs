namespace Song_hw
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
            this.TxtSinger = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnSortIncSong = new System.Windows.Forms.Button();
            this.BtnSortIncNo = new System.Windows.Forms.Button();
            this.TxtMsg = new System.Windows.Forms.TextBox();
            this.BtnSortDecNo = new System.Windows.Forms.Button();
            this.BtnSortDecSong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSinger
            // 
            this.TxtSinger.Location = new System.Drawing.Point(316, 184);
            this.TxtSinger.Name = "TxtSinger";
            this.TxtSinger.Size = new System.Drawing.Size(100, 22);
            this.TxtSinger.TabIndex = 7;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(316, 141);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "查詢歌手";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnSortIncSong
            // 
            this.BtnSortIncSong.Location = new System.Drawing.Point(316, 77);
            this.BtnSortIncSong.Name = "BtnSortIncSong";
            this.BtnSortIncSong.Size = new System.Drawing.Size(75, 23);
            this.BtnSortIncSong.TabIndex = 5;
            this.BtnSortIncSong.Text = "依歌曲遞增排序";
            this.BtnSortIncSong.UseVisualStyleBackColor = true;
            this.BtnSortIncSong.Click += new System.EventHandler(this.BtnSortIncSong_Click);
            // 
            // BtnSortIncNo
            // 
            this.BtnSortIncNo.Location = new System.Drawing.Point(316, 13);
            this.BtnSortIncNo.Name = "BtnSortIncNo";
            this.BtnSortIncNo.Size = new System.Drawing.Size(75, 23);
            this.BtnSortIncNo.TabIndex = 6;
            this.BtnSortIncNo.Text = "依排名遞增排序";
            this.BtnSortIncNo.UseVisualStyleBackColor = true;
            this.BtnSortIncNo.Click += new System.EventHandler(this.BtnSortIncNo_Click);
            // 
            // TxtMsg
            // 
            this.TxtMsg.Location = new System.Drawing.Point(12, 12);
            this.TxtMsg.Multiline = true;
            this.TxtMsg.Name = "TxtMsg";
            this.TxtMsg.ReadOnly = true;
            this.TxtMsg.Size = new System.Drawing.Size(283, 225);
            this.TxtMsg.TabIndex = 3;
            // 
            // BtnSortDecNo
            // 
            this.BtnSortDecNo.Location = new System.Drawing.Point(316, 45);
            this.BtnSortDecNo.Name = "BtnSortDecNo";
            this.BtnSortDecNo.Size = new System.Drawing.Size(75, 23);
            this.BtnSortDecNo.TabIndex = 6;
            this.BtnSortDecNo.Text = "依排名遞減排序";
            this.BtnSortDecNo.UseVisualStyleBackColor = true;
            this.BtnSortDecNo.Click += new System.EventHandler(this.BtnSortDecNo_Click);
            // 
            // BtnSortDecSong
            // 
            this.BtnSortDecSong.Location = new System.Drawing.Point(316, 109);
            this.BtnSortDecSong.Name = "BtnSortDecSong";
            this.BtnSortDecSong.Size = new System.Drawing.Size(75, 23);
            this.BtnSortDecSong.TabIndex = 5;
            this.BtnSortDecSong.Text = "依歌曲遞減排序";
            this.BtnSortDecSong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 259);
            this.Controls.Add(this.TxtSinger);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnSortDecSong);
            this.Controls.Add(this.BtnSortDecNo);
            this.Controls.Add(this.BtnSortIncSong);
            this.Controls.Add(this.BtnSortIncNo);
            this.Controls.Add(this.TxtMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSinger;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnSortIncSong;
        private System.Windows.Forms.Button BtnSortIncNo;
        private System.Windows.Forms.TextBox TxtMsg;
        private System.Windows.Forms.Button BtnSortDecNo;
        private System.Windows.Forms.Button BtnSortDecSong;
    }
}

