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
            this.gbone = new System.Windows.Forms.GroupBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboDest = new System.Windows.Forms.ComboBox();
            this.cboLeave = new System.Windows.Forms.ComboBox();
            this.lblmd = new System.Windows.Forms.Label();
            this.lblcf = new System.Windows.Forms.Label();
            this.gbyd = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtLandTime = new System.Windows.Forms.TextBox();
            this.txtLeave = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLandTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtAirways = new System.Windows.Forms.TextBox();
            this.lblLeave = new System.Windows.Forms.Label();
            this.lblAirways = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FlightNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airways = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LandTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.gbyd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbone
            // 
            this.gbone.Controls.Add(this.dgvShow);
            this.gbone.Controls.Add(this.btnSearch);
            this.gbone.Controls.Add(this.cboDest);
            this.gbone.Controls.Add(this.cboLeave);
            this.gbone.Controls.Add(this.lblmd);
            this.gbone.Controls.Add(this.lblcf);
            this.gbone.Location = new System.Drawing.Point(12, 12);
            this.gbone.Name = "gbone";
            this.gbone.Size = new System.Drawing.Size(691, 203);
            this.gbone.TabIndex = 0;
            this.gbone.TabStop = false;
            this.gbone.Text = "航班信息";
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
            this.dgvShow.Location = new System.Drawing.Point(39, 58);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.Size = new System.Drawing.Size(609, 131);
            this.dgvShow.TabIndex = 3;
            this.dgvShow.Click += new System.EventHandler(this.dgvShow_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(533, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboDest
            // 
            this.cboDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDest.FormattingEnabled = true;
            this.cboDest.Location = new System.Drawing.Point(341, 25);
            this.cboDest.Name = "cboDest";
            this.cboDest.Size = new System.Drawing.Size(157, 20);
            this.cboDest.TabIndex = 1;
            // 
            // cboLeave
            // 
            this.cboLeave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeave.FormattingEnabled = true;
            this.cboLeave.Location = new System.Drawing.Point(87, 25);
            this.cboLeave.Name = "cboLeave";
            this.cboLeave.Size = new System.Drawing.Size(157, 20);
            this.cboLeave.TabIndex = 1;
            // 
            // lblmd
            // 
            this.lblmd.AutoSize = true;
            this.lblmd.Location = new System.Drawing.Point(294, 28);
            this.lblmd.Name = "lblmd";
            this.lblmd.Size = new System.Drawing.Size(41, 12);
            this.lblmd.TabIndex = 0;
            this.lblmd.Text = "目的地";
            // 
            // lblcf
            // 
            this.lblcf.AutoSize = true;
            this.lblcf.Location = new System.Drawing.Point(40, 25);
            this.lblcf.Name = "lblcf";
            this.lblcf.Size = new System.Drawing.Size(41, 12);
            this.lblcf.TabIndex = 0;
            this.lblcf.Text = "出发地";
            // 
            // gbyd
            // 
            this.gbyd.Controls.Add(this.dateTimePicker1);
            this.gbyd.Controls.Add(this.domainUpDown1);
            this.gbyd.Controls.Add(this.txtPrice);
            this.gbyd.Controls.Add(this.txtTime);
            this.gbyd.Controls.Add(this.txtLandTime);
            this.gbyd.Controls.Add(this.txtLeave);
            this.gbyd.Controls.Add(this.txtDest);
            this.gbyd.Controls.Add(this.label9);
            this.gbyd.Controls.Add(this.lblLandTime);
            this.gbyd.Controls.Add(this.label8);
            this.gbyd.Controls.Add(this.txtNo);
            this.gbyd.Controls.Add(this.lblPrice);
            this.gbyd.Controls.Add(this.lblDest);
            this.gbyd.Controls.Add(this.lblTime);
            this.gbyd.Controls.Add(this.txtAirways);
            this.gbyd.Controls.Add(this.lblLeave);
            this.gbyd.Controls.Add(this.lblAirways);
            this.gbyd.Controls.Add(this.lblNo);
            this.gbyd.Location = new System.Drawing.Point(12, 239);
            this.gbyd.Name = "gbyd";
            this.gbyd.Size = new System.Drawing.Size(691, 203);
            this.gbyd.TabIndex = 4;
            this.gbyd.TabStop = false;
            this.gbyd.Text = "航班预订";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(426, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(111, 165);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(197, 21);
            this.domainUpDown1.TabIndex = 2;
            this.domainUpDown1.Text = "0";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(111, 131);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(197, 21);
            this.txtPrice.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(111, 98);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(197, 21);
            this.txtTime.TabIndex = 1;
            // 
            // txtLandTime
            // 
            this.txtLandTime.Location = new System.Drawing.Point(426, 98);
            this.txtLandTime.Name = "txtLandTime";
            this.txtLandTime.ReadOnly = true;
            this.txtLandTime.Size = new System.Drawing.Size(197, 21);
            this.txtLandTime.TabIndex = 1;
            // 
            // txtLeave
            // 
            this.txtLeave.Location = new System.Drawing.Point(111, 65);
            this.txtLeave.Name = "txtLeave";
            this.txtLeave.ReadOnly = true;
            this.txtLeave.Size = new System.Drawing.Size(197, 21);
            this.txtLeave.TabIndex = 1;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(426, 65);
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(197, 21);
            this.txtDest.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "出发日期：";
            // 
            // lblLandTime
            // 
            this.lblLandTime.AutoSize = true;
            this.lblLandTime.Location = new System.Drawing.Point(354, 101);
            this.lblLandTime.Name = "lblLandTime";
            this.lblLandTime.Size = new System.Drawing.Size(65, 12);
            this.lblLandTime.TabIndex = 0;
            this.lblLandTime.Text = "到达时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "预订数量：";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(111, 32);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(197, 21);
            this.txtNo.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(45, 134);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 12);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "成人票价：";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(366, 68);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(53, 12);
            this.lblDest.TabIndex = 0;
            this.lblDest.Text = "目的地：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(45, 101);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 12);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "出发时间：";
            // 
            // txtAirways
            // 
            this.txtAirways.Location = new System.Drawing.Point(426, 32);
            this.txtAirways.Name = "txtAirways";
            this.txtAirways.ReadOnly = true;
            this.txtAirways.Size = new System.Drawing.Size(197, 21);
            this.txtAirways.TabIndex = 1;
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Location = new System.Drawing.Point(57, 68);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(53, 12);
            this.lblLeave.TabIndex = 0;
            this.lblLeave.Text = "出发地：";
            // 
            // lblAirways
            // 
            this.lblAirways.AutoSize = true;
            this.lblAirways.Location = new System.Drawing.Point(354, 35);
            this.lblAirways.Name = "lblAirways";
            this.lblAirways.Size = new System.Drawing.Size(65, 12);
            this.lblAirways.TabIndex = 0;
            this.lblAirways.Text = "航空公司：";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(57, 35);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(53, 12);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "航班号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "预订";
            this.button2.UseVisualStyleBackColor = true;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 498);
            this.Controls.Add(this.gbyd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbone);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "航班查询预订";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbone.ResumeLayout(false);
            this.gbone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.gbyd.ResumeLayout(false);
            this.gbyd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbone;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboDest;
        private System.Windows.Forms.ComboBox cboLeave;
        private System.Windows.Forms.Label lblmd;
        private System.Windows.Forms.Label lblcf;
        private System.Windows.Forms.GroupBox gbyd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtLandTime;
        private System.Windows.Forms.TextBox txtLeave;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLandTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtAirways;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Label lblAirways;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airways;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LandTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

