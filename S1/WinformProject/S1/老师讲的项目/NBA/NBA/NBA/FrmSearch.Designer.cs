namespace NBA
{
    partial class FrmSearch
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
            this.lblHostName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pastScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostTeamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayTeamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(94, 57);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(67, 15);
            this.lblHostName.TabIndex = 0;
            this.lblHostName.Text = "主队名称";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 25);
            this.txtName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(457, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.count,
            this.hostTeamName,
            this.awayTeamName,
            this.pastScore,
            this.competitionTime,
            this.hostTeamScore,
            this.awayTeamScore});
            this.dgvShow.Location = new System.Drawing.Point(36, 121);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(1009, 284);
            this.dgvShow.TabIndex = 3;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.FillWeight = 71.75144F;
            this.count.HeaderText = "场次";
            this.count.Name = "count";
            // 
            // hostTeamName
            // 
            this.hostTeamName.DataPropertyName = "hostTeamName";
            this.hostTeamName.FillWeight = 81.23801F;
            this.hostTeamName.HeaderText = "主队名称";
            this.hostTeamName.Name = "hostTeamName";
            // 
            // awayTeamName
            // 
            this.awayTeamName.DataPropertyName = "awayTeamName";
            this.awayTeamName.FillWeight = 90.36591F;
            this.awayTeamName.HeaderText = "客队名称";
            this.awayTeamName.Name = "awayTeamName";
            // 
            // pastScore
            // 
            this.pastScore.DataPropertyName = "pastScore";
            this.pastScore.FillWeight = 104.8087F;
            this.pastScore.HeaderText = "上一场得分";
            this.pastScore.Name = "pastScore";
            // 
            // competitionTime
            // 
            this.competitionTime.DataPropertyName = "competitionTime";
            this.competitionTime.FillWeight = 119.1056F;
            this.competitionTime.HeaderText = "比赛时间";
            this.competitionTime.Name = "competitionTime";
            // 
            // hostTeamScore
            // 
            this.hostTeamScore.DataPropertyName = "hostTeamScore";
            this.hostTeamScore.FillWeight = 126.1314F;
            this.hostTeamScore.HeaderText = "主队总分分";
            this.hostTeamScore.Name = "hostTeamScore";
            // 
            // awayTeamScore
            // 
            this.awayTeamScore.DataPropertyName = "awayTeamScore";
            this.awayTeamScore.FillWeight = 106.599F;
            this.awayTeamScore.HeaderText = "客队总分数";
            this.awayTeamScore.Name = "awayTeamScore";
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 469);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHostName);
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "赛程查询";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pastScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostTeamScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayTeamScore;
    }
}