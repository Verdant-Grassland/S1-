namespace HrSys
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiSystemManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoneyManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHrManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCount = new System.Windows.Forms.ToolStripMenuItem();
            this.txmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystemManage,
            this.tsmiMoneyManage,
            this.tsmiHrManage,
            this.txmiExit});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(745, 28);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiSystemManage
            // 
            this.tsmiSystemManage.Name = "tsmiSystemManage";
            this.tsmiSystemManage.Size = new System.Drawing.Size(81, 24);
            this.tsmiSystemManage.Text = "系统管理";
            // 
            // tsmiMoneyManage
            // 
            this.tsmiMoneyManage.Name = "tsmiMoneyManage";
            this.tsmiMoneyManage.Size = new System.Drawing.Size(81, 24);
            this.tsmiMoneyManage.Text = "薪酬管理";
            // 
            // tsmiHrManage
            // 
            this.tsmiHrManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearch,
            this.tsmiAdd,
            this.tsmiCount});
            this.tsmiHrManage.Name = "tsmiHrManage";
            this.tsmiHrManage.Size = new System.Drawing.Size(81, 24);
            this.tsmiHrManage.Text = "考勤管理";
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(168, 24);
            this.tsmiSearch.Text = "查看考勤信息";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(168, 24);
            this.tsmiAdd.Text = "补录考勤信息";
            // 
            // tsmiCount
            // 
            this.tsmiCount.Name = "tsmiCount";
            this.tsmiCount.Size = new System.Drawing.Size(168, 24);
            this.tsmiCount.Text = "考勤信息统计";
            // 
            // txmiExit
            // 
            this.txmiExit.Name = "txmiExit";
            this.txmiExit.Size = new System.Drawing.Size(51, 24);
            this.txmiExit.Text = "退出";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 448);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "FrmMain";
            this.Text = "小型HR系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystemManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoneyManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiHrManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiCount;
        private System.Windows.Forms.ToolStripMenuItem txmiExit;
    }
}

