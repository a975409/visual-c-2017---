namespace PicDiy
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LstPC = new System.Windows.Forms.ListBox();
            this.CboCRT = new System.Windows.Forms.ComboBox();
            this.ClbDecive = new System.Windows.Forms.CheckedListBox();
            this.LblSum = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LstShop = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主機廠牌";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "液晶螢幕尺寸";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "週邊配備";
            // 
            // LstPC
            // 
            this.LstPC.FormattingEnabled = true;
            this.LstPC.ItemHeight = 12;
            this.LstPC.Location = new System.Drawing.Point(16, 36);
            this.LstPC.Name = "LstPC";
            this.LstPC.Size = new System.Drawing.Size(134, 88);
            this.LstPC.TabIndex = 1;
            this.LstPC.SelectedIndexChanged += new System.EventHandler(this.LstPC_SelectedIndexChanged);
            // 
            // CboCRT
            // 
            this.CboCRT.FormattingEnabled = true;
            this.CboCRT.Location = new System.Drawing.Point(166, 36);
            this.CboCRT.Name = "CboCRT";
            this.CboCRT.Size = new System.Drawing.Size(121, 20);
            this.CboCRT.TabIndex = 2;
            this.CboCRT.SelectedIndexChanged += new System.EventHandler(this.CboCRT_SelectedIndexChanged);
            // 
            // ClbDecive
            // 
            this.ClbDecive.CheckOnClick = true;
            this.ClbDecive.FormattingEnabled = true;
            this.ClbDecive.Location = new System.Drawing.Point(166, 79);
            this.ClbDecive.Name = "ClbDecive";
            this.ClbDecive.Size = new System.Drawing.Size(120, 89);
            this.ClbDecive.TabIndex = 3;
            this.ClbDecive.SelectedIndexChanged += new System.EventHandler(this.ClbDecive_SelectedIndexChanged);
            // 
            // LblSum
            // 
            this.LblSum.AutoSize = true;
            this.LblSum.Location = new System.Drawing.Point(304, 156);
            this.LblSum.Name = "LblSum";
            this.LblSum.Size = new System.Drawing.Size(33, 12);
            this.LblSum.TabIndex = 4;
            this.LblSum.Text = "label4";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(16, 145);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(51, 23);
            this.BtnOK.TabIndex = 5;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(99, 145);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(51, 23);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "重新";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "購物籃";
            // 
            // LstShop
            // 
            this.LstShop.FormattingEnabled = true;
            this.LstShop.ItemHeight = 12;
            this.LstShop.Location = new System.Drawing.Point(306, 36);
            this.LstShop.Name = "LstShop";
            this.LstShop.Size = new System.Drawing.Size(134, 112);
            this.LstShop.TabIndex = 1;
            this.LstShop.SelectedIndexChanged += new System.EventHandler(this.LstPC_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 206);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblSum);
            this.Controls.Add(this.ClbDecive);
            this.Controls.Add(this.CboCRT);
            this.Controls.Add(this.LstShop);
            this.Controls.Add(this.LstPC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LstPC;
        private System.Windows.Forms.ComboBox CboCRT;
        private System.Windows.Forms.CheckedListBox ClbDecive;
        private System.Windows.Forms.Label LblSum;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LstShop;
    }
}

