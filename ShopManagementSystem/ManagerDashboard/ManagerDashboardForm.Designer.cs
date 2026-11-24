namespace ShopManagementSystem.ManagerDashboard
{
    partial class ManagerDashboardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogout = new Button();
            labelManager = new Label();
            labelLibraryManagement = new Label();
            panelHeader = new Panel();
            tableLayoutPanelMenu = new TableLayoutPanel();
            buttonAddProducts = new Button();
            buttonManageProducts = new Button();
            panelAddProducts = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox4 = new TextBox();
            labelPUDepartment = new Label();
            textBox3 = new TextBox();
            labelPUMobile = new Label();
            richTextBox1 = new TextBox();
            labelId = new Label();
            textBox2 = new TextBox();
            buttonAddProduct2 = new Button();
            labelPUName = new Label();
            textBox1 = new TextBox();
            panelManageProducts = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            dvgProducts = new DataGridView();
            panelMRHeader = new Panel();
            buttonDelete = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            buttonUpdate = new Button();
            textBoxNewDiscount = new TextBox();
            textBoxNewPrice = new TextBox();
            panelHeader.SuspendLayout();
            tableLayoutPanelMenu.SuspendLayout();
            panelAddProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelManageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProducts).BeginInit();
            panelMRHeader.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.None;
            buttonLogout.BackColor = Color.DodgerBlue;
            buttonLogout.BackgroundImageLayout = ImageLayout.None;
            buttonLogout.Cursor = Cursors.Hand;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = SystemColors.ControlLightLight;
            buttonLogout.Location = new Point(730, 13);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(93, 38);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click_1;
            // 
            // labelManager
            // 
            labelManager.Anchor = AnchorStyles.None;
            labelManager.AutoSize = true;
            labelManager.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManager.ForeColor = SystemColors.ControlLightLight;
            labelManager.Location = new Point(397, 11);
            labelManager.Margin = new Padding(5, 0, 5, 0);
            labelManager.Name = "labelManager";
            labelManager.Size = new Size(105, 31);
            labelManager.TabIndex = 11;
            labelManager.Text = "Manager";
            // 
            // labelLibraryManagement
            // 
            labelLibraryManagement.Anchor = AnchorStyles.None;
            labelLibraryManagement.AutoSize = true;
            labelLibraryManagement.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLibraryManagement.ForeColor = SystemColors.ControlLightLight;
            labelLibraryManagement.Location = new Point(5, 11);
            labelLibraryManagement.Margin = new Padding(5, 0, 5, 0);
            labelLibraryManagement.Name = "labelLibraryManagement";
            labelLibraryManagement.Size = new Size(296, 31);
            labelLibraryManagement.TabIndex = 10;
            labelLibraryManagement.Text = "Shop Management System";
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(buttonLogout);
            panelHeader.Controls.Add(labelManager);
            panelHeader.Controls.Add(labelLibraryManagement);
            panelHeader.Location = new Point(1, 1);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(839, 84);
            panelHeader.TabIndex = 15;
            // 
            // tableLayoutPanelMenu
            // 
            tableLayoutPanelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelMenu.BackColor = Color.DodgerBlue;
            tableLayoutPanelMenu.ColumnCount = 2;
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMenu.Controls.Add(buttonAddProducts, 1, 0);
            tableLayoutPanelMenu.Controls.Add(buttonManageProducts, 0, 0);
            tableLayoutPanelMenu.Location = new Point(1, 86);
            tableLayoutPanelMenu.Margin = new Padding(1);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.RowCount = 1;
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMenu.Size = new Size(839, 50);
            tableLayoutPanelMenu.TabIndex = 16;
            // 
            // buttonAddProducts
            // 
            buttonAddProducts.Anchor = AnchorStyles.None;
            buttonAddProducts.BackColor = Color.SteelBlue;
            buttonAddProducts.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddProducts.ForeColor = SystemColors.ControlLightLight;
            buttonAddProducts.Location = new Point(433, 3);
            buttonAddProducts.Name = "buttonAddProducts";
            buttonAddProducts.Size = new Size(392, 44);
            buttonAddProducts.TabIndex = 2;
            buttonAddProducts.Text = "Add Products";
            buttonAddProducts.UseVisualStyleBackColor = false;
            buttonAddProducts.Click += buttonAddProducts_Click_1;
            // 
            // buttonManageProducts
            // 
            buttonManageProducts.Anchor = AnchorStyles.None;
            buttonManageProducts.BackColor = Color.SteelBlue;
            buttonManageProducts.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManageProducts.ForeColor = SystemColors.ControlLightLight;
            buttonManageProducts.Location = new Point(13, 3);
            buttonManageProducts.Name = "buttonManageProducts";
            buttonManageProducts.Size = new Size(393, 44);
            buttonManageProducts.TabIndex = 1;
            buttonManageProducts.Text = "Manage Products";
            buttonManageProducts.UseVisualStyleBackColor = false;
            buttonManageProducts.Click += buttonManageProducts_Click;
            // 
            // panelAddProducts
            // 
            panelAddProducts.Controls.Add(button4);
            panelAddProducts.Controls.Add(button3);
            panelAddProducts.Controls.Add(button2);
            panelAddProducts.Controls.Add(button1);
            panelAddProducts.Controls.Add(pictureBox4);
            panelAddProducts.Controls.Add(pictureBox3);
            panelAddProducts.Controls.Add(pictureBox2);
            panelAddProducts.Controls.Add(pictureBox1);
            panelAddProducts.Controls.Add(label1);
            panelAddProducts.Controls.Add(textBox4);
            panelAddProducts.Controls.Add(labelPUDepartment);
            panelAddProducts.Controls.Add(textBox3);
            panelAddProducts.Controls.Add(labelPUMobile);
            panelAddProducts.Controls.Add(richTextBox1);
            panelAddProducts.Controls.Add(labelId);
            panelAddProducts.Controls.Add(textBox2);
            panelAddProducts.Controls.Add(buttonAddProduct2);
            panelAddProducts.Controls.Add(labelPUName);
            panelAddProducts.Controls.Add(textBox1);
            panelAddProducts.Location = new Point(1, 140);
            panelAddProducts.Name = "panelAddProducts";
            panelAddProducts.Size = new Size(839, 449);
            panelAddProducts.TabIndex = 20;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.Ivory;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Desktop;
            button4.Location = new Point(422, 312);
            button4.Name = "button4";
            button4.Size = new Size(117, 31);
            button4.TabIndex = 32;
            button4.Text = "Browse Image";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Ivory;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Desktop;
            button3.Location = new Point(142, 312);
            button3.Name = "button3";
            button3.Size = new Size(117, 31);
            button3.TabIndex = 31;
            button3.Text = "Browse Image";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Ivory;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Desktop;
            button2.Location = new Point(422, 221);
            button2.Name = "button2";
            button2.Size = new Size(117, 31);
            button2.TabIndex = 30;
            button2.Text = "Browse Image";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Ivory;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(142, 221);
            button1.Name = "button1";
            button1.Size = new Size(117, 31);
            button1.TabIndex = 29;
            button1.Text = "Browse Image";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(545, 293);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 69);
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(265, 293);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 69);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(545, 202);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 69);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(265, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 69);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(433, 154);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 24;
            label1.Text = "Discount:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(541, 152);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 27);
            textBox4.TabIndex = 23;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPUDepartment
            // 
            labelPUDepartment.Anchor = AnchorStyles.None;
            labelPUDepartment.AutoSize = true;
            labelPUDepartment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPUDepartment.ForeColor = SystemColors.ActiveCaptionText;
            labelPUDepartment.Location = new Point(95, 154);
            labelPUDepartment.Margin = new Padding(5, 0, 5, 0);
            labelPUDepartment.Name = "labelPUDepartment";
            labelPUDepartment.Size = new Size(50, 21);
            labelPUDepartment.TabIndex = 22;
            labelPUDepartment.Text = "Price:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(213, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 27);
            textBox3.TabIndex = 21;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPUMobile
            // 
            labelPUMobile.Anchor = AnchorStyles.None;
            labelPUMobile.AutoSize = true;
            labelPUMobile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPUMobile.ForeColor = SystemColors.ActiveCaptionText;
            labelPUMobile.Location = new Point(97, 104);
            labelPUMobile.Margin = new Padding(5, 0, 5, 0);
            labelPUMobile.Name = "labelPUMobile";
            labelPUMobile.Size = new Size(98, 21);
            labelPUMobile.TabIndex = 20;
            labelPUMobile.Text = "Description:";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(213, 102);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(488, 27);
            richTextBox1.TabIndex = 19;
            richTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // labelId
            // 
            labelId.Anchor = AnchorStyles.None;
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelId.ForeColor = SystemColors.ActiveCaptionText;
            labelId.Location = new Point(97, 48);
            labelId.Margin = new Padding(5, 0, 5, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(30, 21);
            labelId.TabIndex = 18;
            labelId.Text = "ID:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(541, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 27);
            textBox2.TabIndex = 17;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAddProduct2
            // 
            buttonAddProduct2.Anchor = AnchorStyles.None;
            buttonAddProduct2.BackColor = Color.Ivory;
            buttonAddProduct2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddProduct2.ForeColor = SystemColors.Desktop;
            buttonAddProduct2.Location = new Point(359, 391);
            buttonAddProduct2.Name = "buttonAddProduct2";
            buttonAddProduct2.Size = new Size(131, 31);
            buttonAddProduct2.TabIndex = 16;
            buttonAddProduct2.Text = "Add Product";
            buttonAddProduct2.UseVisualStyleBackColor = false;
            buttonAddProduct2.Click += buttonAddProduct2_Click;
            // 
            // labelPUName
            // 
            labelPUName.Anchor = AnchorStyles.None;
            labelPUName.AutoSize = true;
            labelPUName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPUName.ForeColor = SystemColors.ActiveCaptionText;
            labelPUName.Location = new Point(433, 52);
            labelPUName.Margin = new Padding(5, 0, 5, 0);
            labelPUName.Name = "labelPUName";
            labelPUName.Size = new Size(57, 21);
            labelPUName.TabIndex = 14;
            labelPUName.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(213, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panelManageProducts
            // 
            panelManageProducts.Controls.Add(pictureBox8);
            panelManageProducts.Controls.Add(pictureBox7);
            panelManageProducts.Controls.Add(pictureBox6);
            panelManageProducts.Controls.Add(pictureBox5);
            panelManageProducts.Controls.Add(dvgProducts);
            panelManageProducts.Controls.Add(panelMRHeader);
            panelManageProducts.Location = new Point(1, 143);
            panelManageProducts.Name = "panelManageProducts";
            panelManageProducts.Size = new Size(836, 446);
            panelManageProducts.TabIndex = 33;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(725, 253);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 71);
            pictureBox8.TabIndex = 23;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(601, 253);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 71);
            pictureBox7.TabIndex = 22;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(725, 149);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 71);
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(601, 149);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 71);
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // dvgProducts
            // 
            dvgProducts.AllowUserToAddRows = false;
            dvgProducts.AllowUserToDeleteRows = false;
            dvgProducts.AllowUserToResizeColumns = false;
            dvgProducts.AllowUserToResizeRows = false;
            dvgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dvgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgProducts.BackgroundColor = SystemColors.ControlLightLight;
            dvgProducts.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dvgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProducts.Location = new Point(3, 85);
            dvgProducts.MultiSelect = false;
            dvgProducts.Name = "dvgProducts";
            dvgProducts.ReadOnly = true;
            dvgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgProducts.Size = new Size(579, 358);
            dvgProducts.TabIndex = 19;
            dvgProducts.SelectionChanged += dvgProducts_SelectionChanged;
            // 
            // panelMRHeader
            // 
            panelMRHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMRHeader.Controls.Add(buttonDelete);
            panelMRHeader.Controls.Add(buttonSearch);
            panelMRHeader.Controls.Add(textBoxSearch);
            panelMRHeader.Controls.Add(buttonUpdate);
            panelMRHeader.Controls.Add(textBoxNewDiscount);
            panelMRHeader.Controls.Add(textBoxNewPrice);
            panelMRHeader.Location = new Point(3, 4);
            panelMRHeader.Name = "panelMRHeader";
            panelMRHeader.Size = new Size(830, 78);
            panelMRHeader.TabIndex = 18;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.BackColor = Color.Ivory;
            buttonDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = SystemColors.Desktop;
            buttonDelete.Location = new Point(679, 18);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(131, 31);
            buttonDelete.TabIndex = 28;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.None;
            buttonSearch.BackColor = Color.Ivory;
            buttonSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = SystemColors.Desktop;
            buttonSearch.Location = new Point(43, 41);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 31);
            buttonSearch.TabIndex = 27;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSearch.ForeColor = SystemColors.InactiveCaption;
            textBoxSearch.Location = new Point(20, 9);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(221, 29);
            textBoxSearch.TabIndex = 26;
            textBoxSearch.Text = "Search by Product Name";
            textBoxSearch.Enter += textBoxSearch_Enter;
            textBoxSearch.Leave += textBoxSearch_Leave;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.None;
            buttonUpdate.BackColor = Color.Ivory;
            buttonUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = SystemColors.Desktop;
            buttonUpdate.Location = new Point(511, 18);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(131, 31);
            buttonUpdate.TabIndex = 25;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxNewDiscount
            // 
            textBoxNewDiscount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNewDiscount.ForeColor = SystemColors.InactiveCaption;
            textBoxNewDiscount.Location = new Point(284, 40);
            textBoxNewDiscount.Name = "textBoxNewDiscount";
            textBoxNewDiscount.Size = new Size(221, 29);
            textBoxNewDiscount.TabIndex = 24;
            textBoxNewDiscount.Text = "Enter New Discount Amount";
            textBoxNewDiscount.Enter += textBoxNewDiscount_Enter;
            textBoxNewDiscount.Leave += textBoxNewDiscount_Leave;
            // 
            // textBoxNewPrice
            // 
            textBoxNewPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNewPrice.ForeColor = SystemColors.InactiveCaption;
            textBoxNewPrice.Location = new Point(284, 5);
            textBoxNewPrice.Name = "textBoxNewPrice";
            textBoxNewPrice.Size = new Size(221, 29);
            textBoxNewPrice.TabIndex = 22;
            textBoxNewPrice.Text = "Enter New Price";
            textBoxNewPrice.Enter += textBoxNewPrice_Enter;
            textBoxNewPrice.Leave += textBoxNewPrice_Leave;
            // 
            // ManagerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 592);
            Controls.Add(tableLayoutPanelMenu);
            Controls.Add(panelHeader);
            Controls.Add(panelAddProducts);
            Controls.Add(panelManageProducts);
            Name = "ManagerDashboardForm";
            Text = "ManagerDashboardForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanelMenu.ResumeLayout(false);
            panelAddProducts.ResumeLayout(false);
            panelAddProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelManageProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProducts).EndInit();
            panelMRHeader.ResumeLayout(false);
            panelMRHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogout;
        private Label labelManager;
        private Label labelLibraryManagement;
        private Panel panelHeader;
        private TableLayoutPanel tableLayoutPanelMenu;
        private Button buttonAddProducts;
        private Button buttonManageProducts;
        private Panel panelAddProducts;
        private Label labelPUDepartment;
        private TextBox textBox3;
        private Label labelPUMobile;
        private TextBox richTextBox1;
        private Label labelId;
        private TextBox textBox2;
        private Button buttonAddProduct2;
        private Label labelPUName;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panelManageProducts;
        private Panel panelMRHeader;
        private Button buttonUpdate;
        private TextBox textBoxNewPrice;
        private TextBox textBoxNewDiscount;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private DataGridView dvgProducts;
        private Button buttonDelete;
        private Button buttonSearch;
        private TextBox textBoxSearch;
    }
}