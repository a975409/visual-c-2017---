namespace Movie_homework
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPrice_250 = new System.Windows.Forms.Label();
            this.LblPrice_200 = new System.Windows.Forms.Label();
            this.TxtQty250 = new System.Windows.Forms.TextBox();
            this.TxtQty200 = new System.Windows.Forms.TextBox();
            this.LblSum250 = new System.Windows.Forms.Label();
            this.LblSum200 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblAllSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "單價";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "張數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "全票";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "優待票";
            // 
            // LblPrice_250
            // 
            this.LblPrice_250.AutoSize = true;
            this.LblPrice_250.Location = new System.Drawing.Point(99, 51);
            this.LblPrice_250.Name = "LblPrice_250";
            this.LblPrice_250.Size = new System.Drawing.Size(23, 12);
            this.LblPrice_250.TabIndex = 0;
            this.LblPrice_250.Text = "250";
            // 
            // LblPrice_200
            // 
            this.LblPrice_200.AutoSize = true;
            this.LblPrice_200.Location = new System.Drawing.Point(99, 90);
            this.LblPrice_200.Name = "LblPrice_200";
            this.LblPrice_200.Size = new System.Drawing.Size(23, 12);
            this.LblPrice_200.TabIndex = 0;
            this.LblPrice_200.Text = "200";
            // 
            // TxtQty250
            // 
            this.TxtQty250.Location = new System.Drawing.Point(173, 48);
            this.TxtQty250.Name = "TxtQty250";
            this.TxtQty250.Size = new System.Drawing.Size(100, 22);
            this.TxtQty250.TabIndex = 1;
            this.TxtQty250.TextChanged += new System.EventHandler(this.TxtQty250_TextChanged);
            this.TxtQty250.Enter += new System.EventHandler(this.TxtQty250_Enter);
            // 
            // TxtQty200
            // 
            this.TxtQty200.Location = new System.Drawing.Point(173, 87);
            this.TxtQty200.Name = "TxtQty200";
            this.TxtQty200.Size = new System.Drawing.Size(100, 22);
            this.TxtQty200.TabIndex = 1;
            this.TxtQty200.TextChanged += new System.EventHandler(this.TxtQty200_TextChanged);
            this.TxtQty200.Enter += new System.EventHandler(this.TxtQty200_Enter);
            // 
            // LblSum250
            // 
            this.LblSum250.AutoSize = true;
            this.LblSum250.Location = new System.Drawing.Point(302, 51);
            this.LblSum250.Name = "LblSum250";
            this.LblSum250.Size = new System.Drawing.Size(23, 12);
            this.LblSum250.TabIndex = 0;
            this.LblSum250.Text = "250";
            this.LblSum250.TextChanged += new System.EventHandler(this.LblSum250_TextChanged);
            // 
            // LblSum200
            // 
            this.LblSum200.AutoSize = true;
            this.LblSum200.Location = new System.Drawing.Point(302, 90);
            this.LblSum200.Name = "LblSum200";
            this.LblSum200.Size = new System.Drawing.Size(23, 12);
            this.LblSum200.TabIndex = 0;
            this.LblSum200.Text = "250";
            this.LblSum200.TextChanged += new System.EventHandler(this.LblSum250_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "合計";
            // 
            // LblAllSum
            // 
            this.LblAllSum.AutoSize = true;
            this.LblAllSum.Location = new System.Drawing.Point(302, 126);
            this.LblAllSum.Name = "LblAllSum";
            this.LblAllSum.Size = new System.Drawing.Size(11, 12);
            this.LblAllSum.TabIndex = 0;
            this.LblAllSum.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 170);
            this.Controls.Add(this.TxtQty200);
            this.Controls.Add(this.TxtQty250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblPrice_200);
            this.Controls.Add(this.LblAllSum);
            this.Controls.Add(this.LblSum200);
            this.Controls.Add(this.LblSum250);
            this.Controls.Add(this.LblPrice_250);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPrice_250;
        private System.Windows.Forms.Label LblPrice_200;
        private System.Windows.Forms.TextBox TxtQty250;
        private System.Windows.Forms.TextBox TxtQty200;
        private System.Windows.Forms.Label LblSum250;
        private System.Windows.Forms.Label LblSum200;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblAllSum;
    }
}

