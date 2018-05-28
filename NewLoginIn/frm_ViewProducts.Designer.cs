namespace POS
{
    partial class frm_ViewProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_Products = new System.Windows.Forms.ListView();
            this.lvi_ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi_ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi_UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi_ProductDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi_InStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_Products
            // 
            this.lv_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvi_ProductID,
            this.lvi_ProductName,
            this.lvi_UnitPrice,
            this.lvi_ProductDescription,
            this.lvi_InStock});
            this.lv_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Products.FullRowSelect = true;
            this.lv_Products.GridLines = true;
            this.lv_Products.Location = new System.Drawing.Point(0, 0);
            this.lv_Products.Name = "lv_Products";
            this.lv_Products.Size = new System.Drawing.Size(749, 424);
            this.lv_Products.TabIndex = 0;
            this.lv_Products.UseCompatibleStateImageBehavior = false;
            this.lv_Products.View = System.Windows.Forms.View.Details;
            // 
            // lvi_ProductID
            // 
            this.lvi_ProductID.Text = "ProductID";
            this.lvi_ProductID.Width = 82;
            // 
            // lvi_ProductName
            // 
            this.lvi_ProductName.Text = "ProductName";
            this.lvi_ProductName.Width = 173;
            // 
            // lvi_UnitPrice
            // 
            this.lvi_UnitPrice.Text = "UnitPrice";
            this.lvi_UnitPrice.Width = 102;
            // 
            // lvi_ProductDescription
            // 
            this.lvi_ProductDescription.Text = "Product Description";
            this.lvi_ProductDescription.Width = 222;
            // 
            // lvi_InStock
            // 
            this.lvi_InStock.Text = "Quantity In Stock";
            this.lvi_InStock.Width = 164;
            // 
            // frm_ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 424);
            this.Controls.Add(this.lv_Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ViewProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frm_ViewProducts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Products;
        private System.Windows.Forms.ColumnHeader lvi_ProductID;
        private System.Windows.Forms.ColumnHeader lvi_ProductName;
        private System.Windows.Forms.ColumnHeader lvi_UnitPrice;
        private System.Windows.Forms.ColumnHeader lvi_ProductDescription;
        private System.Windows.Forms.ColumnHeader lvi_InStock;
    }
}