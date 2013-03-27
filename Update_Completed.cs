using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_compiler
{
    public partial class Update_Completed : Form
    {
        public Update_Completed()
        {
            InitializeComponent();
            lbl_currVer.Text = Compiler.currVer;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
