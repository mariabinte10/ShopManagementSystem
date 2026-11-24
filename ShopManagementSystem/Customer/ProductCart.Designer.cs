namespace ShopManagementSystem.Customer
{
    partial class ProductCart
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
            this.PName = new System.Windows.Forms.Label();
            this.PDiscount = new System.Windows.Forms.Label();
            this.PPrice = new System.Windows.Forms.Label();
            this.PCurrentPrice = new System.Windows.Forms.Label();
            this.PTag = new System.Windows.Forms.Label();
            this.PPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PName
            // 
            this.PName.AutoSize = true;
            this.PName.BackColor = System.Drawing.Color.White;
            this.PName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName.Location = new System.Drawing.Point(15, 180);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(46, 16);
            this.PName.TabIndex = 1;
            this.PName.Text = "label1";
            this.PName.Click += new System.EventHandler(this.PName_Click);
            // 
            // PDiscount
            // 
            this.PDiscount.AutoSize = true;
            this.PDiscount.BackColor = System.Drawing.Color.White;
            this.PDiscount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PDiscount.Location = new System.Drawing.Point(133, 198);
            this.PDiscount.Name = "PDiscount";
            this.PDiscount.Size = new System.Drawing.Size(41, 15);
            this.PDiscount.TabIndex = 2;
            this.PDiscount.Text = "label2";
            // 
            // PPrice
            // 
            this.PPrice.AutoSize = true;
            this.PPrice.BackColor = System.Drawing.Color.White;
            this.PPrice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPrice.ForeColor = System.Drawing.Color.Gray;
            this.PPrice.Location = new System.Drawing.Point(15, 198);
            this.PPrice.Name = "PPrice";
            this.PPrice.Size = new System.Drawing.Size(39, 14);
            this.PPrice.TabIndex = 3;
            this.PPrice.Text = "label2";
            // 
            // PCurrentPrice
            // 
            this.PCurrentPrice.AutoSize = true;
            this.PCurrentPrice.BackColor = System.Drawing.Color.White;
            this.PCurrentPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCurrentPrice.ForeColor = System.Drawing.Color.Green;
            this.PCurrentPrice.Location = new System.Drawing.Point(14, 226);
            this.PCurrentPrice.Name = "PCurrentPrice";
            this.PCurrentPrice.Size = new System.Drawing.Size(54, 19);
            this.PCurrentPrice.TabIndex = 4;
            this.PCurrentPrice.Text = "label2";
            // 
            // PTag
            // 
            this.PTag.AutoSize = true;
            this.PTag.BackColor = System.Drawing.Color.White;
            this.PTag.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTag.ForeColor = System.Drawing.Color.Silver;
            this.PTag.Location = new System.Drawing.Point(133, 231);
            this.PTag.Name = "PTag";
            this.PTag.Size = new System.Drawing.Size(39, 14);
            this.PTag.TabIndex = 5;
            this.PTag.Text = "label2";
            this.PTag.Click += new System.EventHandler(this.PTag_Click);
            // 
            // PPicture
            // 
            this.PPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PPicture.Location = new System.Drawing.Point(3, 3);
            this.PPicture.Name = "PPicture";
            this.PPicture.Size = new System.Drawing.Size(203, 174);
            this.PPicture.TabIndex = 0;
            this.PPicture.TabStop = false;
            this.PPicture.Click += new System.EventHandler(this.PPicture_Click);
            // 
            // ProductCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PTag);
            this.Controls.Add(this.PCurrentPrice);
            this.Controls.Add(this.PPrice);
            this.Controls.Add(this.PDiscount);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.PPicture);
            this.Name = "ProductCart";
            this.Size = new System.Drawing.Size(209, 286);
            this.Load += new System.EventHandler(this.ProductCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PPicture;
        private System.Windows.Forms.Label PName;
        private System.Windows.Forms.Label PDiscount;
        private System.Windows.Forms.Label PPrice;
        private System.Windows.Forms.Label PCurrentPrice;
        private System.Windows.Forms.Label PTag;
    }
}
