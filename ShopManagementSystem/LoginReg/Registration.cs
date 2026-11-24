using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ShopManagementSystem.LoginReg
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxname.Text.Trim();
            string phone = textBoxnumber.Text.Trim();
            string gender = radioButtonmale.Checked ? "Male" : "Female";
            string password = textBoxpassword.Text.Trim();
            

            if (name == "" || phone == "" || password == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            string query = "INSERT INTO Customers (Username, FullName, PhoneNumber, Gender, Password) VALUES (@Username, @FullName, @PhoneNumber, @Gender, @Password)";

            // Using the centralized connection string from DBConnection
            using (var con = DBConnection.GetConnection())
            {
                using (var cmd = new SqlCommand(query, con))
                {
                    // Use 'name' for both Username and FullName since there isn't a separate Username field in the UI yet
                    cmd.Parameters.AddWithValue("@Username", name);
                    cmd.Parameters.AddWithValue("@FullName", name);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Registration successful!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        CustomerLogin login = new CustomerLogin();
                        login.Show();
                        this.Hide();
                    }
                    catch (SqlException sqlEx)
                    {
                        // SQL Error code 2627 indicates a Unique Constraint violation (Username or PhoneNumber already exists)
                        if (sqlEx.Number == 2627) 
                        {
                            MessageBox.Show("An account with this Name or Phone Number already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("A database error occurred: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerLogin back = new CustomerLogin();
            back.Show();
            this.Hide();
        }
    }
}
