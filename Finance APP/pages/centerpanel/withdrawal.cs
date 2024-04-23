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
    public partial class withdrawal : UserControl
    {
        public bool TopLevel { get; internal set; }
        public withdrawal()
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           Transaction newtransaction = (Transaction)BaseModel.New<Transaction>
                // If the account exist go on

            try {

                Account checkaccount = (Account)BaseModel.Get<Account>(int.Parse(guna2TextBox6.Text));
                }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                MessageBox.Show(ex.Message);
            }
        }


            // check if the balance is less than the withdrawal amount
            if (checkaccount.Balance >= withdrawalAmount))
     
             ProcessWithdrawal(checkaccount, withdrawalAmount, newtransaction);
              } else {
              MessageBox.Show("Insufficient funds. Your current balance is: " + checkaccount.Balance.ToString("C"));

      
        //reduce the withdrawal amount from the balance
        private void ProcessWithdrawal(Account checkaccount, decimal withdrawalAmount, Transaction newtransaction)

            //Update the modle in the database
           




        }
    }
}
