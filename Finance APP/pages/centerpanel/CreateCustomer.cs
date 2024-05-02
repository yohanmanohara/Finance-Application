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
using System.Data.SqlTypes;

namespace Finance_APP.pages.centerpanel
{
    public partial class CreateCustomer : UserControl
    {
        public bool TopLevel { get; internal set; }


        public CreateCustomer()

        {
            InitializeComponent();

            fullnameTextBox.MaxLength = 100;
            firstnametxt.MaxLength = 50;
            lastnametxt.MaxLength = 50;
            spouseProfessionTextBox.MaxLength = 100; // Adjust the value as needed
            nationalityTextBoc.MaxLength = 50; // Adjust the value as needed
            addressTextBox.MaxLength = 200; // Adjust the value as needed
            phoneNumberTextBox.MaxLength = 15; // Adjust the value as needed
            emailTextBox.MaxLength = 100; // Adjust the value as needed
            nicTextBox.MaxLength = 20; // Adjust the value as needed
            tinTextBox.MaxLength = 15; // Adjust the value as needed
            occupationTextBox.MaxLength = 100; // Adjust the value as needed
            designationTextBox.MaxLength = 50; // Adjust the value as needed
            professionTextBox.MaxLength = 50; // Adjust the value as needed
            employerTextBox.MaxLength = 100; // Adjust the value as needed
            employmentStatusText.MaxLength = 50; // Adjust the value as needed
            incomeMethodTextBox.MaxLength = 50; // Adjust the value as needed
            incomeAmountTextBox.MaxLength = 10;
        }

        private void Create_customer_account_Load(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = (Customer)BaseModel.New<Customer>();

                customer.FullName = fullnameTextBox.Text;
                customer.FirstName = firstnametxt.Text;
                customer.LastName = lastnametxt.Text;

                customer.DateOfBirth = dateOfBirthDateTimePicker.Value;
                Console.WriteLine(customer.EmployementServiceTimeStart);
                customer.CivilStatus = civilStatusComboBox.Text;
                customer.SpouseProfession = spouseProfessionTextBox.Text;
                customer.Nationality = nationalityTextBoc.Text;

                customer.ResidentialAddress = addressTextBox.Text;
                customer.Mobile = phoneNumberTextBox.Text;
                customer.Email = emailTextBox.Text;
                customer.NICNumber = nicTextBox.Text;
                customer.TINNumber = tinTextBox.Text;

                customer.Occupation = occupationTextBox.Text;
                customer.Designation = designationTextBox.Text;
                customer.Profession = professionTextBox.Text;

                customer.Employer = employerTextBox.Text;
                customer.EmplyementStatus = employmentStatusText.Text;
                customer.EmployementServiceTimeStart = employmentStartDateTimePicker.Value;
                Console.WriteLine(customer.EmployementServiceTimeStart);

                customer.IncomeMethod = incomeMethodTextBox.Text;
                customer.IncomeAmount = int.Parse(incomeAmountTextBox.Text);

                customer.Write();

                ClearFormInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
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

        private bool ValidateForm()
        {
            // Check if required fields are empty
            if (string.IsNullOrWhiteSpace(fullnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(firstnametxt.Text) ||
                string.IsNullOrWhiteSpace(lastnametxt.Text) ||
                string.IsNullOrWhiteSpace(civilStatusComboBox.Text) ||
                string.IsNullOrWhiteSpace(nationalityTextBoc.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(nicTextBox.Text) ||
                string.IsNullOrWhiteSpace(tinTextBox.Text) ||
                string.IsNullOrWhiteSpace(occupationTextBox.Text) ||
                string.IsNullOrWhiteSpace(designationTextBox.Text) ||
                string.IsNullOrWhiteSpace(professionTextBox.Text) ||
                string.IsNullOrWhiteSpace(employerTextBox.Text) ||
                string.IsNullOrWhiteSpace(employmentStatusText.Text) ||
                string.IsNullOrWhiteSpace(incomeMethodTextBox.Text) ||
                string.IsNullOrWhiteSpace(incomeAmountTextBox.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate email format
            if (!IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate NIC number format (assuming it should be numeric)


            // Validate income amount format
            double incomeAmount;
            if (!double.TryParse(incomeAmountTextBox.Text, out incomeAmount))
            {
                MessageBox.Show("Income amount should be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Additional validation rules can be added as needed

            return true; // All validation passed
                         // All validation passed
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    // If validation passed, proceed to create customer account
                    Customer customer = (Customer)BaseModel.New<Customer>();

                    // Populate customer properties

                    customer.Write();

                    ClearFormInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }


            private DateTime ValidateDateTime(DateTime dateTime)
            {
                // Check if the dateTime falls within SQL Server supported range
                if (dateTime < SqlDateTime.MinValue.Value)
                {
                    return SqlDateTime.MinValue.Value;
                }
                else if (dateTime > SqlDateTime.MaxValue.Value)
                {
                    return SqlDateTime.MaxValue.Value;
                }
                else
                {
                    return dateTime;
                }
            }

    }
}
