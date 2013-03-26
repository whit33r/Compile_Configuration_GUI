namespace WindowsForms_compiler
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.pb_down = new System.Windows.Forms.ProgressBar();
            this.lbl_Perecent = new System.Windows.Forms.Label();
            this.lbl_downByte = new System.Windows.Forms.Label();
            this.bw_updater = new System.ComponentModel.BackgroundWorker();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.gb_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_down
            // 
            this.pb_down.Location = new System.Drawing.Point(25, 43);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(397, 29);
            this.pb_down.TabIndex = 0;
            // 
            // lbl_Perecent
            // 
            this.lbl_Perecent.AutoSize = true;
            this.lbl_Perecent.Location = new System.Drawing.Point(394, 23);
            this.lbl_Perecent.Name = "lbl_Perecent";
            this.lbl_Perecent.Size = new System.Drawing.Size(28, 17);
            this.lbl_Perecent.TabIndex = 1;
            this.lbl_Perecent.Text = "0%";
            // 
            // lbl_downByte
            // 
            this.lbl_downByte.AutoSize = true;
            this.lbl_downByte.Location = new System.Drawing.Point(367, 75);
            this.lbl_downByte.Name = "lbl_downByte";
            this.lbl_downByte.Size = new System.Drawing.Size(57, 17);
            this.lbl_downByte.TabIndex = 2;
            this.lbl_downByte.Text = "0 / 0 Kb";
            // 
            // bw_updater
            // 
            this.bw_updater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_updater_DoWork);
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.lbl_speed);
            this.gb_status.Controls.Add(this.lbl_status);
            this.gb_status.Controls.Add(this.pb_down);
            this.gb_status.Controls.Add(this.lbl_downByte);
            this.gb_status.Controls.Add(this.lbl_Perecent);
            this.gb_status.Location = new System.Drawing.Point(12, 12);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(445, 110);
            this.gb_status.TabIndex = 3;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Update Status";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(22, 75);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(52, 17);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "Status:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(360, 128);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(96, 29);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(191, 75);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(80, 17);
            this.lbl_speed.TabIndex = 4;
            this.lbl_speed.Text = "Speed: N/A";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 168);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.gb_status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater";
            this.Shown += new System.EventHandler(this.Update_Shown);
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_down;
        private System.Windows.Forms.Label lbl_Perecent;
        private System.Windows.Forms.Label lbl_downByte;
        private System.ComponentModel.BackgroundWorker bw_updater;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_speed;
    }
}