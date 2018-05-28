namespace POS
{
    partial class frm_ViewUsers
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
            this.lv_Users = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_AccessLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ViewUsers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lv_Users
            // 
            this.lv_Users.Text = "Username";
            this.lv_Users.Width = 138;
            // 
            // lv_Password
            // 
            this.lv_Password.Text = "Password";
            this.lv_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_Password.Width = 363;
            // 
            // lv_AccessLevel
            // 
            this.lv_AccessLevel.Text = "Access Level";
            this.lv_AccessLevel.Width = 131;
            // 
            // lv_ViewUsers
            // 
            this.lv_ViewUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lv_ViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_ViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_Users,
            this.lv_Password,
            this.lv_AccessLevel});
            this.lv_ViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_ViewUsers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ViewUsers.FullRowSelect = true;
            this.lv_ViewUsers.GridLines = true;
            this.lv_ViewUsers.Location = new System.Drawing.Point(0, 0);
            this.lv_ViewUsers.Name = "lv_ViewUsers";
            this.lv_ViewUsers.Size = new System.Drawing.Size(632, 329);
            this.lv_ViewUsers.TabIndex = 0;
            this.lv_ViewUsers.UseCompatibleStateImageBehavior = false;
            this.lv_ViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // frm_ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 329);
            this.Controls.Add(this.lv_ViewUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ViewUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Users";
            this.Load += new System.EventHandler(this.frm_ViewUsers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader lv_Users;
        private System.Windows.Forms.ColumnHeader lv_Password;
        private System.Windows.Forms.ColumnHeader lv_AccessLevel;
        private System.Windows.Forms.ListView lv_ViewUsers;
    }
}