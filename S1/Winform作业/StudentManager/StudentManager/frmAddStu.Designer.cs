namespace StudentManager
{
    partial class frmAddStu
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.gboStudent = new System.Windows.Forms.GroupBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.gboSearch = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtInSearch = new System.Windows.Forms.TextBox();
            this.lblConSearch = new System.Windows.Forms.Label();
            this.cboInSearch = new System.Windows.Forms.ComboBox();
            this.lblInSearch = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.gboSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSearch.Location = new System.Drawing.Point(309, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(302, 28);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "北大青鸟学员信息查询";
            // 
            // gboStudent
            // 
            this.gboStudent.Controls.Add(this.dgvShow);
            this.gboStudent.Location = new System.Drawing.Point(12, 80);
            this.gboStudent.Name = "gboStudent";
            this.gboStudent.Size = new System.Drawing.Size(902, 415);
            this.gboStudent.TabIndex = 1;
            this.gboStudent.TabStop = false;
            this.gboStudent.Text = "学员信息";
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name0,
            this.ClassNo,
            this.Gender,
            this.Age,
            this.IDCard,
            this.Telephone,
            this.Address});
            this.dgvShow.Location = new System.Drawing.Point(6, 24);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.Size = new System.Drawing.Size(888, 379);
            this.dgvShow.TabIndex = 0;
            // 
            // gboSearch
            // 
            this.gboSearch.Controls.Add(this.btnExit);
            this.gboSearch.Controls.Add(this.btnSearch);
            this.gboSearch.Controls.Add(this.btnClear);
            this.gboSearch.Controls.Add(this.txtInSearch);
            this.gboSearch.Controls.Add(this.lblConSearch);
            this.gboSearch.Controls.Add(this.cboInSearch);
            this.gboSearch.Controls.Add(this.lblInSearch);
            this.gboSearch.Location = new System.Drawing.Point(18, 501);
            this.gboSearch.Name = "gboSearch";
            this.gboSearch.Size = new System.Drawing.Size(896, 94);
            this.gboSearch.TabIndex = 2;
            this.gboSearch.TabStop = false;
            this.gboSearch.Text = "查询信息";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(730, 39);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(640, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 31);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(547, 39);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 31);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtInSearch
            // 
            this.txtInSearch.Location = new System.Drawing.Point(380, 36);
            this.txtInSearch.Name = "txtInSearch";
            this.txtInSearch.Size = new System.Drawing.Size(113, 25);
            this.txtInSearch.TabIndex = 4;
            // 
            // lblConSearch
            // 
            this.lblConSearch.AutoSize = true;
            this.lblConSearch.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblConSearch.Location = new System.Drawing.Point(242, 39);
            this.lblConSearch.Name = "lblConSearch";
            this.lblConSearch.Size = new System.Drawing.Size(80, 18);
            this.lblConSearch.TabIndex = 2;
            this.lblConSearch.Text = "查询条件";
            // 
            // cboInSearch
            // 
            this.cboInSearch.FormattingEnabled = true;
            this.cboInSearch.Items.AddRange(new object[] {
            "学员姓名",
            "联系电话",
            "家庭住址",
            "身份证号"});
            this.cboInSearch.Location = new System.Drawing.Point(115, 36);
            this.cboInSearch.Name = "cboInSearch";
            this.cboInSearch.Size = new System.Drawing.Size(105, 23);
            this.cboInSearch.TabIndex = 1;
            // 
            // lblInSearch
            // 
            this.lblInSearch.AutoSize = true;
            this.lblInSearch.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInSearch.Location = new System.Drawing.Point(20, 39);
            this.lblInSearch.Name = "lblInSearch";
            this.lblInSearch.Size = new System.Drawing.Size(80, 18);
            this.lblInSearch.TabIndex = 0;
            this.lblInSearch.Text = "查询类型";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "序号";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Name0
            // 
            this.Name0.DataPropertyName = "Name";
            this.Name0.HeaderText = "姓名";
            this.Name0.MinimumWidth = 6;
            this.Name0.Name = "Name0";
            // 
            // ClassNo
            // 
            this.ClassNo.DataPropertyName = "ClassNo";
            this.ClassNo.HeaderText = "班级编号";
            this.ClassNo.MinimumWidth = 6;
            this.ClassNo.Name = "ClassNo";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "入学年龄";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            // 
            // IDCard
            // 
            this.IDCard.DataPropertyName = "IDCard";
            this.IDCard.HeaderText = "身份证号";
            this.IDCard.MinimumWidth = 6;
            this.IDCard.Name = "IDCard";
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "联想电话";
            this.Telephone.MinimumWidth = 6;
            this.Telephone.Name = "Telephone";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "家庭住址";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // frmAddStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 627);
            this.Controls.Add(this.gboSearch);
            this.Controls.Add(this.gboStudent);
            this.Controls.Add(this.lblSearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "北大青鸟学员信息查询";
            this.Load += new System.EventHandler(this.frmAddStu_Load);
            this.gboStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.gboSearch.ResumeLayout(false);
            this.gboSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gboStudent;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.GroupBox gboSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtInSearch;
        private System.Windows.Forms.Label lblConSearch;
        private System.Windows.Forms.ComboBox cboInSearch;
        private System.Windows.Forms.Label lblInSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name0;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}