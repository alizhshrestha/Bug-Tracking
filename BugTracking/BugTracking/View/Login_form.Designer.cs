namespace BugTracking
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.login_panel = new System.Windows.Forms.Panel();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_invalid = new System.Windows.Forms.Label();
            this.login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.Name = "btn_login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_username
            // 
            resources.ApplyResources(this.txt_username, "txt_username");
            this.txt_username.Name = "txt_username";
            // 
            // txt_password
            // 
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.Name = "txt_password";
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.login_panel.Controls.Add(this.lbl_login);
            resources.ApplyResources(this.login_panel, "login_panel");
            this.login_panel.Name = "login_panel";
            // 
            // lbl_login
            // 
            resources.ApplyResources(this.lbl_login, "lbl_login");
            this.lbl_login.Name = "lbl_login";
            // 
            // lbl_username
            // 
            resources.ApplyResources(this.lbl_username, "lbl_username");
            this.lbl_username.Name = "lbl_username";
            // 
            // lbl_password
            // 
            resources.ApplyResources(this.lbl_password, "lbl_password");
            this.lbl_password.Name = "lbl_password";
            // 
            // lbl_invalid
            // 
            resources.ApplyResources(this.lbl_invalid, "lbl_invalid");
            this.lbl_invalid.Name = "lbl_invalid";
            // 
            // Login_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.lbl_invalid);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_login);
            this.Name = "Login_form";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_invalid;
    }
}

