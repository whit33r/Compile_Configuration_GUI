namespace WindowsForms_compiler
{
    partial class Update_Completed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Completed));
            this.pb_pic = new System.Windows.Forms.PictureBox();
            this.lbl_completed = new System.Windows.Forms.Label();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.lbl_currVer = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pic)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_pic
            // 
            this.pb_pic.Image = global::WindowsForms_compiler.Properties.Resources.Accept_icon1;
            this.pb_pic.Location = new System.Drawing.Point(22, 37);
            this.pb_pic.Name = "pb_pic";
            this.pb_pic.Size = new System.Drawing.Size(80, 80);
            this.pb_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pic.TabIndex = 0;
            this.pb_pic.TabStop = false;
            // 
            // lbl_completed
            // 
            this.lbl_completed.AutoSize = true;
            this.lbl_completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_completed.Location = new System.Drawing.Point(139, 37);
            this.lbl_completed.Name = "lbl_completed";
            this.lbl_completed.Size = new System.Drawing.Size(167, 24);
            this.lbl_completed.TabIndex = 1;
            this.lbl_completed.Text = "Update Completed";
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ver.Location = new System.Drawing.Point(160, 83);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(80, 24);
            this.lbl_ver.TabIndex = 2;
            this.lbl_ver.Text = "Version:";
            // 
            // lbl_currVer
            // 
            this.lbl_currVer.AutoSize = true;
            this.lbl_currVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_currVer.Location = new System.Drawing.Point(242, 83);
            this.lbl_currVer.Name = "lbl_currVer";
            this.lbl_currVer.Size = new System.Drawing.Size(36, 24);
            this.lbl_currVer.TabIndex = 3;
            this.lbl_currVer.Text = "ver";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel.Controls.Add(this.btn_ok);
            this.panel.Location = new System.Drawing.Point(1, 143);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(346, 64);
            this.panel.TabIndex = 4;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(122, 17);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 28);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Update_Completed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 205);
            this.Controls.Add(this.lbl_currVer);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbl_completed);
            this.Controls.Add(this.pb_pic);
            this.Controls.Add(this.lbl_ver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_Completed";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pb_pic)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_pic;
        private System.Windows.Forms.Label lbl_completed;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.Label lbl_currVer;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_ok;
    }
}