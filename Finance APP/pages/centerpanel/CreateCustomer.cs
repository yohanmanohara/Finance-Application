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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = (Customer)BaseModel.New<Customer>();

                customer.FullName = fullnameTextBox.Text;
                customer.FirstName = firstnametxt.Text;
                customer.LastName = lastnametxt.Text;

                customer.DateOfBirth = dateOfBirthDateTimePicker.Value;
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
    }
}
