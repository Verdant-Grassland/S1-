namespace SchoolForm
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.pcShow = new System.Windows.Forms.PictureBox();
            this.ilAbout = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pbOK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).BeginInit();
            this.SuspendLayout();
            // 
            // pcShow
            // 
            this.pcShow.Image = global::SchoolForm.Properties.Resources.girl_1;
            this.pcShow.Location = new System.Drawing.Point(26, 34);
            this.pcShow.Name = "pcShow";
            this.pcShow.Size = new System.Drawing.Size(160, 178);
            this.pcShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcShow.TabIndex = 0;
            this.pcShow.TabStop = false;
            // 
            // ilAbout
            // 
            this.ilAbout.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAbout.ImageStream")));
            this.ilAbout.TransparentColor = System.Drawing.Color.Transparent;
            this.ilAbout.Images.SetKeyName(0, "girl_1.gif");
            this.ilAbout.Images.SetKeyName(1, "girl_2.gif");
            this.ilAbout.Images.SetKeyName(2, "girl_3.gif");
            this.ilAbout.Images.SetKeyName(3, "girl_4.gif");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(243, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "版权所有：北大青鸟\r\n\r\n@Copy Right 2022-2024\r\n\r\n技术支持：bdqn@sina.com\r\n";
            // 
            // pbOK
            // 
            this.pbOK.BackColor = System.Drawing.Color.Transparent;
            this.pbOK.Location = new System.Drawing.Point(371, 242);
            this.pbOK.Name = "pbOK";
            this.pbOK.Size = new System.Drawing.Size(117, 41);
            this.pbOK.TabIndex = 2;
            this.pbOK.TabStop = false;
            this.pbOK.Click += new System.EventHandler(this.pbOK_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolForm.Properties.Resources.aboug_bj;
            this.ClientSize = new System.Drawing.Size(555, 329);
            this.Controls.Add(this.pbOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcShow);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于我们";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcShow;
        private System.Windows.Forms.ImageList ilAbout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOK;
    }
}