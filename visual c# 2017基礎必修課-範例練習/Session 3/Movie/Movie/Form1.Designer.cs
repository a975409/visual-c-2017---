﻿namespace Movie
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
            this.LblPriceF = new System.Windows.Forms.Label();
            this.TxtQtyF = new System.Windows.Forms.TextBox();
            this.LblSumF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "單價";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "張數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "全票";
            // 
            // LblPriceF
            // 
            this.LblPriceF.AutoSize = true;
            this.LblPriceF.Location = new System.Drawing.Point(79, 58);
            this.LblPriceF.Name = "LblPriceF";
            this.LblPriceF.Size = new System.Drawing.Size(23, 12);
            this.LblPriceF.TabIndex = 1;
            this.LblPriceF.Text = "250";
            // 
            // TxtQtyF
            // 
            this.TxtQtyF.Location = new System.Drawing.Point(136, 58);
            this.TxtQtyF.Name = "TxtQtyF";
            this.TxtQtyF.Size = new System.Drawing.Size(56, 22);
            this.TxtQtyF.TabIndex = 2;
            this.TxtQtyF.TextChanged += new System.EventHandler(this.TxtQtyF_TextChanged);
            this.TxtQtyF.Enter += new System.EventHandler(this.TxtQtyF_Enter);
            // 
            // LblSumF
            // 
            this.LblSumF.AutoSize = true;
            this.LblSumF.Location = new System.Drawing.Point(222, 58);
            this.LblSumF.Name = "LblSumF";
            this.LblSumF.Size = new System.Drawing.Size(23, 12);
            this.LblSumF.TabIndex = 1;
            this.LblSumF.Text = "250";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 104);
            this.Controls.Add(this.TxtQtyF);
            this.Controls.Add(this.LblSumF);
            this.Controls.Add(this.LblPriceF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPriceF;
        private System.Windows.Forms.TextBox TxtQtyF;
        private System.Windows.Forms.Label LblSumF;
    }
}

