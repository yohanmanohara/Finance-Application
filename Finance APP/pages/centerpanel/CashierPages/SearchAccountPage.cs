using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Guna.UI2.HtmlRenderer.Core;

using Finance_APP.Core.Database.Models;

namespace Finance_APP.pages.centerpanel.CashierPages
{
    public partial class SearchAccountPage : UserControl
    {
        public bool TopLevel { get; internal set; }

        public SearchAccountPage()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string searchQuery = this.searchQueryInput.Text;

            if (searchQuery == "")
            {
                MessageBox.Show("Please enter an account number");
                return;
            }

            try
            {
                int accountId;
                try
                {
                    accountId = int.Parse(searchQuery);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid account number");
                    return;
                }

                Account account = (Account)BaseModel.Find<Account, int>("ïd", accountId); 

                if (account == null)
                {
                    MessageBox.Show("Account not found");
                    return;
                }

                Customer customer;
                try
                {
                    customer = (Customer)BaseModel.Find<Customer, int>("id", account.CustomerId);
                }
                catch (Exception)
                {
                    MessageBox.Show("Customer for the account was not found");
                    return;
                }

                customerNameInput.Text = customer.Id.ToString();
                accountBalanceInput.Text = account.Balance.ToString();

                searchQueryInput.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Account not found");
                return;
            }
        }
    }
}
