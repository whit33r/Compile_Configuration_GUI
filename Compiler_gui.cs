using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WindowsForms_compiler;
using WindowsForms_compiler.Properties;

namespace WindowsFormsAppCompile
{
    public partial class Compiler : Form
    {
        bool a;
        bool b;
        bool c;
        string core;
        string build;
        string comp;
        string comp_n;
        int count = Environment.ProcessorCount;
        string war_1 = "Visual Studio 10 is not installed on your computer.";
        string war_2 = "Visual Studio 11 is not installed on your computer.";
        
        public Compiler()
        {
            InitializeComponent();


            string target1 = @"src\";
            string target2 = @"cmake\";
            if (Directory.Exists(target1) || (Directory.Exists(target2)))
            {
                string target3 = @"src\bindings\ScriptDev2\sql_mr\";
                string target4 = @"src\bindings\ScriptDev2\scripts";
                if (Directory.Exists(target3) || (Directory.Exists(target4)))
                {
                }
                else
                {
                    MessageBox.Show("\\src\\bindings\\ScriptDev2 Folder is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Can't find MaNGOS files.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (IntPtr.Size == 8)
            {
                c = false;
            }
            else
            {
                c = true;
            }


            for (int i = 1; i <= count; i++)
            {
                comboBox_cpu_core.Items.Add(i);
            }   comboBox_cpu_core.Text = Settings.Default["cpu"].ToString();
            
        }

        private void msgBox(string msg, string cBox)
        {
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            comboBox_com_vc.Items.Clear();
            comboBox_com_vc.Items.Add(cBox);
            comboBox_com_vc.Text = cBox;
        }

        public void PlatformChange()
        {
            if (build == "win32" && comp == "VC10")
            {
                comp_n = "Visual Studio 10";
            }

            else if (build == "x64" && comp == "VC10")
            {
                comp_n = "Visual Studio 10 Win64";
            }

            else if (build == "win32" && comp == "VC11")
            {
                comp_n = "Visual Studio 11";
            }

            else if (build == "x64" && comp == "VC11")
            {
                comp_n = "Visual Studio 11 Win64";
            }
        }

        public void Dialog(Boolean NewFolder)
        {
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowser.ShowNewFolderButton = NewFolder;
            DialogResult result = this.folderBrowser.ShowDialog();

            if (result == DialogResult.OK && NewFolder == true)
            {
                textBox_Selected_install_path.Text = this.folderBrowser.SelectedPath;
            }
            else { textBox_Selected_compiler_path.Text = this.folderBrowser.SelectedPath; }
        }

        private void ExecComm(string Command, Boolean closeProcess)
        {
            ProcessStartInfo ProcessInfo;
            Process Process;
            ProcessInfo = new ProcessStartInfo("cmd.exe", "/C " + Command);
            ProcessInfo.CreateNoWindow = false;
            ProcessInfo.UseShellExecute = false;
            Process = Process.Start(ProcessInfo);

            if (closeProcess == true) { Process.Close(); }
        }

        public void SaveSett(string name, string data)
        {
            Settings.Default[name] = data;
            Settings.Default.Save();
        }

        public string Read(string KeyName)
        {
            try
            {
                RegistryKey regKeyOne = Registry.LocalMachine;
                RegistryKey regKeyTwo = Registry.LocalMachine;
                RegistryKey regKeyThree = Registry.LocalMachine;
                RegistryKey regKeyFour = Registry.LocalMachine;

                if (c == false && a == true && regKeyOne != null)
                {
                    regKeyOne = regKeyOne.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\VisualStudio\10.0\");
                    return regKeyOne.GetValue("ShellFolder").ToString();
                }

                else if (c == false && a == false && regKeyOne != null)
                {
                    regKeyTwo = regKeyTwo.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\VisualStudio\11.0\");
                    return regKeyTwo.GetValue("ShellFolder").ToString();
                }
                else if (c == true && a == true && regKeyOne != null)
                {
                    regKeyThree = regKeyThree.OpenSubKey(@"SOFTWARE\Microsoft\VisualStudio\10.0\");
                    return regKeyThree.GetValue("ShellFolder").ToString();
                }
                else if (c == true && a == false && regKeyOne != null)
                {
                    regKeyThree = regKeyFour.OpenSubKey(@"SOFTWARE\Microsoft\VisualStudio\11.0\");
                    return regKeyFour.GetValue("ShellFolder").ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void button_compile_Click(object sender, EventArgs e)
        {
            string cflag = "/DWIN32 /D_WINDOWS /W3 /Zm1000 /EHsc /GR";

            if (build == "win32")
            {
                ExecComm("@echo off & rd /s/q build & mkdir build & cd build & mkdir \"" + textBox_Selected_install_path.Text + "\" & cmake -G \"" + comp_n + "\" -DPCH=1 -DCMAKE_CXX_COMPILER=\"" + textBox_Selected_compiler_path.Text + "\" -DCMAKE_CXX_FLAGS=\"" + cflag + "\" -DCMAKE_C_FLAGS=\"" + cflag + "\" -DCMAKE_CXX_COMPILER=\"" + textBox_Selected_compiler_path.Text + "\" -DCMAKE_INSTALL_PREFIX=\"" + textBox_Selected_install_path.Text + "\" -DUSE_FASTMM_MALLOC=1 -DUSE_STD_MALLOC=0 -DUSE_TBB_MALLOC=0 .. & call \"" + textBox_Selected_compiler_path.Text + "VC\\vcvarsall.bat\" & MSBuild INSTALL.vcxproj /m:" + core + " /t:Rebuild /p:Configuration=Release;Platform=" + build + " & cd .. & Pause > nul", false);
                Application.Exit();
            }

            if (build == "x64")
            {
                ExecComm("@echo off & rd /s/q build & mkdir build & cd build & mkdir \"" + textBox_Selected_install_path.Text + "\" & cmake -G \"" + comp_n + "\" -DPCH=1 -DPLATFORM=X64 -DCMAKE_CXX_COMPILER=\"" + textBox_Selected_compiler_path.Text + "\" -DCMAKE_CXX_FLAGS=\"" + cflag + "\" -DCMAKE_C_FLAGS=\"" + cflag + "\" -DCMAKE_CXX_COMPILER=\"" + textBox_Selected_compiler_path.Text + "\" -DCMAKE_INSTALL_PREFIX=\"" + textBox_Selected_install_path.Text + "\" -DUSE_FASTMM_MALLOC=1 -DUSE_STD_MALLOC=0 -DUSE_TBB_MALLOC=0 .. & call \"" + textBox_Selected_compiler_path.Text + "VC\\vcvarsall.bat\" & MSBuild INSTALL.vcxproj /m:" + core + " /t:Rebuild /p:Configuration=Release;Platform=" + build + " & cd .. & Pause > nul", false);
                Application.Exit();
            }
        }

        public void button_change_two_Click(object sender, EventArgs e)
        {
            Dialog(true);
        }

        public void button_change_one_Click(object sender, EventArgs e)
        {
            Dialog(false);
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.Show();
        }

        private void comboBox_com_vc_SelectedIndexChanged(object sender, EventArgs e)
        {
            comp = comboBox_com_vc.Items[comboBox_com_vc.SelectedIndex].ToString();
            SaveSett("compiler", comp);
            PlatformChange();

            if (comp == "VC10" && c == false)
            {
                a = true;
                textBox_Selected_compiler_path.Text = Read(KeyName);
                if (Read(KeyName) == null)
                {
                    msgBox(war_1, "VC11");
                }
            }


            if (comp == "VC11" && c == false)
            {
                a = false;
                textBox_Selected_compiler_path.Text = Read(KeyName);
                if (Read(KeyName) == null)
                {
                    msgBox(war_2, "VC10");
                }
            }

            if (comp == "VC10" && c == true)
            {
                b = true;
                textBox_Selected_compiler_path.Text = Read(KeyName);
                if (Read(KeyName) == null)
                {
                    msgBox(war_1, "VC11");
                }
            }

            if (comp == "VC11" && c == true)
            {
                b = false;
                Read(KeyName);
                textBox_Selected_compiler_path.Text = Read(KeyName);
                if (Read(KeyName) == null)
                {
                    msgBox(war_2, "VC10");
                }
            }
        }

        private void comboBox_cpu_core_SelectedIndexChanged(object sender, EventArgs e)
        {
            core = comboBox_cpu_core.Items[comboBox_cpu_core.SelectedIndex].ToString();
            SaveSett("cpu", core);
        }

        private void comboBox_build_platform_SelectedIndexChanged(object sender, EventArgs e)
        {
            build = comboBox_build_platform.Items[comboBox_build_platform.SelectedIndex].ToString();
            SaveSett("platform", build);
            if (build == "win64")
            {
                build = "x64";
            }
            PlatformChange();
        }

        private void textBox_Selected_install_path_TextChanged(object sender, EventArgs e)
        {
            SaveSett("installPath",textBox_Selected_install_path.Text);
        }

        private void Compiler_Load(object sender, EventArgs e)
        {
            comboBox_com_vc.Text = Settings.Default["compiler"].ToString();
            comboBox_build_platform.Text = Settings.Default["platform"].ToString();
            comboBox_cpu_core.Text = Settings.Default["cpu"].ToString();
            textBox_Selected_install_path.Text = Settings.Default["installPath"].ToString();
        }

        public string platform { get; set; }

        public string Command { get; set; }

        public string subKey { get; set; }

        public string KeyName { get; set; }

        public RegistryKey baseRegistryKey { get; set; }
    }
}
