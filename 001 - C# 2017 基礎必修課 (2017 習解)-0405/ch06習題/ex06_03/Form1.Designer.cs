namespace ex06_03
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
            this.Label6 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtSum = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LstName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("新細明體", 16F);
            this.Label6.Location = new System.Drawing.Point(86, 12);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(142, 22);
            this.Label6.TabIndex = 97;
            this.Label6.Text = "商店結帳系統";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(229, 225);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(63, 23);
            this.BtnClear.TabIndex = 96;
            this.BtnClear.Text = "清除";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtSum
            // 
            this.TxtSum.Location = new System.Drawing.Point(192, 180);
            this.TxtSum.Name = "TxtSum";
            this.TxtSum.ReadOnly = true;
            this.TxtSum.Size = new System.Drawing.Size(100, 22);
            this.TxtSum.TabIndex = 95;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(149, 184);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 12);
            this.Label5.TabIndex = 94;
            this.Label5.Text = "總計";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(151, 225);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(60, 23);
            this.BtnOk.TabIndex = 93;
            this.BtnOk.Text = "確定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(192, 148);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(100, 22);
            this.TxtTotal.TabIndex = 92;
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(192, 116);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(100, 22);
            this.TxtNum.TabIndex = 91;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(192, 83);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(100, 22);
            this.TxtPrice.TabIndex = 90;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(192, 49);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 89;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(149, 151);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 12);
            this.Label4.TabIndex = 88;
            this.Label4.Text = "小計";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(149, 118);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 12);
            this.Label3.TabIndex = 87;
            this.Label3.Text = "數量";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(149, 85);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(29, 12);
            this.Label2.TabIndex = 86;
            this.Label2.Text = "單價";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(149, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 12);
            this.Label1.TabIndex = 85;
            this.Label1.Text = "品名";
            // 
            // LstName
            // 
            this.LstName.FormattingEnabled = true;
            this.LstName.ItemHeight = 12;
            this.LstName.Location = new System.Drawing.Point(22, 47);
            this.LstName.Name = "LstName";
            this.LstName.Size = new System.Drawing.Size(115, 160);
            this.LstName.TabIndex = 84;
            this.LstName.SelectedIndexChanged += new System.EventHandler(this.LstName_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtSum);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button BtnClear;
        internal System.Windows.Forms.TextBox TxtSum;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button BtnOk;
        internal System.Windows.Forms.TextBox TxtTotal;
        internal System.Windows.Forms.TextBox TxtNum;
        internal System.Windows.Forms.TextBox TxtPrice;
        internal System.Windows.Forms.TextBox TxtName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox LstName;
    }
}

