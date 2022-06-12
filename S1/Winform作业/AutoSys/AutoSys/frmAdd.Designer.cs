namespace AutoSys
{
    partial class frmAdd
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
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.cboBrandName = new System.Windows.Forms.ComboBox();
            this.lblBuyDate = new System.Windows.Forms.Label();
            this.dtpBuyDate = new System.Windows.Forms.DateTimePicker();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblInitKiloNum = new System.Windows.Forms.Label();
            this.txtInitKiloNum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAutoNum
            // 
            this.lblAutoNum.AutoSize = true;
            this.lblAutoNum.Location = new System.Drawing.Point(123, 56);
            this.lblAutoNum.Name = "lblAutoNum";
            this.lblAutoNum.Size = new System.Drawing.Size(82, 15);
            this.lblAutoNum.TabIndex = 0;
            this.lblAutoNum.Text = "车牌号码：";
            // 
            // txtAutoNum
            // 
            this.txtAutoNum.Location = new System.Drawing.Point(211, 53);
            this.txtAutoNum.Name = "txtAutoNum";
            this.txtAutoNum.Size = new System.Drawing.Size(169, 25);
            this.txtAutoNum.TabIndex = 1;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(123, 111);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(82, 15);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "车牌说明：";
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(211, 108);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new System.Drawing.Size(347, 67);
            this.txtInstruction.TabIndex = 1;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(123, 208);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(82, 15);
            this.lblBrandName.TabIndex = 0;
            this.lblBrandName.Text = "品牌名称：";
            // 
            // cboBrandName
            // 
            this.cboBrandName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrandName.FormattingEnabled = true;
            this.cboBrandName.Location = new System.Drawing.Point(211, 205);
            this.cboBrandName.Name = "cboBrandName";
            this.cboBrandName.Size = new System.Drawing.Size(169, 23);
            this.cboBrandName.TabIndex = 2;
            // 
            // lblBuyDate
            // 
            this.lblBuyDate.AutoSize = true;
            this.lblBuyDate.Location = new System.Drawing.Point(123, 261);
            this.lblBuyDate.Name = "lblBuyDate";
            this.lblBuyDate.Size = new System.Drawing.Size(82, 15);
            this.lblBuyDate.TabIndex = 0;
            this.lblBuyDate.Text = "购入日期：";
            // 
            // dtpBuyDate
            // 
            this.dtpBuyDate.Location = new System.Drawing.Point(211, 254);
            this.dtpBuyDate.Name = "dtpBuyDate";
            this.dtpBuyDate.Size = new System.Drawing.Size(169, 25);
            this.dtpBuyDate.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(123, 312);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(82, 15);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "购入价格：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(211, 309);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(169, 25);
            this.txtPrice.TabIndex = 1;
            // 
            // lblInitKiloNum
            // 
            this.lblInitKiloNum.AutoSize = true;
            this.lblInitKiloNum.Location = new System.Drawing.Point(108, 367);
            this.lblInitKiloNum.Name = "lblInitKiloNum";
            this.lblInitKiloNum.Size = new System.Drawing.Size(97, 15);
            this.lblInitKiloNum.TabIndex = 0;
            this.lblInitKiloNum.Text = "初始公里数：";
            // 
            // txtInitKiloNum
            // 
            this.txtInitKiloNum.Location = new System.Drawing.Point(211, 364);
            this.txtInitKiloNum.Name = "txtInitKiloNum";
            this.txtInitKiloNum.Size = new System.Drawing.Size(169, 25);
            this.txtInitKiloNum.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(336, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(449, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 496);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpBuyDate);
            this.Controls.Add(this.cboBrandName);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblBrandName);
            this.Controls.Add(this.lblBuyDate);
            this.Controls.Add(this.txtInitKiloNum);
            this.Controls.Add(this.lblInitKiloNum);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtAutoNum);
            this.Controls.Add(this.lblAutoNum);
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车辆登记";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutoNum;
        private System.Windows.Forms.TextBox txtAutoNum;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtInstruction;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.ComboBox cboBrandName;
        private System.Windows.Forms.Label lblBuyDate;
        private System.Windows.Forms.DateTimePicker dtpBuyDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblInitKiloNum;
        private System.Windows.Forms.TextBox txtInitKiloNum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}