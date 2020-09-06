namespace Train
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
            this.TxtKm = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbKind1 = new System.Windows.Forms.RadioButton();
            this.RdbKind2 = new System.Windows.Forms.RadioButton();
            this.RdbKind3 = new System.Windows.Forms.RadioButton();
            this.ChkSpecial = new System.Windows.Forms.CheckBox();
            this.ChkToBack = new System.Windows.Forms.CheckBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入公里數：";
            // 
            // TxtKm
            // 
            this.TxtKm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtKm.Location = new System.Drawing.Point(106, 26);
            this.TxtKm.Name = "TxtKm";
            this.TxtKm.Size = new System.Drawing.Size(100, 22);
            this.TxtKm.TabIndex = 1;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(213, 26);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbKind3);
            this.groupBox1.Controls.Add(this.RdbKind2);
            this.groupBox1.Controls.Add(this.RdbKind1);
            this.groupBox1.Location = new System.Drawing.Point(25, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "車種";
            // 
            // RdbKind1
            // 
            this.RdbKind1.AutoSize = true;
            this.RdbKind1.Location = new System.Drawing.Point(7, 22);
            this.RdbKind1.Name = "RdbKind1";
            this.RdbKind1.Size = new System.Drawing.Size(59, 16);
            this.RdbKind1.TabIndex = 0;
            this.RdbKind1.TabStop = true;
            this.RdbKind1.Text = "自強號";
            this.RdbKind1.UseVisualStyleBackColor = true;
            // 
            // RdbKind2
            // 
            this.RdbKind2.AutoSize = true;
            this.RdbKind2.Location = new System.Drawing.Point(6, 44);
            this.RdbKind2.Name = "RdbKind2";
            this.RdbKind2.Size = new System.Drawing.Size(59, 16);
            this.RdbKind2.TabIndex = 0;
            this.RdbKind2.TabStop = true;
            this.RdbKind2.Text = "莒光號";
            this.RdbKind2.UseVisualStyleBackColor = true;
            // 
            // RdbKind3
            // 
            this.RdbKind3.AutoSize = true;
            this.RdbKind3.Location = new System.Drawing.Point(6, 66);
            this.RdbKind3.Name = "RdbKind3";
            this.RdbKind3.Size = new System.Drawing.Size(98, 16);
            this.RdbKind3.TabIndex = 0;
            this.RdbKind3.TabStop = true;
            this.RdbKind3.Text = "復興號/區間車";
            this.RdbKind3.UseVisualStyleBackColor = true;
            // 
            // ChkSpecial
            // 
            this.ChkSpecial.AutoSize = true;
            this.ChkSpecial.Location = new System.Drawing.Point(159, 68);
            this.ChkSpecial.Name = "ChkSpecial";
            this.ChkSpecial.Size = new System.Drawing.Size(128, 16);
            this.ChkSpecial.TabIndex = 4;
            this.ChkSpecial.Text = "優待票(孩童、敬老)";
            this.ChkSpecial.UseVisualStyleBackColor = true;
            // 
            // ChkToBack
            // 
            this.ChkToBack.AutoSize = true;
            this.ChkToBack.Location = new System.Drawing.Point(159, 90);
            this.ChkToBack.Name = "ChkToBack";
            this.ChkToBack.Size = new System.Drawing.Size(60, 16);
            this.ChkToBack.TabIndex = 4;
            this.ChkToBack.Text = "去回票";
            this.ChkToBack.UseVisualStyleBackColor = true;
            // 
            // LblMsg
            // 
            this.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMsg.Location = new System.Drawing.Point(149, 124);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(138, 33);
            this.LblMsg.TabIndex = 5;
            this.LblMsg.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 180);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.ChkToBack);
            this.Controls.Add(this.ChkSpecial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtKm);
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
        private System.Windows.Forms.TextBox TxtKm;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbKind3;
        private System.Windows.Forms.RadioButton RdbKind2;
        private System.Windows.Forms.RadioButton RdbKind1;
        private System.Windows.Forms.CheckBox ChkSpecial;
        private System.Windows.Forms.CheckBox ChkToBack;
        private System.Windows.Forms.Label LblMsg;
    }
}

