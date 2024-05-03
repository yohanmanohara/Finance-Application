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

namespace Finance_APP.pages.centerpanel.CashierPages
{
    public partial class TransferPage : UserControl
    {
        public bool TopLevel { get; internal set; }
        public TransferPage()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Account senderAccount;
            Account receiverAccount;
            try
            {
                senderAccount = (Account)BaseModel.Find<Account, int>("ïd", int.Parse(senderAccountIdGuna2TextBox1.Text));
                receiverAccount = (Account)BaseModel.Find<Account, int>("ïd", int.Parse(receiverAccountIdGuna2TextBox2.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid account number. Please enter a valid account number.");

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account not found.");

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }

            double transferAmount;
            try
            {
                transferAmount = double.Parse(amountGuna2TextBox3.Text);

                if (transferAmount <= 0)
                {
                    throw new Exception("Invalid amount. Please enter a valid amount.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid amount. Please enter a valid amount.");

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }

            if (senderAccount.Balance < transferAmount)
            {
                MessageBox.Show("Insufficient funds. Please enter a valid transfer amount.");
                return;
            }

            senderAccount.Balance -= transferAmount;
            receiverAccount.Balance += transferAmount;

            senderAccount.Save();
            receiverAccount.Save();

            Transaction sendTransaction = (Transaction)BaseModel.New<Transaction>();

            sendTransaction.AccountId = senderAccount.Id;
            sendTransaction.Amount = transferAmount;
            sendTransaction.Type = "Transfer";
            sendTransaction.Date = DateTime.Now;
            sendTransaction.Notes = "Transfer to account " + receiverAccount.Id;

            sendTransaction.Save();

            Transaction receiveTransaction = (Transaction)BaseModel.New<Transaction>();
            receiveTransaction.AccountId = senderAccount.Id;
            receiveTransaction.Amount = transferAmount;
            receiveTransaction.Type = "Transfer";
            receiveTransaction.Date = DateTime.Now;
            receiveTransaction.Notes = "Transfer from account " + senderAccount.Id;

            receiveTransaction.Save();

            MessageBox.Show("Transfer successful.");
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
