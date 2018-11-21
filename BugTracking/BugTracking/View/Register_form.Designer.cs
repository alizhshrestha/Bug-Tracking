namespace BugTracking
{
    partial class Register_form
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
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.lbl_validate = new System.Windows.Forms.Label();
            this.btn_update = new LollipopButton();
            this.txt_last_name = new LollipopTextBox();
            this.lollipopLabel7 = new LollipopLabel();
            this.lollipopLabel6 = new LollipopLabel();
            this.txt_address = new LollipopTextBox();
            this.lollipopLabel5 = new LollipopLabel();
            this.txt_username = new LollipopTextBox();
            this.lollipopLabel4 = new LollipopLabel();
            this.txt_password = new LollipopTextBox();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.btn_submit = new LollipopButton();
            this.txt_first_name = new LollipopTextBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.SuspendLayout();
            // 
            // cmb_sex
            // 
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Location = new System.Drawing.Point(22, 193);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(205, 21);
            this.cmb_sex.TabIndex = 2;
            this.cmb_sex.SelectedIndexChanged += new System.EventHandler(this.cmb_sex_SelectedIndexChanged);
            // 
            // cmb_role
            // 
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(19, 378);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(205, 21);
            this.cmb_role.TabIndex = 6;
            // 
            // lbl_validate
            // 
            this.lbl_validate.AutoSize = true;
            this.lbl_validate.Location = new System.Drawing.Point(19, 411);
            this.lbl_validate.Name = "lbl_validate";
            this.lbl_validate.Size = new System.Drawing.Size(0, 13);
            this.lbl_validate.TabIndex = 18;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BGColor = "#508ef5";
            this.btn_update.FontColor = "#ffffff";
            this.btn_update.Location = new System.Drawing.Point(128, 447);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(102, 41);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // txt_last_name
            // 
            this.txt_last_name.FocusedColor = "#508ef5";
            this.txt_last_name.FontColor = "#999999";
            this.txt_last_name.IsEnabled = true;
            this.txt_last_name.Location = new System.Drawing.Point(22, 146);
            this.txt_last_name.MaxLength = 32767;
            this.txt_last_name.Multiline = false;
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.ReadOnly = false;
            this.txt_last_name.Size = new System.Drawing.Size(208, 24);
            this.txt_last_name.TabIndex = 1;
            this.txt_last_name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_last_name.UseSystemPasswordChar = false;
            // 
            // lollipopLabel7
            // 
            this.lollipopLabel7.AutoSize = true;
            this.lollipopLabel7.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel7.Location = new System.Drawing.Point(19, 126);
            this.lollipopLabel7.Name = "lollipopLabel7";
            this.lollipopLabel7.Size = new System.Drawing.Size(76, 17);
            this.lollipopLabel7.TabIndex = 33;
            this.lollipopLabel7.Text = "Last Name";
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.AutoSize = true;
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel6.Location = new System.Drawing.Point(19, 173);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(56, 17);
            this.lollipopLabel6.TabIndex = 31;
            this.lollipopLabel6.Text = "Gender";
            // 
            // txt_address
            // 
            this.txt_address.FocusedColor = "#508ef5";
            this.txt_address.FontColor = "#999999";
            this.txt_address.IsEnabled = true;
            this.txt_address.Location = new System.Drawing.Point(19, 237);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Multiline = false;
            this.txt_address.Name = "txt_address";
            this.txt_address.ReadOnly = false;
            this.txt_address.Size = new System.Drawing.Size(208, 24);
            this.txt_address.TabIndex = 3;
            this.txt_address.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_address.UseSystemPasswordChar = false;
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(19, 217);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(60, 17);
            this.lollipopLabel5.TabIndex = 29;
            this.lollipopLabel5.Text = "Address";
            // 
            // txt_username
            // 
            this.txt_username.FocusedColor = "#508ef5";
            this.txt_username.FontColor = "#999999";
            this.txt_username.IsEnabled = true;
            this.txt_username.Location = new System.Drawing.Point(19, 284);
            this.txt_username.MaxLength = 32767;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = false;
            this.txt_username.Size = new System.Drawing.Size(208, 24);
            this.txt_username.TabIndex = 4;
            this.txt_username.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.UseSystemPasswordChar = false;
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(19, 264);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(73, 17);
            this.lollipopLabel4.TabIndex = 27;
            this.lollipopLabel4.Text = "Username";
            // 
            // txt_password
            // 
            this.txt_password.FocusedColor = "#508ef5";
            this.txt_password.FontColor = "#999999";
            this.txt_password.IsEnabled = true;
            this.txt_password.Location = new System.Drawing.Point(22, 331);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.ReadOnly = false;
            this.txt_password.Size = new System.Drawing.Size(208, 24);
            this.txt_password.TabIndex = 5;
            this.txt_password.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(19, 311);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(69, 17);
            this.lollipopLabel3.TabIndex = 25;
            this.lollipopLabel3.Text = "Password";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(19, 358);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(37, 17);
            this.lollipopLabel2.TabIndex = 23;
            this.lollipopLabel2.Text = "Role";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_submit.BGColor = "#508ef5";
            this.btn_submit.FontColor = "#ffffff";
            this.btn_submit.Location = new System.Drawing.Point(19, 447);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(103, 41);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Submit";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click_1);
            // 
            // txt_first_name
            // 
            this.txt_first_name.FocusedColor = "#508ef5";
            this.txt_first_name.FontColor = "#999999";
            this.txt_first_name.IsEnabled = true;
            this.txt_first_name.Location = new System.Drawing.Point(19, 99);
            this.txt_first_name.MaxLength = 32767;
            this.txt_first_name.Multiline = false;
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.ReadOnly = false;
            this.txt_first_name.Size = new System.Drawing.Size(208, 24);
            this.txt_first_name.TabIndex = 0;
            this.txt_first_name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_first_name.UseSystemPasswordChar = false;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(16, 79);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(76, 17);
            this.lollipopLabel1.TabIndex = 20;
            this.lollipopLabel1.Text = "First Name";
            this.lollipopLabel1.Click += new System.EventHandler(this.lollipopLabel1_Click);
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 498);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.lollipopLabel7);
            this.Controls.Add(this.lollipopLabel6);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lollipopLabel5);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lollipopLabel4);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.lbl_validate);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.cmb_sex);
            this.Name = "Register_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register_form";
            this.Load += new System.EventHandler(this.Register_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label lbl_validate;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox txt_first_name;
        private LollipopButton btn_submit;
        private LollipopLabel lollipopLabel2;
        private LollipopTextBox txt_password;
        private LollipopLabel lollipopLabel3;
        private LollipopTextBox txt_username;
        private LollipopLabel lollipopLabel4;
        private LollipopTextBox txt_address;
        private LollipopLabel lollipopLabel5;
        private LollipopLabel lollipopLabel6;
        private LollipopTextBox txt_last_name;
        private LollipopLabel lollipopLabel7;
        private LollipopButton btn_update;
    }
}