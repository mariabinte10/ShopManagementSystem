using System;
using System.Data;
using System.Windows.Forms;

namespace ShopManagementSystem.Admin
{ 
    public partial class AdminManager : Form
    {
        // In-memory data table to act as our database
        private DataTable dtManagers;

        public AdminManager()
        {
            InitializeComponent();
            SetupInMemoryData();
            this.PopulateGridView();
        }

        private void SetupInMemoryData()
        {
            // Initialize the structure of our in-memory table
            dtManagers = new DataTable("Shop");
            dtManagers.Columns.Add("ID", typeof(int));
            dtManagers.Columns.Add("Name", typeof(string));
            dtManagers.Columns.Add("Gender", typeof(string));
            dtManagers.Columns.Add("Email", typeof(string));
            dtManagers.Columns.Add("Salary", typeof(decimal));

            // Add demo data
            dtManagers.Rows.Add(1, "Alice Smith", "Female", "alice@shop.com", 65000);
            dtManagers.Rows.Add(2, "Bob Johnson", "Male", "bob@shop.com", 58000);
            dtManagers.Rows.Add(3, "Sarah Williams", "Female", "sarah@shop.com", 72000);
            dtManagers.Rows.Add(4, "Mike Brown", "Male", "mike@shop.com", 60000);
        }

        private void PopulateGridView(string filterExpression = "")
        {
            DataView dv = dtManagers.DefaultView;
            
            // Apply search filter if provided
            dv.RowFilter = filterExpression;
            dv.Sort = "ID ASC";

            this.dgvManager.AutoGenerateColumns = true;
            this.dgvManager.DataSource = dv;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
       
        }

        private void txtSearchTitle_TextChanged(object sender, EventArgs e)
        {
            // Update filter using RowFilter syntax based on the auto search text
            string filter = "";
            if (!string.IsNullOrWhiteSpace(this.txtAutoSearch.Text))
            {
                filter = $"Name LIKE '{this.txtAutoSearch.Text}%'";
            }
            this.PopulateGridView(filter);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                if (!int.TryParse(this.txtNewId.Text, out int newId))
                {
                    MessageBox.Show("ID must be a valid number.");
                    return;
                }

                // Check if ID already exists
                DataRow[] existingRows = dtManagers.Select($"ID = {newId}");
                if (existingRows.Length > 0)
                {
                    MessageBox.Show(" ID already exists");
                    return;
                }
                else
                {
                    // Insert into memory
                    if (!decimal.TryParse(this.txtSalary.Text, out decimal salary))
                    {
                        MessageBox.Show("Salary must be a valid decimal number.");
                        return;
                    }

                    dtManagers.Rows.Add(newId, this.txtNewName.Text, this.cmbGender.Text, this.txtEmail.Text, salary);
                    MessageBox.Show("Data has been added");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void ClearAll()
        {
            this.txtNewId.Clear();
            this.txtNewName.Clear();
            if (this.cmbGender.Items.Count > 0)
            {
                this.cmbGender.SelectedIndex = 0;
            }
            this.txtEmail.Clear();
            this.txtSalary.Clear();
            this.txtAutoSearch.Text = "";
            this.dgvManager.ClearSelection();
        }

        private bool IsValidToAdd()
        {
            if (string.IsNullOrEmpty(this.txtNewId.Text) || string.IsNullOrEmpty(this.txtNewName.Text) ||
                string.IsNullOrEmpty(this.txtEmail.Text) || string.IsNullOrEmpty(this.txtSalary.Text) ||
                string.IsNullOrEmpty(this.cmbGender.Text))
                return false;
            else
                return true;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {
                    MessageBox.Show("Please select and fill all fields");
                    return;
                }

                if (!int.TryParse(this.txtNewId.Text, out int targetId))
                {
                    MessageBox.Show("ID must be a valid number.");
                    return;
                }

                // Find existing row in memory
                DataRow[] rowsToUpdate = dtManagers.Select($"ID = {targetId}");
                if (rowsToUpdate.Length == 0)
                {
                    MessageBox.Show("Record with this ID was not found to update.");
                    return;
                }

                if (!decimal.TryParse(this.txtSalary.Text, out decimal salary))
                {
                    MessageBox.Show("Salary must be a valid decimal number.");
                    return;
                }

                // Update row
                DataRow row = rowsToUpdate[0];
                row["Name"] = this.txtNewName.Text;
                row["Gender"] = this.cmbGender.Text;
                row["Email"] = this.txtEmail.Text;
                row["Salary"] = salary;

                dtManagers.AcceptChanges();
                MessageBox.Show("Data has been updated");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvManager.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var idStr = this.dgvManager.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvManager.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                // Delete from memory
                DataRow[] rowsToDelete = dtManagers.Select($"ID = {idStr}");
                if (rowsToDelete.Length > 0)
                {
                    rowsToDelete[0].Delete();
                    dtManagers.AcceptChanges();
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");
                }
                else
                {
                    MessageBox.Show("Data hasn't been deleted");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminDashboard hp = new AdminDashboard();
            hp.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblManagers_Click(object sender, EventArgs e)
        {

        }

        private void dgvManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvManager_Click(object sender, EventArgs e)
        {
            if (dgvManager.SelectedRows.Count > 0)
            {
                txtNewId.Text = dgvManager.SelectedRows[0].Cells[0].Value.ToString();
                txtNewName.Text = dgvManager.SelectedRows[0].Cells[1].Value.ToString();
                cmbGender.Text = dgvManager.SelectedRows[0].Cells[2].Value.ToString();
                txtEmail.Text = dgvManager.SelectedRows[0].Cells[3].Value.ToString();
                txtSalary.Text = dgvManager.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
