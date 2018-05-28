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

namespace POS
{
    public partial class frm_ViewUsers : Form
    {
        public frm_ViewUsers()
        {
            InitializeComponent();
        }

        private void frm_ViewUsers_Load(object sender, EventArgs e)
        {
            try {

                ConnectionManager cm_vu = new ConnectionManager();
                string query_vu = "SELECT [UserName],[Password],[AccessLevel] FROM tbl_users";
                cm_vu.con_Open();
                DataTable getds = cm_vu.con_DataTable(query_vu);

                for (int i = 0; i < getds.Rows.Count; i++)
                {
                    DataRow dr = getds.Rows[i];

                    ListViewItem lvi = new ListViewItem(dr["UserName"].ToString());
                    lvi.SubItems.Add(dr["Password"].ToString());
                    lvi.SubItems.Add(dr["AccessLevel"].ToString());
                    lv_ViewUsers.Items.Add(lvi);

                }
                cm_vu.con_Close();
            }

            catch(SqlException se)
            {
                MessageBox.Show(se.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
