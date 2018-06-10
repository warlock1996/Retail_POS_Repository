using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace POS
{
    class UserReg
    {
        private string username;
        private string password;
        private string accesslevel;
        ConnectionManager myconn;
        public UserReg(string un, string ps, string al)
        {
            username = un;
            password = ps;
            accesslevel = al;
        }
        public UserReg()
        { }
        public bool UserCounter()
        {
            string count = "SELECT * FROM tbl_users";
            myconn = new ConnectionManager();
            myconn.con_Open();
            DataTable dt = myconn.con_DataTable(count);
            if (dt.Rows.Count < 5)
                return true;
            else
                return false;
        }
        public bool addNewUser()
        {
            myconn = new ConnectionManager();
            myconn.con_Open();
            string addusercommand = "INSERT INTO tbl_users ([UserName],[Password],[AccessLevel]) VALUES ('" + username + "','" + password + "','" + accesslevel + "')";
            if (myconn.con_Query(addusercommand))
                return true;
            else
                return false;

        }
        public bool lookUpUserName(string lookupuser)
        {

            myconn = new ConnectionManager();
            string lookupusercommand = "SELECT * FROM tbl_users WHERE [UserName] = '" + lookupuser + "'";
            myconn.con_Open();
            SqlDataReader lkuprdr = myconn.con_Reader(lookupusercommand);
            if (lkuprdr.HasRows)
                return true;
            else
                return false;
         }
      


    }
}