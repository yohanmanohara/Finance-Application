using Finance_APP.window_forms;
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

namespace Finance_APP.pages.centerpanel
{
    public partial class EditEmployeeAccount : UserControl
    {
        public EditEmployeeAccount()
        {
            InitializeComponent();
        }
        SqlConnection connectionString = new SqlConnection(@"Data Source=financensbm.database.windows.net;Initial Catalog=finance;Persist Security Info=True;User ID=financeadmin;Password=finance2024$;Encrypt=True");
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fullName = fullnameTextBox.Text;
            DateTime dateOfBirth = dateOfBirthDateTimePicker.Value;
            string gender = genderComboBox.Text;
            string phoneNumberStr = phoneNumberTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            string tinStr = tinTextBox.Text;
            string jobtitle = jobtitleBox1.Text;
            string location = locationTextBox.Text;
            string empstatus = empstatustxt.Text;
            string empid = EmployeeIDtxt.Text;



            string firstname = firstnametxt.Text;
            string lastname = lastnametxt.Text;

            if (string.IsNullOrWhiteSpace(fullName) ||
              string.IsNullOrWhiteSpace(gender) ||
              string.IsNullOrWhiteSpace(phoneNumberStr) ||
              string.IsNullOrWhiteSpace(email) ||
              string.IsNullOrWhiteSpace(address) ||
            string.IsNullOrWhiteSpace(tinStr) ||
            

              string.IsNullOrWhiteSpace(firstname) ||
              string.IsNullOrWhiteSpace(lastname) ||
              string.IsNullOrWhiteSpace(jobtitle) ||
                string.IsNullOrWhiteSpace(location) ||

               string.IsNullOrWhiteSpace(empstatus) 
              
              )


            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(phoneNumberStr, out int phoneNumber) || phoneNumber == 0 ||
                !int.TryParse(tinStr, out int tin) || tin == 0)
            {
                MessageBox.Show("Phone number and TIN must be valid integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            try
            {
                connectionString.Open();


                string insertQuery = "UPDATE userdb SET  fullname = @FullName, firstname =@FirstName, lastname =@LastName, birthday = @DateOfBirth, gender =@Gender, phone_number =@PhoneNumber, address =@Address, tin = @TIN, email =@Email, jobtitle = @JobTitle, workinglocation = @Location,empstatus = @Empstatus WHERE Id =@Emp_ID";


                using (SqlCommand command = new SqlCommand(insertQuery, connectionString))
                {

                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@TIN", tin);
                    command.Parameters.AddWithValue("@JobTitle", jobtitle);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@EmpStatus", empstatus);
                    command.Parameters.AddWithValue("@Emp_ID", empid);



                    command.Parameters.AddWithValue("@FirstName", firstname);
                    command.Parameters.AddWithValue("@LastName", lastname);




                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)


                    {

                        ClearFormInputs();
                        success rr = new success();
                        rr.ShowDialog();
                    }
                    else
                    {
                        ClearFormInputs();
                        errocreateaccount Errocreateaccount = new errocreateaccount();
                        Errocreateaccount.ShowDialog();
                    }
                }
            }
            catch (Exception sqlex)
            {
                /* erropop erro = new erropop();
                 erro.ShowDialog();*/
                //sql Exception
                MessageBox.Show(sqlex.Message);
            }
            finally
            {
                connectionString.Close();
            }



        }
        private void ClearFormInputs()
        {
            fullnameTextBox.Text = "";
            dateOfBirthDateTimePicker.Value = DateTime.Now;
            genderComboBox.SelectedIndex = -1;
            phoneNumberTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            tinTextBox.Text = "";
            empstatustxt.Text = "";
            jobtitleBox1.Text = "";
            locationTextBox.Text = "";

            firstnametxt.Text = "";
            lastnametxt.Text = "";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string emp_id = EmployeeIDtxt.Text;
            string query = "SELECT * FROM userdb WHERE Id = @Emp_ID";

            try
            {
                connectionString.Open();
                using (SqlCommand command = new SqlCommand(query, connectionString))
                {
                    command.Parameters.AddWithValue("@Customer_ID", emp_id);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        fullnameTextBox.Text = reader["fullname"].ToString();
                        firstnametxt.Text = reader["firstname"].ToString();
                        lastnametxt.Text = reader["lastname"].ToString();
                        genderComboBox.Text = reader["gender"].ToString();
                        phoneNumberTextBox.Text = reader["phone_number"].ToString();
                        dateOfBirthDateTimePicker.Value = (DateTime)reader["birthday"];
                        emailTextBox.Text = reader["email"].ToString();
                        addressTextBox.Text = reader["address"].ToString();
                        tinTextBox.Text = reader["tin"].ToString();
                        jobtitleBox1.Text = reader["jobtitle"].ToString();
                        locationTextBox.Text = reader["workinglocation"].ToString();
                        empstatustxt.Text = reader["empstatus"].ToString();



                    }
                    else
                    {
                        MessageBox.Show("No records found for the entered employee id.");
                        // Clear all input fields
                        ClearFormInputs();
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


