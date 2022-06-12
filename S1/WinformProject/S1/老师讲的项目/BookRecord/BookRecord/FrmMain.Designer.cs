namespace BookRecord
{
    partial class FrmMain
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInput.Location = new System.Drawing.Point(218, 23);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(168, 30);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "录音室录入";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(96, 98);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 15);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "预订时间：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(96, 153);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "录音室名字：";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(96, 208);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(82, 15);
            this.lblReason.TabIndex = 1;
            this.lblReason.Text = "预订原因：";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(96, 263);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(82, 15);
            this.lblPerson.TabIndex = 1;
            this.lblPerson.Text = "预订人员：";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(96, 318);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(82, 15);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "录入人员：";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(206, 94);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(263, 25);
            this.txtTime.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(206, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 25);
            this.txtName.TabIndex = 2;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(206, 200);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(263, 25);
            this.txtReason.TabIndex = 2;
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(206, 253);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(263, 25);
            this.txtPerson.TabIndex = 2;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(206, 306);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(263, 25);
            this.txtNote.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(123, 361);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 39);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "提交录入";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(262, 361);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 39);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空录入";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(399, 361);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(117, 39);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "取消录入";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 447);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblInput);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "录音室预订录入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancle;
    }
}

