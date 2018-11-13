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
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_last_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.lbl_validate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Location = new System.Drawing.Point(24, 32);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(57, 13);
            this.lbl_first_name.TabIndex = 0;
            this.lbl_first_name.Text = "First Name";
            // 
            // txt_first_name
            // 
            this.txt_first_name.Location = new System.Drawing.Point(166, 29);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(205, 20);
            this.txt_first_name.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(166, 300);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(121, 23);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.AutoSize = true;
            this.lbl_last_name.Location = new System.Drawing.Point(24, 71);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(58, 13);
            this.lbl_last_name.TabIndex = 3;
            this.lbl_last_name.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Addresss";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(24, 107);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(25, 13);
            this.lbl_sex.TabIndex = 5;
            this.lbl_sex.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Role";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Username";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(166, 136);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(205, 20);
            this.txt_address.TabIndex = 9;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(166, 204);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(205, 20);
            this.txt_password.TabIndex = 12;
            // 
            // txt_last_name
            // 
            this.txt_last_name.Location = new System.Drawing.Point(166, 68);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(205, 20);
            this.txt_last_name.TabIndex = 13;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(166, 172);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(205, 20);
            this.txt_username.TabIndex = 15;
            // 
            // cmb_sex
            // 
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Location = new System.Drawing.Point(166, 104);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(205, 21);
            this.cmb_sex.TabIndex = 16;
            this.cmb_sex.SelectedIndexChanged += new System.EventHandler(this.cmb_sex_SelectedIndexChanged);
            // 
            // cmb_role
            // 
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(166, 235);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(205, 21);
            this.cmb_role.TabIndex = 17;
            // 
            // lbl_validate
            // 
            this.lbl_validate.AutoSize = true;
            this.lbl_validate.Location = new System.Drawing.Point(163, 270);
            this.lbl_validate.Name = "lbl_validate";
            this.lbl_validate.Size = new System.Drawing.Size(0, 13);
            this.lbl_validate.TabIndex = 18;
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 335);
            this.Controls.Add(this.lbl_validate);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.cmb_sex);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_last_name);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.lbl_first_name);
            this.Name = "Register_form";
            this.Text = "Register_form";
            this.Load += new System.EventHandler(this.Register_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_first_name;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_last_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label lbl_validate;
    }
}