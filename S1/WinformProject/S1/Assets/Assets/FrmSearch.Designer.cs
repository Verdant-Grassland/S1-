namespace Assets
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.assetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intoDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.cboType);
            this.gbSearch.Controls.Add(this.txtId);
            this.gbSearch.Controls.Add(this.lblType);
            this.gbSearch.Controls.Add(this.lblId);
            this.gbSearch.Location = new System.Drawing.Point(32, 31);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(581, 130);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "查询条件";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(457, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 57);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "请选择类型",
            "电子设备",
            "机械设备",
            "运输设备"});
            this.cboType.Location = new System.Drawing.Point(145, 86);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(291, 23);
            this.cboType.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(145, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(291, 25);
            this.txtId.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(57, 89);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(82, 15);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "资产类型：";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(57, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(82, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "资产编号：";
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetId,
            this.assetName,
            this.assetType,
            this.intoDate});
            this.dgvShow.Location = new System.Drawing.Point(32, 178);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.Size = new System.Drawing.Size(581, 293);
            this.dgvShow.TabIndex = 1;
            // 
            // assetId
            // 
            this.assetId.DataPropertyName = "assetId";
            this.assetId.HeaderText = "资产编号";
            this.assetId.MinimumWidth = 6;
            this.assetId.Name = "assetId";
            // 
            // assetName
            // 
            this.assetName.DataPropertyName = "assetName";
            this.assetName.HeaderText = "资产名称";
            this.assetName.MinimumWidth = 6;
            this.assetName.Name = "assetName";
            // 
            // assetType
            // 
            this.assetType.DataPropertyName = "assetType";
            this.assetType.HeaderText = "资产类型";
            this.assetType.MinimumWidth = 6;
            this.assetType.Name = "assetType";
            // 
            // intoDate
            // 
            this.intoDate.DataPropertyName = "intoDate";
            this.intoDate.HeaderText = "入库日期";
            this.intoDate.MinimumWidth = 6;
            this.intoDate.Name = "intoDate";
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 483);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.gbSearch);
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "固定资产查询";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn intoDate;
    }
}