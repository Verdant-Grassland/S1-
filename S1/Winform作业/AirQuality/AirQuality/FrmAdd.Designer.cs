namespace AirQuality
{
    partial class FrmAdd
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
            this.lblStationID = new System.Windows.Forms.Label();
            this.cboStationID = new System.Windows.Forms.ComboBox();
            this.lblInputName = new System.Windows.Forms.Label();
            this.txtInputName = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblPM = new System.Windows.Forms.Label();
            this.txtPM = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStationID
            // 
            this.lblStationID.AutoSize = true;
            this.lblStationID.Location = new System.Drawing.Point(90, 47);
            this.lblStationID.Name = "lblStationID";
            this.lblStationID.Size = new System.Drawing.Size(67, 15);
            this.lblStationID.TabIndex = 0;
            this.lblStationID.Text = "监测站：";
            // 
            // cboStationID
            // 
            this.cboStationID.FormattingEnabled = true;
            this.cboStationID.Location = new System.Drawing.Point(162, 44);
            this.cboStationID.Name = "cboStationID";
            this.cboStationID.Size = new System.Drawing.Size(158, 23);
            this.cboStationID.TabIndex = 1;
            // 
            // lblInputName
            // 
            this.lblInputName.AutoSize = true;
            this.lblInputName.Location = new System.Drawing.Point(350, 47);
            this.lblInputName.Name = "lblInputName";
            this.lblInputName.Size = new System.Drawing.Size(82, 15);
            this.lblInputName.TabIndex = 0;
            this.lblInputName.Text = "录入人员：";
            // 
            // txtInputName
            // 
            this.txtInputName.Location = new System.Drawing.Point(438, 44);
            this.txtInputName.Name = "txtInputName";
            this.txtInputName.Size = new System.Drawing.Size(113, 25);
            this.txtInputName.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(44, 96);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(112, 15);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "开始监测时间：";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(162, 93);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(200, 25);
            this.txtStartDate.TabIndex = 2;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(44, 159);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(112, 15);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "监测停止时间：";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(162, 156);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(200, 25);
            this.txtEndDate.TabIndex = 2;
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.lblPM.Location = new System.Drawing.Point(64, 222);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(92, 15);
            this.lblPM.TabIndex = 0;
            this.lblPM.Text = "PM2.5指数：";
            // 
            // txtPM
            // 
            this.txtPM.Location = new System.Drawing.Point(162, 219);
            this.txtPM.Name = "txtPM";
            this.txtPM.Size = new System.Drawing.Size(113, 25);
            this.txtPM.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(74, 285);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(82, 15);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "注意事项：";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(162, 282);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(333, 25);
            this.txtNotes.TabIndex = 2;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(300, 222);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(112, 15);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "空气质量等级：";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(418, 219);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(77, 25);
            this.txtLevel.TabIndex = 2;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(501, 222);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(22, 15);
            this.lblStep.TabIndex = 3;
            this.lblStep.Text = "级";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(85, 353);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(109, 35);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(264, 353);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(443, 353);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 433);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtPM);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblPM);
            this.Controls.Add(this.txtInputName);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.cboStationID);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblInputName);
            this.Controls.Add(this.lblStationID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "录入监测数据";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStationID;
        private System.Windows.Forms.ComboBox cboStationID;
        private System.Windows.Forms.Label lblInputName;
        private System.Windows.Forms.TextBox txtInputName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.TextBox txtPM;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}