namespace Ticket
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.FlightNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airways = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LandTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboDest = new System.Windows.Forms.ComboBox();
            this.cboLeave = new System.Windows.Forms.ComboBox();
            this.lblDest = new System.Windows.Forms.Label();
            this.lblLeaveCity = new System.Windows.Forms.Label();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.dtpLeaveDate = new System.Windows.Forms.DateTimePicker();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtLandTime = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.txtLeave = new System.Windows.Forms.TextBox();
            this.txtAirWays = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.lblLandTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblLeave = new System.Windows.Forms.Label();
            this.lblAirWays = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.gbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvShow);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cboDest);
            this.groupBox1.Controls.Add(this.cboLeave);
            this.groupBox1.Controls.Add(this.lblDest);
            this.groupBox1.Controls.Add(this.lblLeaveCity);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "航班信息";
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightNO,
            this.Airways,
            this.LeaveTime,
            this.LandTime,
            this.Price});
            this.dgvShow.Location = new System.Drawing.Point(39, 89);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(646, 173);
            this.dgvShow.TabIndex = 3;
            this.dgvShow.Click += new System.EventHandler(this.dgvShow_Click);
            // 
            // FlightNO
            // 
            this.FlightNO.DataPropertyName = "FlightNO";
            this.FlightNO.HeaderText = "航班号";
            this.FlightNO.Name = "FlightNO";
            // 
            // Airways
            // 
            this.Airways.DataPropertyName = "Airways";
            this.Airways.HeaderText = "航空公司";
            this.Airways.Name = "Airways";
            // 
            // LeaveTime
            // 
            this.LeaveTime.DataPropertyName = "LeaveTime";
            this.LeaveTime.HeaderText = "出发时间";
            this.LeaveTime.Name = "LeaveTime";
            // 
            // LandTime
            // 
            this.LandTime.DataPropertyName = "LandTime";
            this.LandTime.HeaderText = "到达时间";
            this.LandTime.Name = "LandTime";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "成人票价";
            this.Price.Name = "Price";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(572, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboDest
            // 
            this.cboDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDest.FormattingEnabled = true;
            this.cboDest.Location = new System.Drawing.Point(378, 47);
            this.cboDest.Name = "cboDest";
            this.cboDest.Size = new System.Drawing.Size(170, 23);
            this.cboDest.TabIndex = 1;
            // 
            // cboLeave
            // 
            this.cboLeave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeave.FormattingEnabled = true;
            this.cboLeave.Location = new System.Drawing.Point(107, 45);
            this.cboLeave.Name = "cboLeave";
            this.cboLeave.Size = new System.Drawing.Size(170, 23);
            this.cboLeave.TabIndex = 1;
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(307, 48);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(52, 15);
            this.lblDest.TabIndex = 0;
            this.lblDest.Text = "日的地";
            // 
            // lblLeaveCity
            // 
            this.lblLeaveCity.AutoSize = true;
            this.lblLeaveCity.Location = new System.Drawing.Point(46, 47);
            this.lblLeaveCity.Name = "lblLeaveCity";
            this.lblLeaveCity.Size = new System.Drawing.Size(52, 15);
            this.lblLeaveCity.TabIndex = 0;
            this.lblLeaveCity.Text = "出发地";
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.dtpLeaveDate);
            this.gbAdd.Controls.Add(this.nudNumber);
            this.gbAdd.Controls.Add(this.txtPrice);
            this.gbAdd.Controls.Add(this.txtLandTime);
            this.gbAdd.Controls.Add(this.txtTime);
            this.gbAdd.Controls.Add(this.txtDest);
            this.gbAdd.Controls.Add(this.txtLeave);
            this.gbAdd.Controls.Add(this.txtAirWays);
            this.gbAdd.Controls.Add(this.txtNo);
            this.gbAdd.Controls.Add(this.lblCount);
            this.gbAdd.Controls.Add(this.lblPrice);
            this.gbAdd.Controls.Add(this.lblLeaveDate);
            this.gbAdd.Controls.Add(this.lblLandTime);
            this.gbAdd.Controls.Add(this.lblTime);
            this.gbAdd.Controls.Add(this.lblDestination);
            this.gbAdd.Controls.Add(this.lblLeave);
            this.gbAdd.Controls.Add(this.lblAirWays);
            this.gbAdd.Controls.Add(this.lblNo);
            this.gbAdd.Location = new System.Drawing.Point(20, 318);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(732, 268);
            this.gbAdd.TabIndex = 1;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "航班预订";
            // 
            // dtpLeaveDate
            // 
            this.dtpLeaveDate.Location = new System.Drawing.Point(464, 228);
            this.dtpLeaveDate.Name = "dtpLeaveDate";
            this.dtpLeaveDate.Size = new System.Drawing.Size(211, 25);
            this.dtpLeaveDate.TabIndex = 3;
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(131, 230);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(194, 25);
            this.nudNumber.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(131, 184);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(194, 25);
            this.txtPrice.TabIndex = 1;
            // 
            // txtLandTime
            // 
            this.txtLandTime.Location = new System.Drawing.Point(464, 134);
            this.txtLandTime.Name = "txtLandTime";
            this.txtLandTime.ReadOnly = true;
            this.txtLandTime.Size = new System.Drawing.Size(211, 25);
            this.txtLandTime.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(131, 135);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(194, 25);
            this.txtTime.TabIndex = 1;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(464, 90);
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(211, 25);
            this.txtDest.TabIndex = 1;
            // 
            // txtLeave
            // 
            this.txtLeave.Location = new System.Drawing.Point(131, 91);
            this.txtLeave.Name = "txtLeave";
            this.txtLeave.ReadOnly = true;
            this.txtLeave.Size = new System.Drawing.Size(194, 25);
            this.txtLeave.TabIndex = 1;
            // 
            // txtAirWays
            // 
            this.txtAirWays.Location = new System.Drawing.Point(464, 43);
            this.txtAirWays.Name = "txtAirWays";
            this.txtAirWays.ReadOnly = true;
            this.txtAirWays.Size = new System.Drawing.Size(211, 25);
            this.txtAirWays.TabIndex = 1;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(131, 44);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(194, 25);
            this.txtNo.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(45, 238);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(82, 15);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "预订数量：";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(45, 190);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(82, 15);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "成人票价：";
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Location = new System.Drawing.Point(378, 230);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(82, 15);
            this.lblLeaveDate.TabIndex = 0;
            this.lblLeaveDate.Text = "出发日期：";
            // 
            // lblLandTime
            // 
            this.lblLandTime.AutoSize = true;
            this.lblLandTime.Location = new System.Drawing.Point(378, 141);
            this.lblLandTime.Name = "lblLandTime";
            this.lblLandTime.Size = new System.Drawing.Size(82, 15);
            this.lblLandTime.TabIndex = 0;
            this.lblLandTime.Text = "到达时间：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(45, 142);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 15);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "出发时间：";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(393, 93);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(67, 15);
            this.lblDestination.TabIndex = 0;
            this.lblDestination.Text = "目的地：";
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Location = new System.Drawing.Point(60, 94);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(67, 15);
            this.lblLeave.TabIndex = 0;
            this.lblLeave.Text = "出发地：";
            // 
            // lblAirWays
            // 
            this.lblAirWays.AutoSize = true;
            this.lblAirWays.Location = new System.Drawing.Point(378, 45);
            this.lblAirWays.Name = "lblAirWays";
            this.lblAirWays.Size = new System.Drawing.Size(82, 15);
            this.lblAirWays.TabIndex = 0;
            this.lblAirWays.Text = "航空公司：";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(60, 46);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(67, 15);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "航班号：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(542, 602);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "预订";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(649, 602);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 653);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "航班查询预订";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboDest;
        private System.Windows.Forms.ComboBox cboLeave;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label lblLeaveCity;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.DateTimePicker dtpLeaveDate;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtLandTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtLeave;
        private System.Windows.Forms.TextBox txtAirWays;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblLeaveDate;
        private System.Windows.Forms.Label lblLandTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Label lblAirWays;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airways;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LandTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

