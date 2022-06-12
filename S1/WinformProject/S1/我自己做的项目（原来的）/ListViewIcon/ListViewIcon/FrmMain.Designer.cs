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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "C盘",
            "2543255238",
            "男",
            "15"}, 0);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "D盘",
            "326658726",
            "女",
            "18"}, 1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "E盘",
            "27749835526",
            "男",
            "19"}, 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lvComputer = new System.Windows.Forms.ListView();
            this.illBig = new System.Windows.Forms.ImageList(this.components);
            this.illSmall = new System.Windows.Forms.ImageList(this.components);
            this.btnBig = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBigIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvComputer
            // 
            this.lvComputer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvComputer.ContextMenuStrip = this.cmsMenu;
            this.lvComputer.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lvComputer.LargeImageList = this.illBig;
            this.lvComputer.Location = new System.Drawing.Point(38, 23);
            this.lvComputer.Name = "lvComputer";
            this.lvComputer.Size = new System.Drawing.Size(602, 322);
            this.lvComputer.SmallImageList = this.illSmall;
            this.lvComputer.StateImageList = this.illSmall;
            this.lvComputer.TabIndex = 0;
            this.lvComputer.UseCompatibleStateImageBehavior = false;
            this.lvComputer.View = System.Windows.Forms.View.Details;
            // 
            // illBig
            // 
            this.illBig.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("illBig.ImageStream")));
            this.illBig.TransparentColor = System.Drawing.Color.Transparent;
            this.illBig.Images.SetKeyName(0, "1.bmp");
            this.illBig.Images.SetKeyName(1, "2.bmp");
            this.illBig.Images.SetKeyName(2, "3.bmp");
            // 
            // illSmall
            // 
            this.illSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("illSmall.ImageStream")));
            this.illSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.illSmall.Images.SetKeyName(0, "1-1.bmp");
            this.illSmall.Images.SetKeyName(1, "2-1.bmp");
            this.illSmall.Images.SetKeyName(2, "3-1.bmp");
            // 
            // btnBig
            // 
            this.btnBig.Location = new System.Drawing.Point(51, 371);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(72, 32);
            this.btnBig.TabIndex = 1;
            this.btnBig.Text = "大图标";
            this.btnBig.UseVisualStyleBackColor = true;
            this.btnBig.Click += new System.EventHandler(this.btnBig_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(140, 371);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(72, 32);
            this.btnSmall.TabIndex = 1;
            this.btnSmall.Text = "小图标";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(228, 371);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(72, 32);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "详细信息";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "昵称";
            this.ColumnHeader.Width = 91;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "QQ号码";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "性别";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "年龄";
            this.columnHeader3.Width = 248;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBigIcon,
            this.tsmiSmallIcon,
            this.tsmiDetails});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(125, 70);
            // 
            // tsmiBigIcon
            // 
            this.tsmiBigIcon.Name = "tsmiBigIcon";
            this.tsmiBigIcon.Size = new System.Drawing.Size(152, 22);
            this.tsmiBigIcon.Text = "大图标";
            this.tsmiBigIcon.Click += new System.EventHandler(this.tsmiBigIcon_Click);
            // 
            // tsmiSmallIcon
            // 
            this.tsmiSmallIcon.Name = "tsmiSmallIcon";
            this.tsmiSmallIcon.Size = new System.Drawing.Size(152, 22);
            this.tsmiSmallIcon.Text = "小图标";
            this.tsmiSmallIcon.Click += new System.EventHandler(this.tsmiSmallIcon_Click);
            // 
            // tsmiDetails
            // 
            this.tsmiDetails.Name = "tsmiDetails";
            this.tsmiDetails.Size = new System.Drawing.Size(152, 22);
            this.tsmiDetails.Text = "详细信息";
            this.tsmiDetails.Click += new System.EventHandler(this.tsmiDetails_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 463);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnBig);
            this.Controls.Add(this.lvComputer);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvComputer;
        private System.Windows.Forms.ImageList illBig;
        private System.Windows.Forms.ImageList illSmall;
        private System.Windows.Forms.Button btnBig;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiBigIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetails;
    }
}

