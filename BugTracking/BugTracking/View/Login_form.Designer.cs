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
            this.lbl_invalid = new System.Windows.Forms.Label();
            this.txt_password = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.btnlop_login = new LollipopButton();
            this.txt_username = new LollipopTextBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.SuspendLayout();
            // 
            // lbl_invalid
            // 
            resources.ApplyResources(this.lbl_invalid, "lbl_invalid");
            this.lbl_invalid.Name = "lbl_invalid";
            // 
            // txt_password
            // 
            this.txt_password.FocusedColor = "#508ef5";
            this.txt_password.FontColor = "#999999";
            this.txt_password.IsEnabled = true;
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.MaxLength = 32767;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.ReadOnly = false;
            this.txt_password.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            resources.ApplyResources(this.lollipopLabel2, "lollipopLabel2");
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Name = "lollipopLabel2";
            // 
            // btnlop_login
            // 
            this.btnlop_login.BackColor = System.Drawing.Color.Transparent;
            this.btnlop_login.BGColor = "#508ef5";
            this.btnlop_login.FontColor = "#ffffff";
            resources.ApplyResources(this.btnlop_login, "btnlop_login");
            this.btnlop_login.Name = "btnlop_login";
            this.btnlop_login.Click += new System.EventHandler(this.btnlop_login_Click);
            // 
            // txt_username
            // 
            this.txt_username.FocusedColor = "#508ef5";
            this.txt_username.FontColor = "#999999";
            this.txt_username.IsEnabled = true;
            resources.ApplyResources(this.txt_username, "txt_username");
            this.txt_username.MaxLength = 32767;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = false;
            this.txt_username.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.UseSystemPasswordChar = false;
            // 
            // lollipopLabel1
            // 
            resources.ApplyResources(this.lollipopLabel1, "lollipopLabel1");
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Name = "lollipopLabel1";
            // 
            // Login_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.btnlop_login);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.lbl_invalid);
            this.Name = "Login_form";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_invalid;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox txt_username;
        private LollipopButton btnlop_login;
        private LollipopTextBox txt_password;
        private LollipopLabel lollipopLabel2;
    }
}

