namespace POS
{
    partial class frm_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Products));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_InStock = new System.Windows.Forms.TextBox();
            this.pb_Products = new System.Windows.Forms.PictureBox();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_CancelProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ProductName";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(120, 145);
            this.txt_ProductName.MaxLength = 50;
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(289, 20);
            this.txt_ProductName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "UnitPrice";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(120, 180);
            this.txt_UnitPrice.MaxLength = 100000;
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(289, 20);
            this.txt_UnitPrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(120, 250);
            this.txt_Description.MaxLength = 50;
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(289, 98);
            this.txt_Description.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "InStock";
            // 
            // txt_InStock
            // 
            this.txt_InStock.Location = new System.Drawing.Point(120, 215);
            this.txt_InStock.MaxLength = 300;
            this.txt_InStock.Name = "txt_InStock";
            this.txt_InStock.Size = new System.Drawing.Size(289, 20);
            this.txt_InStock.TabIndex = 2;
            // 
            // pb_Products
            // 
            this.pb_Products.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_Products.Image = ((System.Drawing.Image)(resources.GetObject("pb_Products.Image")));
            this.pb_Products.Location = new System.Drawing.Point(0, 0);
            this.pb_Products.Name = "pb_Products";
            this.pb_Products.Size = new System.Drawing.Size(431, 125);
            this.pb_Products.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Products.TabIndex = 10;
            this.pb_Products.TabStop = false;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddProduct.Location = new System.Drawing.Point(312, 363);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(96, 25);
            this.btn_AddProduct.TabIndex = 4;
            this.btn_AddProduct.Text = "+ Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_CancelProduct
            // 
            this.btn_CancelProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelProduct.Location = new System.Drawing.Point(119, 363);
            this.btn_CancelProduct.Name = "btn_CancelProduct";
            this.btn_CancelProduct.Size = new System.Drawing.Size(89, 25);
            this.btn_CancelProduct.TabIndex = 5;
            this.btn_CancelProduct.Text = "Cancel";
            this.btn_CancelProduct.UseVisualStyleBackColor = true;
            this.btn_CancelProduct.Click += new System.EventHandler(this.btn_CancelProduct_Click);
            // 
            // frm_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(431, 394);
            this.Controls.Add(this.btn_CancelProduct);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.pb_Products);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_InStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Products";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Products";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_InStock;
        private System.Windows.Forms.PictureBox pb_Products;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_CancelProduct;
    }
}