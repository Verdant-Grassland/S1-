namespace MyOffice
{
    partial class FrmJudge
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
            this.lblJudgement = new System.Windows.Forms.Label();
            this.txtJudgement = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "员工姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 48);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(323, 25);
            this.txtName.TabIndex = 1;
            // 
            // lblJudgement
            // 
            this.lblJudgement.AutoSize = true;
            this.lblJudgement.Location = new System.Drawing.Point(52, 82);
            this.lblJudgement.Name = "lblJudgement";
            this.lblJudgement.Size = new System.Drawing.Size(67, 15);
            this.lblJudgement.TabIndex = 0;
            this.lblJudgement.Text = "填写评价";
            // 
            // txtJudgement
            // 
            this.txtJudgement.Location = new System.Drawing.Point(145, 79);
            this.txtJudgement.Multiline = true;
            this.txtJudgement.Name = "txtJudgement";
            this.txtJudgement.Size = new System.Drawing.Size(323, 96);
            this.txtJudgement.TabIndex = 1;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(52, 184);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(67, 15);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "年度评分";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(145, 181);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(323, 25);
            this.txtScore.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(145, 236);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 33);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "评分";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(248, 236);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmJudge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 297);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtJudgement);
            this.Controls.Add(this.lblJudgement);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmJudge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "评分";
            this.Load += new System.EventHandler(this.FrmJudge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblJudgement;
        private System.Windows.Forms.TextBox txtJudgement;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtName;
    }
}