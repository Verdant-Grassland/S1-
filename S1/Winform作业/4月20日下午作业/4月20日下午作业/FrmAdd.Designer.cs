namespace _4月20日下午作业
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
            this.lbIAdd = new System.Windows.Forms.Label();
            this.lbIName = new System.Windows.Forms.Label();
            this.lbIAlias = new System.Windows.Forms.Label();
            this.lbIGenus = new System.Windows.Forms.Label();
            this.lbIPrice = new System.Windows.Forms.Label();
            this.lbIOrigin = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtGenus = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIAdd
            // 
            this.lbIAdd.AutoSize = true;
            this.lbIAdd.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbIAdd.Location = new System.Drawing.Point(172, 45);
            this.lbIAdd.Name = "lbIAdd";
            this.lbIAdd.Size = new System.Drawing.Size(193, 30);
            this.lbIAdd.TabIndex = 0;
            this.lbIAdd.Text = "增加花卉信息";
            // 
            // lbIName
            // 
            this.lbIName.AutoSize = true;
            this.lbIName.Location = new System.Drawing.Point(64, 129);
            this.lbIName.Name = "lbIName";
            this.lbIName.Size = new System.Drawing.Size(52, 15);
            this.lbIName.TabIndex = 1;
            this.lbIName.Text = "花名：";
            // 
            // lbIAlias
            // 
            this.lbIAlias.AutoSize = true;
            this.lbIAlias.Location = new System.Drawing.Point(64, 201);
            this.lbIAlias.Name = "lbIAlias";
            this.lbIAlias.Size = new System.Drawing.Size(52, 15);
            this.lbIAlias.TabIndex = 1;
            this.lbIAlias.Text = "别名：";
            // 
            // lbIGenus
            // 
            this.lbIGenus.AutoSize = true;
            this.lbIGenus.Location = new System.Drawing.Point(64, 273);
            this.lbIGenus.Name = "lbIGenus";
            this.lbIGenus.Size = new System.Drawing.Size(52, 15);
            this.lbIGenus.TabIndex = 1;
            this.lbIGenus.Text = "科属：";
            // 
            // lbIPrice
            // 
            this.lbIPrice.AutoSize = true;
            this.lbIPrice.Location = new System.Drawing.Point(64, 345);
            this.lbIPrice.Name = "lbIPrice";
            this.lbIPrice.Size = new System.Drawing.Size(52, 15);
            this.lbIPrice.TabIndex = 1;
            this.lbIPrice.Text = "价格：";
            // 
            // lbIOrigin
            // 
            this.lbIOrigin.AutoSize = true;
            this.lbIOrigin.Location = new System.Drawing.Point(64, 417);
            this.lbIOrigin.Name = "lbIOrigin";
            this.lbIOrigin.Size = new System.Drawing.Size(52, 15);
            this.lbIOrigin.TabIndex = 1;
            this.lbIOrigin.Text = "产地：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 116);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 32);
            this.txtName.TabIndex = 2;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(143, 190);
            this.txtAlias.Multiline = true;
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(279, 32);
            this.txtAlias.TabIndex = 2;
            // 
            // txtGenus
            // 
            this.txtGenus.Location = new System.Drawing.Point(143, 262);
            this.txtGenus.Multiline = true;
            this.txtGenus.Name = "txtGenus";
            this.txtGenus.Size = new System.Drawing.Size(279, 32);
            this.txtGenus.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(143, 334);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(279, 32);
            this.txtPrice.TabIndex = 2;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(143, 406);
            this.txtOrigin.Multiline = true;
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(279, 32);
            this.txtOrigin.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(53, 491);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 35);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "增加";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(201, 491);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(113, 35);
            this.btnEmpty.TabIndex = 3;
            this.btnEmpty.Text = "清空";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(363, 491);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 565);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtGenus);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbIOrigin);
            this.Controls.Add(this.lbIPrice);
            this.Controls.Add(this.lbIGenus);
            this.Controls.Add(this.lbIAlias);
            this.Controls.Add(this.lbIName);
            this.Controls.Add(this.lbIAdd);
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加花卉信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIAdd;
        private System.Windows.Forms.Label lbIName;
        private System.Windows.Forms.Label lbIAlias;
        private System.Windows.Forms.Label lbIGenus;
        private System.Windows.Forms.Label lbIPrice;
        private System.Windows.Forms.Label lbIOrigin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.TextBox txtGenus;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnClose;
    }
}