namespace GPAAvg
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
            this.label6 = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.TxtHour = new System.Windows.Forms.TextBox();
            this.LblSumGPA = new System.Windows.Forms.Label();
            this.LblSumCourses = new System.Windows.Forms.Label();
            this.LblAvgGPA = new System.Windows.Forms.Label();
            this.TxtOK = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.課程代號：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(47, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "2.學習成績：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(47, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "3.學分數：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(47, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "4.累計GPA積點x學分：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(47, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "5.目前累計總學分數：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(47, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "6.本學期平均GPA：";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.BackColor = System.Drawing.Color.DarkGray;
            this.LblMsg.Location = new System.Drawing.Point(47, 334);
            this.LblMsg.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(0, 24);
            this.LblMsg.TabIndex = 0;
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtCode.Location = new System.Drawing.Point(217, 39);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(100, 30);
            this.TxtCode.TabIndex = 1;
            // 
            // TxtScore
            // 
            this.TxtScore.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtScore.Location = new System.Drawing.Point(217, 86);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(100, 30);
            this.TxtScore.TabIndex = 1;
            // 
            // TxtHour
            // 
            this.TxtHour.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtHour.Location = new System.Drawing.Point(217, 136);
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(100, 30);
            this.TxtHour.TabIndex = 1;
            // 
            // LblSumGPA
            // 
            this.LblSumGPA.AutoSize = true;
            this.LblSumGPA.Location = new System.Drawing.Point(324, 185);
            this.LblSumGPA.Name = "LblSumGPA";
            this.LblSumGPA.Size = new System.Drawing.Size(64, 24);
            this.LblSumGPA.TabIndex = 2;
            this.LblSumGPA.Text = "label8";
            // 
            // LblSumCourses
            // 
            this.LblSumCourses.AutoSize = true;
            this.LblSumCourses.Location = new System.Drawing.Point(324, 235);
            this.LblSumCourses.Name = "LblSumCourses";
            this.LblSumCourses.Size = new System.Drawing.Size(64, 24);
            this.LblSumCourses.TabIndex = 2;
            this.LblSumCourses.Text = "label8";
            // 
            // LblAvgGPA
            // 
            this.LblAvgGPA.AutoSize = true;
            this.LblAvgGPA.Location = new System.Drawing.Point(324, 284);
            this.LblAvgGPA.Name = "LblAvgGPA";
            this.LblAvgGPA.Size = new System.Drawing.Size(64, 24);
            this.LblAvgGPA.TabIndex = 2;
            this.LblAvgGPA.Text = "label8";
            // 
            // TxtOK
            // 
            this.TxtOK.Location = new System.Drawing.Point(349, 39);
            this.TxtOK.Name = "TxtOK";
            this.TxtOK.Size = new System.Drawing.Size(75, 30);
            this.TxtOK.TabIndex = 3;
            this.TxtOK.Text = "累計";
            this.TxtOK.UseVisualStyleBackColor = true;
            this.TxtOK.Click += new System.EventHandler(this.TxtOK_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(349, 86);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(75, 30);
            this.BtnQuit.TabIndex = 3;
            this.BtnQuit.Text = "離開";
            this.BtnQuit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 433);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.TxtOK);
            this.Controls.Add(this.LblAvgGPA);
            this.Controls.Add(this.LblSumCourses);
            this.Controls.Add(this.LblSumGPA);
            this.Controls.Add(this.TxtHour);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.TextBox TxtHour;
        private System.Windows.Forms.Label LblSumGPA;
        private System.Windows.Forms.Label LblSumCourses;
        private System.Windows.Forms.Label LblAvgGPA;
        private System.Windows.Forms.Button TxtOK;
        private System.Windows.Forms.Button BtnQuit;
    }
}

