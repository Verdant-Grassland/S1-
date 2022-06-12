namespace _4月20日下午作业
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
            this.lbISearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.别名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.科属 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产地 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbISearch
            // 
            this.lbISearch.AutoSize = true;
            this.lbISearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbISearch.Location = new System.Drawing.Point(85, 38);
            this.lbISearch.Name = "lbISearch";
            this.lbISearch.Size = new System.Drawing.Size(149, 20);
            this.lbISearch.TabIndex = 0;
            this.lbISearch.Text = "按名称模糊查询";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 25);
            this.textBox1.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(626, 34);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 31);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "查询";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名称,
            this.别名,
            this.科属,
            this.价格,
            this.产地});
            this.dataGridView1.Location = new System.Drawing.Point(21, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(764, 285);
            this.dataGridView1.TabIndex = 3;
            // 
            // 名称
            // 
            this.名称.HeaderText = "名称";
            this.名称.MinimumWidth = 6;
            this.名称.Name = "名称";
            this.名称.Width = 145;
            // 
            // 别名
            // 
            this.别名.HeaderText = "别名";
            this.别名.MinimumWidth = 6;
            this.别名.Name = "别名";
            this.别名.Width = 145;
            // 
            // 科属
            // 
            this.科属.HeaderText = "科属";
            this.科属.MinimumWidth = 6;
            this.科属.Name = "科属";
            this.科属.Width = 145;
            // 
            // 价格
            // 
            this.价格.HeaderText = "价格";
            this.价格.MinimumWidth = 6;
            this.价格.Name = "价格";
            this.价格.Width = 145;
            // 
            // 产地
            // 
            this.产地.HeaderText = "产地";
            this.产地.MinimumWidth = 6;
            this.产地.Name = "产地";
            this.产地.Width = 145;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(663, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 474);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbISearch);
            this.Name = "FrmSearch";
            this.Text = "查看花卉信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbISearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 别名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 科属;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产地;
        private System.Windows.Forms.Button btnClose;
    }
}