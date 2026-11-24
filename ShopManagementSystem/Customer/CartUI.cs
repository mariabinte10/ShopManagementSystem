using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.Customer
{
    public partial class CartUI : UserControl
    {
        public CartUI()
        {
            InitializeComponent();
        }

        private void CartUI_Load(object sender, EventArgs e)
        {

        }
        public void SetLables(string name, decimal price, int quality, decimal total)
        {
            CProduct.Text = name;
            CPrice.Text = price.ToString("F2");
            CCount.Text = quality.ToString();
            CTotal.Text = total.ToString("F2");
        }

        public Button GetCPlusButton()
        {
            return CPlus;
        }
        public Button GetCMinusButton()
        {
            return CMinus;
        }
        public string GetProductName()
        {
            return CProduct.Text;
        }
        private void CPlus_Click(object sender, EventArgs e)
        {

        }

        private void CMinus_Click(object sender, EventArgs e)
        {

        }
    }
}
