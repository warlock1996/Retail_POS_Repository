namespace POS
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.menu_Home = new System.Windows.Forms.MenuStrip();
            this.menuItem_POS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Products = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_ViewProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_EditProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_AddNewProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Revenues = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Invoices = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_UserAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_ViewUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_AddUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.openHelpDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_UserLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_Home = new System.Windows.Forms.StatusStrip();
            this.slbl_Home = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblvalue_Home = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvi_ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi_ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi_UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi_OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_OrderID = new System.Windows.Forms.Label();
            this.txt_H_OrderID = new System.Windows.Forms.TextBox();
            this.txt_H_TotalBill = new System.Windows.Forms.TextBox();
            this.lbl_TotalBill = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_H_Discount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.p_Home = new System.Windows.Forms.Panel();
            this.menu_Home.SuspendLayout();
            this.ss_Home.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Home
            // 
            this.menu_Home.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu_Home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_POS,
            this.menuItem_Products,
            this.menuItem_Revenues,
            this.menuItem_Invoices,
            this.menuItem_UserAccounts,
            this.menuItem_About,
            this.menuItem_Help,
            this.menuItem_UserLogs,
            this.menuItem_LogOut});
            this.menu_Home.Location = new System.Drawing.Point(0, 0);
            this.menu_Home.Name = "menu_Home";
            this.menu_Home.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_Home.Size = new System.Drawing.Size(1022, 24);
            this.menu_Home.TabIndex = 0;
            // 
            // menuItem_POS
            // 
            this.menuItem_POS.Name = "menuItem_POS";
            this.menuItem_POS.Size = new System.Drawing.Size(41, 20);
            this.menuItem_POS.Text = "POS";
            // 
            // menuItem_Products
            // 
            this.menuItem_Products.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_ViewProducts,
            this.menuItem_EditProducts,
            this.menuItem_AddNewProducts});
            this.menuItem_Products.Name = "menuItem_Products";
            this.menuItem_Products.Size = new System.Drawing.Size(66, 20);
            this.menuItem_Products.Text = "Products";
            // 
            // menuItem_ViewProducts
            // 
            this.menuItem_ViewProducts.Name = "menuItem_ViewProducts";
            this.menuItem_ViewProducts.Size = new System.Drawing.Size(173, 22);
            this.menuItem_ViewProducts.Text = "View Products";
            this.menuItem_ViewProducts.Click += new System.EventHandler(this.menuItem_ViewProducts_Click);
            // 
            // menuItem_EditProducts
            // 
            this.menuItem_EditProducts.Name = "menuItem_EditProducts";
            this.menuItem_EditProducts.Size = new System.Drawing.Size(173, 22);
            this.menuItem_EditProducts.Text = "Edit Products";
            // 
            // menuItem_AddNewProducts
            // 
            this.menuItem_AddNewProducts.Image = ((System.Drawing.Image)(resources.GetObject("menuItem_AddNewProducts.Image")));
            this.menuItem_AddNewProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuItem_AddNewProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItem_AddNewProducts.Name = "menuItem_AddNewProducts";
            this.menuItem_AddNewProducts.Size = new System.Drawing.Size(173, 22);
            this.menuItem_AddNewProducts.Text = "Add New Products";
            this.menuItem_AddNewProducts.Click += new System.EventHandler(this.menuItem_AddNewProducts_Click);
            // 
            // menuItem_Revenues
            // 
            this.menuItem_Revenues.Name = "menuItem_Revenues";
            this.menuItem_Revenues.Size = new System.Drawing.Size(69, 20);
            this.menuItem_Revenues.Text = "Revenues";
            // 
            // menuItem_Invoices
            // 
            this.menuItem_Invoices.Name = "menuItem_Invoices";
            this.menuItem_Invoices.Size = new System.Drawing.Size(62, 20);
            this.menuItem_Invoices.Text = "Invoices";
            // 
            // menuItem_UserAccounts
            // 
            this.menuItem_UserAccounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_ViewUsers,
            this.menuItem_AddUsers});
            this.menuItem_UserAccounts.Name = "menuItem_UserAccounts";
            this.menuItem_UserAccounts.Size = new System.Drawing.Size(95, 20);
            this.menuItem_UserAccounts.Text = "User Accounts";
            // 
            // menuItem_ViewUsers
            // 
            this.menuItem_ViewUsers.Name = "menuItem_ViewUsers";
            this.menuItem_ViewUsers.Size = new System.Drawing.Size(130, 22);
            this.menuItem_ViewUsers.Text = "View Users";
            this.menuItem_ViewUsers.Click += new System.EventHandler(this.menuItem_ViewUsers_Click);
            // 
            // menuItem_AddUsers
            // 
            this.menuItem_AddUsers.Name = "menuItem_AddUsers";
            this.menuItem_AddUsers.Size = new System.Drawing.Size(130, 22);
            this.menuItem_AddUsers.Text = "Add Users";
            this.menuItem_AddUsers.Click += new System.EventHandler(this.menuItem_AddUsers_Click);
            // 
            // menuItem_About
            // 
            this.menuItem_About.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPOSToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuItem_About.Name = "menuItem_About";
            this.menuItem_About.Size = new System.Drawing.Size(52, 20);
            this.menuItem_About.Text = "About";
            // 
            // aboutPOSToolStripMenuItem
            // 
            this.aboutPOSToolStripMenuItem.Name = "aboutPOSToolStripMenuItem";
            this.aboutPOSToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutPOSToolStripMenuItem.Text = "About POS";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // menuItem_Help
            // 
            this.menuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHelpDialogToolStripMenuItem});
            this.menuItem_Help.Name = "menuItem_Help";
            this.menuItem_Help.Size = new System.Drawing.Size(44, 20);
            this.menuItem_Help.Text = "Help";
            // 
            // openHelpDialogToolStripMenuItem
            // 
            this.openHelpDialogToolStripMenuItem.Name = "openHelpDialogToolStripMenuItem";
            this.openHelpDialogToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openHelpDialogToolStripMenuItem.Text = "Open Help Dialog";
            // 
            // menuItem_UserLogs
            // 
            this.menuItem_UserLogs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUserLogToolStripMenuItem});
            this.menuItem_UserLogs.Name = "menuItem_UserLogs";
            this.menuItem_UserLogs.Size = new System.Drawing.Size(70, 20);
            this.menuItem_UserLogs.Text = "User Logs";
            // 
            // viewUserLogToolStripMenuItem
            // 
            this.viewUserLogToolStripMenuItem.Name = "viewUserLogToolStripMenuItem";
            this.viewUserLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewUserLogToolStripMenuItem.Text = "View User Log";
            this.viewUserLogToolStripMenuItem.Click += new System.EventHandler(this.viewUserLogToolStripMenuItem_Click);
            // 
            // menuItem_LogOut
            // 
            this.menuItem_LogOut.Name = "menuItem_LogOut";
            this.menuItem_LogOut.Size = new System.Drawing.Size(62, 20);
            this.menuItem_LogOut.Text = "Log Out";
            this.menuItem_LogOut.ToolTipText = "Logs User Out Of The POS";
            this.menuItem_LogOut.Click += new System.EventHandler(this.menuItem_LogOut_Click);
            // 
            // ss_Home
            // 
            this.ss_Home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbl_Home,
            this.slblvalue_Home});
            this.ss_Home.Location = new System.Drawing.Point(0, 470);
            this.ss_Home.Name = "ss_Home";
            this.ss_Home.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ss_Home.Size = new System.Drawing.Size(1022, 22);
            this.ss_Home.TabIndex = 1;
            this.ss_Home.Text = "statusStrip1";
            // 
            // slbl_Home
            // 
            this.slbl_Home.Name = "slbl_Home";
            this.slbl_Home.Size = new System.Drawing.Size(63, 17);
            this.slbl_Home.Text = "Welcome :";
            // 
            // slblvalue_Home
            // 
            this.slblvalue_Home.Name = "slblvalue_Home";
            this.slblvalue_Home.Size = new System.Drawing.Size(0, 17);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvi_ProductID,
            this.lvi_ProductName,
            this.lvi_UnitPrice,
            this.lvi_Description,
            this.lvi_OrderDate});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 403);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lvi_ProductID
            // 
            this.lvi_ProductID.Text = "ProductID";
            this.lvi_ProductID.Width = 131;
            // 
            // lvi_ProductName
            // 
            this.lvi_ProductName.Text = "ProductName";
            this.lvi_ProductName.Width = 164;
            // 
            // lvi_UnitPrice
            // 
            this.lvi_UnitPrice.Text = "UnitPrice";
            this.lvi_UnitPrice.Width = 143;
            // 
            // lvi_Description
            // 
            this.lvi_Description.Text = "ProductDesc";
            this.lvi_Description.Width = 178;
            // 
            // lvi_OrderDate
            // 
            this.lvi_OrderDate.Text = "OrderDate";
            this.lvi_OrderDate.Width = 147;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 403);
            this.panel1.TabIndex = 3;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(281, 35);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(242, 22);
            this.txt_Search.TabIndex = 4;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(657, 34);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(105, 24);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormatString = "N0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Orders",
            "Products",
            "Sold"});
            this.comboBox1.Location = new System.Drawing.Point(525, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // lbl_OrderID
            // 
            this.lbl_OrderID.AutoSize = true;
            this.lbl_OrderID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_OrderID.Location = new System.Drawing.Point(14, 38);
            this.lbl_OrderID.Name = "lbl_OrderID";
            this.lbl_OrderID.Size = new System.Drawing.Size(67, 16);
            this.lbl_OrderID.TabIndex = 7;
            this.lbl_OrderID.Text = "Order ID : ";
            // 
            // txt_H_OrderID
            // 
            this.txt_H_OrderID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_H_OrderID.Location = new System.Drawing.Point(78, 36);
            this.txt_H_OrderID.Name = "txt_H_OrderID";
            this.txt_H_OrderID.Size = new System.Drawing.Size(100, 20);
            this.txt_H_OrderID.TabIndex = 8;
            // 
            // txt_H_TotalBill
            // 
            this.txt_H_TotalBill.Location = new System.Drawing.Point(837, 393);
            this.txt_H_TotalBill.Name = "txt_H_TotalBill";
            this.txt_H_TotalBill.Size = new System.Drawing.Size(175, 20);
            this.txt_H_TotalBill.TabIndex = 10;
            // 
            // lbl_TotalBill
            // 
            this.lbl_TotalBill.AutoSize = true;
            this.lbl_TotalBill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalBill.Location = new System.Drawing.Point(775, 395);
            this.lbl_TotalBill.Name = "lbl_TotalBill";
            this.lbl_TotalBill.Size = new System.Drawing.Size(66, 16);
            this.lbl_TotalBill.TabIndex = 9;
            this.lbl_TotalBill.Text = "TotalBill : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(837, 367);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 12;
            // 
            // lbl_H_Discount
            // 
            this.lbl_H_Discount.AutoSize = true;
            this.lbl_H_Discount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_H_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_H_Discount.Location = new System.Drawing.Point(775, 369);
            this.lbl_H_Discount.Name = "lbl_H_Discount";
            this.lbl_H_Discount.Size = new System.Drawing.Size(66, 16);
            this.lbl_H_Discount.TabIndex = 11;
            this.lbl_H_Discount.Text = "Discount :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(837, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Print Invoice";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(208, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Order ID : ";
            // 
            // p_Home
            // 
            this.p_Home.BackColor = System.Drawing.SystemColors.ControlLight;
            this.p_Home.Location = new System.Drawing.Point(766, 64);
            this.p_Home.Name = "p_Home";
            this.p_Home.Size = new System.Drawing.Size(256, 403);
            this.p_Home.TabIndex = 15;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_H_Discount);
            this.Controls.Add(this.txt_H_TotalBill);
            this.Controls.Add(this.lbl_TotalBill);
            this.Controls.Add(this.txt_H_OrderID);
            this.Controls.Add(this.lbl_OrderID);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ss_Home);
            this.Controls.Add(this.menu_Home);
            this.Controls.Add(this.p_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retail POS System (Beta)";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.menu_Home.ResumeLayout(false);
            this.menu_Home.PerformLayout();
            this.ss_Home.ResumeLayout(false);
            this.ss_Home.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Home;
        private System.Windows.Forms.ToolStripMenuItem menuItem_POS;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Products;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Revenues;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Invoices;
        private System.Windows.Forms.ToolStripMenuItem menuItem_UserAccounts;
        private System.Windows.Forms.ToolStripMenuItem menuItem_ViewUsers;
        private System.Windows.Forms.ToolStripMenuItem menuItem_AddUsers;
        private System.Windows.Forms.ToolStripMenuItem menuItem_About;
        private System.Windows.Forms.ToolStripMenuItem aboutPOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem openHelpDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_UserLogs;
        private System.Windows.Forms.ToolStripMenuItem viewUserLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_LogOut;
        private System.Windows.Forms.StatusStrip ss_Home;
        private System.Windows.Forms.ToolStripStatusLabel slbl_Home;
        private System.Windows.Forms.ToolStripStatusLabel slblvalue_Home;
        private System.Windows.Forms.ToolStripMenuItem menuItem_ViewProducts;
        private System.Windows.Forms.ToolStripMenuItem menuItem_EditProducts;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_AddNewProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader lvi_ProductID;
        private System.Windows.Forms.ColumnHeader lvi_ProductName;
        private System.Windows.Forms.ColumnHeader lvi_UnitPrice;
        private System.Windows.Forms.ColumnHeader lvi_Description;
        private System.Windows.Forms.ColumnHeader lvi_OrderDate;
        private System.Windows.Forms.Label lbl_OrderID;
        private System.Windows.Forms.TextBox txt_H_OrderID;
        private System.Windows.Forms.TextBox txt_H_TotalBill;
        private System.Windows.Forms.Label lbl_TotalBill;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_H_Discount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p_Home;
    }
}