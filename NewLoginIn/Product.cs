using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace POS
{
    class Product
    {
        private string ProductName;
        private decimal UnitPrice;
        private string ProductDesc;
        private int InStock;

        public Product(string pn, decimal up,string pd, int ist)
        {
            ProductName = pn;
            UnitPrice = up;
            ProductDesc = pd;
            InStock = ist;
        }
        public Product()
        {

        }
        public bool addNewProduct()
        {
            ConnectionManager con_anp = new ConnectionManager();
            string query_addproduct = "INSERT INTO tbl_products ([ProductName],[UnitPrice],[ProductDesc],[InStock]) VALUES ('" + ProductName + "', '" + UnitPrice + "','" + ProductDesc + "','" + InStock + "')";
            con_anp.con_Open();
            if (con_anp.con_Query(query_addproduct))
                return true;
            else
                return false; 
            
        } 

    }
}
