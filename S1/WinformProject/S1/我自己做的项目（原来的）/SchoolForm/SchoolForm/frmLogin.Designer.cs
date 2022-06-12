namespace SchoolForm
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblName = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblType1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCalce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(171, 183);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "用 户 名：";
            this.lblName.UseCompatibleTextRendering = true;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lblPwd.Location = new System.Drawing.Point(171, 218);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(110, 29);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "密    码：";
            this.lblPwd.UseCompatibleTextRendering = true;
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.BackColor = System.Drawing.Color.Transparent;
            this.lblType1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lblType1.Location = new System.Drawing.Point(171, 253);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(110, 29);
            this.lblType1.TabIndex = 0;
            this.lblType1.Text = "登录类型：";
            this.lblType1.UseCompatibleTextRendering = true;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(278, 184);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd.Location = new System.Drawing.Point(278, 221);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(147, 25);
            this.txtPwd.TabIndex = 1;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.DropDownWidth = 156;
            this.cboType.FormattingEnabled = true;
            this.cboType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboType.Items.AddRange(new object[] {
            "管理员",
            "学生"});
            this.cboType.Location = new System.Drawing.Point(278, 256);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(147, 23);
            this.cboType.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::SchoolForm.Properties.Resources.button;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnLogin.Location = new System.Drawing.Point(170, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 22);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCalce
            // 
            this.btnCalce.BackgroundImage = global::SchoolForm.Properties.Resources.button;
            this.btnCalce.FlatAppearance.BorderSize = 0;
            this.btnCalce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalce.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalce.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnCalce.Location = new System.Drawing.Point(299, 291);
            this.btnCalce.Name = "btnCalce";
            this.btnCalce.Size = new System.Drawing.Size(84, 22);
            this.btnCalce.TabIndex = 6;
            this.btnCalce.Text = "取消";
            this.btnCalce.UseVisualStyleBackColor = true;
            this.btnCalce.Click += new System.EventHandler(this.btnCalce_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolForm.Properties.Resources.login_bj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 359);
            this.Controls.Add(this.btnCalce);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblType1);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySchool--登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCalce;
    }
}

