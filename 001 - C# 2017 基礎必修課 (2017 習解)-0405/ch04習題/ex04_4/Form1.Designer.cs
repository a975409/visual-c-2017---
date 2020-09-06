namespace ex04_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbA1 = new System.Windows.Forms.RadioButton();
            this.RdbA2 = new System.Windows.Forms.RadioButton();
            this.RdbA3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChkC1 = new System.Windows.Forms.CheckBox();
            this.ChkC2 = new System.Windows.Forms.CheckBox();
            this.RdbB1 = new System.Windows.Forms.RadioButton();
            this.RdbB2 = new System.Windows.Forms.RadioButton();
            this.RdbB3 = new System.Windows.Forms.RadioButton();
            this.BtnOK = new System.Windows.Forms.Button();
            this.LblMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "數位相機購物中心";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbA3);
            this.groupBox1.Controls.Add(this.RdbA2);
            this.groupBox1.Controls.Add(this.RdbA1);
            this.groupBox1.Location = new System.Drawing.Point(15, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "相機";
            // 
            // RdbA1
            // 
            this.RdbA1.AutoSize = true;
            this.RdbA1.Location = new System.Drawing.Point(8, 24);
            this.RdbA1.Name = "RdbA1";
            this.RdbA1.Size = new System.Drawing.Size(101, 16);
            this.RdbA1.TabIndex = 0;
            this.RdbA1.TabStop = true;
            this.RdbA1.Text = "時尚機 5,980元";
            this.RdbA1.UseVisualStyleBackColor = true;
            // 
            // RdbA2
            // 
            this.RdbA2.AutoSize = true;
            this.RdbA2.Location = new System.Drawing.Point(8, 54);
            this.RdbA2.Name = "RdbA2";
            this.RdbA2.Size = new System.Drawing.Size(101, 16);
            this.RdbA2.TabIndex = 1;
            this.RdbA2.TabStop = true;
            this.RdbA2.Text = "功能機 4,980元";
            this.RdbA2.UseVisualStyleBackColor = true;
            // 
            // RdbA3
            // 
            this.RdbA3.AutoSize = true;
            this.RdbA3.Location = new System.Drawing.Point(8, 84);
            this.RdbA3.Name = "RdbA3";
            this.RdbA3.Size = new System.Drawing.Size(101, 16);
            this.RdbA3.TabIndex = 2;
            this.RdbA3.TabStop = true;
            this.RdbA3.Text = "可愛機 2,980元";
            this.RdbA3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbB3);
            this.groupBox2.Controls.Add(this.RdbB2);
            this.groupBox2.Controls.Add(this.RdbB1);
            this.groupBox2.Location = new System.Drawing.Point(155, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "購品";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChkC2);
            this.groupBox3.Controls.Add(this.ChkC1);
            this.groupBox3.Location = new System.Drawing.Point(15, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 73);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "加價購";
            // 
            // ChkC1
            // 
            this.ChkC1.AutoSize = true;
            this.ChkC1.Location = new System.Drawing.Point(8, 23);
            this.ChkC1.Name = "ChkC1";
            this.ChkC1.Size = new System.Drawing.Size(129, 16);
            this.ChkC1.TabIndex = 0;
            this.ChkC1.Text = "大容量記憶卡 599元";
            this.ChkC1.UseVisualStyleBackColor = true;
            // 
            // ChkC2
            // 
            this.ChkC2.AutoSize = true;
            this.ChkC2.Location = new System.Drawing.Point(8, 45);
            this.ChkC2.Name = "ChkC2";
            this.ChkC2.Size = new System.Drawing.Size(105, 16);
            this.ChkC2.TabIndex = 1;
            this.ChkC2.Text = "專用電池 499元";
            this.ChkC2.UseVisualStyleBackColor = true;
            // 
            // RdbB1
            // 
            this.RdbB1.AutoSize = true;
            this.RdbB1.Location = new System.Drawing.Point(7, 24);
            this.RdbB1.Name = "RdbB1";
            this.RdbB1.Size = new System.Drawing.Size(59, 16);
            this.RdbB1.TabIndex = 0;
            this.RdbB1.TabStop = true;
            this.RdbB1.Text = "清潔組";
            this.RdbB1.UseVisualStyleBackColor = true;
            // 
            // RdbB2
            // 
            this.RdbB2.AutoSize = true;
            this.RdbB2.Location = new System.Drawing.Point(7, 54);
            this.RdbB2.Name = "RdbB2";
            this.RdbB2.Size = new System.Drawing.Size(59, 16);
            this.RdbB2.TabIndex = 1;
            this.RdbB2.TabStop = true;
            this.RdbB2.Text = "保護貼";
            this.RdbB2.UseVisualStyleBackColor = true;
            // 
            // RdbB3
            // 
            this.RdbB3.AutoSize = true;
            this.RdbB3.Location = new System.Drawing.Point(7, 84);
            this.RdbB3.Name = "RdbB3";
            this.RdbB3.Size = new System.Drawing.Size(59, 16);
            this.RdbB3.TabIndex = 2;
            this.RdbB3.TabStop = true;
            this.RdbB3.Text = "防潮盒";
            this.RdbB3.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(197, 233);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(18, 271);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(33, 12);
            this.LblMsg.TabIndex = 5;
            this.LblMsg.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 298);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbA3;
        private System.Windows.Forms.RadioButton RdbA2;
        private System.Windows.Forms.RadioButton RdbA1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ChkC2;
        private System.Windows.Forms.CheckBox ChkC1;
        private System.Windows.Forms.RadioButton RdbB3;
        private System.Windows.Forms.RadioButton RdbB2;
        private System.Windows.Forms.RadioButton RdbB1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LblMsg;
    }
}

