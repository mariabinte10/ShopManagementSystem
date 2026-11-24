namespace ShopManagementSystem.Admin
{
    partial class FrmCustomerPurchaseData
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtbxEnterText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalAmount0 = new System.Windows.Forms.Label();
            this.lblTotalQuantity0 = new System.Windows.Forms.Label();
            this.lblTotalRecords0 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cmboxSearchBy = new System.Windows.Forms.ComboBox();
            this.dgvPurchaseRecordTable = new System.Windows.Forms.DataGridView();
            this.ClmnPurchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadPurchases = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHead = new System.Windows.Forms.Panel();
            this.lblCustomerPurchase = new System.Windows.Forms.Label();
            this.lblAdminModule = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseRecordTable)).BeginInit();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(14, 87);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(101, 25);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search By:";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtbxEnterText
            // 
            this.txtbxEnterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEnterText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbxEnterText.Location = new System.Drawing.Point(460, 88);
            this.txtbxEnterText.Name = "txtbxEnterText";
            this.txtbxEnterText.Size = new System.Drawing.Size(187, 26);
            this.txtbxEnterText.TabIndex = 3;
            this.txtbxEnterText.Text = " ";
            this.txtbxEnterText.TextChanged += new System.EventHandler(this.txtbxEnterText_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalAmount0);
            this.panel1.Controls.Add(this.lblTotalQuantity0);
            this.panel1.Controls.Add(this.lblTotalRecords0);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.lblTotalQuantity);
            this.panel1.Controls.Add(this.lblTotalRecords);
            this.panel1.Location = new System.Drawing.Point(-10, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 73);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTotalAmount0
            // 
            this.lblTotalAmount0.AutoSize = true;
            this.lblTotalAmount0.Location = new System.Drawing.Point(842, 17);
            this.lblTotalAmount0.Name = "lblTotalAmount0";
            this.lblTotalAmount0.Size = new System.Drawing.Size(18, 20);
            this.lblTotalAmount0.TabIndex = 5;
            this.lblTotalAmount0.Text = "0";
            // 
            // lblTotalQuantity0
            // 
            this.lblTotalQuantity0.AutoSize = true;
            this.lblTotalQuantity0.Location = new System.Drawing.Point(533, 17);
            this.lblTotalQuantity0.Name = "lblTotalQuantity0";
            this.lblTotalQuantity0.Size = new System.Drawing.Size(18, 20);
            this.lblTotalQuantity0.TabIndex = 4;
            this.lblTotalQuantity0.Text = "0";
            // 
            // lblTotalRecords0
            // 
            this.lblTotalRecords0.AutoSize = true;
            this.lblTotalRecords0.Location = new System.Drawing.Point(182, 18);
            this.lblTotalRecords0.Name = "lblTotalRecords0";
            this.lblTotalRecords0.Size = new System.Drawing.Size(18, 20);
            this.lblTotalRecords0.TabIndex = 3;
            this.lblTotalRecords0.Text = "0";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalAmount.Location = new System.Drawing.Point(725, 16);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(118, 21);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalQuantity.Location = new System.Drawing.Point(407, 16);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(123, 21);
            this.lblTotalQuantity.TabIndex = 1;
            this.lblTotalQuantity.Text = "Total Quantity:";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalRecords.Location = new System.Drawing.Point(67, 16);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(116, 21);
            this.lblTotalRecords.TabIndex = 0;
            this.lblTotalRecords.Text = "Total Records:";
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchText.Location = new System.Drawing.Point(349, 90);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(115, 25);
            this.lblSearchText.TabIndex = 5;
            this.lblSearchText.Text = "Search Text:";
            this.lblSearchText.Click += new System.EventHandler(this.lblSearchText_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(676, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 37);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Item";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(823, 85);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(93, 37);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cmboxSearchBy
            // 
            this.cmboxSearchBy.FormattingEnabled = true;
            this.cmboxSearchBy.Location = new System.Drawing.Point(114, 85);
            this.cmboxSearchBy.Name = "cmboxSearchBy";
            this.cmboxSearchBy.Size = new System.Drawing.Size(214, 28);
            this.cmboxSearchBy.TabIndex = 9;
            this.cmboxSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvPurchaseRecordTable
            // 
            this.dgvPurchaseRecordTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseRecordTable.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvPurchaseRecordTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseRecordTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnPurchaseID,
            this.ClmnCustomerName,
            this.ClmnProductName,
            this.ClmnQuantity,
            this.ClmnTotalPrice,
            this.ClmnPurchaseDate});
            this.dgvPurchaseRecordTable.Location = new System.Drawing.Point(6, 145);
            this.dgvPurchaseRecordTable.Name = "dgvPurchaseRecordTable";
            this.dgvPurchaseRecordTable.RowHeadersVisible = false;
            this.dgvPurchaseRecordTable.RowHeadersWidth = 62;
            this.dgvPurchaseRecordTable.RowTemplate.Height = 28;
            this.dgvPurchaseRecordTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseRecordTable.Size = new System.Drawing.Size(970, 286);
            this.dgvPurchaseRecordTable.TabIndex = 10;
            this.dgvPurchaseRecordTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClmnPurchaseID
            // 
            this.ClmnPurchaseID.HeaderText = "Purchase ID";
            this.ClmnPurchaseID.MinimumWidth = 8;
            this.ClmnPurchaseID.Name = "ClmnPurchaseID";
            // 
            // ClmnCustomerName
            // 
            this.ClmnCustomerName.HeaderText = "Customer Name";
            this.ClmnCustomerName.MinimumWidth = 8;
            this.ClmnCustomerName.Name = "ClmnCustomerName";
            // 
            // ClmnProductName
            // 
            this.ClmnProductName.HeaderText = "Product Name";
            this.ClmnProductName.MinimumWidth = 8;
            this.ClmnProductName.Name = "ClmnProductName";
            // 
            // ClmnQuantity
            // 
            this.ClmnQuantity.HeaderText = "Quantity";
            this.ClmnQuantity.MinimumWidth = 8;
            this.ClmnQuantity.Name = "ClmnQuantity";
            // 
            // ClmnTotalPrice
            // 
            this.ClmnTotalPrice.HeaderText = "Total Price";
            this.ClmnTotalPrice.MinimumWidth = 8;
            this.ClmnTotalPrice.Name = "ClmnTotalPrice";
            // 
            // ClmnPurchaseDate
            // 
            this.ClmnPurchaseDate.HeaderText = "Purchase Date";
            this.ClmnPurchaseDate.MinimumWidth = 8;
            this.ClmnPurchaseDate.Name = "ClmnPurchaseDate";
            // 
            // btnLoadPurchases
            // 
            this.btnLoadPurchases.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLoadPurchases.FlatAppearance.BorderSize = 0;
            this.btnLoadPurchases.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPurchases.ForeColor = System.Drawing.Color.White;
            this.btnLoadPurchases.Location = new System.Drawing.Point(46, 442);
            this.btnLoadPurchases.Name = "btnLoadPurchases";
            this.btnLoadPurchases.Size = new System.Drawing.Size(200, 48);
            this.btnLoadPurchases.TabIndex = 0;
            this.btnLoadPurchases.Text = "Load Purchases";
            this.btnLoadPurchases.UseVisualStyleBackColor = false;
            this.btnLoadPurchases.Click += new System.EventHandler(this.btnLoadPurchases_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteSelected.FlatAppearance.BorderSize = 0;
            this.btnDeleteSelected.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelected.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSelected.Location = new System.Drawing.Point(294, 442);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(204, 48);
            this.btnDeleteSelected.TabIndex = 11;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(553, 442);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRefresh.Size = new System.Drawing.Size(151, 48);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(769, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 48);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelHead.Controls.Add(this.lblAdminModule);
            this.panelHead.Controls.Add(this.lblCustomerPurchase);
            this.panelHead.Location = new System.Drawing.Point(-10, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1004, 71);
            this.panelHead.TabIndex = 14;
            this.panelHead.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblCustomerPurchase
            // 
            this.lblCustomerPurchase.AutoSize = true;
            this.lblCustomerPurchase.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPurchase.ForeColor = System.Drawing.Color.White;
            this.lblCustomerPurchase.Location = new System.Drawing.Point(138, -1);
            this.lblCustomerPurchase.Name = "lblCustomerPurchase";
            this.lblCustomerPurchase.Size = new System.Drawing.Size(705, 45);
            this.lblCustomerPurchase.TabIndex = 0;
            this.lblCustomerPurchase.Text = "CUSTOMER PURCHASE DATA MANAGEMENT";
            // 
            // lblAdminModule
            // 
            this.lblAdminModule.AutoSize = true;
            this.lblAdminModule.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminModule.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdminModule.Location = new System.Drawing.Point(329, 40);
            this.lblAdminModule.Name = "lblAdminModule";
            this.lblAdminModule.Size = new System.Drawing.Size(349, 21);
            this.lblAdminModule.TabIndex = 1;
            this.lblAdminModule.Text = "(Admin Module- Keep Customers Purchase Data)";
            this.lblAdminModule.Click += new System.EventHandler(this.lblAdminModule_Click_1);
            // 
            // FrmCustomerPurchaseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(983, 554);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoadPurchases);
            this.Controls.Add(this.dgvPurchaseRecordTable);
            this.Controls.Add(this.cmboxSearchBy);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbxEnterText);
            this.Controls.Add(this.lblSearch);
            this.Name = "FrmCustomerPurchaseData";
            this.Text = "Admin-Purchase Data Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseRecordTable)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtbxEnterText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cmboxSearchBy;
        private System.Windows.Forms.DataGridView dgvPurchaseRecordTable;
        private System.Windows.Forms.Button btnLoadPurchases;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPurchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPurchaseDate;
        private System.Windows.Forms.Label lblTotalAmount0;
        private System.Windows.Forms.Label lblTotalQuantity0;
        private System.Windows.Forms.Label lblTotalRecords0;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label lblCustomerPurchase;
        private System.Windows.Forms.Label lblAdminModule;
    }
}

