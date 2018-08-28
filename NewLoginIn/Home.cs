using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace POS
{
    public partial class frm_Home : Form
    {
        ConnectionManager con_menu = new ConnectionManager();
        public frm_Home()
        {
            InitializeComponent();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            slblvalue_Home.Text = users.UserName;
            slblvalue_Home.ForeColor = Color.Green;
        }

        private void menuItem_AddUsers_Click(object sender, EventArgs e)
        {

            frm_UserReg newuser = new frm_UserReg();
            newuser.ShowDialog();
            con_menu.con_Open();
            con_menu.con_recordLog("Add User Form (Click)", users.UserName);
            con_menu.con_Close();



        }

        private void menuItem_ViewUsers_Click(object sender, EventArgs e)
        {
            frm_ViewUsers vu = new frm_ViewUsers();
            vu.ShowDialog();
            con_menu.con_Open();
            con_menu.con_recordLog("Viewed User Accounts", users.UserName);
            con_menu.con_Close();

        }

        private void menuItem_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
            con_menu.con_Open();
            con_menu.con_recordLog("Log Out", users.UserName);
            con_menu.con_Close();

        }

        private void menuItem_AddNewProducts_Click(object sender, EventArgs e)
        {
            frm_Products prod = new frm_Products();
            prod.ShowDialog();
            con_menu.con_Open();
            con_menu.con_recordLog("Add Products Form (Click)", users.UserName);
            con_menu.con_Close();

        }

        private void menuItem_ViewProducts_Click(object sender, EventArgs e)
        {
            frm_ViewProducts vp = new frm_ViewProducts();
            vp.Show();
            con_menu.con_Open();
            con_menu.con_recordLog("Viewed Products Form", users.UserName);
            con_menu.con_Close();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void viewUserLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ViewUserLogs vulgs = new frm_ViewUserLogs();
            vulgs.Show();
            con_menu.con_Open();
            con_menu.con_recordLog("Viewed User Logs", users.UserName);
            con_menu.con_Close();

        }
    }
}
