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

namespace Finance_APP.pages.dasbordpanel
{
    public partial class hrofficer : UserControl
    {
        public hrofficer()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            addemployee fm = new addemployee();
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

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            employeemanegment fm = new employeemanegment();
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
