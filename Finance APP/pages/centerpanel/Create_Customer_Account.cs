using Guna.UI2.WinForms.Suite;
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
    public partial class Create_Customer_Account : UserControl
    {
        public Create_Customer_Account()
        {
            InitializeComponent();
        }

        private void btnSignature_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();

            
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Image";

            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                    string selectedFilePath = openFileDialog.FileName;

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
