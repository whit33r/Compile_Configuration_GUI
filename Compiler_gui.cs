using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;
using WindowsForms_compiler.Properties;

namespace WindowsForms_compiler
{
    public partial class Compiler : Form
    {
        private const string War1 = "Visual Studio 10 is not installed on your computer.";
        private const string War2 = "Visual Studio 11 is not installed on your computer.";
        public static bool Available;
        public static string RemoteVer, currVer = "1.2.4";
        private readonly int count = Environment.ProcessorCount;
        private bool a, b, update = false;
        private string build, comp, comp_n;
        private int controll;
        private string core;
        private bool updateYes;

        public Compiler()
        {
            InitializeComponent();

            if (File.Exists("R2_Compiler_conf_gui_OLD.exe"))
            {
                File.Delete(@"R2_Compiler_conf_gui_OLD.exe");
                var uC = new Update_Completed();
                uC.Show();
                update = true;
            }

            const string target1 = @"src\";
            const string target2 = @"cmake\";
            
            if (!update)
            {
                if (Directory.Exists(target1) || (Directory.Exists(target2)))
                {
                    const string target3 = @"src\bindings\ScriptDev2\sql_mr\";
                    const string target4 = @"src\bindings\ScriptDev2\scripts";
                    if (!Directory.Exists(target3) || (!Directory.Exists(target4)))
                    {
                        MessageBox.Show("\\src\\bindings\\ScriptDev2 Folder is empty.", "Warning", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Can't find MaNGOS files.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            b = IntPtr.Size != 8;

            for (int i = 1; i <= count; i++)
            {
                comboBox_cpu_core.Items.Add(i);
            }
            comboBox_cpu_core.Text = Settings.Default["cpu"].ToString();

            bw_update.RunWorkerAsync();
        }

        private void MsgBox(string msg, string cBox)
        {
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            comboBox_com_vc.Items.Clear();
            comboBox_com_vc.Items.Add(cBox);
            comboBox_com_vc.Text = cBox;
        }

        private void PlatformChange()
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

        private void Dialog(Boolean newFolder)
        {
            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowser.ShowNewFolderButton = newFolder;
            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK && newFolder)
            {
                textBox_Selected_install_path.Text = folderBrowser.SelectedPath;
            }
            else
            {
                textBox_Selected_compiler_path.Text = folderBrowser.SelectedPath;
            }
        }

        private void ExecComm(string cmdS, Boolean closeProcess)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/C " + cmdS)
                {
                    CreateNoWindow = false,
                    UseShellExecute = false
                };
            Process process = Process.Start(processInfo);
            if (closeProcess)
            {
                process.Close();
            }
        }

        private void SaveSett(string name, string data)
        {
            Settings.Default[name] = data;
        }

        private string Read()
        {
            try
            {
                RegistryKey regKeyOne = Registry.LocalMachine;
                RegistryKey regKeyTwo = Registry.LocalMachine;
                RegistryKey regKeyThree = Registry.LocalMachine;
                RegistryKey regKeyFour = Registry.LocalMachine;

                if (b == false && a && regKeyOne != null)
                {
                    regKeyOne = regKeyOne.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\VisualStudio\10.0\");
                    if (regKeyOne != null) return regKeyOne.GetValue("ShellFolder").ToString();
                }
                if (b == false && a == false && regKeyOne != null)
                {
                    regKeyTwo = regKeyTwo.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\VisualStudio\11.0\");
                    if (regKeyTwo != null) return regKeyTwo.GetValue("ShellFolder").ToString();
                }
                if (b && a && regKeyOne != null)
                {
                    regKeyThree = regKeyThree.OpenSubKey(@"SOFTWARE\Microsoft\VisualStudio\10.0\");
                    if (regKeyThree != null) return regKeyThree.GetValue("ShellFolder").ToString();
                }
                if (b && a == false && regKeyOne != null)
                {
                    regKeyFour.OpenSubKey(@"SOFTWARE\Microsoft\VisualStudio\\11.0\");
                    return regKeyFour.GetValue("ShellFolder").ToString();
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void button_compile_Click(object sender, EventArgs e)
        {
            const string cflag = "/DWIN32 /D_WINDOWS /W3 /Zm1000 /EHsc /GR";

            if (build == "win32")
            {
                ExecComm(
                    "@echo off & rd /s/q build & mkdir build & cd build & mkdir \"" + textBox_Selected_install_path.Text +
                    "\" & cmake -G \"" + comp_n + "\" -DPCH=1 -DCMAKE_CXX_COMPILER=\"" +
                    textBox_Selected_compiler_path.Text + "\" -DCMAKE_CXX_FLAGS=\"" + cflag + "\" -DCMAKE_C_FLAGS=\"" +
                    cflag + "\" -DCMAKE_CXX_COMPILER=\"" + textBox_Selected_compiler_path.Text +
                    "\" -DCMAKE_INSTALL_PREFIX=\"" + textBox_Selected_install_path.Text +
                    "\" -DUSE_FASTMM_MALLOC=1 -DUSE_STD_MALLOC=0 -DUSE_TBB_MALLOC=0 .. & call \"" +
                    textBox_Selected_compiler_path.Text + "VC\\vcvarsall.bat\" & MSBuild INSTALL.vcxproj /m:" + core +
                    " /t:Rebuild /p:Configuration=Release;Platform=" + build + " & cd .. & Pause > nul", false);
                Application.Exit();
            }

            if (build == "x64")
            {
                ExecComm(
                    "@echo off & rd /s/q build & mkdir build & cd build & mkdir \"" + textBox_Selected_install_path.Text +
                    "\" & cmake -G \"" + comp_n + "\" -DPCH=1 -DPLATFORM=X64 -DCMAKE_CXX_COMPILER=\"" +
                    textBox_Selected_compiler_path.Text + "\" -DCMAKE_CXX_FLAGS=\"" + cflag + "\" -DCMAKE_C_FLAGS=\"" +
                    cflag + "\" -DCMAKE_CXX_COMPILER=\"" + textBox_Selected_compiler_path.Text +
                    "\" -DCMAKE_INSTALL_PREFIX=\"" + textBox_Selected_install_path.Text +
                    "\" -DUSE_FASTMM_MALLOC=1 -DUSE_STD_MALLOC=0 -DUSE_TBB_MALLOC=0 .. & call \"" +
                    textBox_Selected_compiler_path.Text + "VC\\vcvarsall.bat\" & MSBuild INSTALL.vcxproj /m:" + core +
                    " /t:Rebuild /p:Configuration=Release;Platform=" + build + " & cd .. & Pause > nul", false);
                Application.Exit();
            }
        }

        private void button_change_two_Click(object sender, EventArgs e)
        {
            Dialog(true);
        }

        private void button_change_one_Click(object sender, EventArgs e)
        {
            Dialog(false);
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            var aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void comboBox_com_vc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controll < 2)
            {
                comp = comboBox_com_vc.Items[comboBox_com_vc.SelectedIndex].ToString();
                SaveSett("compiler", comp);
                PlatformChange();

                if (comp == "VC10" && b == false)
                {
                    a = true;
                    textBox_Selected_compiler_path.Text = Read();

                    if (Read() == null)
                    {
                        controll++;
                        MsgBox(War1, "VC11");
                    }
                }

                if (comp == "VC11" && b == false)
                {
                    a = false;
                    textBox_Selected_compiler_path.Text = Read();

                    if (Read() == null)
                    {
                        controll++;
                        MsgBox(War2, "VC10");
                    }
                }

                if (comp == "VC10" && b)
                {
                    b = true;
                    textBox_Selected_compiler_path.Text = Read();

                    if (Read() == null)
                    {
                        controll++;
                        MsgBox(War1, "VC11");
                    }
                }

                if (comp == "VC11" && b)
                {
                    b = false;
                    Read();
                    textBox_Selected_compiler_path.Text = Read();

                    if (Read() == null)
                    {
                        controll++;
                        MsgBox(War2, "VC10");
                    }
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
            SaveSett("installPath", textBox_Selected_install_path.Text);
        }

        private void Compiler_Load(object sender, EventArgs e)
        {
            comboBox_com_vc.Text = Settings.Default["compiler"].ToString();
            comboBox_build_platform.Text = Settings.Default["platform"].ToString();
            comboBox_cpu_core.Text = Settings.Default["cpu"].ToString();
            textBox_Selected_install_path.Text = Settings.Default["installPath"].ToString();
        }

        private void Compiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void bw_update_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var client = new WebClient();
                Stream stream = client.OpenRead("http://dl.dropbox.com/u/7587303/Updates/R2_Compiler_conf_gui.txt");
                var reader = new StreamReader(stream);
                String content = reader.ReadToEnd();
                Available = true;
                RemoteVer = content;
                if (content != currVer)
                {
                    if (
                        MessageBox.Show("New Version Available: V" + content + "\n" + "You want to download?",
                                        "New Version", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                    {
                        updateYes = true;
                    }
                }
            }
            catch (Exception)
            {
                Available = false;
            }
        }

        private void bw_update_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (updateYes)
            {
                var update = new Update();
                update.Show();
            }
        }
    }
}