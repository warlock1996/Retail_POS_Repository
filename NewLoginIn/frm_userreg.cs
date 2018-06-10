using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace POS
{
    public partial class frm_UserReg : Form
    {
        UserReg myUserreg;
        public frm_UserReg()
        {
            InitializeComponent();
           
        }
        private void frm_UserReg_Load(object sender, EventArgs e)
        {
            txt_UserName.Focus();
        }
        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "")
                MessageBox.Show("Please Specify A Username !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_Password.Text == "")
                MessageBox.Show("Please Specify A Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_Password.Text != txt_ConfirmPassword.Text)
                MessageBox.Show("Password Do Not Match !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(cb_AccessLevel.Text=="")
                MessageBox.Show("Please Specify A User Role !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if ((txt_UserName.Text == "") && (txt_Password.Text == "") && (txt_ConfirmPassword.Text == ""))
                MessageBox.Show("Please Specify User Information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                string password = BitConverter.ToString(md5.ComputeHash(Encoding.ASCII.GetBytes(txt_ConfirmPassword.Text)));
                myUserreg = new UserReg(txt_UserName.Text, password, cb_AccessLevel.Text);
                if (myUserreg.UserCounter())
                {
                    if (myUserreg.addNewUser())
                        MessageBox.Show("User Added Successfully !","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Failed To Add New User !","Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("More Users Cannot Be Added !", "Users Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
               

                }

        }

        private void txt_UserName_Leave(object sender, EventArgs e)
        {
            myUserreg = new UserReg();
            if (myUserreg.lookUpUserName(txt_UserName.Text))
            {
                MessageBox.Show("Username Already Exists In The Database !", "Duplicate User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_UserName.Text = "";
                txt_UserName.Focus();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                txt_Password.Focus();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                txt_ConfirmPassword.Focus();
        }

        private void txt_ConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btn_AddUser.Focus();
        }

       
    }
}