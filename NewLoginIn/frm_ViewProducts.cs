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
    public partial class frm_ViewProducts : Form
    {
        public frm_ViewProducts()
        {
            InitializeComponent();
        }

        private void frm_ViewProducts_Load(object sender, EventArgs e)
        {
            ConnectionManager vp_con = new ConnectionManager();
            string vp_query = "Select * FROM tbl_products";
            vp_con.con_Open();
            DataTable dt =  vp_con.con_DataTable(vp_query);
            for(int i=0;i<dt.Rows.Count;i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem lvi_p = new ListViewItem(dr["ProductID"].ToString());
                lvi_p.SubItems.Add(dr["ProductName"].ToString());
                lvi_p.SubItems.Add(dr["UnitPrice"].ToString());
                lvi_p.SubItems.Add(dr["ProductDesc"].ToString());
                lvi_p.SubItems.Add(dr["InStock"].ToString());
                lv_Products.Items.Add(lvi_p);


            }

            vp_con.con_Close();
        }
    }
}
