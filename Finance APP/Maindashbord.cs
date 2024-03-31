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

        public Panel Guna2Panel4 { get { return guna2Panel4; } }

        public string jobroll { get; set; } 


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
            MessageBox.Show($"Job Roll: {jobroll}");

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

            switch (jobroll)
            {
                case "hro":
                    hrofficer hro = new hrofficer();
                    hro.Dock = DockStyle.Fill;
                    this.guna2Panel2.Controls.Add(hro);
                    this.guna2Panel2.Tag = hro;
                    hro.Show();
                    break;

                case "bro":
                    branchofficer bro = new branchofficer();
                    bro.Dock = DockStyle.Fill;
                    this.guna2Panel2.Controls.Add(bro);
                    this.guna2Panel2.Tag = bro;
                    bro.Show();
                    break;

                case "ca":
                    cashierview ca = new cashierview();
                    ca.Dock = DockStyle.Fill;
                    this.guna2Panel2.Controls.Add(ca);
                    this.guna2Panel2.Tag = ca;
                    ca.Show();
                    break;
                case "acc":
                    Accounthadle acc = new Accounthadle();
                    acc.Dock = DockStyle.Fill;
                    this.guna2Panel2.Controls.Add(acc);
                    this.guna2Panel2.Tag = acc;
                    acc.Show();
                    break;

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
