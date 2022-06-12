namespace RegisteredDesign
{
    partial class EnrollPage
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
            this.EnrollButton = new Sunny.UI.UIButton();
            this.PwdBox = new Sunny.UI.UITextBox();
            this.UserName = new Sunny.UI.UITextBox();
            this.Pwd = new Sunny.UI.UILabel();
            this.IblUserName = new Sunny.UI.UILabel();
            this.IblRepeatPwd = new Sunny.UI.UILabel();
            this.RepeatPwdBox = new Sunny.UI.UITextBox();
            this.LoginLink = new Sunny.UI.UILinkLabel();
            this.ldlLoginName = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // EnrollButton
            // 
            this.EnrollButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnrollButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EnrollButton.ForeColor = System.Drawing.Color.Black;
            this.EnrollButton.Location = new System.Drawing.Point(139, 300);
            this.EnrollButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.EnrollButton.Name = "EnrollButton";
            this.EnrollButton.Size = new System.Drawing.Size(450, 52);
            this.EnrollButton.Style = Sunny.UI.UIStyle.Custom;
            this.EnrollButton.TabIndex = 8;
            this.EnrollButton.Text = "注册";
            this.EnrollButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnrollButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.EnrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
            // 
            // PwdBox
            // 
            this.PwdBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PwdBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.PwdBox.Location = new System.Drawing.Point(284, 141);
            this.PwdBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PwdBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.PwdBox.Name = "PwdBox";
            this.PwdBox.Padding = new System.Windows.Forms.Padding(5);
            this.PwdBox.PasswordChar = '*';
            this.PwdBox.ShowText = false;
            this.PwdBox.Size = new System.Drawing.Size(282, 34);
            this.PwdBox.TabIndex = 6;
            this.PwdBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PwdBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UserName
            // 
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserName.Location = new System.Drawing.Point(284, 81);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserName.MinimumSize = new System.Drawing.Size(1, 16);
            this.UserName.Name = "UserName";
            this.UserName.Padding = new System.Windows.Forms.Padding(5);
            this.UserName.ShowText = false;
            this.UserName.Size = new System.Drawing.Size(282, 34);
            this.UserName.TabIndex = 7;
            this.UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Pwd
            // 
            this.Pwd.AutoSize = true;
            this.Pwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Pwd.Location = new System.Drawing.Point(148, 149);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(72, 27);
            this.Pwd.TabIndex = 4;
            this.Pwd.Text = "密码：";
            this.Pwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pwd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // IblUserName
            // 
            this.IblUserName.AutoSize = true;
            this.IblUserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.IblUserName.Location = new System.Drawing.Point(148, 82);
            this.IblUserName.Name = "IblUserName";
            this.IblUserName.Size = new System.Drawing.Size(92, 27);
            this.IblUserName.TabIndex = 5;
            this.IblUserName.Text = "用户名：";
            this.IblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IblUserName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // IblRepeatPwd
            // 
            this.IblRepeatPwd.AutoSize = true;
            this.IblRepeatPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.IblRepeatPwd.Location = new System.Drawing.Point(148, 214);
            this.IblRepeatPwd.Name = "IblRepeatPwd";
            this.IblRepeatPwd.Size = new System.Drawing.Size(112, 27);
            this.IblRepeatPwd.TabIndex = 4;
            this.IblRepeatPwd.Text = "确定密码：";
            this.IblRepeatPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IblRepeatPwd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // RepeatPwdBox
            // 
            this.RepeatPwdBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RepeatPwdBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RepeatPwdBox.Location = new System.Drawing.Point(284, 206);
            this.RepeatPwdBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RepeatPwdBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.RepeatPwdBox.Name = "RepeatPwdBox";
            this.RepeatPwdBox.Padding = new System.Windows.Forms.Padding(5);
            this.RepeatPwdBox.PasswordChar = '*';
            this.RepeatPwdBox.ShowText = false;
            this.RepeatPwdBox.Size = new System.Drawing.Size(282, 34);
            this.RepeatPwdBox.TabIndex = 6;
            this.RepeatPwdBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.RepeatPwdBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LoginLink
            // 
            this.LoginLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.LoginLink.AutoSize = true;
            this.LoginLink.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LoginLink.Location = new System.Drawing.Point(527, 366);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(69, 20);
            this.LoginLink.Style = Sunny.UI.UIStyle.Custom;
            this.LoginLink.TabIndex = 9;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "登录账号";
            this.LoginLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LoginLink.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.LoginLink.Click += new System.EventHandler(this.LoginLink_Click);
            // 
            // ldlLoginName
            // 
            this.ldlLoginName.AutoSize = true;
            this.ldlLoginName.BackColor = System.Drawing.Color.Transparent;
            this.ldlLoginName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ldlLoginName.Location = new System.Drawing.Point(393, 366);
            this.ldlLoginName.Name = "ldlLoginName";
            this.ldlLoginName.Size = new System.Drawing.Size(129, 20);
            this.ldlLoginName.TabIndex = 10;
            this.ldlLoginName.Text = "已有账号？点击去";
            this.ldlLoginName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ldlLoginName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // EnrollPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(743, 437);
            this.Controls.Add(this.ldlLoginName);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.EnrollButton);
            this.Controls.Add(this.RepeatPwdBox);
            this.Controls.Add(this.PwdBox);
            this.Controls.Add(this.IblRepeatPwd);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.IblUserName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnrollPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册页面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton EnrollButton;
        private Sunny.UI.UITextBox PwdBox;
        private Sunny.UI.UITextBox UserName;
        private Sunny.UI.UILabel Pwd;
        private Sunny.UI.UILabel IblUserName;
        private Sunny.UI.UILabel IblRepeatPwd;
        private Sunny.UI.UITextBox RepeatPwdBox;
        private Sunny.UI.UILinkLabel LoginLink;
        private Sunny.UI.UILabel ldlLoginName;
        // 你知道这什么原因吗 你知道你搞吧 不知道我研究研究？？？
    }
}