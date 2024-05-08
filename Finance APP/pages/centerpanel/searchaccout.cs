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
    public partial class searchaccout : UserControl
    {
        public bool TopLevel { get; internal set; }
        public searchaccout()
        {
            InitializeComponent();
        }

        private void searchaccout_Load(object sender, EventArgs e)
        {

        }
        SqlConnection connectionString = new SqlConnection(@"Data Source=financensbm.database.windows.net;Initial Catalog=finance;Persist Security Info=True;User ID=financeadmin;Password=finance2024$;Encrypt=True");

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string customer_id = CustomerIDtxt.Text;
            string query = "SELECT * FROM customer WHERE customer_id = @Customer_ID";

            try
            {
                connectionString.Open();
                using (SqlCommand command = new SqlCommand(query, connectionString))
                {
                    command.Parameters.AddWithValue("@Customer_ID", customer_id);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        fullnameTextBox.Text = reader["fullname"].ToString();
                        firstnametxt.Text = reader["firstname"].ToString();
                        lastnametxt.Text = reader["lastname"].ToString();
                        genderComboBox.Text = reader["gender"].ToString();
                        phoneNumberTextBox.Text = reader["phone_number"].ToString();
                        dateOfBirthDateTimePicker.Value = (DateTime)reader["birthday"];
                        emailTextBox.Text = reader["email"].ToString();
                        addressTextBox.Text = reader["address"].ToString();
                        tinTextBox.Text = reader["tin"].ToString();
                        
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
           
            firstnametxt.Text = "";
            lastnametxt.Text = "";
            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
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

