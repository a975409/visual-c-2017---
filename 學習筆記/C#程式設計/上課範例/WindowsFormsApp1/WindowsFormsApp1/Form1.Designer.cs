
namespace WindowsFormsApp1
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblResponMsg = new System.Windows.Forms.Label();
            this.BtnBlackTea = new System.Windows.Forms.Button();
            this.BtnGreenTea = new System.Windows.Forms.Button();
            this.BtnMilkTea = new System.Windows.Forms.Button();
            this.BtnCoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Chartreuse;
            this.LblTitle.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblTitle.ForeColor = System.Drawing.Color.Black;
            this.LblTitle.Location = new System.Drawing.Point(124, 12);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(362, 63);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "冷飲選購";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblResponMsg
            // 
            this.LblResponMsg.BackColor = System.Drawing.Color.Orange;
            this.LblResponMsg.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblResponMsg.ForeColor = System.Drawing.Color.Black;
            this.LblResponMsg.Location = new System.Drawing.Point(15, 89);
            this.LblResponMsg.Name = "LblResponMsg";
            this.LblResponMsg.Size = new System.Drawing.Size(576, 225);
            this.LblResponMsg.TabIndex = 0;
            this.LblResponMsg.Text = "回應訊息";
            // 
            // BtnBlackTea
            // 
            this.BtnBlackTea.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnBlackTea.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnBlackTea.ForeColor = System.Drawing.Color.White;
            this.BtnBlackTea.Location = new System.Drawing.Point(12, 326);
            this.BtnBlackTea.Name = "BtnBlackTea";
            this.BtnBlackTea.Size = new System.Drawing.Size(141, 63);
            this.BtnBlackTea.TabIndex = 1;
            this.BtnBlackTea.Text = "紅茶";
            this.BtnBlackTea.UseVisualStyleBackColor = false;
            this.BtnBlackTea.Click += new System.EventHandler(this.BtnBlackTea_Click);
            // 
            // BtnGreenTea
            // 
            this.BtnGreenTea.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnGreenTea.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnGreenTea.ForeColor = System.Drawing.Color.Black;
            this.BtnGreenTea.Location = new System.Drawing.Point(158, 326);
            this.BtnGreenTea.Name = "BtnGreenTea";
            this.BtnGreenTea.Size = new System.Drawing.Size(141, 63);
            this.BtnGreenTea.TabIndex = 1;
            this.BtnGreenTea.Text = "綠茶";
            this.BtnGreenTea.UseVisualStyleBackColor = false;
            this.BtnGreenTea.Click += new System.EventHandler(this.BtnGreenTea_Click);
            // 
            // BtnMilkTea
            // 
            this.BtnMilkTea.BackColor = System.Drawing.Color.NavajoWhite;
            this.BtnMilkTea.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnMilkTea.ForeColor = System.Drawing.Color.Black;
            this.BtnMilkTea.Location = new System.Drawing.Point(304, 326);
            this.BtnMilkTea.Name = "BtnMilkTea";
            this.BtnMilkTea.Size = new System.Drawing.Size(141, 63);
            this.BtnMilkTea.TabIndex = 1;
            this.BtnMilkTea.Text = "奶茶";
            this.BtnMilkTea.UseVisualStyleBackColor = false;
            this.BtnMilkTea.Click += new System.EventHandler(this.BtnMilkTea_Click);
            // 
            // BtnCoke
            // 
            this.BtnCoke.BackColor = System.Drawing.Color.DarkViolet;
            this.BtnCoke.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCoke.ForeColor = System.Drawing.Color.White;
            this.BtnCoke.Location = new System.Drawing.Point(450, 326);
            this.BtnCoke.Name = "BtnCoke";
            this.BtnCoke.Size = new System.Drawing.Size(141, 63);
            this.BtnCoke.TabIndex = 1;
            this.BtnCoke.Text = "可樂";
            this.BtnCoke.UseVisualStyleBackColor = false;
            this.BtnCoke.Click += new System.EventHandler(this.BtnCoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(609, 399);
            this.Controls.Add(this.BtnCoke);
            this.Controls.Add(this.BtnMilkTea);
            this.Controls.Add(this.BtnGreenTea);
            this.Controls.Add(this.BtnBlackTea);
            this.Controls.Add(this.LblResponMsg);
            this.Controls.Add(this.LblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "冷飲選購";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblResponMsg;
        private System.Windows.Forms.Button BtnBlackTea;
        private System.Windows.Forms.Button BtnGreenTea;
        private System.Windows.Forms.Button BtnMilkTea;
        private System.Windows.Forms.Button BtnCoke;
    }
}

