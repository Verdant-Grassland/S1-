namespace ComputerManager
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
            this.lblComputerId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.ComputerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HardDisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComputerId
            // 
            this.lblComputerId.AutoSize = true;
            this.lblComputerId.Location = new System.Drawing.Point(102, 40);
            this.lblComputerId.Name = "lblComputerId";
            this.lblComputerId.Size = new System.Drawing.Size(52, 15);
            this.lblComputerId.TabIndex = 0;
            this.lblComputerId.Text = "编号：";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(176, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(219, 25);
            this.txtId.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(436, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 30);
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
            this.ComputerId,
            this.Brand,
            this.CPU,
            this.Memory,
            this.HardDisk,
            this.Employee});
            this.dgvShow.Location = new System.Drawing.Point(0, 94);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.Size = new System.Drawing.Size(835, 293);
            this.dgvShow.TabIndex = 3;
            // 
            // ComputerId
            // 
            this.ComputerId.DataPropertyName = "ComputerId";
            this.ComputerId.HeaderText = "编号";
            this.ComputerId.MinimumWidth = 6;
            this.ComputerId.Name = "ComputerId";
            this.ComputerId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "品牌";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            // 
            // CPU
            // 
            this.CPU.DataPropertyName = "CPU";
            this.CPU.HeaderText = "CPU";
            this.CPU.MinimumWidth = 6;
            this.CPU.Name = "CPU";
            // 
            // Memory
            // 
            this.Memory.DataPropertyName = "Memory";
            this.Memory.HeaderText = "内存大小(G)";
            this.Memory.MinimumWidth = 6;
            this.Memory.Name = "Memory";
            // 
            // HardDisk
            // 
            this.HardDisk.DataPropertyName = "HardDisk";
            this.HardDisk.HeaderText = "硬盘大小(G)";
            this.HardDisk.MinimumWidth = 6;
            this.HardDisk.Name = "HardDisk";
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "Employee";
            this.Employee.HeaderText = "使用员工";
            this.Employee.MinimumWidth = 6;
            this.Employee.Name = "Employee";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 386);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblComputerId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算机配置信息查询";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComputerId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn HardDisk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
    }
}