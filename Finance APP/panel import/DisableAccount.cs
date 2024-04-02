﻿using Finance_APP.window_forms;
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
    public partial class DisableAccount : UserControl
    {
        internal FormBorderStyle FormBorderStyle;

        public bool TopLevel { get; internal set; }
        public DisableAccount()
        {
            InitializeComponent();
        }







        
        





        private void DisableAccount_Load(object sender, EventArgs e)
        {

        }

        private void firstnametxt_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection connectionString = new SqlConnection(@"Data Source=financensbm.database.windows.net;Initial Catalog=finance;Persist Security Info=True;User ID=financeadmin;Password=finance2024$;Encrypt=True");


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // Retrieve input data from textboxes
            string username = usernameTxt.Text;
            string firstname = firstnametxt.Text;
            
            string newEmpStatus = empstatustxt.Text;

            // SQL query to update or insert new job roll data
            string query = "IF EXISTS (SELECT 1 FROM userdb WHERE username = @Username AND firstname = @Firstname) " +
                           "BEGIN " +
                           "   UPDATE userdb SET empstatus = @EmpStatus WHERE username = @Username AND firstname = @Firstname " +
                           "END ";


            try
            {
               
                {
                    // Open the database connection
                    connectionString.Open();

                    // Create a SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand(query, connectionString))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Firstname", firstname);
                        command.Parameters.AddWithValue("@EmpStatus", newEmpStatus);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                          sucess1   sucess2 = new sucess1();    
                            sucess2.ShowDialog();
                        }
                        else
                        {
                           erropop erropop = new erropop();
                            erropop.ShowDialog();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connectionString.Close();
            }
        }

    }
    
    }

