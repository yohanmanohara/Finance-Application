using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Guna.UI2.WinForms;

using Finance_APP.Core.Database.Models;

namespace Finance_APP.pages.centerpanel.CashierPages
{
    public partial class DepositPage : UserControl
    {
        public bool TopLevel { get; internal set; }
        public DepositPage()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int accountId;
            try
            {
                accountId = int.Parse(accountNumberGuna2TextBox6.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid account number. Please enter a valid account number.");

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }

            double depositAmount;
            try
            {
                depositAmount = double.Parse(depositAmountTextBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid amount. Please enter a valid amount.");

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }

            if (depositAmount <= 0)
            {
                MessageBox.Show("Invalid amount. Please enter a valid amount.");
                return;
            }

            string transactionNote = noteGuna2TextBox4.Text;

            Account account;
            try
            {
                account = (Account)BaseModel.Get<Account>(accountId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account not found. Please enter a valid account number.");

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }

            account.Balance += depositAmount;
            account.Save();

            Transaction transaction = new Transaction();

            transaction.AccountId = accountId;
            transaction.Amount = depositAmount;
            transaction.Type = "Deposit";
            transaction.Date = DateTime.Now;
            transaction.Notes = transactionNote;

            transaction.Save();
        }
    }
}
