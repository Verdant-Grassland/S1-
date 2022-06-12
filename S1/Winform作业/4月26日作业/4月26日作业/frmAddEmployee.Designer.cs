namespace _4月26日作业
{
    partial class frmAddEmployee
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPostRank = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPostRankID = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.cboPostRankId = new System.Windows.Forms.ComboBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.lblNativePlace = new System.Windows.Forms.Label();
            this.txtNativePlace = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(94, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓    名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 25);
            this.txtName.TabIndex = 1;
            // 
            // lblPostRank
            // 
            this.lblPostRank.AutoSize = true;
            this.lblPostRank.Location = new System.Drawing.Point(94, 146);
            this.lblPostRank.Name = "lblPostRank";
            this.lblPostRank.Size = new System.Drawing.Size(69, 15);
            this.lblPostRank.TabIndex = 0;
            this.lblPostRank.Text = "岗    位";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(179, 143);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(128, 25);
            this.txtPosition.TabIndex = 1;
            // 
            // lblPostRankID
            // 
            this.lblPostRankID.AutoSize = true;
            this.lblPostRankID.Location = new System.Drawing.Point(336, 149);
            this.lblPostRankID.Name = "lblPostRankID";
            this.lblPostRankID.Size = new System.Drawing.Size(67, 15);
            this.lblPostRankID.TabIndex = 0;
            this.lblPostRankID.Text = "岗位级别";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(336, 94);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(69, 15);
            this.lblSex.TabIndex = 0;
            this.lblSex.Text = "性    别";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(431, 93);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(43, 19);
            this.rbtnMale.TabIndex = 2;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "男";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(506, 93);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(43, 19);
            this.rbtnFemale.TabIndex = 2;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "女";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // cboPostRankId
            // 
            this.cboPostRankId.FormattingEnabled = true;
            this.cboPostRankId.Location = new System.Drawing.Point(417, 143);
            this.cboPostRankId.Name = "cboPostRankId";
            this.cboPostRankId.Size = new System.Drawing.Size(170, 23);
            this.cboPostRankId.TabIndex = 3;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(94, 199);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(67, 15);
            this.lblBirthday.TabIndex = 0;
            this.lblBirthday.Text = "出生日期";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Location = new System.Drawing.Point(94, 246);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(67, 15);
            this.lblJoinDate.TabIndex = 0;
            this.lblJoinDate.Text = "入职时间";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(179, 192);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(226, 25);
            this.dtpBirthday.TabIndex = 4;
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.Location = new System.Drawing.Point(179, 239);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(226, 25);
            this.dtpJoinDate.TabIndex = 4;
            // 
            // lblNativePlace
            // 
            this.lblNativePlace.AutoSize = true;
            this.lblNativePlace.Location = new System.Drawing.Point(96, 303);
            this.lblNativePlace.Name = "lblNativePlace";
            this.lblNativePlace.Size = new System.Drawing.Size(69, 15);
            this.lblNativePlace.TabIndex = 0;
            this.lblNativePlace.Text = "籍    贯";
            // 
            // txtNativePlace
            // 
            this.txtNativePlace.Location = new System.Drawing.Point(179, 300);
            this.txtNativePlace.Name = "txtNativePlace";
            this.txtNativePlace.Size = new System.Drawing.Size(408, 25);
            this.txtNativePlace.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(140, 402);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 31);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(295, 402);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 31);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(450, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 517);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtpJoinDate);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.cboPostRankId);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.lblPostRankID);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblNativePlace);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblPostRank);
            this.Controls.Add(this.txtNativePlace);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加员工";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPostRank;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPostRankID;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.ComboBox cboPostRankId;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.Label lblNativePlace;
        private System.Windows.Forms.TextBox txtNativePlace;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}