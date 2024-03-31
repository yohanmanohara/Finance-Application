using Finance_APP.pages.centerpanel;
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
    public partial class BranchOfficer : UserControl
    {




        public BranchOfficer()
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
            MainDashbord maindashbord = (MainDashbord)this.ParentForm;
            maindashbord.Guna2Panel4.Controls.Clear(); // Clear existing controls in the panel
            maindashbord.Guna2Panel4.Controls.Add(fm); 



        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CreateCustomerAccount fm = new CreateCustomerAccount();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.Show();

            // Access guna2Panel4 directly from the parent form (Maindashbord)
            MainDashbord maindashbord = (MainDashbord)this.ParentForm;
            maindashbord.Guna2Panel4.Controls.Clear(); // Clear existing controls in the panel
            maindashbord.Guna2Panel4.Controls.Add(fm);




        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SearchAccout fm = new SearchAccout();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.Show();

            // Access guna2Panel4 directly from the parent form (Maindashbord)
            MainDashbord maindashbord = (MainDashbord)this.ParentForm;
            maindashbord.Guna2Panel4.Controls.Clear(); // Clear existing controls in the panel
            maindashbord.Guna2Panel4.Controls.Add(fm);


        }
    }
}
