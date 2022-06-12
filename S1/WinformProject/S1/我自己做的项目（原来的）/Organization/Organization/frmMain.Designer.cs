namespace Organization
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.社团管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Enroll = new System.Windows.Forms.ToolStripMenuItem();
            this.Lnquire = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.社团管理ToolStripMenuItem,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 社团管理ToolStripMenuItem
            // 
            this.社团管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Enroll,
            this.Lnquire,
            this.Logout});
            this.社团管理ToolStripMenuItem.Name = "社团管理ToolStripMenuItem";
            this.社团管理ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.社团管理ToolStripMenuItem.Text = "社团管理";
            // 
            // Enroll
            // 
            this.Enroll.Name = "Enroll";
            this.Enroll.Size = new System.Drawing.Size(138, 32);
            this.Enroll.Text = "注册";
            this.Enroll.Click += new System.EventHandler(this.tsmiReg_Click);
            // 
            // Lnquire
            // 
            this.Lnquire.Name = "Lnquire";
            this.Lnquire.Size = new System.Drawing.Size(138, 32);
            this.Lnquire.Text = "查询";
            this.Lnquire.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(138, 32);
            this.Logout.Text = "注销";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(66, 31);
            this.Exit.Text = "退出";
            this.Exit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "社团管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 社团管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Enroll;
        private System.Windows.Forms.ToolStripMenuItem Lnquire;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.ToolStripMenuItem Exit;
    }
}

