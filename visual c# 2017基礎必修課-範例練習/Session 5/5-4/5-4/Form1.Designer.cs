namespace _5_4
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
            this.TxtRxdollor = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLast = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Num_1000 = new System.Windows.Forms.TextBox();
            this.Txt_Num_500 = new System.Windows.Forms.TextBox();
            this.Txt_Num_100 = new System.Windows.Forms.TextBox();
            this.Txt_Num_50 = new System.Windows.Forms.TextBox();
            this.Txt_Num_10 = new System.Windows.Forms.TextBox();
            this.Txt_Num_5 = new System.Windows.Forms.TextBox();
            this.Txt_Num_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "收現：";
            // 
            // TxtRxdollor
            // 
            this.TxtRxdollor.Location = new System.Drawing.Point(36, 43);
            this.TxtRxdollor.Name = "TxtRxdollor";
            this.TxtRxdollor.Size = new System.Drawing.Size(136, 22);
            this.TxtRxdollor.TabIndex = 1;
            this.TxtRxdollor.Enter += new System.EventHandler(this.TxtRxdollor_Enter);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(23, 87);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 12);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "消費：";
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(36, 102);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(136, 22);
            this.TxtCost.TabIndex = 1;
            this.TxtCost.Enter += new System.EventHandler(this.TxtCost_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "找零：";
            // 
            // TxtLast
            // 
            this.TxtLast.Location = new System.Drawing.Point(36, 162);
            this.TxtLast.Name = "TxtLast";
            this.TxtLast.Size = new System.Drawing.Size(136, 22);
            this.TxtLast.TabIndex = 1;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(97, 200);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "計算";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "1000元";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "500元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "100元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "50元";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "5元";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "10元";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "1元";
            // 
            // Txt_Num_1000
            // 
            this.Txt_Num_1000.Location = new System.Drawing.Point(253, 24);
            this.Txt_Num_1000.Name = "Txt_Num_1000";
            this.Txt_Num_1000.Size = new System.Drawing.Size(91, 22);
            this.Txt_Num_1000.TabIndex = 1;
            // 
            // Txt_Num_500
            // 
            this.Txt_Num_500.Location = new System.Drawing.Point(253, 61);
            this.Txt_Num_500.Name = "Txt_Num_500";
            this.Txt_Num_500.Size = new System.Drawing.Size(91, 22);
            this.Txt_Num_500.TabIndex = 1;
            // 
            // Txt_Num_100
            // 
            this.Txt_Num_100.Location = new System.Drawing.Point(253, 98);
            this.Txt_Num_100.Name = "Txt_Num_100";
            this.Txt_Num_100.Size = new System.Drawing.Size(91, 22);
            this.Txt_Num_100.TabIndex = 1;
            // 
            // Txt_Num_50
            // 
            this.Txt_Num_50.Location = new System.Drawing.Point(253, 135);
            this.Txt_Num_50.Name = "Txt_Num_50";
            this.Txt_Num_50.Size = new System.Drawing.Size(91, 22);
            this.Txt_Num_50.TabIndex = 1;
            // 
            // Txt_Num_10
            // 
            this.Txt_Num_10.Location = new System.Drawing.Point(253, 172);
            this.Txt_Num_10.Name = "Txt_Num_10";
            this.Txt_Num_10.Size = new System.Drawing.Size(91, 22);
            this.Txt_Num_10.TabIndex = 1;
            // 
            // Txt_Num_5
            // 
            this.Txt_Num_5.Location = new System.Drawing.Point(253, 209);
            this.Txt_Num_5.Name = "Txt_Num_5";
            this.Txt_Num_5.Size = new System.Drawing.Size(91, 22);
            this.Txt_Num_5.TabIndex = 1;
            // 
            // Txt_Num_1
            // 
            this.Txt_Num_1.Location = new System.Drawing.Point(253, 246);
            this.Txt_Num_1.Name = "Txt_Num_1";
            this.Txt_Num_1.Size = new System.Drawing.Size(91, 22);
            this.Txt_Num_1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 298);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtLast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Txt_Num_1);
            this.Controls.Add(this.Txt_Num_5);
            this.Controls.Add(this.Txt_Num_100);
            this.Controls.Add(this.Txt_Num_10);
            this.Controls.Add(this.Txt_Num_500);
            this.Controls.Add(this.Txt_Num_50);
            this.Controls.Add(this.Txt_Num_1000);
            this.Controls.Add(this.TxtRxdollor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRxdollor;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLast;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Num_1000;
        private System.Windows.Forms.TextBox Txt_Num_500;
        private System.Windows.Forms.TextBox Txt_Num_100;
        private System.Windows.Forms.TextBox Txt_Num_50;
        private System.Windows.Forms.TextBox Txt_Num_10;
        private System.Windows.Forms.TextBox Txt_Num_5;
        private System.Windows.Forms.TextBox Txt_Num_1;
    }
}

