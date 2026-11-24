namespace ShopManagementSystem.Customer
{
    partial class CartUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.CPlus = new System.Windows.Forms.Button();
            this.CMinus = new System.Windows.Forms.Button();
            this.CTotal = new System.Windows.Forms.Label();
            this.CPrice = new System.Windows.Forms.Label();
            this.CCount = new System.Windows.Forms.Label();
            this.CProduct = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CPlus);
            this.panel4.Controls.Add(this.CMinus);
            this.panel4.Controls.Add(this.CTotal);
            this.panel4.Controls.Add(this.CPrice);
            this.panel4.Controls.Add(this.CCount);
            this.panel4.Controls.Add(this.CProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 79);
            this.panel4.TabIndex = 2;
            // 
            // CPlus
            // 
            this.CPlus.Location = new System.Drawing.Point(326, 28);
            this.CPlus.Name = "CPlus";
            this.CPlus.Size = new System.Drawing.Size(19, 20);
            this.CPlus.TabIndex = 11;
            this.CPlus.Text = "+";
            this.CPlus.UseVisualStyleBackColor = true;
            this.CPlus.Click += new System.EventHandler(this.CPlus_Click);
            // 
            // CMinus
            // 
            this.CMinus.Location = new System.Drawing.Point(277, 28);
            this.CMinus.Name = "CMinus";
            this.CMinus.Size = new System.Drawing.Size(19, 20);
            this.CMinus.TabIndex = 10;
            this.CMinus.Text = "-";
            this.CMinus.UseVisualStyleBackColor = true;
            this.CMinus.Click += new System.EventHandler(this.CMinus_Click);
            // 
            // CTotal
            // 
            this.CTotal.AutoSize = true;
            this.CTotal.BackColor = System.Drawing.Color.White;
            this.CTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTotal.ForeColor = System.Drawing.Color.Green;
            this.CTotal.Location = new System.Drawing.Point(390, 28);
            this.CTotal.Name = "CTotal";
            this.CTotal.Size = new System.Drawing.Size(34, 15);
            this.CTotal.TabIndex = 9;
            this.CTotal.Text = "Total";
            // 
            // CPrice
            // 
            this.CPrice.AutoSize = true;
            this.CPrice.BackColor = System.Drawing.Color.White;
            this.CPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPrice.ForeColor = System.Drawing.Color.DimGray;
            this.CPrice.Location = new System.Drawing.Point(143, 28);
            this.CPrice.Name = "CPrice";
            this.CPrice.Size = new System.Drawing.Size(37, 15);
            this.CPrice.TabIndex = 7;
            this.CPrice.Text = "Price";
            // 
            // CCount
            // 
            this.CCount.AutoSize = true;
            this.CCount.BackColor = System.Drawing.Color.White;
            this.CCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CCount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCount.ForeColor = System.Drawing.Color.Black;
            this.CCount.Location = new System.Drawing.Point(302, 28);
            this.CCount.Name = "CCount";
            this.CCount.Size = new System.Drawing.Size(18, 20);
            this.CCount.TabIndex = 8;
            this.CCount.Text = "1";
            // 
            // CProduct
            // 
            this.CProduct.AutoSize = true;
            this.CProduct.BackColor = System.Drawing.Color.White;
            this.CProduct.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CProduct.ForeColor = System.Drawing.Color.Black;
            this.CProduct.Location = new System.Drawing.Point(17, 28);
            this.CProduct.Name = "CProduct";
            this.CProduct.Size = new System.Drawing.Size(64, 18);
            this.CProduct.TabIndex = 6;
            this.CProduct.Text = "Product";
            // 
            // CartUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "CartUI";
            this.Size = new System.Drawing.Size(463, 79);
            this.Load += new System.EventHandler(this.CartUI_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button CPlus;
        private System.Windows.Forms.Button CMinus;
        private System.Windows.Forms.Label CTotal;
        private System.Windows.Forms.Label CPrice;
        private System.Windows.Forms.Label CCount;
        private System.Windows.Forms.Label CProduct;
    }
}
