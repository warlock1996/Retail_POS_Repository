namespace POS
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disPOSed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ss_Login = new System.Windows.Forms.StatusStrip();
            this.txt_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_ConLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.progress_Login = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_login = new System.Windows.Forms.ProgressBar();
            this.ss_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(92, 211);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(225, 22);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(92, 248);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(225, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(208, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ss_Login
            // 
            this.ss_Login.AutoSize = false;
            this.ss_Login.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_Status,
            this.txt_ConLbl});
            this.ss_Login.Location = new System.Drawing.Point(0, 342);
            this.ss_Login.Name = "ss_Login";
            this.ss_Login.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ss_Login.Size = new System.Drawing.Size(353, 20);
            this.ss_Login.SizingGrip = false;
            this.ss_Login.TabIndex = 5;
            this.ss_Login.Text = "StatusLogin";
            // 
            // txt_Status
            // 
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(45, 17);
            this.txt_Status.Text = "Status :";
            // 
            // txt_ConLbl
            // 
            this.txt_ConLbl.Name = "txt_ConLbl";
            this.txt_ConLbl.Size = new System.Drawing.Size(79, 17);
            this.txt_ConLbl.Text = "Disconnected";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(92, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progress_Login
            // 
            this.progress_Login.Location = new System.Drawing.Point(-4, 370);
            this.progress_Login.Name = "progress_Login";
            this.progress_Login.Size = new System.Drawing.Size(447, 0);
            this.progress_Login.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pb_login
            // 
            this.pb_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_login.ForeColor = System.Drawing.SystemColors.Control;
            this.pb_login.Location = new System.Drawing.Point(0, 340);
            this.pb_login.MarqueeAnimationSpeed = 80;
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(353, 2);
            this.pb_login.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_login.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(353, 362);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progress_Login);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ss_Login);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ss_Login.ResumeLayout(false);
            this.ss_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip ss_Login;
        private System.Windows.Forms.ToolStripStatusLabel txt_Status;
        private System.Windows.Forms.ToolStripStatusLabel txt_ConLbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progress_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pb_login;
    }
}

