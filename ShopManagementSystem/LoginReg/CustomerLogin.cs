using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagementSystem.Customer;

namespace ShopManagementSystem.LoginReg
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Password FROM Customers WHERE Username = @Username;";

            using (var con = DBConnection.GetConnection())
            {
                using (var cmd = new SqlCommand(query, con)) 
                {
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text.Trim());

                    try
                    {
                        con.Open();
                        
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPassword = reader["Password"].ToString();
                                string typedPassword = textBox2.Text.Trim();

                                if (dbPassword == typedPassword)
                                {
                                    MessageBox.Show("Login successful! Welcome " + textBox1.Text.Trim() + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Open the customer dashboard form here
                                    CustomerPage customerDashboard = new CustomerPage();
                                    customerDashboard.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registernow = new Registration();
            registernow.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChooseUserForLogin back = new ChooseUserForLogin();
            back.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
