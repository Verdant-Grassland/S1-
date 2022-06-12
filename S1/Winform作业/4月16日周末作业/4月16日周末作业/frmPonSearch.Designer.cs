namespace _4月16日周末作业
{
    partial class frmPonSearch
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbIName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvProductInfo = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corporation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 25);
            this.txtName.TabIndex = 3;
            // 
            // lbIName
            // 
            this.lbIName.AutoSize = true;
            this.lbIName.Location = new System.Drawing.Point(71, 32);
            this.lbIName.Name = "lbIName";
            this.lbIName.Size = new System.Drawing.Size(82, 15);
            this.lbIName.TabIndex = 2;
            this.lbIName.Text = "产品名称：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(520, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(656, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvProductInfo
            // 
            this.dgvProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.RelaseDate,
            this.MarketDate,
            this.Price,
            this.Corporation});
            this.dgvProductInfo.Location = new System.Drawing.Point(12, 88);
            this.dgvProductInfo.Name = "dgvProductInfo";
            this.dgvProductInfo.RowHeadersWidth = 51;
            this.dgvProductInfo.RowTemplate.Height = 27;
            this.dgvProductInfo.Size = new System.Drawing.Size(958, 350);
            this.dgvProductInfo.TabIndex = 5;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "产品编号";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 145;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "产品名称";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 145;
            // 
            // RelaseDate
            // 
            this.RelaseDate.HeaderText = "发布时间";
            this.RelaseDate.MinimumWidth = 6;
            this.RelaseDate.Name = "RelaseDate";
            this.RelaseDate.Width = 145;
            // 
            // MarketDate
            // 
            this.MarketDate.HeaderText = "上市时间";
            this.MarketDate.MinimumWidth = 6;
            this.MarketDate.Name = "MarketDate";
            this.MarketDate.Width = 145;
            // 
            // Price
            // 
            this.Price.HeaderText = "售价";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 145;
            // 
            // Corporation
            // 
            this.Corporation.HeaderText = "录入人员";
            this.Corporation.MinimumWidth = 6;
            this.Corporation.Name = "Corporation";
            this.Corporation.Width = 145;
            // 
            // frmPonSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.dgvProductInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbIName);
            this.Name = "frmPonSearch";
            this.Text = "产品信息查找";
            this.Load += new System.EventHandler(this.frmPonSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbIName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvProductInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corporation;
    }
}