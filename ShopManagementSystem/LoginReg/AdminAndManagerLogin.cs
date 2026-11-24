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
using ShopManagementSystem.ManagerDashboard;
using ShopManagementSystem.Admin;

namespace ShopManagementSystem.LoginReg
{
    public partial class AdminAndManagerLogin : Form
    {
        public AdminAndManagerLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password;";

            // Using the centralized connection string from DBConnection
            using (var con = DBConnection.GetConnection())
            {
                using (var cmd = new SqlCommand(query, con))
                {
                    // Replace textBox1 and textBox2 with your respective username and password textboxes
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar(); // Retrieves the 'Role' if login is successful

                        if (result != null)
                        {
                            string role = result.ToString();
                            MessageBox.Show("Welcome, " + textBox1.Text + "! You have logged in as: " + role, "Staff Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            // You can now route the user to different dashboards based on their role
                            
                            if (role == "Admin")
                            {
                                // implement admin dashboard form and show it here
                                    AdminDashboard adminForm = new AdminDashboard();
                                    adminForm.Show();
                            }
                            else if (role == "Manager")
                            {
                                ManagerDashboardForm managerForm = new ManagerDashboardForm();
                                managerForm.Show();
                            }
                            this.Hide();
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseUserForLogin back = new ChooseUserForLogin();
            back.Show();
            this.Hide();
        }
    }
}
