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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(307, 158);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(91, 23);
            this.btn_AddUser.TabIndex = 3;
            this.btn_AddUser.Text = "Add";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(413, 158);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(91, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(164, 57);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(340, 20);
            this.txt_UserName.TabIndex = 0;
            this.txt_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserName_KeyDown);
            this.txt_UserName.Leave += new System.EventHandler(this.txt_UserName_Leave);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(164, 90);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(340, 20);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(164, 123);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(340, 20);
            this.txt_ConfirmPassword.TabIndex = 2;
            this.txt_ConfirmPassword.UseSystemPasswordChar = true;
            this.txt_ConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ConfirmPassword_KeyDown);
            // 
            // frm_UserReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 200);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_AddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
    }
}