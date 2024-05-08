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


        }
        

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
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
            string customerID = CustomerIDtxt.Text;

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

            try
            {
                // Open the connection
                connectionString.Open();
                //sql query to update data
                string query = "UPDATE Customer SET FullName = @fullName, FirstName = @firstName, LastName = @lastName, Gender = @gender, NICNumber = @nICNumber, TINNUmber = @tINNUmber, ResidentialAddress = @residentialAddress, Mobile = @mobile, Email = @email, DateOfBirth = @dateOfBirth, CivilStatus = @civilStatus, SpouseProfession = @spouseProfession, Nationality = @nationality, Occupation = @occupation, Designation = @designation, Profession = @profession, Employer = @employer, EmplyementStatus = @emplyementStatus, EmployementServiceTimeStart = @employmentServiceTimeStart, IncomeMethod = @incomeMethod, IncomeAmount = @incomeAmount, DepositAmount = @depositAmount WHERE Id= @CustomerID";
                /*string query = "INSERT INTO Customer (FullName, FirstName, LastName,Gender, NICNumber, TINNUmber, ResidentialAddress, Mobile, Email, DateOfBirth, CivilStatus, SpouseProfession, Nationality, Occupation, Designation, Profession, Employer, EmplyementStatus, EmployementServiceTimeStart,IncomeMethod, IncomeAmount, DepositAmount) " +
                    "VALUES (@fullName, @firstName, @lastName, @gender, @nICNumber, @tINNUmber, @residentialAddress, @mobile, @email, @dateOfBirth, @civilStatus, @spouseProfession, @nationality, @occupation, @designation, @profession, @employer, @emplyementStatus, @employmentServiceTimeStart, @incomeMethod, @incomeAmount, @depositAmount)";*/

                using (SqlCommand command = new SqlCommand(query, connectionString))
                {
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@firstName", firstname);
                    command.Parameters.AddWithValue("@lastName", lastname);
                    command.Parameters.AddWithValue("@gender", gender);
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
                    command.Parameters.AddWithValue("@CustomerID", customerID);


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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string customerID = CustomerIDtxt.Text;
            string query = "SELECT * FROM Customer WHERE Id= @CustomerID";

            try
            {
                connectionString.Open();
                using (SqlCommand command = new SqlCommand(query, connectionString))
                {
                    command.Parameters.AddWithValue("CustomerID", customerID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        fullnameTextBox.Text = reader["FullName"].ToString();
                        firstnametxt.Text = reader["FirstName"].ToString();
                        lastnametxt.Text = reader["LastName"].ToString();
                        genderComboBox.Text = reader["Gender"].ToString();
                        phoneNumberTextBox.Text = reader["Mobile"].ToString();
                        dateOfBirthDateTimePicker.Value = (DateTime)reader["DateOfBirth"];
                        emailTextBox.Text = reader["Email"].ToString();
                        addressTextBox.Text = reader["ResidentialAddress"].ToString();
                        tinTextBox.Text = reader["TINNumber"].ToString();
                        Deposittxt.Text = reader["DepositAmount"].ToString();
                        civilStatusComboBox.Text = reader["CivilStatus"].ToString();
                        spouseProfessionTextBox.Text = reader["SpouseProfession"].ToString();
                        nationalityTextBoc.Text = reader["Nationality"].ToString();
                        occupationTextBox.Text = reader["Occupation"].ToString();
                        designationTextBox.Text = reader["Designation"].ToString();
                        professionTextBox.Text = reader["Profession"].ToString();
                        employerTextBox.Text = reader["Employer"].ToString();
                        employmentStatusText.Text = reader["EmplyementStatus"].ToString();
                        employmentStartDateTimePicker.Value = (DateTime)reader["EmployementServiceTimeStart"];
                        incomeMethodTextBox.Text = reader["IncomeMethod"].ToString();
                        incomeAmountTextBox.Text = reader["IncomeAmount"].ToString();
                        nicTextBox.Text = reader["NICNumber"].ToString();

                        
                        



                      



                    }
                    else
                    {
                        MessageBox.Show("No records found for the entered ID.");
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
    }
    }


    

