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

namespace POS
{
    public partial class LoginForm : Form
    {
        ConnectionManager con_login_logs = new ConnectionManager();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txt_ConLbl.Text = "Connected";
            txt_ConLbl.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                MD5CryptoServiceProvider md5pwd = new MD5CryptoServiceProvider();

                string txtUser = txtUserName.Text;
                string txtPwd = BitConverter.ToString(md5pwd.ComputeHash(Encoding.ASCII.GetBytes(txtPassword.Text)));

                users newuser = new users(txtUser, txtPwd);

                con_login_logs.con_Open();
                if (con_login_logs.con_LookUpUsers(users.UserName))
                {
                    if (newuser.Validate())
                    {

                        pb_login.Value += 100;
                        if (pb_login.Value > 99)
                        {
                            MessageBox.Show("You Are Successfully Logged In !", "Login Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            frm_Home myhome = new frm_Home();
                            myhome.Show();


                            string log_operation = "Login Attempt (Successfull)";
                            string login_log = "Insert INTO tbl_userlogs ([Operation],[UserName],[Time]) VALUES ('" + log_operation + "', '" + users.UserName + "','" + DateTime.Now.ToString() + "')";
                            con_login_logs.con_Open();
                            con_login_logs.con_Query(login_log);
                            con_login_logs.con_Close();

                        }
                    }
                    else
                    {

                        MessageBox.Show("Invalid Credentials ! ", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtUserName.Focus();
                        string log_operation = "Failed Login Attempt";
                        string login_log = "Insert INTO tbl_userlogs ([Operation],[UserName],[Time]) VALUES ('" + log_operation + "','" + users.UserName + "','" + DateTime.Now.ToString() + "')";
                        con_login_logs.con_Open();
                        con_login_logs.con_Query(login_log);
                        con_login_logs.con_Close();
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
                button1.Focus();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
