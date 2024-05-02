using Finance_APP.Core.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_APP.pages.centerpanel
{
    public partial class WithdrawPage : UserControl
    {
        public bool TopLevel { get; internal set; }
        public WithdrawPage()
        {
            InitializeComponent();
        }

        private void u_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void u_name_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void withdrawal_Load(object sender, EventArgs e)

        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int accountId;
            try
            {
                accountId = int.Parse(guna2TextBox6.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("Invalid account number. Please enter a valid account number.");

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }

            double withdrawalAmount;
            try
            {
                withdrawalAmount = double.Parse(guna2TextBox1.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("Invalid withdrawal amount. Please enter a valid withdrawal amount.");

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }

            if (withdrawalAmount <= 0)
            {
                MessageBox.Show("Invalid withdrawal amount. Please enter a valid withdrawal amount.");
                return;
            }

            string transactionNotes = guna2TextBox4.Text;

            Account account;
            try {
                account = (Account)BaseModel.Get<Account>(accountId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account not found. Please enter a valid account number.");

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }

            if (account.Balance < withdrawalAmount)
            {
                MessageBox.Show("Insufficient funds. Please enter a valid withdrawal amount.");
                return;
            }

            account.Balance -= withdrawalAmount;
            account.Save();

            Transaction transaction = new Transaction();

            transaction.AccountId = accountId;
            transaction.Amount = withdrawalAmount;
            transaction.Type = "Withdrawal";
            transaction.Date = DateTime.Now;
            transaction.Notes = transactionNotes;

            transaction.Save();
        }
    }
}
