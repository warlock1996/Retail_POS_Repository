﻿using System;
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
            
           
         
        }

        private void menuItem_ViewUsers_Click(object sender, EventArgs e)
        {
            frm_ViewUsers vu = new frm_ViewUsers();
            vu.ShowDialog();
        }

        private void menuItem_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}