using Finance_APP.pages;
using Finance_APP.pages.dasbordpanel;
using Finance_APP.window_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_APP
{
    public partial class Maindashbord : Form
    {



        public string job_rollnum { get; set; }
        public Maindashbord()
        {
            InitializeComponent();

            this.FormClosing += MainForm_FormClosing;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }










       

        private void btnCreateAC_Click(object sender, EventArgs e)
        {
            CreateAccount f = new CreateAccount();
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            logoutpopup logoutpopup = new logoutpopup(); // Creates an instance of the logoutpopup class
            logoutpopup.ShowDialog(); //  

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

            cashierview f = new cashierview();
            f.Dock = DockStyle.Fill;
            this.guna2Panel2.Controls.Add(f);
            this.guna2Panel2.Tag = f;
            f.Show();
        }
    }
}
