using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS
{
    public partial class frm_Products : Form
    {
        public frm_Products()
        {
            InitializeComponent();
            txt_ProductName.Focus();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
          //  try {
                Product p = new Product(txt_ProductName.Text, Convert.ToDecimal(txt_UnitPrice.Text),txt_Description.Text,Convert.ToInt16(txt_InStock.Text));
                if (p.addNewProduct())
                    MessageBox.Show("New Product Added !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Product Not Saved !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ProductName.Clear();
                    txt_UnitPrice.Clear();
                    txt_Description.Clear();
                    txt_InStock.Clear();
                    txt_ProductName.Focus();
                }
           // }
            //catch(SqlException se)
            //{
             //   MessageBox.Show("Error !"+se.ToString()+"", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btn_CancelProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
