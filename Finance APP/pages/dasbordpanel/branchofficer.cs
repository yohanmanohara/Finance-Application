using Finance_APP.pages.centerpanel;
using Finance_APP.panel_import;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using System.Windows.Forms;

namespace Finance_APP.pages.dasbordpanel
{
    public partial class branchofficer : UserControl
    {




        public branchofficer()
        {
            InitializeComponent();
           
        }

        private void branchofficer_Load(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UpdateAccount fm = new UpdateAccount();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.Show();

            // Access guna2Panel4 directly from the parent form (Maindashbord)
            Maindashbord maindashbord = (Maindashbord)this.ParentForm;
            maindashbord.Guna2Panel4.Controls.Clear(); // Clear existing controls in the panel
            maindashbord.Guna2Panel4.Controls.Add(fm); 



        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CreateCustomer fm = new CreateCustomer();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.Show();

            // Access guna2Panel4 directly from the parent form (Maindashbord)
            Maindashbord maindashbord = (Maindashbord)this.ParentForm;
            maindashbord.Guna2Panel4.Controls.Clear(); // Clear existing controls in the panel
            maindashbord.Guna2Panel4.Controls.Add(fm);




        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            searchaccout fm = new searchaccout();
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
            Customerdatabase fm = new Customerdatabase();
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
            Personal_loan_1 fm = new Personal_loan_1();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.Show();

            // Access guna2Panel4 directly from the parent form (Maindashbord)
            Maindashbord maindashbord = (Maindashbord)this.ParentForm;
            maindashbord.Guna2Panel4.Controls.Clear(); // Clear existing controls in the panel
            maindashbord.Guna2Panel4.Controls.Add(fm);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            addaccount fm = new addaccount();
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
