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
    public partial class Customerdatabase : UserControl
    {
        public bool TopLevel { get; internal set; }
        public Customerdatabase()
        {
            InitializeComponent();
            DisplayData();
        }

        private void Customerdatabase_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection connectionString = new SqlConnection(@"Data Source=financensbm.database.windows.net;Initial Catalog=finance;Persist Security Info=True;User ID=financeadmin;Password=finance2024$;Encrypt=True");

        private void DisplayData()
        {
            try
            {

                {
                    connectionString.Open();
                    string query = "SELECT * FROM customer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    guna2DataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
