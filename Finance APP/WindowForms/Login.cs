using System;
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
   
    public partial class Login : Form
    {
       
        public Login()
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

        SqlConnection conn = new SqlConnection(@"Data Source=financensbm.database.windows.net;Initial Catalog=finance;Persist Security Info=True;User ID=financeadmin;Password=finance2024$;Encrypt=True");





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
            MessageBox.Show("login succses " );
          
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = u_name.Text;
            string password = u_password.Text;

            try
            {
                string query = "SELECT * FROM [userdb] WHERE username='" + username + "' AND password='" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string jobroll = dt.Rows[0]["jobroll"].ToString();


                    switch (jobroll)
                    {
                        case "hro":

                            
                            this.Hide();
                            MainDashbord HRO = new MainDashbord();
                            HRO.jobroll = jobroll;
                            HRO.ShowDialog();
                            break;

                        case "bro":


                            this.Hide();
                            MainDashbord BRO = new MainDashbord();
                            BRO.jobroll = jobroll;
                            BRO.ShowDialog();
                            break;

                        case "ca":


                            this.Hide();
                            MainDashbord CA = new MainDashbord();
                            CA.jobroll = jobroll;
                            CA.ShowDialog();
                            break;

                        case "acc":


                            this.Hide();
                            MainDashbord ACC = new MainDashbord();
                            ACC.jobroll = jobroll;
                            ACC.ShowDialog();
                            break;





                        case "noroll":
                            this.Hide();
                            JobRollError erropop = new JobRollError();
                            erropop.ShowDialog();
                            break;


                        
                    }
                }
                else
                {
                    this.Hide();
                    ErrorPopUp erropop = new ErrorPopUp();
                    erropop.ShowDialog();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void u_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }
    }
}
