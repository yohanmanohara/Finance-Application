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

    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
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

        private void timer3_Tick(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("login succses ");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Maindashbord testBoard = new Maindashbord();

            testBoard.jobroll = "Cashier";
            testBoard.firstname = "Test";
            testBoard.lastname = "Üser";
            testBoard.ShowDialog();

            return;

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
                    string jobroll = dt.Rows[0]["jobtitle"].ToString();

                    string firstname = dt.Rows[0]["firstname"].ToString();
                    string lastname = dt.Rows[0]["lastname"].ToString();
                    string empstatus = dt.Rows[0]["empstatus"].ToString();

                    switch (jobroll)
                    {
                        case "HR Manager":
                            if (empstatus == "Active")
                            {
                                this.Hide();

                                Maindashbord HRO = new Maindashbord();
                                HRO.jobroll = jobroll;
                                HRO.firstname = firstname;
                                HRO.lastname = lastname;
                                HRO.ShowDialog();
                            }
                            else if (empstatus == "Blocked")
                            {
                                this.Hide();
                                jobrollerro erropop = new jobrollerro();
                                erropop.ShowDialog();
                            }

                            break;

                        case "Branch Officer":
                            if (empstatus == "Active")
                            {

                                this.Hide();
                                Maindashbord BRO = new Maindashbord();

                                BRO.jobroll = jobroll;
                                BRO.firstname = firstname;
                                BRO.lastname = lastname;
                                BRO.ShowDialog();
                            }
                            else if (empstatus == "Blocked")
                            {
                                this.Hide();
                                jobrollerro erropop = new jobrollerro();
                                erropop.ShowDialog();

                            }
                            break;

                        case "Cashier":
                            if (empstatus == "Active")
                            {


                                this.Hide();
                                Maindashbord CA = new Maindashbord();

                                CA.jobroll = jobroll;
                                CA.firstname = firstname;
                                CA.lastname = lastname;
                                CA.ShowDialog();
                            }
                            else if (empstatus == "Blocked")
                            {
                                this.Hide();
                                jobrollerro erropop = new jobrollerro();
                                erropop.ShowDialog();

                            }
                            break;


                        case "Branch Manager":

                            if (empstatus == "Active")
                            {

                                this.Hide();
                                Maindashbord bm = new Maindashbord();

                                bm.jobroll = jobroll;
                                bm.firstname = firstname;
                                bm.lastname = lastname;
                                bm.ShowDialog();
                            }
                            else if (empstatus == "Blocked")
                            {
                                this.Hide();
                                jobrollerro erropop = new jobrollerro();
                                erropop.ShowDialog();
                            }
                            break;

                        default:
                            this.Hide();
                            jobrollerro jobrollerro = new jobrollerro();
                            jobrollerro.ShowDialog();

                            break;






                    }
                }
                else
                {
                    this.Hide();
                    erropop erropop = new erropop();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
