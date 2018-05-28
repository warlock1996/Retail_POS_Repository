using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace POS
{
    class users
    {

        public static string UserName;
        private string PassWord;
        private string Command;

        public users(string un, string ps)
        {
            UserName = un;
            PassWord = ps;
        }
        public bool Validate()
        {

            Command = " SELECT * FROM tbl_users WHERE [UserName] = '" + UserName + "' AND [Password] = '" + PassWord + "' ";
            ConnectionManager myconn = new ConnectionManager();
            myconn.con_Open();
            SqlDataReader rdr = myconn.con_Reader(Command);
            if (rdr.HasRows)
                return true;
            else
                return false;

        }
      
    }



}
