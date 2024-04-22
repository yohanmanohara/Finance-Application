using Finance_APP.Core.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Finance_APP.Core.Utility;

namespace Finance_APP.pages.centerpanel
{
    public partial class Personal_loan_1 : UserControl
    {
        public bool TopLevel { get; internal set; }

        public Personal_loan_1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = (Account)BaseModel.New<Account>();
                Customer customer = (Customer)BaseModel.New<Customer>();
                PersonalLoan personalLoan = (PersonalLoan)BaseModel.New<PersonalLoan>();

                customer.FullName = guna2TextBox1.Text;
                customer.ResidentialAddress = guna2TextBox2.Text;
                customer.Occupation = guna2TextBox3.Text;

                Console.WriteLine(guna2TextBox4.Text);
                customer.DateOfBirth = DateTime.Parse(guna2TextBox4.Text);

                customer.NICNumber = guna2TextBox5.Text;
                customer.TINNumber = guna2TextBox9.Text; // Text Box 9

                customer.Mobile = guna2TextBox6.Text;
                customer.Email = guna2TextBox7.Text;

                string nationalityAndCivilStatus = guna2TextBox8.Text;

                customer.Nationality = nationalityAndCivilStatus; // ex: Sri Lankan, American, British
                customer.CivilStatus = nationalityAndCivilStatus; // ex: Single, Married, Divorced, Widowed

                customer.Profession = guna2TextBox10.Text;
                customer.Designation = guna2TextBox11.Text;
                customer.Employer = guna2TextBox12.Text;
                customer.EmplyementStatus = guna2TextBox13.Text;

                customer.EmployementServiceTimeStart = DateTime.Parse(guna2TextBox14.Text);

                customer.SpouseProfession = guna2TextBox15.Text;
                customer.IncomeMethod = guna2TextBox16.Text;
                customer.IncomeAmount = double.Parse(guna2TextBox17.Text);

                customer.Write();

                personalLoan.AccountId = account.Id;

                personalLoan.LoanPurpose = guna2TextBox19.Text;
                personalLoan.LoanAmount = double.Parse(guna2TextBox20.Text);

                int repaymentPeriodDelta = UserInputParser.HumanTimeDelta(guna2TextBox21.Text);

                personalLoan.RepaymentPeriodStart = DateTime.Now;
                personalLoan.RepaymentPeriodEnd = DateTime.Now.AddDays(repaymentPeriodDelta);

                personalLoan.Write();

                account.CustomerId = customer.Id;
                account.Type = "Personal Loan";
                account.Balance = personalLoan.LoanAmount * -1;
                account.Name = customer.FullName + "'s personal loan - " + personalLoan.LoanAmount.ToString();

                account.Write();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                MessageBox.Show(ex.Message);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
