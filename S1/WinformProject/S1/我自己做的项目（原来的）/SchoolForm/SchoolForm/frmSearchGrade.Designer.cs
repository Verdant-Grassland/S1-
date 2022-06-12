namespace SchoolForm
{
    partial class frmSearchGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchGrade));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("男", 2, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("女", 0, 0);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("S1", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("男", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("女", 0, 0);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("S2", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("男", 2, 2);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("女", 0, 0);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Y2", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("全部", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            this.lbIGrade = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddResult = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilImages = new System.Windows.Forms.ImageList(this.components);
            this.tvShow = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIGrade
            // 
            this.lbIGrade.AutoSize = true;
            this.lbIGrade.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold);
            this.lbIGrade.Location = new System.Drawing.Point(474, 42);
            this.lbIGrade.Name = "lbIGrade";
            this.lbIGrade.Size = new System.Drawing.Size(125, 22);
            this.lbIGrade.TabIndex = 0;
            this.lbIGrade.Text = "按年级查询";
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(607, 45);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(243, 23);
            this.cboGrade.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(866, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNo,
            this.StudentName,
            this.Gender,
            this.GradeName,
            this.Phone});
            this.dgvShow.ContextMenuStrip = this.cmsMenu;
            this.dgvShow.Location = new System.Drawing.Point(363, 100);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.Size = new System.Drawing.Size(730, 387);
            this.dgvShow.TabIndex = 3;
            // 
            // cmsMenu
            // 
            this.cmsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddResult});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(165, 36);
            // 
            // tsmiAddResult
            // 
            this.tsmiAddResult.Name = "tsmiAddResult";
            this.tsmiAddResult.Size = new System.Drawing.Size(164, 32);
            this.tsmiAddResult.Text = "添加成绩";
            this.tsmiAddResult.Click += new System.EventHandler(this.tsmiAddResult_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(980, 505);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StudentNo
            // 
            this.StudentNo.DataPropertyName = "StudentNo";
            this.StudentNo.HeaderText = "学生学号";
            this.StudentNo.MinimumWidth = 6;
            this.StudentNo.Name = "StudentNo";
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "学生姓名";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // GradeName
            // 
            this.GradeName.DataPropertyName = "GradeName";
            this.GradeName.HeaderText = "年级";
            this.GradeName.MinimumWidth = 6;
            this.GradeName.Name = "GradeName";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "电话";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            // 
            // ilImages
            // 
            this.ilImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImages.ImageStream")));
            this.ilImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImages.Images.SetKeyName(0, "female.jpg");
            this.ilImages.Images.SetKeyName(1, "file.jpg");
            this.ilImages.Images.SetKeyName(2, "male.jpg");
            // 
            // tvShow
            // 
            this.tvShow.ImageIndex = 0;
            this.tvShow.ImageList = this.ilImages;
            this.tvShow.Location = new System.Drawing.Point(26, 12);
            this.tvShow.Name = "tvShow";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "male";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Tag = "male";
            treeNode1.Text = "男";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "female";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Tag = "female";
            treeNode2.Text = "女";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "S1";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "S1";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "male";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Tag = "male";
            treeNode4.Text = "男";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "female";
            treeNode5.SelectedImageIndex = 0;
            treeNode5.Tag = "female";
            treeNode5.Text = "女";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "S2";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "S2";
            treeNode7.ImageIndex = 2;
            treeNode7.Name = "male";
            treeNode7.SelectedImageIndex = 2;
            treeNode7.Tag = "male";
            treeNode7.Text = "男";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "female";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Tag = "female";
            treeNode8.Text = "女";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "Y2";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "Y2";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "all";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "全部";
            this.tvShow.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.tvShow.SelectedImageIndex = 0;
            this.tvShow.Size = new System.Drawing.Size(297, 549);
            this.tvShow.TabIndex = 5;
            this.tvShow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvShow_AfterSelect);
            // 
            // frmSearchGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 589);
            this.Controls.Add(this.tvShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboGrade);
            this.Controls.Add(this.lbIGrade);
            this.Name = "frmSearchGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "按年级查询";
            this.Load += new System.EventHandler(this.frmSearchGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIGrade;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.ImageList ilImages;
        private System.Windows.Forms.TreeView tvShow;
    }
}