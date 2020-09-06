namespace ex03_01
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
            this.LblWord = new System.Windows.Forms.Label();
            this.BtnBC1 = new System.Windows.Forms.Button();
            this.BtnFC1 = new System.Windows.Forms.Button();
            this.BtnFS1 = new System.Windows.Forms.Button();
            this.BtnBC2 = new System.Windows.Forms.Button();
            this.BtnFC2 = new System.Windows.Forms.Button();
            this.BtnFS2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblWord
            // 
            this.LblWord.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblWord.Location = new System.Drawing.Point(12, 14);
            this.LblWord.Name = "LblWord";
            this.LblWord.Size = new System.Drawing.Size(267, 66);
            this.LblWord.TabIndex = 0;
            this.LblWord.Text = "金雞報喜";
            this.LblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBC1
            // 
            this.BtnBC1.Location = new System.Drawing.Point(12, 98);
            this.BtnBC1.Name = "BtnBC1";
            this.BtnBC1.Size = new System.Drawing.Size(75, 23);
            this.BtnBC1.TabIndex = 1;
            this.BtnBC1.Text = "黑底";
            this.BtnBC1.UseVisualStyleBackColor = true;
            this.BtnBC1.Click += new System.EventHandler(this.BtnBC1_Click);
            // 
            // BtnFC1
            // 
            this.BtnFC1.Location = new System.Drawing.Point(108, 98);
            this.BtnFC1.Name = "BtnFC1";
            this.BtnFC1.Size = new System.Drawing.Size(75, 23);
            this.BtnFC1.TabIndex = 2;
            this.BtnFC1.Text = "紅字";
            this.BtnFC1.UseVisualStyleBackColor = true;
            this.BtnFC1.Click += new System.EventHandler(this.BtnFC1_Click);
            // 
            // BtnFS1
            // 
            this.BtnFS1.Location = new System.Drawing.Point(204, 98);
            this.BtnFS1.Name = "BtnFS1";
            this.BtnFS1.Size = new System.Drawing.Size(75, 23);
            this.BtnFS1.TabIndex = 3;
            this.BtnFS1.Text = "粗體";
            this.BtnFS1.UseVisualStyleBackColor = true;
            this.BtnFS1.Click += new System.EventHandler(this.BtnFS1_Click);
            // 
            // BtnBC2
            // 
            this.BtnBC2.Location = new System.Drawing.Point(12, 139);
            this.BtnBC2.Name = "BtnBC2";
            this.BtnBC2.Size = new System.Drawing.Size(75, 23);
            this.BtnBC2.TabIndex = 4;
            this.BtnBC2.Text = "黃底";
            this.BtnBC2.UseVisualStyleBackColor = true;
            this.BtnBC2.Click += new System.EventHandler(this.BtnBC2_Click);
            // 
            // BtnFC2
            // 
            this.BtnFC2.Location = new System.Drawing.Point(108, 139);
            this.BtnFC2.Name = "BtnFC2";
            this.BtnFC2.Size = new System.Drawing.Size(75, 23);
            this.BtnFC2.TabIndex = 5;
            this.BtnFC2.Text = "藍字";
            this.BtnFC2.UseVisualStyleBackColor = true;
            this.BtnFC2.Click += new System.EventHandler(this.BtnFC2_Click);
            // 
            // BtnFS2
            // 
            this.BtnFS2.Location = new System.Drawing.Point(204, 139);
            this.BtnFS2.Name = "BtnFS2";
            this.BtnFS2.Size = new System.Drawing.Size(75, 23);
            this.BtnFS2.TabIndex = 6;
            this.BtnFS2.Text = "斜體";
            this.BtnFS2.UseVisualStyleBackColor = true;
            this.BtnFS2.Click += new System.EventHandler(this.BtnFS2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 176);
            this.Controls.Add(this.BtnFS2);
            this.Controls.Add(this.BtnFC2);
            this.Controls.Add(this.BtnBC2);
            this.Controls.Add(this.BtnFS1);
            this.Controls.Add(this.BtnFC1);
            this.Controls.Add(this.BtnBC1);
            this.Controls.Add(this.LblWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblWord;
        private System.Windows.Forms.Button BtnBC1;
        private System.Windows.Forms.Button BtnFC1;
        private System.Windows.Forms.Button BtnFS1;
        private System.Windows.Forms.Button BtnBC2;
        private System.Windows.Forms.Button BtnFC2;
        private System.Windows.Forms.Button BtnFS2;
    }
}

