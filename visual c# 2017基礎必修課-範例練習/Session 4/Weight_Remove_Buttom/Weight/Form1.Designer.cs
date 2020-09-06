namespace Weight
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
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbWoman = new System.Windows.Forms.RadioButton();
            this.RdbMan = new System.Windows.Forms.RadioButton();
            this.LblMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入身高(公分)：";
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(127, 18);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(159, 22);
            this.TxtHeight.TabIndex = 1;
            this.TxtHeight.TextChanged += new System.EventHandler(this.TxtHeight_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbWoman);
            this.groupBox1.Controls.Add(this.RdbMan);
            this.groupBox1.Location = new System.Drawing.Point(14, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "性別";
            // 
            // RdbWoman
            // 
            this.RdbWoman.AutoSize = true;
            this.RdbWoman.Location = new System.Drawing.Point(73, 22);
            this.RdbWoman.Name = "RdbWoman";
            this.RdbWoman.Size = new System.Drawing.Size(35, 16);
            this.RdbWoman.TabIndex = 0;
            this.RdbWoman.TabStop = true;
            this.RdbWoman.Text = "女";
            this.RdbWoman.UseVisualStyleBackColor = true;
            this.RdbWoman.CheckedChanged += new System.EventHandler(this.RdbWoman_CheckedChanged);
            // 
            // RdbMan
            // 
            this.RdbMan.AutoSize = true;
            this.RdbMan.Location = new System.Drawing.Point(7, 22);
            this.RdbMan.Name = "RdbMan";
            this.RdbMan.Size = new System.Drawing.Size(35, 16);
            this.RdbMan.TabIndex = 0;
            this.RdbMan.TabStop = true;
            this.RdbMan.Text = "男";
            this.RdbMan.UseVisualStyleBackColor = true;
            this.RdbMan.CheckedChanged += new System.EventHandler(this.RdbMan_CheckedChanged);
            // 
            // LblMsg
            // 
            this.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMsg.Location = new System.Drawing.Point(147, 85);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(139, 23);
            this.LblMsg.TabIndex = 4;
            this.LblMsg.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 128);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtHeight);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbWoman;
        private System.Windows.Forms.RadioButton RdbMan;
        private System.Windows.Forms.Label LblMsg;
    }
}

