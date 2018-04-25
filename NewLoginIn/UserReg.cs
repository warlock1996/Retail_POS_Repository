using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POS
{
    class UserReg
    {
        private string username;
        private string password;
        ConnectionManager myconn;
        public UserReg(string un, string ps)
        {
            username = un;
            password = ps;
        }
        public UserReg()
        { }
        public bool addNewUser()
        {
            myconn = new ConnectionManager();
            string addusercommand = "INSERT INTO tbl_admin ([user],[password]) VALUES ('" + username + "','" + password + "')";
            myconn.con_Open();
            if (myconn.con_Query(addusercommand))
                return true;
            else
                return false;

        }
        public bool lookUpUserName(string lookupuser)
        {

            myconn = new ConnectionManager();
            string lookupusercommand = "SELECT * FROM tbl_admin WHERE [user] = '" + lookupuser + "'";
            myconn.con_Open();
            SqlDataReader lkuprdr = myconn.con_Reader(lookupusercommand);
            if (lkuprdr.HasRows)
                return true;
            else
                return false;
         }
      


    }
}