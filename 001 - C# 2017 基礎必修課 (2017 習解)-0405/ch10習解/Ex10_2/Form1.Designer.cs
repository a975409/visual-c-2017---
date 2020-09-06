namespace Ex10_2
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
            this.components = new System.ComponentModel.Container();
            this.pic = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.第一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最後一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.ContextMenuStrip = this.contextMenuStrip1;
            this.pic.Location = new System.Drawing.Point(12, 19);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(281, 161);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.第一張ToolStripMenuItem,
            this.下一張ToolStripMenuItem,
            this.上一張ToolStripMenuItem,
            this.最後一張ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
            // 
            // 第一張ToolStripMenuItem
            // 
            this.第一張ToolStripMenuItem.Name = "第一張ToolStripMenuItem";
            this.第一張ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.第一張ToolStripMenuItem.Text = "第一張";
            this.第一張ToolStripMenuItem.Click += new System.EventHandler(this.第一張ToolStripMenuItem_Click);
            // 
            // 上一張ToolStripMenuItem
            // 
            this.上一張ToolStripMenuItem.Name = "上一張ToolStripMenuItem";
            this.上一張ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.上一張ToolStripMenuItem.Text = "上一張";
            this.上一張ToolStripMenuItem.Click += new System.EventHandler(this.上一張ToolStripMenuItem_Click);
            // 
            // 下一張ToolStripMenuItem
            // 
            this.下一張ToolStripMenuItem.Name = "下一張ToolStripMenuItem";
            this.下一張ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.下一張ToolStripMenuItem.Text = "下一張";
            this.下一張ToolStripMenuItem.Click += new System.EventHandler(this.下一張ToolStripMenuItem_Click);
            // 
            // 最後一張ToolStripMenuItem
            // 
            this.最後一張ToolStripMenuItem.Name = "最後一張ToolStripMenuItem";
            this.最後一張ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.最後一張ToolStripMenuItem.Text = "最後一張";
            this.最後一張ToolStripMenuItem.Click += new System.EventHandler(this.最後一張ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 201);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "日月潭風景";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 第一張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最後一張ToolStripMenuItem;
    }
}

