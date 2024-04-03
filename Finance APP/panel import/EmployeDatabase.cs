using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_APP.panel_import
{
    public partial class EmployeDatabase : UserControl
    {
        internal FormBorderStyle FormBorderStyle;

        public bool TopLevel { get; internal set; }



        public EmployeDatabase()
        {
            InitializeComponent();
            DisplayData();
        }

        private void EmployeDatabase_Load(object sender, EventArgs e)
        {



        }
        SqlConnection connectionString = new SqlConnection(@"Data Source=financensbm.database.windows.net;Initial Catalog=finance;Persist Security Info=True;User ID=financeadmin;Password=finance2024$;Encrypt=True");

        private void DisplayData()
        {
            try
            {
                // Create a connection to the database
                
                {
                    // Open the connection
                    connectionString.Open();

                    // SQL query to select data from a table
                    string query = "SELECT * FROM userdb";

                    // Create a data adapter and a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                    DataTable dataTable = new DataTable();

                    // Fill the data table with the data from the adapter
                    adapter.Fill(dataTable);

                    // Bind the data table to the DataGridView
                    guna2DataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
