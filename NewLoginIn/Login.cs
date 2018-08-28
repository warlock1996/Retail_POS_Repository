using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using MetroFramework.Forms;

namespace POS
{
    public partial class LoginForm : MetroForm
    {
        ConnectionManager con_login = new ConnectionManager();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lbl_status.Text = "Connected";
            lbl_status.ForeColor = Color.Green;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            try
            {
                MD5CryptoServiceProvider md5pwd = new MD5CryptoServiceProvider();

                string txtUser = txtUserName.Text;
                string txtPwd = BitConverter.ToString(md5pwd.ComputeHash(Encoding.ASCII.GetBytes(txtPassword.Text)));

                users newuser = new users(txtUser, txtPwd);

                con_login.con_Open();
                if (con_login.con_LookUpUsers(users.UserName))
                {
                    if (newuser.Validate())
                    {

                        pb_login.Value += 100;
                        if (pb_login.Value > 99)
                        {
                            con_login.con_Close();
                            MessageBox.Show("You Are Successfully Logged In !", "Login Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            frm_Home myhome = new frm_Home();
                            myhome.Show();

                            con_login.con_Open();
                            con_login.con_recordLog("Login Attempt (Successfull)", users.UserName);
                            con_login.con_Close();
                           

                        }
                    }
                    else
                    {

                        MessageBox.Show("Invalid Credentials ! ", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtUserName.Focus();

                        con_login.con_Open();
                        con_login.con_recordLog("Failed Login Attempt", users.UserName);
                        con_login.con_Close();


                    }
                    
                }
                else
                {

                    MessageBox.Show("User Does Not Exist !", " User Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();

                }
             
            }

            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
        }


        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                txtPassword.Focus();

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btn_login.Focus();
        }
         private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_UserName_Click(object sender, EventArgs e)
        {

        }
    }
}
