
using Finance_APP.panel_import;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Finance_APP.pages.centerpanel
{
    public partial class employeemanegment : UserControl
    {
        public bool TopLevel { get; internal set; }
      

        public employeemanegment()
        {
            InitializeComponent();
            guna2Panel1.Click += Guna2Panel1_Click;

        }
       

        private void InitializeUserControl()
        {
            
            
        }

        private void employeemanegment_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Guna2Panel1_Click(object sender, EventArgs e)
        {
            // Create an instance of DisableAccount form
            DisableAccount otherForm = new DisableAccount();

            // Set the parent of otherForm to guna2Panel4
            otherForm.TopLevel = false;
            otherForm.FormBorderStyle = FormBorderStyle.None;
            otherForm.Dock = DockStyle.Fill;
            guna2Panel4.Controls.Add(otherForm);

            // Show otherForm
            otherForm.Show();
        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
