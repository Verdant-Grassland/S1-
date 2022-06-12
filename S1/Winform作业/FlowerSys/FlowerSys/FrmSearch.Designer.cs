namespace FlowerSys
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
            this.components = new System.ComponentModel.Container();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.SaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleClerk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.conMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.txtName);
            this.gbSearch.Controls.Add(this.lblName);
            this.gbSearch.Location = new System.Drawing.Point(23, 36);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(1002, 86);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "查询条件";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(127, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "鲜花名称：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(215, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(314, 25);
            this.txtName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(599, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 38);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleId,
            this.FlowerId,
            this.FlowerName,
            this.SaleCount,
            this.SalePrice,
            this.SaleDate,
            this.SaleClerk});
            this.dgvShow.ContextMenuStrip = this.conMenu;
            this.dgvShow.Location = new System.Drawing.Point(23, 155);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.Size = new System.Drawing.Size(1002, 336);
            this.dgvShow.TabIndex = 1;
            // 
            // SaleId
            // 
            this.SaleId.DataPropertyName = "SaleId";
            this.SaleId.HeaderText = "销售编号";
            this.SaleId.MinimumWidth = 6;
            this.SaleId.Name = "SaleId";
            // 
            // FlowerId
            // 
            this.FlowerId.DataPropertyName = "FlowerId";
            this.FlowerId.HeaderText = "鲜花编号";
            this.FlowerId.MinimumWidth = 6;
            this.FlowerId.Name = "FlowerId";
            // 
            // FlowerName
            // 
            this.FlowerName.DataPropertyName = "FlowerName";
            this.FlowerName.HeaderText = "鲜花名称";
            this.FlowerName.MinimumWidth = 6;
            this.FlowerName.Name = "FlowerName";
            // 
            // SaleCount
            // 
            this.SaleCount.DataPropertyName = "SaleCount";
            this.SaleCount.HeaderText = "销售数量";
            this.SaleCount.MinimumWidth = 6;
            this.SaleCount.Name = "SaleCount";
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "单价";
            this.SalePrice.MinimumWidth = 6;
            this.SalePrice.Name = "SalePrice";
            // 
            // SaleDate
            // 
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "销售日期";
            this.SaleDate.MinimumWidth = 6;
            this.SaleDate.Name = "SaleDate";
            // 
            // SaleClerk
            // 
            this.SaleClerk.DataPropertyName = "SaleClerk";
            this.SaleClerk.HeaderText = "销售员";
            this.SaleClerk.MinimumWidth = 6;
            this.SaleClerk.Name = "SaleClerk";
            // 
            // conMenu
            // 
            this.conMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdate,
            this.tsmiDelete});
            this.conMenu.Name = "conMenu";
            this.conMenu.Size = new System.Drawing.Size(211, 88);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(210, 28);
            this.tsmiUpdate.Text = "修改";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(116, 28);
            this.tsmiDelete.Text = "删除";
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 503);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.gbSearch);
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询鲜花销售信息";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.conMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleClerk;
        private System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}