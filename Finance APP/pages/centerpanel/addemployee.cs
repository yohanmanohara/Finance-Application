using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_APP.pages.centerpanel
{
    public partial class addemployee : UserControl
    {




        public bool TopLevel { get; internal set; }
        public addemployee()
        {
            InitializeComponent();
        }

        private void addemployee_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection connectionString = new SqlConnection(@"Data Source=financensbm.database.windows.net;Initial Catalog=finance;Persist Security Info=True;User ID=financeadmin;Password=finance2024$;Encrypt=True");

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // Collect account data from the form
            string fullName = fullnameTextBox.Text;
            DateTime dateOfBirth = dateOfBirthDateTimePicker.Value;
            string gender = genderComboBox.Text;
            int phoneNumber = int.Parse(phoneNumberTextBox.Text);
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            int tin = int.Parse(tinTextBox.Text);
            string jobtitle= jobtitleBox1.Text;
            string location=locationTextBox.Text;
            string username = usernameTxt.Text;
            string firstname = firstnametxt.Text;
            string lastname = lastnametxt.Text;
            string empstatus = empstatustxt.Text;


            string password = passwordTextBox.Text;


            // Create a connection to the SQL Server database

            try
            {
                connectionString.Open();

                // Create a SQL command to insert account data into the database
                string insertQuery = "INSERT INTO [dbo].[userdb] (username, password, email, fullname, birthdate, gender, phonenumber, adress, tin, jobtitle, workinglocation,firstname,lastname,empstatus) " +
                                     "VALUES ('" + username + "', '" + password + "', '" + email + "', '" + fullName + "', '" + dateOfBirth + "', '" + gender + "', '" + phoneNumber + "', '" + address + "', '" + tin + "', '" + jobtitle + "', '" + location + "','"+ firstname +"','"+lastname+"','"+empstatus+"')";

                using (SqlCommand command = new SqlCommand(insertQuery, connectionString))
                {
                    // Execute the command to insert data
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if data insertion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account created successfully!");
                    }
                    else
                    {
                        // Handle the case when no rows were affected
                        MessageBox.Show("Failed to create account.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
































        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
