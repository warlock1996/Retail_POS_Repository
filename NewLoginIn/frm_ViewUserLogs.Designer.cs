namespace POS
{
    partial class frm_ViewUserLogs
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
            this.lv_userlogs = new System.Windows.Forms.ListView();
            this.lvi_LogID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi_Operation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi_UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi_DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_userlogs
            // 
            this.lv_userlogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvi_LogID,
            this.lvi_Operation,
            this.lvi_UserName,
            this.lvi_DateTime});
            this.lv_userlogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_userlogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_userlogs.FullRowSelect = true;
            this.lv_userlogs.GridLines = true;
            this.lv_userlogs.Location = new System.Drawing.Point(0, 0);
            this.lv_userlogs.Name = "lv_userlogs";
            this.lv_userlogs.Size = new System.Drawing.Size(686, 398);
            this.lv_userlogs.TabIndex = 0;
            this.lv_userlogs.UseCompatibleStateImageBehavior = false;
            this.lv_userlogs.View = System.Windows.Forms.View.Details;
            // 
            // lvi_LogID
            // 
            this.lvi_LogID.Text = "LogID";
            this.lvi_LogID.Width = 84;
            // 
            // lvi_Operation
            // 
            this.lvi_Operation.Text = "Operation";
            this.lvi_Operation.Width = 181;
            // 
            // lvi_UserName
            // 
            this.lvi_UserName.Text = "UserName";
            this.lvi_UserName.Width = 147;
            // 
            // lvi_DateTime
            // 
            this.lvi_DateTime.Text = "Date/Time";
            this.lvi_DateTime.Width = 270;
            // 
            // frm_ViewUserLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 398);
            this.Controls.Add(this.lv_userlogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ViewUserLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Logs";
            this.Load += new System.EventHandler(this.frm_ViewUserLogs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_userlogs;
        private System.Windows.Forms.ColumnHeader lvi_LogID;
        private System.Windows.Forms.ColumnHeader lvi_Operation;
        private System.Windows.Forms.ColumnHeader lvi_UserName;
        private System.Windows.Forms.ColumnHeader lvi_DateTime;
    }
}