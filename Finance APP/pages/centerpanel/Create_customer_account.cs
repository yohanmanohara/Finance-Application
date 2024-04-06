using Finance_APP.window_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Finance_APP.pages.centerpanel
{
    public partial class Create_customer_account : UserControl
    {
        public bool TopLevel { get; internal set; }


        public Create_customer_account()

        {
            InitializeComponent();
        }

        private void Create_customer_account_Load(object sender, EventArgs e)
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
            string Deposit_id = Deposittxt.Text;

            string firstname = firstnametxt.Text;
            string lastname = lastnametxt.Text;
            if (string.IsNullOrWhiteSpace(fullName) ||
              string.IsNullOrWhiteSpace(gender) ||
              string.IsNullOrWhiteSpace(phoneNumberStr) ||
              string.IsNullOrWhiteSpace(email) ||
              string.IsNullOrWhiteSpace(address) ||
            string.IsNullOrWhiteSpace(tinStr) ||


              string.IsNullOrWhiteSpace(firstname) ||
              string.IsNullOrWhiteSpace(lastname) )


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

                string insertQuery = "INSERT INTO [dbo].[customer] ( fullname, firstname, lastname, birthday, gender, phone_number, email, address, tin, deposit_id) " +
                                     "VALUES ( @FullName,  @FirstName, @LastName, @DateOfBirth, @Gender, @PhoneNumber, @email, @Address, @TIN, @Deposit_id)";

                using (SqlCommand command = new SqlCommand(insertQuery, connectionString))
                {

                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@TIN", tin);

                    command.Parameters.AddWithValue("@FirstName", firstname);
                    command.Parameters.AddWithValue("@LastName", lastname);
                    command.Parameters.AddWithValue("@Deposit_id", Deposit_id);


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
            catch (Exception)
            {
                erropop erro = new erropop();
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


            firstnametxt.Text = "";
            lastnametxt.Text = "";

        }
    }
}
