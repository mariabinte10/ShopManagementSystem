using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagementSystem.LoginReg;

namespace ShopManagementSystem.Admin
{
    public partial class AdminDashboard : Form
    {
        // ================= IN-MEMORY DATA STORES =================
        private List<string> _users = new List<string>();
        private List<string> _managers = new List<string>();
        private List<string> _categories = new List<string>();
        private List<string> _products = new List<string>();
        private int _totalOrders = 0;
        // =========================================================

        public AdminDashboard()
        {
            InitializeComponent();
        }

        public AdminDashboard(string name) : this()
        {
            //this.lblAdminportal.Text += name.ToUpper();
            //this.lp = lp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // Simulate logging out by closing the dashboard and showing the login form
            this.Close();
            ChooseUserForLogin loginForm = new ChooseUserForLogin();
            loginForm.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            // Simulate adding a category in memory
            int nextId = _categories.Count + 1;
            string newCategory = $"Category {nextId}";
            _categories.Add(newCategory);
            
            MessageBox.Show($"New '{newCategory}' added successfully!\nTotal Categories: {_categories.Count}", "In-Memory Category System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Simulate adding a user in memory
            int nextId = _users.Count + 1;
            string newUser = $"User {nextId}";
            _users.Add(newUser);

            MessageBox.Show($"New '{newUser}' registered successfully!\nTotal Users: {_users.Count}", "In-Memory User System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show($"Total System Users: {_users.Count}\nTotal System Managers: {_managers.Count}", "In-Memory System Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Store active listings: {_products.Count} Products", "In-Memory Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAdminportal_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminManager ap = new AdminManager();
            ap.Visible = true;
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            // Simulate adding a manager in memory
            int nextId = _managers.Count + 1;
            string newManager = $"Manager {nextId}";
            _managers.Add(newManager);

            MessageBox.Show($"New '{newManager}' added successfully!\nTotal Managers: {_managers.Count}", "In-Memory Manager System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // Form obj. CustomerPurchaseData  implement
            FrmCustomerPurchaseData reportForm = new FrmCustomerPurchaseData();
            reportForm.Show();

        }

        private void lblTechShopApp_Click(object sender, EventArgs e)
        {

        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            // Simulate a new order being placed
            _totalOrders++;
            MessageBox.Show($"New order placed in-memory!\nTotal Orders Pending: {_totalOrders}", "In-Memory Order System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            // Simulate adding a product
            int nextId = _products.Count + 1;
            string newProduct = $"Product {nextId}";
            _products.Add(newProduct);

            MessageBox.Show($"New '{newProduct}' added successfully!\nTotal Products: {_products.Count}", "In-Memory Product System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            btnReport_Click(sender, e); // Re-use the report generator logic
        }
    }
}
