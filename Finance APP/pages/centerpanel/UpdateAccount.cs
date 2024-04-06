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
    public partial class UpdateAccount : UserControl
    {
        public bool TopLevel { get; internal set; }

        public UpdateAccount()
        {
            InitializeComponent();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateAccount_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        SqlConnection connectionString = new SqlConnection(@"Data Source=financensbm.database.windows.net;Initial Catalog=finance;Persist Security Info=True;User ID=financeadmin;Password=finance2024$;Encrypt=True");


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fullName = fullnameTextBox.Text;
            DateTime dateOfBirth = dateOfBirthDateTimePicker.Value;
            string gender = genderComboBox.Text;
            string phoneNumberStr = phoneNumberTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            string tinStr = tinTextBox.Text;
            string customer_id = CustomerIDtxt.Text;
            
            

            string firstname = firstnametxt.Text;
            string lastname = lastnametxt.Text;
            if (string.IsNullOrWhiteSpace(fullName) ||
              string.IsNullOrWhiteSpace(gender) ||
              string.IsNullOrWhiteSpace(phoneNumberStr) ||
              string.IsNullOrWhiteSpace(email) ||
              string.IsNullOrWhiteSpace(address) ||
            string.IsNullOrWhiteSpace(tinStr) ||
            string.IsNullOrWhiteSpace(customer_id) ||

              string.IsNullOrWhiteSpace(firstname) ||
              string.IsNullOrWhiteSpace(lastname))


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

                
                string insertQuery = "UPDATE customer SET  fullname = @FullName, firstname =@FirstName, lastname =@LastName, birthday = @DateOfBirth, gender =@Gender, phone_number =@PhoneNumber, address =@Address, tin = @TIN, email =@Email WHERE customer_id =@Customer_ID";


                using (SqlCommand command = new SqlCommand(insertQuery, connectionString))
                {

                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@TIN", tin);
                    command.Parameters.AddWithValue("@Customer_ID", customer_id);

                    command.Parameters.AddWithValue("@FirstName", firstname);
                    command.Parameters.AddWithValue("@LastName", lastname);
                  



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
            catch (Exception sqlex)
            {
                /* erropop erro = new erropop();
                 erro.ShowDialog();*/
                //sql Exception
                MessageBox.Show(sqlex.Message);
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


            firstnametxt.Text = "";
            lastnametxt.Text = "";

        }
    }

}
    

