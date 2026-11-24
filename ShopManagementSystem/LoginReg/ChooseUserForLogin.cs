using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.LoginReg
{
    public partial class ChooseUserForLogin : Form
    {
        string selectedRole = "";
        public ChooseUserForLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedRole = "Customer";
            button1.BackColor = Color.LightBlue;
            button2.BackColor = Color.White;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedRole = "User";

            button2.BackColor = Color.LightBlue;
            button1.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedRole == "Customer")
            {
                CustomerLogin login = new CustomerLogin();
                login.Show();
                this.Hide();
            }
            else if (selectedRole == "User")
            {
                AdminAndManagerLogin login = new AdminAndManagerLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select an option first");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
