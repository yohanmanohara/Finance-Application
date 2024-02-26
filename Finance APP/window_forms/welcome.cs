using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_APP.window_forms
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            TopMost = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            TopMost = true;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
