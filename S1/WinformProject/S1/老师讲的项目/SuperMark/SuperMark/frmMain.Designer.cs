namespace SuperMark
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.rbtnZuanShi = new System.Windows.Forms.RadioButton();
            this.rbtnBoJin = new System.Windows.Forms.RadioButton();
            this.rbtnJk = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSystem.Location = new System.Drawing.Point(307, 37);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(261, 30);
            this.lblSystem.TabIndex = 0;
            this.lblSystem.Text = "超市会员管理系统";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(142, 116);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(37, 15);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "账号";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(193, 114);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(184, 25);
            this.txtCustomerId.TabIndex = 2;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(390, 117);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(37, 15);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "密码";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(441, 115);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(194, 25);
            this.txtPwd.TabIndex = 2;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.rbtnZuanShi);
            this.gbInfo.Controls.Add(this.rbtnBoJin);
            this.gbInfo.Controls.Add(this.rbtnJk);
            this.gbInfo.Location = new System.Drawing.Point(135, 162);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(500, 111);
            this.gbInfo.TabIndex = 3;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "卡别：";
            // 
            // rbtnZuanShi
            // 
            this.rbtnZuanShi.AutoSize = true;
            this.rbtnZuanShi.Location = new System.Drawing.Point(323, 48);
            this.rbtnZuanShi.Name = "rbtnZuanShi";
            this.rbtnZuanShi.Size = new System.Drawing.Size(73, 19);
            this.rbtnZuanShi.TabIndex = 0;
            this.rbtnZuanShi.Text = "钻石卡";
            this.rbtnZuanShi.UseVisualStyleBackColor = true;
            this.rbtnZuanShi.CheckedChanged += new System.EventHandler(this.rbtnZuanShi_CheckedChanged);
            // 
            // rbtnBoJin
            // 
            this.rbtnBoJin.AutoSize = true;
            this.rbtnBoJin.Location = new System.Drawing.Point(169, 48);
            this.rbtnBoJin.Name = "rbtnBoJin";
            this.rbtnBoJin.Size = new System.Drawing.Size(73, 19);
            this.rbtnBoJin.TabIndex = 0;
            this.rbtnBoJin.Text = "铂金卡";
            this.rbtnBoJin.UseVisualStyleBackColor = true;
            this.rbtnBoJin.CheckedChanged += new System.EventHandler(this.rbtnBoJin_CheckedChanged);
            // 
            // rbtnJk
            // 
            this.rbtnJk.AutoSize = true;
            this.rbtnJk.Checked = true;
            this.rbtnJk.Location = new System.Drawing.Point(39, 48);
            this.rbtnJk.Name = "rbtnJk";
            this.rbtnJk.Size = new System.Drawing.Size(58, 19);
            this.rbtnJk.TabIndex = 0;
            this.rbtnJk.TabStop = true;
            this.rbtnJk.Text = "金卡";
            this.rbtnJk.UseVisualStyleBackColor = true;
            this.rbtnJk.CheckedChanged += new System.EventHandler(this.rbtnJk_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(677, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(677, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(140, 304);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(52, 15);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "状态：";
            // 
            // cboStates
            // 
            this.cboStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(191, 303);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(185, 23);
            this.cboStates.TabIndex = 6;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(390, 306);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(82, 15);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "账户积分：";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(478, 304);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(171, 25);
            this.txtScore.TabIndex = 7;
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.customerId,
            this.customerType,
            this.score,
            this.statesName});
            this.dgvShow.ContextMenuStrip = this.cmsMenu;
            this.dgvShow.Location = new System.Drawing.Point(114, 356);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(731, 204);
            this.dgvShow.TabIndex = 8;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "编号";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // customerId
            // 
            this.customerId.DataPropertyName = "customerId";
            this.customerId.HeaderText = "账号";
            this.customerId.Name = "customerId";
            // 
            // customerType
            // 
            this.customerType.DataPropertyName = "customerType";
            this.customerType.HeaderText = "卡别";
            this.customerType.Name = "customerType";
            // 
            // score
            // 
            this.score.DataPropertyName = "score";
            this.score.HeaderText = "积分";
            this.score.Name = "score";
            // 
            // statesName
            // 
            this.statesName.DataPropertyName = "statesName";
            this.statesName.HeaderText = "状态";
            this.statesName.Name = "statesName";
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(153, 50);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(152, 24);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 573);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSystem);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市会员管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.RadioButton rbtnZuanShi;
        private System.Windows.Forms.RadioButton rbtnBoJin;
        private System.Windows.Forms.RadioButton rbtnJk;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn statesName;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}

