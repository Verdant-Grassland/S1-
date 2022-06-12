namespace ListViewIcon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "C盘",
            "本地磁盘",
            "20G",
            "4G"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "D盘",
            "本地磁盘",
            "30G",
            "10G"}, 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "E盘",
            "本地磁盘",
            "100G",
            "30G"}, 2);
            this.ilBig = new System.Windows.Forms.ImageList(this.components);
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.lvComputer = new System.Windows.Forms.ListView();
            this.btnBig = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilBig
            // 
            this.ilBig.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBig.ImageStream")));
            this.ilBig.TransparentColor = System.Drawing.Color.Transparent;
            this.ilBig.Images.SetKeyName(0, "大图1.png");
            this.ilBig.Images.SetKeyName(1, "大图2.png");
            this.ilBig.Images.SetKeyName(2, "大图3.png");
            // 
            // ilSmall
            // 
            this.ilSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSmall.ImageStream")));
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSmall.Images.SetKeyName(0, "图1.png");
            this.ilSmall.Images.SetKeyName(1, "图2.png");
            this.ilSmall.Images.SetKeyName(2, "图3.png");
            // 
            // lvComputer
            // 
            this.lvComputer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvComputer.ContextMenuStrip = this.cmsMenu;
            this.lvComputer.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvComputer.LargeImageList = this.ilBig;
            this.lvComputer.Location = new System.Drawing.Point(48, 48);
            this.lvComputer.Name = "lvComputer";
            this.lvComputer.Size = new System.Drawing.Size(495, 236);
            this.lvComputer.SmallImageList = this.ilSmall;
            this.lvComputer.TabIndex = 0;
            this.lvComputer.UseCompatibleStateImageBehavior = false;
            this.lvComputer.View = System.Windows.Forms.View.Details;
            // 
            // btnBig
            // 
            this.btnBig.Location = new System.Drawing.Point(54, 315);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(85, 33);
            this.btnBig.TabIndex = 1;
            this.btnBig.Text = "大图标";
            this.btnBig.UseVisualStyleBackColor = true;
            this.btnBig.Click += new System.EventHandler(this.btnBig_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(170, 315);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(85, 33);
            this.btnSmall.TabIndex = 1;
            this.btnSmall.Text = "小图标";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(293, 316);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(104, 34);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "详细列表";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类型";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "总大小";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "可用空间";
            this.columnHeader4.Width = 206;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBig,
            this.tsmiSmall,
            this.tsmiDetails});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(139, 76);
            // 
            // tsmiBig
            // 
            this.tsmiBig.Name = "tsmiBig";
            this.tsmiBig.Size = new System.Drawing.Size(138, 24);
            this.tsmiBig.Text = "大图标";
            this.tsmiBig.Click += new System.EventHandler(this.btnBig_Click);
            // 
            // tsmiSmall
            // 
            this.tsmiSmall.Name = "tsmiSmall";
            this.tsmiSmall.Size = new System.Drawing.Size(138, 24);
            this.tsmiSmall.Text = "小图标";
            this.tsmiSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // tsmiDetails
            // 
            this.tsmiDetails.Name = "tsmiDetails";
            this.tsmiDetails.Size = new System.Drawing.Size(138, 24);
            this.tsmiDetails.Text = "详细列表";
            this.tsmiDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 457);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnBig);
            this.Controls.Add(this.lvComputer);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算机";
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilBig;
        private System.Windows.Forms.ImageList ilSmall;
        private System.Windows.Forms.ListView lvComputer;
        private System.Windows.Forms.Button btnBig;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiBig;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmall;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetails;
    }
}

