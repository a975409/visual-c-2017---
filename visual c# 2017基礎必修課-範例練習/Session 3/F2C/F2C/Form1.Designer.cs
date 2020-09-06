namespace F2C
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
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnF2C = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入華氏溫度";
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(154, 33);
            this.TxtInput.MaxLength = 3;
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(162, 22);
            this.TxtInput.TabIndex = 1;
            // 
            // BtnF2C
            // 
            this.BtnF2C.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnF2C.Location = new System.Drawing.Point(154, 71);
            this.BtnF2C.Name = "BtnF2C";
            this.BtnF2C.Size = new System.Drawing.Size(99, 32);
            this.BtnF2C.TabIndex = 2;
            this.BtnF2C.Text = "轉換成攝氏";
            this.BtnF2C.UseVisualStyleBackColor = true;
            this.BtnF2C.Click += new System.EventHandler(this.BtnF2C_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(98, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "攝氏";
            // 
            // TxtAns
            // 
            this.TxtAns.Location = new System.Drawing.Point(154, 117);
            this.TxtAns.Name = "TxtAns";
            this.TxtAns.ReadOnly = true;
            this.TxtAns.Size = new System.Drawing.Size(162, 22);
            this.TxtAns.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 170);
            this.Controls.Add(this.BtnF2C);
            this.Controls.Add(this.TxtAns);
            this.Controls.Add(this.TxtInput);
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
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button BtnF2C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAns;
    }
}

