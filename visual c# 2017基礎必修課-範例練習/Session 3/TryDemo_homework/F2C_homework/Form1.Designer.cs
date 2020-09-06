namespace F2C_homework
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
            this.TxtTemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAns = new System.Windows.Forms.TextBox();
            this.BtnFtoC = new System.Windows.Forms.Button();
            this.BtnCtoF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入溫度";
            // 
            // TxtTemp
            // 
            this.TxtTemp.Location = new System.Drawing.Point(100, 30);
            this.TxtTemp.Name = "TxtTemp";
            this.TxtTemp.Size = new System.Drawing.Size(146, 22);
            this.TxtTemp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "轉換成";
            // 
            // TxtAns
            // 
            this.TxtAns.Location = new System.Drawing.Point(100, 68);
            this.TxtAns.Name = "TxtAns";
            this.TxtAns.Size = new System.Drawing.Size(146, 22);
            this.TxtAns.TabIndex = 1;
            // 
            // BtnFtoC
            // 
            this.BtnFtoC.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnFtoC.Location = new System.Drawing.Point(265, 30);
            this.BtnFtoC.Name = "BtnFtoC";
            this.BtnFtoC.Size = new System.Drawing.Size(107, 23);
            this.BtnFtoC.TabIndex = 2;
            this.BtnFtoC.Text = "轉換成攝氏";
            this.BtnFtoC.UseVisualStyleBackColor = true;
            this.BtnFtoC.Click += new System.EventHandler(this.BtnFtoC_Click);
            // 
            // BtnCtoF
            // 
            this.BtnCtoF.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCtoF.Location = new System.Drawing.Point(265, 68);
            this.BtnCtoF.Name = "BtnCtoF";
            this.BtnCtoF.Size = new System.Drawing.Size(107, 23);
            this.BtnCtoF.TabIndex = 2;
            this.BtnCtoF.Text = "轉換成華氏";
            this.BtnCtoF.UseVisualStyleBackColor = true;
            this.BtnCtoF.Click += new System.EventHandler(this.BtnCtoF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 118);
            this.Controls.Add(this.BtnCtoF);
            this.Controls.Add(this.BtnFtoC);
            this.Controls.Add(this.TxtAns);
            this.Controls.Add(this.TxtTemp);
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
        private System.Windows.Forms.TextBox TxtTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAns;
        private System.Windows.Forms.Button BtnFtoC;
        private System.Windows.Forms.Button BtnCtoF;
    }
}

