using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.Admin
{
    public partial class FrmCustomerPurchaseData : Form
    {
        // In-memory data store
        private DataTable dtPurchases;

        public FrmCustomerPurchaseData()
        {
            InitializeComponent();
            SetupInMemoryData();
        }

        private void SetupInMemoryData()
        {
            dtPurchases = new DataTable("Purchases");
            dtPurchases.Columns.Add("PurchaseID", typeof(int));
            dtPurchases.Columns.Add("CustomerName", typeof(string));
            dtPurchases.Columns.Add("ProductName", typeof(string));
            dtPurchases.Columns.Add("Quantity", typeof(int));
            dtPurchases.Columns.Add("TotalPrice", typeof(decimal));
            dtPurchases.Columns.Add("Date", typeof(DateTime));

            // Populate with demo data
            dtPurchases.Rows.Add(1001, "Alice Smith", "Wireless Mouse", 2, 45.00m, DateTime.Now.AddDays(-1));
            dtPurchases.Rows.Add(1002, "Bob Johnson", "Mechanical Keyboard", 1, 85.50m, DateTime.Now.AddDays(-2));
            dtPurchases.Rows.Add(1003, "Alice Smith", "USB-C Hub", 1, 30.00m, DateTime.Now.AddDays(-3));
            dtPurchases.Rows.Add(1004, "Charlie Brown", "27-inch Monitor", 2, 450.00m, DateTime.Now.AddDays(-4));
            dtPurchases.Rows.Add(1005, "Diana Prince", "Gaming Headset", 1, 120.00m, DateTime.Now.AddDays(-5));
        }

        private void label1_Click(object? sender, EventArgs e)
        {

        }

        private void panel1_Paint(object? sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAdminModule_Click(object? sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object? sender, EventArgs e)
        {
            // Clear filter to show all content
            dtPurchases.DefaultView.RowFilter = string.Empty;
            txtbxEnterText.Text = "Enter Name";
            txtbxEnterText.ForeColor = Color.Gray;

            // Recalculate totals automatically when showing all
            btnLoadPurchases_Click(sender, e);
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string searchText = txtbxEnterText.Text.Trim();
            
            if (!string.IsNullOrWhiteSpace(searchText) && searchText != "Enter Name")
            {
                // Filter the table using the CustomerName column
                dtPurchases.DefaultView.RowFilter = $"CustomerName LIKE '%{searchText}%'";
            }
            else
            {
                dtPurchases.DefaultView.RowFilter = string.Empty;
            }

            // Recalculate totals after search
            btnLoadPurchases_Click(sender, e);
        }

        private void lblSearchText_Click(object? sender, EventArgs e)
        {

        }

        private void txtbxEnterText_TextChanged(object? sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object? sender, EventArgs e)
        {

        }

        private void btnLoadPurchases_Click(object? sender, EventArgs e)
        {
            int totalRecords = dtPurchases.DefaultView.Count;
            int totalQuantity = 0;
            decimal totalAmount = 0;

            // Calculate from the DefaultView to respect the current in-memory search filter
            foreach (DataRowView rowView in dtPurchases.DefaultView)
            {
                if (rowView["Quantity"] != DBNull.Value)
                {
                    totalQuantity += Convert.ToInt32(rowView["Quantity"]);
                }

                if (rowView["TotalPrice"] != DBNull.Value)
                {
                    totalAmount += Convert.ToDecimal(rowView["TotalPrice"]);
                }
            }

            lblTotalRecords0.Text = totalRecords.ToString();
            lblTotalQuantity0.Text = totalQuantity.ToString();
            lblTotalAmount0.Text = totalAmount.ToString("C2");
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            txtbxEnterText.Text = "Enter Name";
            txtbxEnterText.ForeColor = Color.Gray;

            // Use simplified delegates
            txtbxEnterText.Enter += txtbxEnterText_Enter;
            txtbxEnterText.Leave += txtbxEnterText_Leave;

            // Bind the gridview to the in-memory data
            dgvPurchaseRecordTable.DataSource = dtPurchases;

            // Auto-load totals on startup
            btnLoadPurchases_Click(sender, e);
        }

        private void txtbxEnterText_Enter(object? sender, EventArgs e)
        {
            if (txtbxEnterText.Text == "Enter Name")
            {
                txtbxEnterText.Text = "";
                txtbxEnterText.ForeColor = Color.Black;
            }
        }

        private void txtbxEnterText_Leave(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxEnterText.Text))
            {
                txtbxEnterText.Text = "Enter Name";
                txtbxEnterText.ForeColor = Color.Gray;
            }
        }

        private void panel2_Paint(object? sender, PaintEventArgs e)
        {

        }

        private void lblAdminModule_Click_1(object? sender, EventArgs e)
        {

        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}