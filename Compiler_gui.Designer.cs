namespace WindowsForms_compiler
{
    partial class Compiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compiler));
            this.comboBox_com_vc = new System.Windows.Forms.ComboBox();
            this.comboBox_build_platform = new System.Windows.Forms.ComboBox();
            this.comboBox_cpu_core = new System.Windows.Forms.ComboBox();
            this.textBox_Selected_compiler_path = new System.Windows.Forms.TextBox();
            this.textBox_Selected_install_path = new System.Windows.Forms.TextBox();
            this.label_comp = new System.Windows.Forms.Label();
            this.label_plat = new System.Windows.Forms.Label();
            this.label_cpu = new System.Windows.Forms.Label();
            this.label_compPath = new System.Windows.Forms.Label();
            this.label_installPath = new System.Windows.Forms.Label();
            this.button_compile = new System.Windows.Forms.Button();
            this.button_change_one = new System.Windows.Forms.Button();
            this.button_change_two = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox_conf = new System.Windows.Forms.GroupBox();
            this.button_help = new System.Windows.Forms.Button();
            this.bw_update = new System.ComponentModel.BackgroundWorker();
            this.groupBox_conf.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_com_vc
            // 
            this.comboBox_com_vc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_com_vc.FormattingEnabled = true;
            this.comboBox_com_vc.Items.AddRange(new object[] {
            "VC10",
            "VC11"});
            this.comboBox_com_vc.Location = new System.Drawing.Point(119, 23);
            this.comboBox_com_vc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_com_vc.Name = "comboBox_com_vc";
            this.comboBox_com_vc.Size = new System.Drawing.Size(91, 24);
            this.comboBox_com_vc.TabIndex = 0;
            this.comboBox_com_vc.SelectedIndexChanged += new System.EventHandler(this.comboBox_com_vc_SelectedIndexChanged);
            // 
            // comboBox_build_platform
            // 
            this.comboBox_build_platform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_build_platform.FormattingEnabled = true;
            this.comboBox_build_platform.Items.AddRange(new object[] {
            "win32",
            "win64"});
            this.comboBox_build_platform.Location = new System.Drawing.Point(119, 57);
            this.comboBox_build_platform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_build_platform.Name = "comboBox_build_platform";
            this.comboBox_build_platform.Size = new System.Drawing.Size(91, 24);
            this.comboBox_build_platform.TabIndex = 1;
            this.comboBox_build_platform.SelectedIndexChanged += new System.EventHandler(this.comboBox_build_platform_SelectedIndexChanged);
            // 
            // comboBox_cpu_core
            // 
            this.comboBox_cpu_core.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cpu_core.FormattingEnabled = true;
            this.comboBox_cpu_core.Location = new System.Drawing.Point(119, 90);
            this.comboBox_cpu_core.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_cpu_core.Name = "comboBox_cpu_core";
            this.comboBox_cpu_core.Size = new System.Drawing.Size(91, 24);
            this.comboBox_cpu_core.TabIndex = 2;
            this.comboBox_cpu_core.SelectedIndexChanged += new System.EventHandler(this.comboBox_cpu_core_SelectedIndexChanged);
            // 
            // textBox_Selected_compiler_path
            // 
            this.textBox_Selected_compiler_path.Location = new System.Drawing.Point(335, 27);
            this.textBox_Selected_compiler_path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Selected_compiler_path.Name = "textBox_Selected_compiler_path";
            this.textBox_Selected_compiler_path.Size = new System.Drawing.Size(337, 22);
            this.textBox_Selected_compiler_path.TabIndex = 3;
            // 
            // textBox_Selected_install_path
            // 
            this.textBox_Selected_install_path.Location = new System.Drawing.Point(335, 62);
            this.textBox_Selected_install_path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Selected_install_path.Name = "textBox_Selected_install_path";
            this.textBox_Selected_install_path.Size = new System.Drawing.Size(337, 22);
            this.textBox_Selected_install_path.TabIndex = 4;
            this.textBox_Selected_install_path.TextChanged += new System.EventHandler(this.textBox_Selected_install_path_TextChanged);
            // 
            // label_comp
            // 
            this.label_comp.AutoSize = true;
            this.label_comp.Location = new System.Drawing.Point(44, 27);
            this.label_comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_comp.Name = "label_comp";
            this.label_comp.Size = new System.Drawing.Size(67, 17);
            this.label_comp.TabIndex = 5;
            this.label_comp.Text = "Compiler:";
            // 
            // label_plat
            // 
            this.label_plat.AutoSize = true;
            this.label_plat.Location = new System.Drawing.Point(13, 62);
            this.label_plat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_plat.Name = "label_plat";
            this.label_plat.Size = new System.Drawing.Size(98, 17);
            this.label_plat.TabIndex = 6;
            this.label_plat.Text = "Build platform:";
            // 
            // label_cpu
            // 
            this.label_cpu.AutoSize = true;
            this.label_cpu.Location = new System.Drawing.Point(36, 94);
            this.label_cpu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cpu.Name = "label_cpu";
            this.label_cpu.Size = new System.Drawing.Size(72, 17);
            this.label_cpu.TabIndex = 7;
            this.label_cpu.Text = "CPU core:";
            // 
            // label_compPath
            // 
            this.label_compPath.AutoSize = true;
            this.label_compPath.Location = new System.Drawing.Point(228, 31);
            this.label_compPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_compPath.Name = "label_compPath";
            this.label_compPath.Size = new System.Drawing.Size(99, 17);
            this.label_compPath.TabIndex = 8;
            this.label_compPath.Text = "Compiler path:";
            // 
            // label_installPath
            // 
            this.label_installPath.AutoSize = true;
            this.label_installPath.Location = new System.Drawing.Point(245, 65);
            this.label_installPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_installPath.Name = "label_installPath";
            this.label_installPath.Size = new System.Drawing.Size(80, 17);
            this.label_installPath.TabIndex = 9;
            this.label_installPath.Text = "Install path:";
            // 
            // button_compile
            // 
            this.button_compile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_compile.Location = new System.Drawing.Point(335, 105);
            this.button_compile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_compile.Name = "button_compile";
            this.button_compile.Size = new System.Drawing.Size(111, 28);
            this.button_compile.TabIndex = 7;
            this.button_compile.Text = "Start Compile";
            this.button_compile.UseVisualStyleBackColor = true;
            this.button_compile.Click += new System.EventHandler(this.button_compile_Click);
            // 
            // button_change_one
            // 
            this.button_change_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_change_one.Location = new System.Drawing.Point(681, 23);
            this.button_change_one.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_change_one.Name = "button_change_one";
            this.button_change_one.Size = new System.Drawing.Size(33, 28);
            this.button_change_one.TabIndex = 5;
            this.button_change_one.Text = "...";
            this.button_change_one.UseVisualStyleBackColor = true;
            this.button_change_one.Click += new System.EventHandler(this.button_change_one_Click);
            // 
            // button_change_two
            // 
            this.button_change_two.Location = new System.Drawing.Point(681, 59);
            this.button_change_two.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_change_two.Name = "button_change_two";
            this.button_change_two.Size = new System.Drawing.Size(33, 28);
            this.button_change_two.TabIndex = 6;
            this.button_change_two.Text = "...";
            this.button_change_two.UseVisualStyleBackColor = true;
            this.button_change_two.Click += new System.EventHandler(this.button_change_two_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // groupBox_conf
            // 
            this.groupBox_conf.Controls.Add(this.button_help);
            this.groupBox_conf.Controls.Add(this.textBox_Selected_compiler_path);
            this.groupBox_conf.Controls.Add(this.button_change_two);
            this.groupBox_conf.Controls.Add(this.comboBox_com_vc);
            this.groupBox_conf.Controls.Add(this.button_change_one);
            this.groupBox_conf.Controls.Add(this.comboBox_build_platform);
            this.groupBox_conf.Controls.Add(this.button_compile);
            this.groupBox_conf.Controls.Add(this.comboBox_cpu_core);
            this.groupBox_conf.Controls.Add(this.label_installPath);
            this.groupBox_conf.Controls.Add(this.textBox_Selected_install_path);
            this.groupBox_conf.Controls.Add(this.label_compPath);
            this.groupBox_conf.Controls.Add(this.label_comp);
            this.groupBox_conf.Controls.Add(this.label_cpu);
            this.groupBox_conf.Controls.Add(this.label_plat);
            this.groupBox_conf.Location = new System.Drawing.Point(16, 7);
            this.groupBox_conf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_conf.Name = "groupBox_conf";
            this.groupBox_conf.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_conf.Size = new System.Drawing.Size(732, 142);
            this.groupBox_conf.TabIndex = 13;
            this.groupBox_conf.TabStop = false;
            this.groupBox_conf.Text = "Configuration";
            // 
            // button_help
            // 
            this.button_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_help.Location = new System.Drawing.Point(637, 106);
            this.button_help.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(77, 26);
            this.button_help.TabIndex = 10;
            this.button_help.TabStop = false;
            this.button_help.Text = "About...";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // bw_update
            // 
            this.bw_update.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_update_DoWork);
            this.bw_update.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_update_RunWorkerCompleted);
            // 
            // Compiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 159);
            this.Controls.Add(this.groupBox_conf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Compiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R2 Compiler Configuration GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Compiler_FormClosing);
            this.Load += new System.EventHandler(this.Compiler_Load);
            this.groupBox_conf.ResumeLayout(false);
            this.groupBox_conf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_com_vc;
        private System.Windows.Forms.ComboBox comboBox_build_platform;
        private System.Windows.Forms.ComboBox comboBox_cpu_core;
        private System.Windows.Forms.TextBox textBox_Selected_compiler_path;
        private System.Windows.Forms.TextBox textBox_Selected_install_path;
        private System.Windows.Forms.Label label_comp;
        private System.Windows.Forms.Label label_plat;
        private System.Windows.Forms.Label label_cpu;
        private System.Windows.Forms.Label label_compPath;
        private System.Windows.Forms.Label label_installPath;
        private System.Windows.Forms.Button button_compile;
        private System.Windows.Forms.Button button_change_one;
        private System.Windows.Forms.Button button_change_two;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.GroupBox groupBox_conf;
        private System.Windows.Forms.Button button_help;
        private System.ComponentModel.BackgroundWorker bw_update;
    }
}

