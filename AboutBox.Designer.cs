namespace WindowsForms_compiler
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.lbl_oneDesc = new System.Windows.Forms.Label();
            this.lbl_twoDesc = new System.Windows.Forms.Label();
            this.lbl_local = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.lbl_remote = new System.Windows.Forms.Label();
            this.lbl_remoteV = new System.Windows.Forms.Label();
            this.lbl_LocalV = new System.Windows.Forms.Label();
            this.pb_Donate = new System.Windows.Forms.PictureBox();
            this.pb_screen = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Donate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_screen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_oneDesc
            // 
            this.lbl_oneDesc.AutoSize = true;
            this.lbl_oneDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_oneDesc.Location = new System.Drawing.Point(127, 10);
            this.lbl_oneDesc.Name = "lbl_oneDesc";
            this.lbl_oneDesc.Size = new System.Drawing.Size(48, 18);
            this.lbl_oneDesc.TabIndex = 2;
            this.lbl_oneDesc.Text = "desc1";
            // 
            // lbl_twoDesc
            // 
            this.lbl_twoDesc.AutoSize = true;
            this.lbl_twoDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_twoDesc.Location = new System.Drawing.Point(127, 53);
            this.lbl_twoDesc.Name = "lbl_twoDesc";
            this.lbl_twoDesc.Size = new System.Drawing.Size(48, 18);
            this.lbl_twoDesc.TabIndex = 3;
            this.lbl_twoDesc.Text = "desc2";
            // 
            // lbl_local
            // 
            this.lbl_local.AutoSize = true;
            this.lbl_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_local.Location = new System.Drawing.Point(13, 105);
            this.lbl_local.Name = "lbl_local";
            this.lbl_local.Size = new System.Drawing.Size(106, 18);
            this.lbl_local.TabIndex = 4;
            this.lbl_local.Text = "Local Version: ";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(157, 15);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 28);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel.Controls.Add(this.btn_ok);
            this.panel.Location = new System.Drawing.Point(0, 158);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(432, 64);
            this.panel.TabIndex = 6;
            // 
            // lbl_remote
            // 
            this.lbl_remote.AutoSize = true;
            this.lbl_remote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_remote.Location = new System.Drawing.Point(13, 123);
            this.lbl_remote.Name = "lbl_remote";
            this.lbl_remote.Size = new System.Drawing.Size(119, 18);
            this.lbl_remote.TabIndex = 7;
            this.lbl_remote.Text = "Remote Version:";
            // 
            // lbl_remoteV
            // 
            this.lbl_remoteV.AutoSize = true;
            this.lbl_remoteV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_remoteV.Location = new System.Drawing.Point(133, 123);
            this.lbl_remoteV.Name = "lbl_remoteV";
            this.lbl_remoteV.Size = new System.Drawing.Size(30, 18);
            this.lbl_remoteV.TabIndex = 8;
            this.lbl_remoteV.Text = "Ver";
            // 
            // lbl_LocalV
            // 
            this.lbl_LocalV.AutoSize = true;
            this.lbl_LocalV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_LocalV.Location = new System.Drawing.Point(133, 105);
            this.lbl_LocalV.Name = "lbl_LocalV";
            this.lbl_LocalV.Size = new System.Drawing.Size(40, 18);
            this.lbl_LocalV.TabIndex = 9;
            this.lbl_LocalV.Text = "1.2.3";
            // 
            // pb_Donate
            // 
            this.pb_Donate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Donate.Image = global::WindowsForms_compiler.Properties.Resources.paypal_donate_button;
            this.pb_Donate.Location = new System.Drawing.Point(234, 103);
            this.pb_Donate.Name = "pb_Donate";
            this.pb_Donate.Size = new System.Drawing.Size(122, 48);
            this.pb_Donate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Donate.TabIndex = 1;
            this.pb_Donate.TabStop = false;
            this.pb_Donate.Click += new System.EventHandler(this.pictureBox_donate_Click);
            // 
            // pb_screen
            // 
            this.pb_screen.Image = global::WindowsForms_compiler.Properties.Resources.Counterclockwise_arrow_icon;
            this.pb_screen.Location = new System.Drawing.Point(27, 14);
            this.pb_screen.Name = "pb_screen";
            this.pb_screen.Size = new System.Drawing.Size(77, 72);
            this.pb_screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_screen.TabIndex = 0;
            this.pb_screen.TabStop = false;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 215);
            this.Controls.Add(this.lbl_LocalV);
            this.Controls.Add(this.lbl_remoteV);
            this.Controls.Add(this.lbl_remote);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbl_local);
            this.Controls.Add(this.lbl_twoDesc);
            this.Controls.Add(this.lbl_oneDesc);
            this.Controls.Add(this.pb_Donate);
            this.Controls.Add(this.pb_screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutBox1_Load_1);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Donate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_screen;
        private System.Windows.Forms.PictureBox pb_Donate;
        private System.Windows.Forms.Label lbl_oneDesc;
        private System.Windows.Forms.Label lbl_twoDesc;
        private System.Windows.Forms.Label lbl_local;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbl_remote;
        private System.Windows.Forms.Label lbl_remoteV;
        private System.Windows.Forms.Label lbl_LocalV;

    }
}
