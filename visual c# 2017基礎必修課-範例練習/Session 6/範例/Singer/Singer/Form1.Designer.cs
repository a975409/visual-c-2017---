namespace Singer
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboSinger = new System.Windows.Forms.ComboBox();
            this.BtnVote = new System.Windows.Forms.Button();
            this.LblMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LstVote = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "最佳女歌手名單：";
            // 
            // CboSinger
            // 
            this.CboSinger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSinger.FormattingEnabled = true;
            this.CboSinger.Location = new System.Drawing.Point(20, 42);
            this.CboSinger.Name = "CboSinger";
            this.CboSinger.Size = new System.Drawing.Size(174, 20);
            this.CboSinger.TabIndex = 1;
            this.CboSinger.SelectedIndexChanged += new System.EventHandler(this.CboSinger_SelectedIndexChanged);
            // 
            // BtnVote
            // 
            this.BtnVote.Location = new System.Drawing.Point(60, 102);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Size = new System.Drawing.Size(85, 48);
            this.BtnVote.TabIndex = 2;
            this.BtnVote.Text = "投票";
            this.BtnVote.UseVisualStyleBackColor = true;
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.BackColor = System.Drawing.Color.White;
            this.LblMsg.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.Location = new System.Drawing.Point(216, 18);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(178, 44);
            this.LblMsg.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(216, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "投票結果：";
            // 
            // LstVote
            // 
            this.LstVote.FormattingEnabled = true;
            this.LstVote.ItemHeight = 12;
            this.LstVote.Location = new System.Drawing.Point(220, 102);
            this.LstVote.Name = "LstVote";
            this.LstVote.Size = new System.Drawing.Size(174, 100);
            this.LstVote.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 225);
            this.Controls.Add(this.LstVote);
            this.Controls.Add(this.BtnVote);
            this.Controls.Add(this.CboSinger);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboSinger;
        private System.Windows.Forms.Button BtnVote;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LstVote;
    }
}

