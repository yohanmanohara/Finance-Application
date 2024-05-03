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

namespace Finance_APP.pages.centerpanel
{
    public partial class addaccount : UserControl
    {
        public bool TopLevel { get; internal set; }
        private bool customerIdvalid;
        public addaccount()
        {
            InitializeComponent();
        }

        private void addaccount_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (!this.customerIdvalid)
            {
                MessageBox.Show("Please validate the customer ID first");
                return;
            }

            Account createAccount = (Account)BaseModel.New<Account>();

            try { createAccount.CustomerId = int.Parse(customerIdTextBox.Text); }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid customer ID");
                return;
            }
            createAccount.Type = accountTypeTextBox2.Text;
            createAccount.Name = accountNameTextBox3.Text;
            createAccount.Balance = 0;
            

            createAccount.Save();
        }

        private void validateButton1_Click(object sender, EventArgs e)
        {
            Customer customer;
            try
            {
                customer = (Customer)BaseModel.Find<Customer, int>("id", int.Parse(customerIdTextBox.Text));
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Customer for the account was not found");

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }
            this.customerIdvalid = true;
        }
    }
}