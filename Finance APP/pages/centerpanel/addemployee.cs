using Finance_APP.window_forms;
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
            string fullName = fullnameTextBox.Text;
            DateTime dateOfBirth = dateOfBirthDateTimePicker.Value;
            string gender = genderComboBox.Text;
            string phoneNumberStr = phoneNumberTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            string tinStr = tinTextBox.Text;
            string jobtitle= jobtitleBox1.Text;
            string location=locationTextBox.Text;
            string username = usernameTxt.Text;
            string firstname = firstnametxt.Text;
            string lastname = lastnametxt.Text;
            string empstatus = empstatustxt.Text;
            string ConPass = conpassTextbox.Text;


            string password = passwordTextBox.Text;
            if (password != ConPass)
            {
                MessageBox.Show("Password and Confirm Password must be same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(phoneNumberStr) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(tinStr) ||
                string.IsNullOrWhiteSpace(jobtitle) ||
                string.IsNullOrWhiteSpace(location) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(firstname) ||
                string.IsNullOrWhiteSpace(lastname) ||
                string.IsNullOrWhiteSpace(empstatus) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(phoneNumberStr, out int phoneNumber) || phoneNumber == 0 ||
                !int.TryParse(tinStr, out int tin) || tin == 0)
            {
                MessageBox.Show("Phone number and TIN must be valid integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            try
            {
                connectionString.Open();

                string insertQuery = "INSERT INTO [dbo].[userdb] (username, password, email, fullname, birthdate, gender, phonenumber, adress, tin, jobtitle, workinglocation, firstname, lastname, empstatus) " +
                                     "VALUES (@Username, @Password, @Email, @FullName, @DateOfBirth, @Gender, @PhoneNumber, @Address, @TIN, @JobTitle, @Location, @FirstName, @LastName, @EmpStatus)";

                using (SqlCommand command = new SqlCommand(insertQuery, connectionString))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@TIN", tin);
                    command.Parameters.AddWithValue("@JobTitle", jobtitle);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@FirstName", firstname);
                    command.Parameters.AddWithValue("@LastName", lastname);
                    command.Parameters.AddWithValue("@EmpStatus", empstatus);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)


                    {

                        ClearFormInputs();
                        success success = new success();
                        success.ShowDialog();

                    }
                    else
                    {
                        ClearFormInputs();
                        errocreateaccount errocreateaccount = new errocreateaccount();
                        errocreateaccount.ShowDialog();
                    }
                }
            }
            catch (Exception )
            {
               erropop erro =new erropop();
                erro.ShowDialog();  
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
            genderComboBox.SelectedIndex = -1; 
            phoneNumberTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            tinTextBox.Text = "";
            jobtitleBox1.Text = "";
            locationTextBox.Text = "";
            usernameTxt.Text = "";
            firstnametxt.Text = "";
            lastnametxt.Text = "";
            empstatustxt.Text = "";
            passwordTextBox.Text = "";
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
