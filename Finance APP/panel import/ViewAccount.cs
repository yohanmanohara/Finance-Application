using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Finance_APP.panel_import
{
    
    public partial class ViewAccount : UserControl

    {
        public bool TopLevel { get; internal set; }
        internal FormBorderStyle FormBorderStyle;




        SqlConnection connectionString = new SqlConnection(@"Data Source=financensbm.database.windows.net;Initial Catalog=finance;Persist Security Info=True;User ID=financeadmin;Password=finance2024$;Encrypt=True");

        public ViewAccount()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string query = "SELECT * FROM userdb WHERE username = @Username";

            try
            {
                connectionString.Open();
                using (SqlCommand command = new SqlCommand(query, connectionString))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        fullnameTextBox.Text = reader["fullname"].ToString();
                        firstnametxt.Text = reader["firstname"].ToString();
                        lastnametxt.Text = reader["lastname"].ToString();
                        genderComboBox.Text = reader["gender"].ToString();
                        phoneNumberTextBox.Text = reader["phonenumber"].ToString();
                        dateOfBirthDateTimePicker.Value = (DateTime)reader["birthdate"];
                        emailTextBox.Text = reader["email"].ToString();
                        addressTextBox.Text = reader["adress"].ToString();
                        tinTextBox.Text = reader["tin"].ToString();
                        jobtitleBox1.Text = reader["jobtitle"].ToString();
                        locationTextBox.Text = reader["workinglocation"].ToString();
                        empstatustxt.Text = reader["empstatus"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No records found for the entered username.");
                        // Clear all input fields
                        ClearFormInputs();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connectionString.Close();
            }
        }

        private void ClearFormInputs()
        {
            fullnameTextBox.Text = "";
            dateOfBirthDateTimePicker.Value = DateTime.Now;
            genderComboBox.Text = "";
            phoneNumberTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            tinTextBox.Text = "";
            jobtitleBox1.Text = "";
            locationTextBox.Text = "";
            firstnametxt.Text = "";
            lastnametxt.Text = "";
            empstatustxt.Text = "";
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
