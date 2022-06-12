namespace RegisteredDesign
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.UserName = new Sunny.UI.UILabel();
            this.Pwd = new Sunny.UI.UILabel();
            this.UserNameLogin = new Sunny.UI.UITextBox();
            this.PwdBox = new Sunny.UI.UITextBox();
            this.LoginButton = new Sunny.UI.UIButton();
            this.EnrollLink = new Sunny.UI.UILinkLabel();
            this.SuspendLayout();
            // 
            // UserName
            // 
            resources.ApplyResources(this.UserName, "UserName");
            this.UserName.Name = "UserName";
            // 
            // Pwd
            // 
            resources.ApplyResources(this.Pwd, "Pwd");
            this.Pwd.Name = "Pwd";
            // 
            // UserNameLogin
            // 
            this.UserNameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.UserNameLogin, "UserNameLogin");
            this.UserNameLogin.Name = "UserNameLogin";
            this.UserNameLogin.ShowText = false;
            this.UserNameLogin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PwdBox
            // 
            this.PwdBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.PwdBox, "PwdBox");
            this.PwdBox.Name = "PwdBox";
            this.PwdBox.PasswordChar = '*';
            this.PwdBox.ShowText = false;
            this.PwdBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Style = Sunny.UI.UIStyle.Custom;
            this.LoginButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // EnrollLink
            // 
            this.EnrollLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.EnrollLink, "EnrollLink");
            this.EnrollLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.EnrollLink.Name = "EnrollLink";
            this.EnrollLink.TabStop = true;
            this.EnrollLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.EnrollLink.Click += new System.EventHandler(this.EnrollLink_Click);
            // 
            // LoginPage
            // 
            this.AcceptButton = this.LoginButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.EnrollLink);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PwdBox);
            this.Controls.Add(this.UserNameLogin);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.UserName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel UserName;
        private Sunny.UI.UILabel Pwd;
        private Sunny.UI.UITextBox UserNameLogin;
        private Sunny.UI.UITextBox PwdBox;
        private Sunny.UI.UIButton LoginButton;
        private Sunny.UI.UILinkLabel EnrollLink;
    }
}

