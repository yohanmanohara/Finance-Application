using Finance_APP.pages.centerpanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Finance_APP.pages.centerpanel.CashierPages;

namespace Finance_APP.pages.dasbordpanel
{
    public partial class cashierview : UserControl
    {

        public cashierview()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SearchAccountPage fm = new SearchAccountPage();

            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.Show();

            // Access guna2Panel4 directly from the parent form (Maindashbord)
            Maindashbord maindashbord = (Maindashbord)this.ParentForm;
            maindashbord.Guna2Panel4.Controls.Clear(); // Clear existing controls in the panel
            maindashbord.Guna2Panel4.Controls.Add(fm);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            WithdrawPage fm = new WithdrawPage();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.Show();

            // Access guna2Panel4 directly from the parent form (Maindashbord)
            Maindashbord maindashbord = (Maindashbord)this.ParentForm;
            maindashbord.Guna2Panel4.Controls.Clear(); // Clear existing controls in the panel
            maindashbord.Guna2Panel4.Controls.Add(fm);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TransferPage fm = new TransferPage();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.Show();

            // Access guna2Panel4 directly from the parent form (Maindashbord)
            Maindashbord maindashbord = (Maindashbord)this.ParentForm;
            maindashbord.Guna2Panel4.Controls.Clear(); // Clear existing controls in the panel
            maindashbord.Guna2Panel4.Controls.Add(fm);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DepositPage fm = new DepositPage();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.Show();

            // Access guna2Panel4 directly from the parent form (Maindashbord)
            Maindashbord maindashbord = (Maindashbord)this.ParentForm;
            maindashbord.Guna2Panel4.Controls.Clear(); // Clear existing controls in the panel
            maindashbord.Guna2Panel4.Controls.Add(fm);
        }
    }
}
