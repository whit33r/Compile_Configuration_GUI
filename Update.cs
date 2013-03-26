using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace WindowsForms_compiler
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Shown(object sender, EventArgs e)
        {
            bw_updater.RunWorkerAsync();
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn/totalBytes*100;
            lbl_downByte.Text = e.BytesReceived / 1024 + " / " + e.TotalBytesToReceive / 1024 + " Kb";
            pb_down.Value = int.Parse(Math.Truncate(percentage).ToString(CultureInfo.InvariantCulture));
            lbl_Perecent.Text = int.Parse(Math.Truncate(percentage).ToString(CultureInfo.InvariantCulture)) + "%";
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lbl_status.Text = "Status: Completed";
            Thread.Sleep(500);
            Process.Start("R2_Compiler_conf_gui.exe");
            Application.Exit();
        }

        private void bw_updater_DoWork(object sender, DoWorkEventArgs e)
        {
            lbl_status.Text = "Status: Connecting";
            Thread.Sleep(500);
            string exePath = AppDomain.CurrentDomain.FriendlyName;
            File.Move(exePath, @"R2_Compiler_conf_gui_OLD.exe");
            File.SetAttributes("R2_Compiler_conf_gui_OLD.exe", FileAttributes.Hidden);

            var client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            lbl_status.Text = "Status: Downloading";
            client.DownloadFileAsync(
                new Uri("http://dl.dropbox.com/u/7587303/Updates/R2_Compiler_conf_gui_update.exe"),
                "R2_Compiler_conf_gui.exe");
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            string exePath = AppDomain.CurrentDomain.FriendlyName;
            File.Delete(@"R2_Compiler_conf_gui.exe");
            File.Move(exePath, @"R2_Compiler_conf_gui.exe");
            Application.Exit();
        }
    }
}

