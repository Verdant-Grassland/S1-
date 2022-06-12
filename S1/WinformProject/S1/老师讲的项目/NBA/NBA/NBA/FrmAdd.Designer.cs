namespace NBA
{
    partial class FrmAdd
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblHostScore = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPastScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboHost = new System.Windows.Forms.ComboBox();
            this.txtHostScore = new System.Windows.Forms.TextBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtPastScore = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblAway = new System.Windows.Forms.Label();
            this.cboAway = new System.Windows.Forms.ComboBox();
            this.lblAwayScore = new System.Windows.Forms.Label();
            this.txtAwayScore = new System.Windows.Forms.TextBox();
            this.lblSucc = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdd.Location = new System.Drawing.Point(208, 24);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(180, 28);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "添加赛程信息";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(52, 96);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(37, 15);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "主队";
            // 
            // lblHostScore
            // 
            this.lblHostScore.AutoSize = true;
            this.lblHostScore.Location = new System.Drawing.Point(52, 155);
            this.lblHostScore.Name = "lblHostScore";
            this.lblHostScore.Size = new System.Drawing.Size(82, 15);
            this.lblHostScore.TabIndex = 1;
            this.lblHostScore.Text = "主队总比分";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(52, 214);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(37, 15);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "场次";
            // 
            // lblPastScore
            // 
            this.lblPastScore.AutoSize = true;
            this.lblPastScore.Location = new System.Drawing.Point(52, 273);
            this.lblPastScore.Name = "lblPastScore";
            this.lblPastScore.Size = new System.Drawing.Size(82, 15);
            this.lblPastScore.TabIndex = 1;
            this.lblPastScore.Text = "上一场得分";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(52, 332);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(67, 15);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "比赛时间";
            // 
            // cboHost
            // 
            this.cboHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHost.FormattingEnabled = true;
            this.cboHost.Location = new System.Drawing.Point(152, 93);
            this.cboHost.Name = "cboHost";
            this.cboHost.Size = new System.Drawing.Size(141, 23);
            this.cboHost.TabIndex = 2;
            // 
            // txtHostScore
            // 
            this.txtHostScore.Location = new System.Drawing.Point(152, 148);
            this.txtHostScore.Name = "txtHostScore";
            this.txtHostScore.Size = new System.Drawing.Size(91, 25);
            this.txtHostScore.TabIndex = 3;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(258, 153);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(22, 15);
            this.lblSuccess.TabIndex = 4;
            this.lblSuccess.Text = "胜";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(152, 204);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(150, 25);
            this.txtCount.TabIndex = 3;
            // 
            // txtPastScore
            // 
            this.txtPastScore.Location = new System.Drawing.Point(152, 263);
            this.txtPastScore.Name = "txtPastScore";
            this.txtPastScore.Size = new System.Drawing.Size(150, 25);
            this.txtPastScore.TabIndex = 3;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(152, 322);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(150, 25);
            this.txtTime.TabIndex = 3;
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.Location = new System.Drawing.Point(351, 96);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(37, 15);
            this.lblAway.TabIndex = 1;
            this.lblAway.Text = "客队";
            // 
            // cboAway
            // 
            this.cboAway.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAway.FormattingEnabled = true;
            this.cboAway.Location = new System.Drawing.Point(451, 93);
            this.cboAway.Name = "cboAway";
            this.cboAway.Size = new System.Drawing.Size(141, 23);
            this.cboAway.TabIndex = 2;
            // 
            // lblAwayScore
            // 
            this.lblAwayScore.AutoSize = true;
            this.lblAwayScore.Location = new System.Drawing.Point(351, 152);
            this.lblAwayScore.Name = "lblAwayScore";
            this.lblAwayScore.Size = new System.Drawing.Size(82, 15);
            this.lblAwayScore.TabIndex = 1;
            this.lblAwayScore.Text = "客队总比分";
            // 
            // txtAwayScore
            // 
            this.txtAwayScore.Location = new System.Drawing.Point(451, 145);
            this.txtAwayScore.Name = "txtAwayScore";
            this.txtAwayScore.Size = new System.Drawing.Size(91, 25);
            this.txtAwayScore.TabIndex = 3;
            // 
            // lblSucc
            // 
            this.lblSucc.AutoSize = true;
            this.lblSucc.Location = new System.Drawing.Point(557, 150);
            this.lblSucc.Name = "lblSucc";
            this.lblSucc.Size = new System.Drawing.Size(22, 15);
            this.lblSucc.TabIndex = 4;
            this.lblSucc.Text = "胜";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(293, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 31);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(426, 371);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 462);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtPastScore);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblSucc);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.txtAwayScore);
            this.Controls.Add(this.txtHostScore);
            this.Controls.Add(this.cboAway);
            this.Controls.Add(this.cboHost);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPastScore);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblAwayScore);
            this.Controls.Add(this.lblHostScore);
            this.Controls.Add(this.lblAway);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "赛程添加";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblHostScore;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblPastScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cboHost;
        private System.Windows.Forms.TextBox txtHostScore;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtPastScore;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.ComboBox cboAway;
        private System.Windows.Forms.Label lblAwayScore;
        private System.Windows.Forms.TextBox txtAwayScore;
        private System.Windows.Forms.Label lblSucc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}