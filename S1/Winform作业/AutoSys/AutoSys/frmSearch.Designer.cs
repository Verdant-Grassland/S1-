namespace AutoSys
{
    partial class frmSearch
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
            this.lblAutoNum = new System.Windows.Forms.Label();
            this.txtAutoNum = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.AutoNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitKiloNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutoNum
            // 
            this.lblAutoNum.AutoSize = true;
            this.lblAutoNum.Location = new System.Drawing.Point(116, 53);
            this.lblAutoNum.Name = "lblAutoNum";
            this.lblAutoNum.Size = new System.Drawing.Size(82, 15);
            this.lblAutoNum.TabIndex = 0;
            this.lblAutoNum.Text = "车牌号码：";
            // 
            // txtAutoNum
            // 
            this.txtAutoNum.Location = new System.Drawing.Point(204, 43);
            this.txtAutoNum.Name = "txtAutoNum";
            this.txtAutoNum.Size = new System.Drawing.Size(162, 25);
            this.txtAutoNum.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(383, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutoNum,
            this.BrandName,
            this.Instruction,
            this.BuyDate,
            this.Price,
            this.InitKiloNum});
            this.dgvShow.Location = new System.Drawing.Point(12, 109);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.Size = new System.Drawing.Size(776, 286);
            this.dgvShow.TabIndex = 3;
            // 
            // AutoNum
            // 
            this.AutoNum.DataPropertyName = "AutoNum";
            this.AutoNum.HeaderText = "车牌号码";
            this.AutoNum.MinimumWidth = 6;
            this.AutoNum.Name = "AutoNum";
            // 
            // BrandName
            // 
            this.BrandName.DataPropertyName = "BrandName";
            this.BrandName.HeaderText = "品牌名称";
            this.BrandName.MinimumWidth = 6;
            this.BrandName.Name = "BrandName";
            // 
            // Instruction
            // 
            this.Instruction.DataPropertyName = "Instruction";
            this.Instruction.HeaderText = "车辆说明";
            this.Instruction.MinimumWidth = 6;
            this.Instruction.Name = "Instruction";
            // 
            // BuyDate
            // 
            this.BuyDate.DataPropertyName = "BuyDate";
            this.BuyDate.HeaderText = "购入日期";
            this.BuyDate.MinimumWidth = 6;
            this.BuyDate.Name = "BuyDate";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "购入价格";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // InitKiloNum
            // 
            this.InitKiloNum.DataPropertyName = "InitKiloNum";
            this.InitKiloNum.HeaderText = "初始公里数";
            this.InitKiloNum.MinimumWidth = 6;
            this.InitKiloNum.Name = "InitKiloNum";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(636, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAutoNum);
            this.Controls.Add(this.lblAutoNum);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车辆查询";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutoNum;
        private System.Windows.Forms.TextBox txtAutoNum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitKiloNum;
    }
}