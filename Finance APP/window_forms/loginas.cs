using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Finance_APP.window_forms
{
    public partial class loginas : Form
    {
        public loginas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }



        //this code for form rounded

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );


        //it is end up on here




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void label_Click(object sender, EventArgs e)
        {
          
        }

        private void loginas_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dd_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd");
            date2.Text = DateTime.Now.ToString("MMM");
            time.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin adminlogin = new adminlogin();
            adminlogin.Show();
        }

        private void date2_Click(object sender, EventArgs e)
        {

        }
    }
}
