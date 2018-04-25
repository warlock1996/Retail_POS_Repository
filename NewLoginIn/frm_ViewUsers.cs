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
            ConnectionManager cm = new ConnectionManager();
            cm.con_Open();
            DataTable getds = cm.con_DataTable();

            for (int i =0 ; i < getds.Rows.Count ; i++)
            {
                DataRow dr = getds.Rows[i];

                ListViewItem lvi = new ListViewItem(dr["user"].ToString());
                lvi.SubItems.Add(dr["password"].ToString());
                lv_ViewUsers.Items.Add(lvi);

            }

        }
    }
}
