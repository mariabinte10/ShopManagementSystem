using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ShopManagementSystem.ManagerDashboard
{
    public partial class ManagerDashboardForm : Form
    {
        SqlConnection con = DBConnection.GetConnection();

        private Button activeMenuButton;

        private static readonly Color MenuNormalColor = Color.SteelBlue;
        private static readonly Color MenuActiveColor = Color.DodgerBlue;

        byte[] pic1;
        byte[] pic2;
        byte[] pic3;
        byte[] pic4;



        public ManagerDashboardForm()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

            textBoxNewPrice.Text = "Enter New Price";
            textBoxNewDiscount.Text = "Enter New Discount Amount";
            textBoxSearch.Text = "Search by Product Name";

            textBoxNewPrice.ForeColor = Color.Gray;
            textBoxNewDiscount.ForeColor = Color.Gray;
            textBoxSearch.ForeColor = Color.Gray;

            InitializeDashboard();
        }

        // ================= INITIALIZATION =================

        private void InitializeDashboard()
        {
            HideAllPanels();

            SetActiveMenuButton(buttonManageProducts);

            ShowPanel(panelManageProducts);

            LoadProducts();
        }

        // ================= PANEL MANAGEMENT =================

        private void HideAllPanels()
        {
            panelAddProducts.Visible = false;

            panelManageProducts.Visible = false;
        }

        private void ShowPanel(Panel panel)
        {
            HideAllPanels();

            panel.Visible = true;
        }

        // ================= MENU BUTTON DESIGN =================

        private void SetActiveMenuButton(Button button)
        {
            if (activeMenuButton != null)
            {
                activeMenuButton.BackColor = MenuNormalColor;
            }

            activeMenuButton = button;

            if (activeMenuButton != null)
            {
                activeMenuButton.BackColor = MenuActiveColor;
            }
        }

        // ================= BUTTON EVENTS =================



        private void buttonAddProducts_Click_1(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);

            ShowPanel(panelAddProducts);
        }
        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);


            ShowPanel(panelManageProducts);

            LoadProducts();
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        //------------------ PRODUCT ADDITION LOGIC =================

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);

                MemoryStream ms = new MemoryStream();

                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                pic1 = ms.ToArray();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);

                MemoryStream ms = new MemoryStream();

                pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);

                pic2 = ms.ToArray();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(ofd.FileName);

                MemoryStream ms = new MemoryStream();

                pictureBox3.Image.Save(ms, pictureBox3.Image.RawFormat);

                pic3 = ms.ToArray();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(ofd.FileName);

                MemoryStream ms = new MemoryStream();

                pictureBox4.Image.Save(ms, pictureBox4.Image.RawFormat);

                pic4 = ms.ToArray();
            }
        }

        private void buttonAddProduct2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO Products
        (ID, Name, Description,
        Pic1, Pic2, Pic3, Pic4,
        Price, Discount)

        VALUES

        (@ID, @Name, @Description,
        @Pic1, @Pic2, @Pic3, @Pic4,
        @Price, @Discount)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Description", richTextBox1.Text);

                cmd.Parameters.AddWithValue("@Pic1", (object)pic1 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Pic2", (object)pic2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Pic3", (object)pic3 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Pic4", (object)pic4 ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@Discount", decimal.Parse(textBox4.Text));

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Product Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        // ------------------- END OF PRODUCT ADDITION LOGIC =================



        //---------------------- Start of manage products logic-----------------------


        private void dvgProducts_SelectionChanged(object sender, EventArgs e)
        {
            ShowSelectedProductImages();
        }


        private void LoadProducts()
        {
            try
            {
                string query = @"SELECT
                        ID,
                        Name,
                        Description,
                        Price,
                        Discount
                        FROM Products";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dvgProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ShowSelectedProductImages()
        {
            try
            {
                if (dvgProducts.CurrentRow == null)
                    return;

                string id =
                    dvgProducts.CurrentRow.Cells["ID"].Value.ToString();

                string query =
                    "SELECT Pic1, Pic2, Pic3, Pic4 FROM Products WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    LoadImage(reader["Pic1"], pictureBox5);
                    LoadImage(reader["Pic2"], pictureBox6);
                    LoadImage(reader["Pic3"], pictureBox7);
                    LoadImage(reader["Pic4"], pictureBox8);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }

        private void LoadImage(object imageData, PictureBox pictureBox)
        {
            if (imageData != DBNull.Value)
            {
                byte[] bytes = (byte[])imageData;

                MemoryStream ms = new MemoryStream(bytes);

                pictureBox.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox.Image = null;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgProducts.CurrentRow == null)
                {
                    MessageBox.Show("Select a product first");
                    return;
                }

                string id =
                    dvgProducts.CurrentRow.Cells["ID"].Value.ToString();

                bool updatePrice =
                    !string.IsNullOrWhiteSpace(textBoxNewPrice.Text) &&
                    textBoxNewPrice.Text != "Enter New Price";

                bool updateDiscount =
                    !string.IsNullOrWhiteSpace(textBoxNewDiscount.Text) &&
                    textBoxNewDiscount.Text != "Enter New Discount Amount";

                if (!updatePrice && !updateDiscount)
                {
                    MessageBox.Show("Enter at least one value to update");
                    return;
                }

                string query = "UPDATE Products SET ";

                if (updatePrice)
                {
                    query += "Price=@Price";
                }

                if (updateDiscount)
                {
                    if (updatePrice)
                    {
                        query += ", ";
                    }

                    query += "Discount=@Discount";
                }

                query += " WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(query, con);

                if (updatePrice)
                {
                    cmd.Parameters.AddWithValue(
                        "@Price",
                        decimal.Parse(textBoxNewPrice.Text));
                }

                if (updateDiscount)
                {
                    cmd.Parameters.AddWithValue(
                        "@Discount",
                        decimal.Parse(textBoxNewDiscount.Text));
                }

                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Product Updated Successfully");

                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT
                        ID,
                        Name,
                        Description,
                        Price,
                        Discount
                        FROM Products
                        WHERE Name LIKE @Name";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@Name",
                    "%" + textBoxSearch.Text + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                dvgProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgProducts.CurrentRow == null)
                {
                    MessageBox.Show("Select a product first");
                    return;
                }

                string id =
                    dvgProducts.CurrentRow.Cells["ID"].Value.ToString();

                string query =
                    "DELETE FROM Products WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Product Deleted");

                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }

        private void textBoxNewPrice_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPrice.Text == "Enter New Price")
            {
                textBoxNewPrice.Text = "";
                textBoxNewPrice.ForeColor = Color.Black;
            }
        }

        private void textBoxNewPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNewPrice.Text))
            {
                textBoxNewPrice.Text = "Enter New Price";
                textBoxNewPrice.ForeColor = Color.Gray;
            }
        }

        private void textBoxNewDiscount_Enter(object sender, EventArgs e)
        {
            if (textBoxNewDiscount.Text == "Enter New Discount Amount")
            {
                textBoxNewDiscount.Text = "";
                textBoxNewDiscount.ForeColor = Color.Black;
            }
        }

        private void textBoxNewDiscount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNewDiscount.Text))
            {
                textBoxNewDiscount.Text = "Enter New Discount Amount";
                textBoxNewDiscount.ForeColor = Color.Gray;
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search by Product Name")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Search by Product Name";
                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            // implement logout logic here, for example:
            this.Hide();
            LoginReg.AdminAndManagerLogin loginForm = new LoginReg.AdminAndManagerLogin();
            loginForm.Show();


        }
    }
}