using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsForms_compiler
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void AboutBox1_Load_1(object sender, EventArgs e)
        {
            lbl_oneDesc.Text = "Created by Whit33r \nSpecial thanks: ConanHUN";
            lbl_twoDesc.Text = "If you liked it and would like to see\nmore like this software, please donate.";
           
            if (Compiler.Available)
            {
                lbl_remoteV.Text = Compiler.RemoteVer;
            }
            else
            {
                lbl_remoteV.Text = "Error";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void pictureBox_donate_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=L5L443PH22PQ4");
        }
    }
}
