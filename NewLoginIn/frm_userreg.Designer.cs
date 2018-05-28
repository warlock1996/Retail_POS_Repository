namespace POS
{
    partial class frm_UserReg
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
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_un = new System.Windows.Forms.Label();
            this.lbl_cpwd = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbl_al = new System.Windows.Forms.Label();
            this.cb_AccessLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(284, 124);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(91, 23);
            this.btn_AddUser.TabIndex = 4;
            this.btn_AddUser.Text = "Add";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(390, 124);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(91, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_UserName.Location = new System.Drawing.Point(141, 28);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(340, 20);
            this.txt_UserName.TabIndex = 0;
            this.txt_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserName_KeyDown);
            this.txt_UserName.Leave += new System.EventHandler(this.txt_UserName_Leave);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Password.Location = new System.Drawing.Point(141, 60);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(340, 20);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // lbl_un
            // 
            this.lbl_un.AutoSize = true;
            this.lbl_un.BackColor = System.Drawing.Color.Transparent;
            this.lbl_un.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_un.Location = new System.Drawing.Point(17, 29);
            this.lbl_un.Name = "lbl_un";
            this.lbl_un.Size = new System.Drawing.Size(74, 17);
            this.lbl_un.TabIndex = 5;
            this.lbl_un.Text = "Username :";
            // 
            // lbl_cpwd
            // 
            this.lbl_cpwd.AutoSize = true;
            this.lbl_cpwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpwd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpwd.Location = new System.Drawing.Point(17, 93);
            this.lbl_cpwd.Name = "lbl_cpwd";
            this.lbl_cpwd.Size = new System.Drawing.Size(121, 17);
            this.lbl_cpwd.TabIndex = 6;
            this.lbl_cpwd.Text = "Confirm Password :";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pwd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.Location = new System.Drawing.Point(17, 61);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(71, 17);
            this.lbl_pwd.TabIndex = 7;
            this.lbl_pwd.Text = "Password :";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(141, 92);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(340, 20);
            this.txt_ConfirmPassword.TabIndex = 2;
            this.txt_ConfirmPassword.UseSystemPasswordChar = true;
            this.txt_ConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ConfirmPassword_KeyDown);
            // 
            // lbl_al
            // 
            this.lbl_al.AutoSize = true;
            this.lbl_al.BackColor = System.Drawing.Color.Transparent;
            this.lbl_al.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_al.Location = new System.Drawing.Point(16, 124);
            this.lbl_al.Name = "lbl_al";
            this.lbl_al.Size = new System.Drawing.Size(87, 17);
            this.lbl_al.TabIndex = 9;
            this.lbl_al.Text = "AccessLevel : ";
            // 
            // cb_AccessLevel
            // 
            this.cb_AccessLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_AccessLevel.FormattingEnabled = true;
            this.cb_AccessLevel.Items.AddRange(new object[] {
            "Administrator",
            "User A",
            "User B",
            "User C"});
            this.cb_AccessLevel.Location = new System.Drawing.Point(141, 124);
            this.cb_AccessLevel.Name = "cb_AccessLevel";
            this.cb_AccessLevel.Size = new System.Drawing.Size(121, 21);
            this.cb_AccessLevel.TabIndex = 3;
            // 
            // frm_UserReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 164);
            this.Controls.Add(this.cb_AccessLevel);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_al);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_cpwd);
            this.Controls.Add(this.lbl_un);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_AddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UserReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registeration";
            this.Load += new System.EventHandler(this.frm_UserReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_un;
        private System.Windows.Forms.Label lbl_cpwd;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label lbl_al;
        private System.Windows.Forms.ComboBox cb_AccessLevel;
    }
}