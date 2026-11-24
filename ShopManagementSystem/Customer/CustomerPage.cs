using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagementSystem.LoginReg;

namespace ShopManagementSystem.Customer
{
    public partial class CustomerPage : Form
    {
        // Cart lists
        List<string> cartNames = new List<string>();
        List<decimal> cartPrices = new List<decimal>();
        List<int> cartQty = new List<int>();
        decimal totals = 0;

        public CustomerPage()
        {
            InitializeComponent();
            LoadProducts();
            InitializeCheckoutPanel(); // Initialize the checkout panel as hidden
        }

        private void InitializeCheckoutPanel()
        {
            // Initially hide the checkout panel
            CheackOutPanel.Visible = false;
            panel4.Visible = false;
            CheackOutPanel.AutoScroll = true;
            CheackOutPanel.BackColor = Color.WhiteSmoke;
            CheackOutPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void LoadProducts()
        {
            try
            {
                // In-memory demo data
                var demoProducts = new[]
                {
                    new { Id = "P001", Name = "Gaming Laptop", Price = 1200.00m, Discount = 10.00m, Tag = "computer" },
                    new { Id = "P002", Name = "Running Shoes", Price = 80.00m, Discount = 5.00m, Tag = "gear" },
                    new { Id = "P003", Name = "Smart Watch", Price = 250.00m, Discount = 15.00m, Tag = "gear" },
                    new { Id = "P004", Name = "Backpack", Price = 45.00m, Discount = 0.00m, Tag = "bag" },
                    new { Id = "P005", Name = "Mechanical Keyboard", Price = 150.00m, Discount = 20.00m, Tag = "computer" },
                    new { Id = "P006", Name = "Cotton T-Shirt", Price = 25.00m, Discount = 0.00m, Tag = "cloth" },
                    new { Id = "P007", Name = "Gym Dumbbells", Price = 60.00m, Discount = 5.00m, Tag = "gym" }
                };

                foreach (var prod in demoProducts)
                {
                    // Get product data
                    string Id = prod.Id;
                    string name = prod.Name;
                    decimal price = prod.Price;
                    decimal discount = prod.Discount;

                    // Create product card panel
                    ProductCart card = new ProductCart();
                    card.Tag = prod.Tag; // Use Tag for search functionality

                    decimal finalPrice = price;

                    if (discount > 0)
                    {
                        finalPrice = price - (price * discount / 100);
                    }

                    // Demo data doesn't use real images, passing null
                    card.SetData(
                        null,
                        name,
                        price,
                        discount,
                        finalPrice,
                        Id
                    );

                    Button btnCart = new Button();
                    btnCart.Text = "Add to Cart";
                    btnCart.Size = new Size(180, 30);
                    btnCart.Location = new Point(10, 245);
                    btnCart.BackColor = Color.Orange;
                    btnCart.Click += (s, e) =>
                    {
                        // Check if product already in cart
                        int index = cartNames.IndexOf(name);
                        if (index >= 0)
                        {
                            cartQty[index]++;
                        }
                        else
                        {
                            cartNames.Add(name);
                            cartPrices.Add(finalPrice);
                            cartQty.Add(1);
                        }

                        MessageBox.Show(name + " added to cart!\nPrice: $" + finalPrice.ToString("F2"), "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowCheckoutPanel();
                    };

                    card.Controls.Add(btnCart);
                    flowLayoutPanel2.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        string searchTag = "";
        string searchName = "";
        string searchDiscount = "";

        private void SearchProducts(string searchText)
        {
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control is ProductCart card)
                {
                    searchName = card.GetProductName();
                    bool matchesName = string.IsNullOrWhiteSpace(searchText) ||
                               card.GetProductName().ToLower().Contains(searchText.ToLower());

                    bool matchesTag = string.IsNullOrWhiteSpace(searchTag) ||
                                      (card.Tag != null && card.Tag.ToString().ToLower().Contains(searchTag.ToLower()));

                    bool matchesDiscount = string.IsNullOrWhiteSpace(searchDiscount) && card.GetProductDiscount() > 0;

                    // ALL conditions must be true (AND logic)
                    bool isMatch = matchesName && matchesTag && matchesDiscount;

                    card.Visible = isMatch;
                }
            }
        }

        // Show the checkout panel with cart items
        private void ShowCheckoutPanel()
        {
            if (cartNames.Count == 0)
            {
                return;
            }

            CheackOutPanel.Visible = true;
            panel4.Visible = true;
            CheackOutPanel.BringToFront();
            UpdateCheckoutPanel();
        }

        // Hide checkout panel
        private void HideCheckoutPanel()
        {
            CheackOutPanel.Visible = false;
            panel4.Visible = false;
        }

        private void UpdateCheckoutPanel()
        {
            // 1. Clear all existing cart item controls FIRST
            var controlsToRemove = CheackOutPanel.Controls.OfType<CartUI>().ToList();
            foreach (var control in controlsToRemove)
            {
                CheackOutPanel.Controls.Remove(control);
                control.Dispose(); // Clean up resources
            }

            decimal total = 0;
            for (int i = 0; i < cartNames.Count; i++)
            {
                CartUI cartUI = new CartUI();

                decimal itemTotal = cartPrices[i] * cartQty[i];
                cartUI.SetLables(cartNames[i], cartPrices[i], cartQty[i], itemTotal);

                int index = i; // Capture index for closure

                // Minus button handler
                cartUI.GetCMinusButton().Click += (s, e) =>
                {
                    if (cartQty[index] > 1)
                    {
                        cartQty[index]--;
                        UpdateCheckoutPanel(); // This will re-render everything
                    }
                    else if (cartQty[index] == 1)
                    {
                        // Remove item when quantity would become 0
                        cartNames.RemoveAt(index);
                        cartPrices.RemoveAt(index);
                        cartQty.RemoveAt(index);
                        UpdateCheckoutPanel();
                        if (cartNames.Count == 0)
                        {
                            HideCheckoutPanel();
                        }
                    }
                };

                // Plus button handler
                cartUI.GetCPlusButton().Click += (s, e) =>
                {
                    cartQty[index]++;
                    UpdateCheckoutPanel();
                };

                CheackOutPanel.Controls.Add(cartUI);
                total += itemTotal;
            }

            // 5. Update total label
            CTotalAmount.Text = "Total: $" + total.ToString("F2");
            totals = total;
        }

        // Helper method to update panel size when form resizes
        private void HomePage_Resize(object sender, EventArgs e)
        {
            if (CheackOutPanel.Visible)
            {
                UpdateCheckoutPanel();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(textBox2.Text);
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CheackOutPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Cbuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Total Amount: $" + totals.ToString("F2") + "\n\nConfirm your purchase?",
                "Checkout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("✅ Purchase Successful!\n\nThank you for shopping with us!",
                    "Order Confirmed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                cartNames.Clear();
                cartPrices.Clear();
                cartQty.Clear();
                HideCheckoutPanel();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("❌ Purchase Cancelled.",
                    "Order Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            searchTag = "computer";
            SearchProducts(searchName);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
        }

        private void ResetAll_Click(object sender, EventArgs e)
        {
            searchDiscount = "";
            searchTag = "";
            searchName = "";
            textBox2.Text = "";
            SearchProducts(searchName);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            searchTag = "bag";
            SearchProducts(searchName);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            searchTag = "gym";
            SearchProducts(searchName);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            searchTag = "cloth";
            SearchProducts(searchName);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            //logout implementation

            this.Hide();
            ChooseUserForLogin login = new ChooseUserForLogin();
            login.Show();


        }
    }
}