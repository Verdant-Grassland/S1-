namespace Organization
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
            this.lbIName = new System.Windows.Forms.Label();
            this.lbIPerson = new System.Windows.Forms.Label();
            this.lbIPhone = new System.Windows.Forms.Label();
            this.lbIContent = new System.Windows.Forms.Label();
            this.lbIDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIName
            // 
            this.lbIName.AutoSize = true;
            this.lbIName.Location = new System.Drawing.Point(31, 40);
            this.lbIName.Name = "lbIName";
            this.lbIName.Size = new System.Drawing.Size(37, 15);
            this.lbIName.TabIndex = 0;
            this.lbIName.Text = "名称";
            // 
            // lbIPerson
            // 
            this.lbIPerson.AutoSize = true;
            this.lbIPerson.Location = new System.Drawing.Point(31, 96);
            this.lbIPerson.Name = "lbIPerson";
            this.lbIPerson.Size = new System.Drawing.Size(52, 15);
            this.lbIPerson.TabIndex = 0;
            this.lbIPerson.Text = "负责人";
            // 
            // lbIPhone
            // 
            this.lbIPhone.AutoSize = true;
            this.lbIPhone.Location = new System.Drawing.Point(31, 152);
            this.lbIPhone.Name = "lbIPhone";
            this.lbIPhone.Size = new System.Drawing.Size(67, 15);
            this.lbIPhone.TabIndex = 0;
            this.lbIPhone.Text = "联系电话";
            // 
            // lbIContent
            // 
            this.lbIContent.AutoSize = true;
            this.lbIContent.Location = new System.Drawing.Point(31, 264);
            this.lbIContent.Name = "lbIContent";
            this.lbIContent.Size = new System.Drawing.Size(37, 15);
            this.lbIContent.TabIndex = 0;
            this.lbIContent.Text = "简介";
            // 
            // lbIDate
            // 
            this.lbIDate.AutoSize = true;
            this.lbIDate.Location = new System.Drawing.Point(31, 208);
            this.lbIDate.Name = "lbIDate";
            this.lbIDate.Size = new System.Drawing.Size(67, 15);
            this.lbIDate.TabIndex = 0;
            this.lbIDate.Text = "注册日期";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(125, 93);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(205, 25);
            this.txtPerson.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(125, 149);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(205, 25);
            this.txtPhone.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(125, 205);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(205, 25);
            this.txtDate.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(125, 261);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(446, 251);
            this.txtContent.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(212, 533);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 39);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "注册";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmint_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(368, 533);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(104, 39);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 598);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbIDate);
            this.Controls.Add(this.lbIContent);
            this.Controls.Add(this.lbIPhone);
            this.Controls.Add(this.lbIPerson);
            this.Controls.Add(this.lbIName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注册社团";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIName;
        private System.Windows.Forms.Label lbIPerson;
        private System.Windows.Forms.Label lbIPhone;
        private System.Windows.Forms.Label lbIContent;
        private System.Windows.Forms.Label lbIDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancle;
    }
}