namespace HrSys
{
    partial class FrmUpdate
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名：";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(143, 54);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label1";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(357, 54);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(52, 15);
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "部门：";
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(467, 54);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(55, 15);
            this.lblDeptName.TabIndex = 0;
            this.lblDeptName.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(654, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "日期：";
            // 
            // lblShowDate
            // 
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Location = new System.Drawing.Point(729, 54);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(55, 15);
            this.lblShowDate.TabIndex = 0;
            this.lblShowDate.Text = "label1";
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(51, 114);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(82, 15);
            this.lblIn.TabIndex = 0;
            this.lblIn.Text = "签到时间：";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(356, 114);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(82, 15);
            this.lblOut.TabIndex = 0;
            this.lblOut.Text = "签退时间：";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(132, 109);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(184, 25);
            this.txtIn.TabIndex = 1;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(456, 109);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(184, 25);
            this.txtOut.TabIndex = 1;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(51, 172);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(52, 15);
            this.lblRemark.TabIndex = 0;
            this.lblRemark.Text = "备注：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(132, 169);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(715, 243);
            this.txtRemark.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(137, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(303, 438);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(135, 39);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 525);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.lblShowDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.lblName);
            this.Name = "FrmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "维护考勤信息";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblDeptName;
        public System.Windows.Forms.Label lblShowDate;
        public System.Windows.Forms.TextBox txtIn;
        public System.Windows.Forms.TextBox txtOut;
        public System.Windows.Forms.TextBox txtRemark;
    }
}