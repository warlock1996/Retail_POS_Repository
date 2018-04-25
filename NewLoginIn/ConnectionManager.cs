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
            int value = scmd.ExecuteNonQuery();
            if (value > 0)
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
        public DataTable con_DataTable()
        {
            string Command = "SELECT [user],[password] FROM tbl_admin";
            SqlDataAdapter sda = new SqlDataAdapter(Command,sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }


    }
}
