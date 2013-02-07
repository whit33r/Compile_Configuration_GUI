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
            this.pictureBox_Info = new System.Windows.Forms.PictureBox();
            this.pictureBox_donate = new System.Windows.Forms.PictureBox();
            this.label_one = new System.Windows.Forms.Label();
            this.label_two = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_donate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Info
            // 
            this.pictureBox_Info.Image = global::WindowsForms_compiler.Properties.Resources.pic2;
            this.pictureBox_Info.Location = new System.Drawing.Point(27, 27);
            this.pictureBox_Info.Name = "pictureBox_Info";
            this.pictureBox_Info.Size = new System.Drawing.Size(37, 40);
            this.pictureBox_Info.TabIndex = 1;
            this.pictureBox_Info.TabStop = false;
            // 
            // pictureBox_donate
            // 
            this.pictureBox_donate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_donate.Image = global::WindowsForms_compiler.Properties.Resources.pic1;
            this.pictureBox_donate.Location = new System.Drawing.Point(151, 93);
            this.pictureBox_donate.Name = "pictureBox_donate";
            this.pictureBox_donate.Size = new System.Drawing.Size(95, 28);
            this.pictureBox_donate.TabIndex = 0;
            this.pictureBox_donate.TabStop = false;
            this.pictureBox_donate.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_one
            // 
            this.label_one.AutoSize = true;
            this.label_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_one.Location = new System.Drawing.Point(95, 8);
            this.label_one.Name = "label_one";
            this.label_one.Size = new System.Drawing.Size(41, 15);
            this.label_one.TabIndex = 2;
            this.label_one.Text = "label1";
            // 
            // label_two
            // 
            this.label_two.AutoSize = true;
            this.label_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_two.Location = new System.Drawing.Point(94, 52);
            this.label_two.Name = "label_two";
            this.label_two.Size = new System.Drawing.Size(41, 15);
            this.label_two.TabIndex = 3;
            this.label_two.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 52);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Version: 1.0.2";
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 175);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_two);
            this.Controls.Add(this.label_one);
            this.Controls.Add(this.pictureBox_Info);
            this.Controls.Add(this.pictureBox_donate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.AboutBox1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_donate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_donate;
        private System.Windows.Forms.PictureBox pictureBox_Info;
        private System.Windows.Forms.Label label_one;
        private System.Windows.Forms.Label label_two;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;

    }
}
