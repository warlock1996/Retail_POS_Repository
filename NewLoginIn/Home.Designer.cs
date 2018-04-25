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
            this.menu_Home = new System.Windows.Forms.MenuStrip();
            this.menuItem_POS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Products = new System.Windows.Forms.ToolStripMenuItem();
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
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menu_Home.SuspendLayout();
            this.ss_Home.SuspendLayout();
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
            this.menu_Home.Size = new System.Drawing.Size(978, 24);
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
            this.viewProductsToolStripMenuItem,
            this.editProductsToolStripMenuItem});
            this.menuItem_Products.Name = "menuItem_Products";
            this.menuItem_Products.Size = new System.Drawing.Size(66, 20);
            this.menuItem_Products.Text = "Products";
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
            this.viewUserLogToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.viewUserLogToolStripMenuItem.Text = "View User Log";
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
            this.ss_Home.Size = new System.Drawing.Size(978, 22);
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
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewProductsToolStripMenuItem.Text = "View Products";
            // 
            // editProductsToolStripMenuItem
            // 
            this.editProductsToolStripMenuItem.Name = "editProductsToolStripMenuItem";
            this.editProductsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editProductsToolStripMenuItem.Text = "Edit Products";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(5, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(765, 424);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 492);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ss_Home);
            this.Controls.Add(this.menu_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS  v1.0";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.menu_Home.ResumeLayout(false);
            this.menu_Home.PerformLayout();
            this.ss_Home.ResumeLayout(false);
            this.ss_Home.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductsToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
    }
}