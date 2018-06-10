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
    public partial class frm_ViewUserLogs : Form
    {
        public frm_ViewUserLogs()
        {
            InitializeComponent();
        }
       
        private void frm_ViewUserLogs_Load(object sender, EventArgs e)
        {


            ConnectionManager myconn_vulgs = new ConnectionManager();
            string rulgs_query = "SELECT * FROM tbl_userlogs";
            myconn_vulgs.con_Open();
            DataTable dt = myconn_vulgs.con_DataTable(rulgs_query);

            for(int i=0;i<dt.Rows.Count;i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem lvi = new ListViewItem(dr["LogID"].ToString());
                lvi.SubItems.Add(dr["Operation"].ToString());
                lvi.SubItems.Add(dr["UserName"].ToString());
                lvi.SubItems.Add(dr["Time"].ToString());
                lv_userlogs.Items.Add(lvi);
            }

            myconn_vulgs.con_Close();
        }
    }
}
