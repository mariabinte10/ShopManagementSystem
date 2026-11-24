using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ShopManagementSystem.Customer
{
    public partial class ProductCart : UserControl
    {
        internal object button1;
        public ProductCart()
        {
            InitializeComponent();

        }

        public void SetData(PictureBox picture, string name, decimal price, decimal discount, decimal nowPreice, string tag)
        {
            if (picture != null)
            {
                PPicture.Image = picture.Image;
            }
            else
            {
                // Optional: Provide a default placeholder image if picture is null
                // PPicture.Image = Properties.Resources.DefaultImage;
                PPicture.Image = null; 
            }

            PName.Text = name;
            PDiscount.Text = discount.ToString("F0") + "%";
            PTag.Text = tag;
            if (discount > 0)
            {
                PPrice.Text = price.ToString("F2");
                PCurrentPrice.Text = (price - (price * discount / 100)).ToString("F2");
                PPrice.Font = new Font(PPrice.Font, FontStyle.Strikeout);
            }
            else
            {
                PPrice.Text = price.ToString("F2");
                PCurrentPrice.Text = nowPreice.ToString("F2");
            }
        }
        public string GetProductName()
        {
            return PName.Text;
        }
        public string GetTag()
        {
            return PTag.Text;
        }
        public decimal GetProductDiscount()
        {
            return decimal.Parse(PDiscount.Text.TrimEnd('%'));
        }

        private void ProductCart_Load(object sender, EventArgs e)
        {

        }

        private void PPicture_Click(object sender, EventArgs e)
        {

        }

     

        public void PCartButton_Click(object sender, EventArgs e)
        {

        }

        private void PName_Click(object sender, EventArgs e)
        {

        }

        private void PTag_Click(object sender, EventArgs e)
        {

        }
    }
}
