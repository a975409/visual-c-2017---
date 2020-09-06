namespace Camera_Shop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdbCamera_5980 = new System.Windows.Forms.RadioButton();
            this.RdbCamera_4980 = new System.Windows.Forms.RadioButton();
            this.RdbCamera_2980 = new System.Windows.Forms.RadioButton();
            this.RdbClean = new System.Windows.Forms.RadioButton();
            this.RdbProtection = new System.Windows.Forms.RadioButton();
            this.RdbMoistureproof = new System.Windows.Forms.RadioButton();
            this.ChkSD = new System.Windows.Forms.CheckBox();
            this.ChkBattery = new System.Windows.Forms.CheckBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "數位相機購物中心";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbCamera_2980);
            this.groupBox1.Controls.Add(this.RdbCamera_4980);
            this.groupBox1.Controls.Add(this.RdbCamera_5980);
            this.groupBox1.Location = new System.Drawing.Point(41, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "相機";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbMoistureproof);
            this.groupBox2.Controls.Add(this.RdbClean);
            this.groupBox2.Controls.Add(this.RdbProtection);
            this.groupBox2.Location = new System.Drawing.Point(165, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "贈品";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChkBattery);
            this.groupBox3.Controls.Add(this.ChkSD);
            this.groupBox3.Location = new System.Drawing.Point(41, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 73);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "加價購";
            // 
            // RdbCamera_5980
            // 
            this.RdbCamera_5980.AutoSize = true;
            this.RdbCamera_5980.Location = new System.Drawing.Point(7, 22);
            this.RdbCamera_5980.Name = "RdbCamera_5980";
            this.RdbCamera_5980.Size = new System.Drawing.Size(95, 16);
            this.RdbCamera_5980.TabIndex = 0;
            this.RdbCamera_5980.TabStop = true;
            this.RdbCamera_5980.Text = "時尚機5980元";
            this.RdbCamera_5980.UseVisualStyleBackColor = true;
            // 
            // RdbCamera_4980
            // 
            this.RdbCamera_4980.AutoSize = true;
            this.RdbCamera_4980.Location = new System.Drawing.Point(7, 44);
            this.RdbCamera_4980.Name = "RdbCamera_4980";
            this.RdbCamera_4980.Size = new System.Drawing.Size(95, 16);
            this.RdbCamera_4980.TabIndex = 0;
            this.RdbCamera_4980.TabStop = true;
            this.RdbCamera_4980.Text = "功能機4980元";
            this.RdbCamera_4980.UseVisualStyleBackColor = true;
            // 
            // RdbCamera_2980
            // 
            this.RdbCamera_2980.AutoSize = true;
            this.RdbCamera_2980.Location = new System.Drawing.Point(7, 66);
            this.RdbCamera_2980.Name = "RdbCamera_2980";
            this.RdbCamera_2980.Size = new System.Drawing.Size(95, 16);
            this.RdbCamera_2980.TabIndex = 0;
            this.RdbCamera_2980.TabStop = true;
            this.RdbCamera_2980.Text = "可愛機2980元";
            this.RdbCamera_2980.UseVisualStyleBackColor = true;
            // 
            // RdbClean
            // 
            this.RdbClean.AutoSize = true;
            this.RdbClean.Location = new System.Drawing.Point(6, 22);
            this.RdbClean.Name = "RdbClean";
            this.RdbClean.Size = new System.Drawing.Size(59, 16);
            this.RdbClean.TabIndex = 0;
            this.RdbClean.TabStop = true;
            this.RdbClean.Text = "清潔組";
            this.RdbClean.UseVisualStyleBackColor = true;
            // 
            // RdbProtection
            // 
            this.RdbProtection.AutoSize = true;
            this.RdbProtection.Location = new System.Drawing.Point(6, 44);
            this.RdbProtection.Name = "RdbProtection";
            this.RdbProtection.Size = new System.Drawing.Size(59, 16);
            this.RdbProtection.TabIndex = 0;
            this.RdbProtection.TabStop = true;
            this.RdbProtection.Text = "保護貼";
            this.RdbProtection.UseVisualStyleBackColor = true;
            // 
            // RdbMoistureproof
            // 
            this.RdbMoistureproof.AutoSize = true;
            this.RdbMoistureproof.Location = new System.Drawing.Point(6, 66);
            this.RdbMoistureproof.Name = "RdbMoistureproof";
            this.RdbMoistureproof.Size = new System.Drawing.Size(59, 16);
            this.RdbMoistureproof.TabIndex = 0;
            this.RdbMoistureproof.TabStop = true;
            this.RdbMoistureproof.Text = "防潮盒";
            this.RdbMoistureproof.UseVisualStyleBackColor = true;
            // 
            // ChkSD
            // 
            this.ChkSD.AutoSize = true;
            this.ChkSD.Location = new System.Drawing.Point(7, 22);
            this.ChkSD.Name = "ChkSD";
            this.ChkSD.Size = new System.Drawing.Size(126, 16);
            this.ChkSD.TabIndex = 0;
            this.ChkSD.Text = "大容量記憶卡599元";
            this.ChkSD.UseVisualStyleBackColor = true;
            // 
            // ChkBattery
            // 
            this.ChkBattery.AutoSize = true;
            this.ChkBattery.Location = new System.Drawing.Point(7, 44);
            this.ChkBattery.Name = "ChkBattery";
            this.ChkBattery.Size = new System.Drawing.Size(102, 16);
            this.ChkBattery.TabIndex = 0;
            this.ChkBattery.Text = "專用電池499元";
            this.ChkBattery.UseVisualStyleBackColor = true;
            // 
            // LblMsg
            // 
            this.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMsg.Location = new System.Drawing.Point(41, 262);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(164, 25);
            this.LblMsg.TabIndex = 2;
            this.LblMsg.Text = "label2";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(214, 265);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 325);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblMsg);
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
        private System.Windows.Forms.RadioButton RdbCamera_2980;
        private System.Windows.Forms.RadioButton RdbCamera_4980;
        private System.Windows.Forms.RadioButton RdbCamera_5980;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdbMoistureproof;
        private System.Windows.Forms.RadioButton RdbClean;
        private System.Windows.Forms.RadioButton RdbProtection;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ChkBattery;
        private System.Windows.Forms.CheckBox ChkSD;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Button BtnOK;
    }
}

