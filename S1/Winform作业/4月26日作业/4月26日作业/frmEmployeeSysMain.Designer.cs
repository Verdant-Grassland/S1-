namespace _4月26日作业
{
    partial class frmEmployeeSysMain
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
            this.tsmiAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.业诚管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.津贴管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddEmployee,
            this.tsmiSearchEmployee,
            this.考勤管理ToolStripMenuItem,
            this.业诚管理ToolStripMenuItem,
            this.津贴管理ToolStripMenuItem,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAddEmployee
            // 
            this.tsmiAddEmployee.Name = "tsmiAddEmployee";
            this.tsmiAddEmployee.Size = new System.Drawing.Size(106, 31);
            this.tsmiAddEmployee.Text = "添加员工";
            this.tsmiAddEmployee.Click += new System.EventHandler(this.tsmiAddEmployee_Click);
            // 
            // tsmiSearchEmployee
            // 
            this.tsmiSearchEmployee.Name = "tsmiSearchEmployee";
            this.tsmiSearchEmployee.Size = new System.Drawing.Size(106, 31);
            this.tsmiSearchEmployee.Text = "查询员工";
            // 
            // 考勤管理ToolStripMenuItem
            // 
            this.考勤管理ToolStripMenuItem.Name = "考勤管理ToolStripMenuItem";
            this.考勤管理ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.考勤管理ToolStripMenuItem.Text = "考勤管理";
            // 
            // 业诚管理ToolStripMenuItem
            // 
            this.业诚管理ToolStripMenuItem.Name = "业诚管理ToolStripMenuItem";
            this.业诚管理ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.业诚管理ToolStripMenuItem.Text = "业诚管理";
            // 
            // 津贴管理ToolStripMenuItem
            // 
            this.津贴管理ToolStripMenuItem.Name = "津贴管理ToolStripMenuItem";
            this.津贴管理ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.津贴管理ToolStripMenuItem.Text = "津贴管理";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(66, 31);
            this.tsmiExit.Text = "退出";
            // 
            // frmEmployeeSysMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEmployeeSysMain";
            this.Text = "员工管理信息系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchEmployee;
        private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 业诚管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 津贴管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

