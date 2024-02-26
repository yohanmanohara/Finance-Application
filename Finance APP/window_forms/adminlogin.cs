﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_APP.window_forms
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
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

        SqlConnection conn = new SqlConnection(@"Data Source=167.172.94.222;Initial Catalog=admindatabase;User ID=sa;Password=12345678Qw;Connect Timeout=30;");





        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            date.Text = DateTime.Now.ToString("dd");
            date2.Text = DateTime.Now.ToString("MMM");
            time.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginas lo = new loginas(); 
            lo.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String username, password;
            username = u_name.Text;
            password = u_password.Text;


            try 
            {
                String query = "SELECT * FROM [admintable] WHERE username='" + u_name.Text + "' AND password='" + u_password.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query,conn);
                DataTable dt = new DataTable();
                sda.Fill( dt );
                if(dt.Rows.Count > 0)
                {
                    username = u_name.Text;
                    password = u_password.Text;
                    this.Hide();
                    admindashbord admindashbord = new admindashbord();
                    admindashbord.Show();

                    

                    

                }
                else
                {
                    this.Hide();
                    erropop successpop = new erropop();
                    successpop.Show();
                }


            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }



        }
    }
}