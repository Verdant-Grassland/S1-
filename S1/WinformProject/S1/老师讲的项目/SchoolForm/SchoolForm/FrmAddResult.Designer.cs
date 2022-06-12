namespace SchoolForm
{
    partial class FrmAddResult
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
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtStudentResult = new System.Windows.Forms.TextBox();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnSubmit);
            this.gbInput.Controls.Add(this.dtpTime);
            this.gbInput.Controls.Add(this.txtStudentResult);
            this.gbInput.Controls.Add(this.cboSubject);
            this.gbInput.Controls.Add(this.lblDate);
            this.gbInput.Controls.Add(this.lblScore);
            this.gbInput.Controls.Add(this.lblSubject);
            this.gbInput.Location = new System.Drawing.Point(16, 29);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(616, 182);
            this.gbInput.TabIndex = 0;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "输入成绩";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(494, 125);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 25);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "添加";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(162, 125);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(326, 25);
            this.dtpTime.TabIndex = 3;
            // 
            // txtStudentResult
            // 
            this.txtStudentResult.Location = new System.Drawing.Point(162, 81);
            this.txtStudentResult.Name = "txtStudentResult";
            this.txtStudentResult.Size = new System.Drawing.Size(328, 25);
            this.txtStudentResult.TabIndex = 2;
            // 
            // cboSubject
            // 
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(162, 39);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(328, 23);
            this.cboSubject.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(82, 125);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "考试时间";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(112, 84);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(37, 15);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "成绩";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(112, 43);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(37, 15);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "科目";
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentName,
            this.subjectName,
            this.studentResult,
            this.examDate});
            this.dgvShow.Location = new System.Drawing.Point(16, 224);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.Size = new System.Drawing.Size(615, 280);
            this.dgvShow.TabIndex = 1;
            // 
            // studentName
            // 
            this.studentName.DataPropertyName = "StudentName";
            this.studentName.HeaderText = "学生姓名";
            this.studentName.Name = "studentName";
            // 
            // subjectName
            // 
            this.subjectName.DataPropertyName = "SubjectName";
            this.subjectName.HeaderText = "科目名称";
            this.subjectName.Name = "subjectName";
            // 
            // studentResult
            // 
            this.studentResult.DataPropertyName = "StudentResult";
            this.studentResult.HeaderText = "成绩";
            this.studentResult.Name = "studentResult";
            // 
            // examDate
            // 
            this.examDate.DataPropertyName = "ExamDate";
            this.examDate.HeaderText = "考试时间";
            this.examDate.Name = "examDate";
            // 
            // FrmAddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 569);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.gbInput);
            this.Name = "FrmAddResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加成绩";
            this.Load += new System.EventHandler(this.FrmAddResult_Load);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtStudentResult;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDate;
    }
}