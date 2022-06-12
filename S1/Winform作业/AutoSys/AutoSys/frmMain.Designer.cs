namespace AutoSys
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
            this.tsmiVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiState = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSynthesis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVehicle,
            this.tsmiCar,
            this.tsmiSynthesis,
            this.tsmiInformation,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiVehicle
            // 
            this.tsmiVehicle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiState,
            this.tsmiAdd,
            this.tsmiSearch});
            this.tsmiVehicle.Name = "tsmiVehicle";
            this.tsmiVehicle.Size = new System.Drawing.Size(96, 28);
            this.tsmiVehicle.Text = "车辆管理";
            // 
            // tsmiState
            // 
            this.tsmiState.Name = "tsmiState";
            this.tsmiState.Size = new System.Drawing.Size(224, 28);
            this.tsmiState.Text = "车辆状态";
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(224, 28);
            this.tsmiAdd.Text = "车辆登记";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(224, 28);
            this.tsmiSearch.Text = "车辆查询";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // tsmiCar
            // 
            this.tsmiCar.Name = "tsmiCar";
            this.tsmiCar.Size = new System.Drawing.Size(96, 28);
            this.tsmiCar.Text = "出车管理";
            // 
            // tsmiSynthesis
            // 
            this.tsmiSynthesis.Name = "tsmiSynthesis";
            this.tsmiSynthesis.Size = new System.Drawing.Size(96, 28);
            this.tsmiSynthesis.Text = "综合管理";
            // 
            // tsmiInformation
            // 
            this.tsmiInformation.Name = "tsmiInformation";
            this.tsmiInformation.Size = new System.Drawing.Size(96, 28);
            this.tsmiInformation.Text = "信息设置";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(96, 28);
            this.tsmiExit.Text = "退出系统";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "车辆管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiVehicle;
        private System.Windows.Forms.ToolStripMenuItem tsmiState;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiCar;
        private System.Windows.Forms.ToolStripMenuItem tsmiSynthesis;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformation;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

