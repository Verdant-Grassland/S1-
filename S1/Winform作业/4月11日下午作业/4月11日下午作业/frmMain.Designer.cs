namespace _4月11日下午作业
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Stuled = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PstTime = new System.Windows.Forms.TextBox();
            this.SdoName = new System.Windows.Forms.TextBox();
            this.SedReasons = new System.Windows.Forms.TextBox();
            this.SedStaff = new System.Windows.Forms.TextBox();
            this.EntryStaff = new System.Windows.Forms.TextBox();
            this.SubmitEnter = new System.Windows.Forms.Button();
            this.EmptyEntry = new System.Windows.Forms.Button();
            this.CancelEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stuled
            // 
            this.Stuled.AutoSize = true;
            this.Stuled.Font = new System.Drawing.Font("幼圆", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stuled.Location = new System.Drawing.Point(159, 19);
            this.Stuled.Name = "Stuled";
            this.Stuled.Size = new System.Drawing.Size(445, 60);
            this.Stuled.TabIndex = 0;
            this.Stuled.Text = "录 音 室 预 定";
            this.Stuled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "预定时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "录音室名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "预定原因：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "预定人员：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "录入人员：";
            // 
            // PstTime
            // 
            this.PstTime.Location = new System.Drawing.Point(169, 107);
            this.PstTime.Name = "PstTime";
            this.PstTime.Size = new System.Drawing.Size(231, 25);
            this.PstTime.TabIndex = 2;
            // 
            // SdoName
            // 
            this.SdoName.Location = new System.Drawing.Point(169, 166);
            this.SdoName.Name = "SdoName";
            this.SdoName.Size = new System.Drawing.Size(231, 25);
            this.SdoName.TabIndex = 2;
            // 
            // SedReasons
            // 
            this.SedReasons.Location = new System.Drawing.Point(169, 231);
            this.SedReasons.Name = "SedReasons";
            this.SedReasons.Size = new System.Drawing.Size(598, 25);
            this.SedReasons.TabIndex = 2;
            // 
            // SedStaff
            // 
            this.SedStaff.Location = new System.Drawing.Point(169, 294);
            this.SedStaff.Name = "SedStaff";
            this.SedStaff.Size = new System.Drawing.Size(231, 25);
            this.SedStaff.TabIndex = 2;
            // 
            // EntryStaff
            // 
            this.EntryStaff.Location = new System.Drawing.Point(169, 353);
            this.EntryStaff.Name = "EntryStaff";
            this.EntryStaff.Size = new System.Drawing.Size(231, 25);
            this.EntryStaff.TabIndex = 2;
            // 
            // SubmitEnter
            // 
            this.SubmitEnter.BackColor = System.Drawing.SystemColors.Control;
            this.SubmitEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SubmitEnter.Location = new System.Drawing.Point(106, 433);
            this.SubmitEnter.Name = "SubmitEnter";
            this.SubmitEnter.Size = new System.Drawing.Size(111, 38);
            this.SubmitEnter.TabIndex = 3;
            this.SubmitEnter.Text = "提交录入";
            this.SubmitEnter.UseVisualStyleBackColor = false;
            // 
            // EmptyEntry
            // 
            this.EmptyEntry.BackColor = System.Drawing.SystemColors.Control;
            this.EmptyEntry.Location = new System.Drawing.Point(275, 433);
            this.EmptyEntry.Name = "EmptyEntry";
            this.EmptyEntry.Size = new System.Drawing.Size(111, 38);
            this.EmptyEntry.TabIndex = 3;
            this.EmptyEntry.Text = "清空录入";
            this.EmptyEntry.UseVisualStyleBackColor = false;
            // 
            // CancelEntry
            // 
            this.CancelEntry.Location = new System.Drawing.Point(446, 433);
            this.CancelEntry.Name = "CancelEntry";
            this.CancelEntry.Size = new System.Drawing.Size(111, 38);
            this.CancelEntry.TabIndex = 3;
            this.CancelEntry.Text = "取消录入";
            this.CancelEntry.UseVisualStyleBackColor = true;
            this.CancelEntry.Click += new System.EventHandler(this.CancelEntry_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 493);
            this.Controls.Add(this.CancelEntry);
            this.Controls.Add(this.EmptyEntry);
            this.Controls.Add(this.SubmitEnter);
            this.Controls.Add(this.EntryStaff);
            this.Controls.Add(this.SedStaff);
            this.Controls.Add(this.SedReasons);
            this.Controls.Add(this.SdoName);
            this.Controls.Add(this.PstTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Stuled);
            this.Name = "frmMain";
            this.Text = "录音室预定录入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Stuled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PstTime;
        private System.Windows.Forms.TextBox SdoName;
        private System.Windows.Forms.TextBox SedReasons;
        private System.Windows.Forms.TextBox SedStaff;
        private System.Windows.Forms.TextBox EntryStaff;
        private System.Windows.Forms.Button SubmitEnter;
        private System.Windows.Forms.Button EmptyEntry;
        private System.Windows.Forms.Button CancelEntry;
    }
}

