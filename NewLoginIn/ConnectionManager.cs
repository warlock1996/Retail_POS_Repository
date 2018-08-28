using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
namespace POS
{
    class ConnectionManager
    {

        private static string Constr = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.loginConnectionString"].ConnectionString;
        SqlConnection sc;
        public void con_Open()
        {
            sc = new SqlConnection(Constr);
            sc.Open();
        }
        public void con_Close()
        {
            sc.Close();
        }
        public bool con_Query(string _query)
        {
            SqlCommand scmd = new SqlCommand(_query, sc);
            int value_q = scmd.ExecuteNonQuery();
            if (value_q > 0)
                return true;
            else
                return false;
        }
        public SqlDataReader con_Reader(string _readquery)
        {

            SqlCommand scrmd = new SqlCommand(_readquery, sc);
                SqlDataReader sdr = scrmd.ExecuteReader();
                return sdr;
            
        }
        public DataTable con_DataTable(string _readdatatable)
        {
            SqlDataAdapter sda = new SqlDataAdapter(_readdatatable,sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public bool con_LookUpUsers(string _username)
        {

            string _lkupquery = "SELECT [UserName] FROM tbl_users WHERE [UserName] = '" + _username + "'";
            SqlCommand sclkup = new SqlCommand(_lkupquery,sc);
            SqlDataReader sdr_lkup = sclkup.ExecuteReader();                
               if (sdr_lkup.HasRows)
                return true;
            else
                return false;

        }
        public void con_recordLog(string operation, string user)
        {
            string _logquery = "INSERT INTO tbl_userlogs ([Operation],[UserName],[Time]) VALUES ('" + operation + "', '" + user + "','" + DateTime.Now.ToString() + "')";
            SqlCommand _sclq = new SqlCommand(_logquery, sc);
            _sclq.ExecuteNonQuery();
        }


    }
}
