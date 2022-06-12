namespace Board
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblXingMing = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLongTime = new System.Windows.Forms.Label();
            this.lblInputName = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtEnteringName = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(111, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "选择会议室";
            // 
            // lblXingMing
            // 
            this.lblXingMing.AutoSize = true;
            this.lblXingMing.Location = new System.Drawing.Point(111, 109);
            this.lblXingMing.Name = "lblXingMing";
            this.lblXingMing.Size = new System.Drawing.Size(82, 15);
            this.lblXingMing.TabIndex = 0;
            this.lblXingMing.Text = "预订人姓名";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(96, 160);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(97, 15);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "预订开始时间";
            // 
            // lblLongTime
            // 
            this.lblLongTime.AutoSize = true;
            this.lblLongTime.Location = new System.Drawing.Point(126, 211);
            this.lblLongTime.Name = "lblLongTime";
            this.lblLongTime.Size = new System.Drawing.Size(67, 15);
            this.lblLongTime.TabIndex = 0;
            this.lblLongTime.Text = "预订时长";
            // 
            // lblInputName
            // 
            this.lblInputName.AutoSize = true;
            this.lblInputName.Location = new System.Drawing.Point(111, 262);
            this.lblInputName.Name = "lblInputName";
            this.lblInputName.Size = new System.Drawing.Size(82, 15);
            this.lblInputName.TabIndex = 0;
            this.lblInputName.Text = "录入人姓名";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(126, 313);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(67, 15);
            this.lblReason.TabIndex = 0;
            this.lblReason.Text = "预订原因";
            // 
            // cboName
            // 
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(208, 51);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(257, 23);
            this.cboName.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(208, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 25);
            this.txtName.TabIndex = 2;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(208, 153);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(256, 25);
            this.txtDate.TabIndex = 3;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(208, 205);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(144, 25);
            this.txtDuration.TabIndex = 4;
            // 
            // txtEnteringName
            // 
            this.txtEnteringName.Location = new System.Drawing.Point(208, 257);
            this.txtEnteringName.Name = "txtEnteringName";
            this.txtEnteringName.Size = new System.Drawing.Size(256, 25);
            this.txtEnteringName.TabIndex = 5;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(208, 309);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(409, 25);
            this.txtReason.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(114, 356);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 36);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "保存";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(244, 356);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(392, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 36);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 457);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtEnteringName);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblInputName);
            this.Controls.Add(this.lblLongTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblXingMing);
            this.Controls.Add(this.lblName);
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预订会议室";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblXingMing;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLongTime;
        private System.Windows.Forms.Label lblInputName;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtEnteringName;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}