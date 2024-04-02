
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



   

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
     
        private void Guna2Panel2_Click(object sender, EventArgs e)
        {
            ViewAccount otherForm = new ViewAccount();
            otherForm.TopLevel = false;
            otherForm.FormBorderStyle = FormBorderStyle.None;
            otherForm.Dock = DockStyle.Fill;
            guna2Panel4.Controls.Add(otherForm);
            otherForm.Show();
            guna2PictureBox4.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DisableAccount otherForm = new DisableAccount();
            otherForm.TopLevel = false;
            otherForm.FormBorderStyle = FormBorderStyle.None;
            otherForm.Dock = DockStyle.Fill;
            guna2Panel4.Controls.Clear();
            guna2Panel4.Controls.Add(otherForm);
            otherForm.Show();
            guna2PictureBox4.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            ViewAccount otherForm = new ViewAccount();
            otherForm.TopLevel = false;
            otherForm.FormBorderStyle = FormBorderStyle.None;
            otherForm.Dock = DockStyle.Fill;
            guna2Panel4.Controls.Clear();
            guna2Panel4.Controls.Add(otherForm);
            otherForm.Show();
            guna2PictureBox4.Hide();
        }
    }
}
