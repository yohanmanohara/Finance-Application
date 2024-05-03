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

using Finance_APP.window_forms;
using Finance_APP.Core.Database.Models;

namespace Finance_APP.pages.centerpanel
{
    public partial class CreateCustomer : UserControl
    {
        public bool TopLevel { get; internal set; }


        public CreateCustomer()

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
            string nicStr = nicTextBox.Text;
            string civilStatus = civilStatusComboBox.Text;
            string spouseProfession = spouseProfessionTextBox.Text;
            string firstname = firstnametxt.Text;
            string lastname = lastnametxt.Text;
            string nationality = nationalityTextBoc.Text;
            string occupation = occupationTextBox.Text;
            string designation = designationTextBox.Text;
            string profession = professionTextBox.Text;
            string employer = employerTextBox.Text;
            string employmentStatus = employmentStatusText.Text;
            DateTime employmentStart = employmentStartDateTimePicker.Value;
            string incomeMethod = incomeMethodTextBox.Text;
            string incomeAmountStr = incomeAmountTextBox.Text;
            string deposit = Deposittxt.Text;

            if (string.IsNullOrEmpty(fullName) || 
                string.IsNullOrEmpty(phoneNumberStr) || 
                string.IsNullOrEmpty(deposit) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) || 
                string.IsNullOrEmpty(tinStr) || string.IsNullOrEmpty(nicStr) || string.IsNullOrEmpty(civilStatus) || 
                string.IsNullOrEmpty(spouseProfession) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || 
                string.IsNullOrEmpty(nationality) || string.IsNullOrEmpty(occupation) || string.IsNullOrEmpty(designation) || 
                string.IsNullOrEmpty(profession) || string.IsNullOrEmpty(employer) || string.IsNullOrEmpty(employmentStatus) || 
                string.IsNullOrEmpty(incomeMethod) || string.IsNullOrEmpty(incomeAmountStr))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }       

            if (!int.TryParse(phoneNumberStr, out int phoneNumber))
            {
                MessageBox.Show("Please enter a valid phone number");
                return;
            }

            if (!int.TryParse(deposit, out int Deposit))
            {
                MessageBox.Show("Please enter a valid deposit amount");
                return;
            }

            if (!int.TryParse(tinStr, out int tin))
            {
                MessageBox.Show("Please enter a valid TIN number");
                return;
            }

            if (!int.TryParse(nicStr, out int nic))
            {
                MessageBox.Show("Please enter a valid NIC number");
                return;
            }

            if (!int.TryParse(incomeAmountStr, out int incomeAmount))
            {
                MessageBox.Show("Please enter a valid income amount");
                return;
            }

            try { 
                // Open the connection
                connectionString.Open();
                //sql query to insert data
                string query = "INSERT INTO Customer (FullName, FirstName, LastName,Gender, NICNumber, TINNUmber, ResidentialAddress, Mobile, Email, DateOfBirth, CivilStatus, SpouseProfession, Nationality, Occupation, Designation, Profession, Employer, EmplyementStatus, EmployementServiceTimeStart,IncomeMethod, IncomeAmount, DepositAmount) " +
                    "VALUES (@fullName, @firstName, @lastName, @gender, @nICNumber, @tINNUmber, @residentialAddress, @mobile, @email, @dateOfBirth, @civilStatus, @spouseProfession, @nationality, @occupation, @designation, @profession, @employer, @emplyementStatus, @employmentServiceTimeStart, @incomeMethod, @incomeAmount, @depositAmount)"; 

                using (SqlCommand command = new SqlCommand(query, connectionString))
                {
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@firstName", firstname);
                    command.Parameters.AddWithValue("@lastName", lastname);
                    command.Parameters.AddWithValue ("@gender", gender);
                    command.Parameters.AddWithValue("@nICNumber", nic);
                    command.Parameters.AddWithValue("@tINNUmber", tin); 
                    command.Parameters.AddWithValue("@residentialAddress", address);
                    command.Parameters.AddWithValue("@mobile", phoneNumber);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@civilStatus", civilStatus);
                    command.Parameters.AddWithValue("@spouseProfession", spouseProfession);
                    command.Parameters.AddWithValue("@nationality", nationality);
                    command.Parameters.AddWithValue("@occupation", occupation);
                    command.Parameters.AddWithValue("@designation", designation);
                    command.Parameters.AddWithValue("@profession", profession);
                    command.Parameters.AddWithValue("@employer", employer);
                    command.Parameters.AddWithValue("@emplyementStatus", employmentStatus);
                    command.Parameters.AddWithValue("@employmentServiceTimeStart", employmentStart);
                    command.Parameters.AddWithValue("@incomeMethod", incomeMethod);
                    command.Parameters.AddWithValue("@incomeAmount", incomeAmount);
                    command.Parameters.AddWithValue("@depositAmount", deposit);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connectionString.Close();
            }

        }

        private void ClearFormInputs()
        {
            fullnameTextBox.Text = "";
            firstnametxt.Text = "";
            lastnametxt.Text = "";

            dateOfBirthDateTimePicker.Value = DateTime.Now;
            civilStatusComboBox.Text = "";
            spouseProfessionTextBox.Text = "";
            nationalityTextBoc.Text = "";

            addressTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            emailTextBox.Text = "";
            nicTextBox.Text = "";
            tinTextBox.Text = "";
            
            occupationTextBox.Text = "";
            designationTextBox.Text = "";
            professionTextBox.Text = "";

            employerTextBox.Text = "";
            employmentStatusText.Text = "";
            employmentStartDateTimePicker.Value = DateTime.Now;

            incomeMethodTextBox.Text = "";
            incomeAmountTextBox.Text = "";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
