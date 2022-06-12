namespace SchoolForm
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAccountManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdatePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchByName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchByGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubjectManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubjectList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbnSearchName = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearchGrade = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSubjectList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStudentList = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAccountManage,
            this.tsmiStudentManage,
            this.tsmiSubjectManage,
            this.tsmiWindow,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAccountManage
            // 
            this.tsmiAccountManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdatePwd,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.tsmiAccountManage.Name = "tsmiAccountManage";
            this.tsmiAccountManage.Size = new System.Drawing.Size(106, 31);
            this.tsmiAccountManage.Text = "账户管理";
            // 
            // tsmiUpdatePwd
            // 
            this.tsmiUpdatePwd.Name = "tsmiUpdatePwd";
            this.tsmiUpdatePwd.Size = new System.Drawing.Size(224, 32);
            this.tsmiUpdatePwd.Text = "修改密码";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(224, 32);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiStudentManage
            // 
            this.tsmiStudentManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStudent,
            this.tsmiSearchByName,
            this.tsmiSearchByGrade,
            this.tsmiStudentList});
            this.tsmiStudentManage.Name = "tsmiStudentManage";
            this.tsmiStudentManage.Size = new System.Drawing.Size(172, 31);
            this.tsmiStudentManage.Text = "学生用户管理(&S)";
            // 
            // tsmiAddStudent
            // 
            this.tsmiAddStudent.Name = "tsmiAddStudent";
            this.tsmiAddStudent.Size = new System.Drawing.Size(232, 32);
            this.tsmiAddStudent.Text = "新增学生(&N)";
            this.tsmiAddStudent.Click += new System.EventHandler(this.tsmiAddStudent_Click);
            // 
            // tsmiSearchByName
            // 
            this.tsmiSearchByName.Name = "tsmiSearchByName";
            this.tsmiSearchByName.Size = new System.Drawing.Size(232, 32);
            this.tsmiSearchByName.Text = "按姓名查询(&M)";
            this.tsmiSearchByName.Click += new System.EventHandler(this.tsmiSearchByName_Click);
            // 
            // tsmiSearchByGrade
            // 
            this.tsmiSearchByGrade.Name = "tsmiSearchByGrade";
            this.tsmiSearchByGrade.Size = new System.Drawing.Size(232, 32);
            this.tsmiSearchByGrade.Text = "按年级查询(&G)";
            // 
            // tsmiStudentList
            // 
            this.tsmiStudentList.Name = "tsmiStudentList";
            this.tsmiStudentList.Size = new System.Drawing.Size(232, 32);
            this.tsmiStudentList.Text = "学生列表(&L)";
            // 
            // tsmiSubjectManage
            // 
            this.tsmiSubjectManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSubjectList});
            this.tsmiSubjectManage.Name = "tsmiSubjectManage";
            this.tsmiSubjectManage.Size = new System.Drawing.Size(131, 31);
            this.tsmiSubjectManage.Text = "科目管理(&T)";
            // 
            // tsmiSubjectList
            // 
            this.tsmiSubjectList.Name = "tsmiSubjectList";
            this.tsmiSubjectList.Size = new System.Drawing.Size(224, 32);
            this.tsmiSubjectList.Text = "科目列表";
            // 
            // tsmiWindow
            // 
            this.tsmiWindow.Name = "tsmiWindow";
            this.tsmiWindow.Size = new System.Drawing.Size(100, 31);
            this.tsmiWindow.Text = "窗口(&W)";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(95, 31);
            this.tsmiHelp.Text = "帮助(&H)";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddStudent,
            this.tsbnSearchName,
            this.tsbtnSearchGrade,
            this.tsbtnSubjectList,
            this.tsbtnStudentList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(848, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAddStudent
            // 
            this.tsbtnAddStudent.Image = global::SchoolForm.Properties.Resources.tsbtn2;
            this.tsbtnAddStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddStudent.Name = "tsbtnAddStudent";
            this.tsbtnAddStudent.Size = new System.Drawing.Size(168, 36);
            this.tsbtnAddStudent.Text = "增加学生信息";
            this.tsbtnAddStudent.Click += new System.EventHandler(this.tsmiAddStudent_Click);
            // 
            // tsbnSearchName
            // 
            this.tsbnSearchName.Image = global::SchoolForm.Properties.Resources.tsbtn1;
            this.tsbnSearchName.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbnSearchName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbnSearchName.Name = "tsbnSearchName";
            this.tsbnSearchName.Size = new System.Drawing.Size(148, 36);
            this.tsbnSearchName.Text = "按姓名查询";
            this.tsbnSearchName.Click += new System.EventHandler(this.tsmiSearchByName_Click);
            // 
            // tsbtnSearchGrade
            // 
            this.tsbtnSearchGrade.Image = global::SchoolForm.Properties.Resources.tsbtn3;
            this.tsbtnSearchGrade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSearchGrade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearchGrade.Name = "tsbtnSearchGrade";
            this.tsbtnSearchGrade.Size = new System.Drawing.Size(148, 36);
            this.tsbtnSearchGrade.Text = "按年级查询";
            this.tsbtnSearchGrade.Click += new System.EventHandler(this.tsbtnSearchGrade_Click);
            // 
            // tsbtnSubjectList
            // 
            this.tsbtnSubjectList.Image = global::SchoolForm.Properties.Resources.tsbtn4;
            this.tsbtnSubjectList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSubjectList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSubjectList.Name = "tsbtnSubjectList";
            this.tsbtnSubjectList.Size = new System.Drawing.Size(128, 36);
            this.tsbtnSubjectList.Text = "科目列表";
            // 
            // tsbtnStudentList
            // 
            this.tsbtnStudentList.Image = global::SchoolForm.Properties.Resources.tsbtn5;
            this.tsbtnStudentList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnStudentList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStudentList.Name = "tsbtnStudentList";
            this.tsbtnStudentList.Size = new System.Drawing.Size(128, 36);
            this.tsbtnStudentList.Text = "学生列表";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 608);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "MySchool-管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePwd;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchByName;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchByGrade;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentList;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubjectManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubjectList;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAddStudent;
        private System.Windows.Forms.ToolStripButton tsbnSearchName;
        private System.Windows.Forms.ToolStripButton tsbtnSearchGrade;
        private System.Windows.Forms.ToolStripButton tsbtnSubjectList;
        private System.Windows.Forms.ToolStripButton tsbtnStudentList;
    }
}