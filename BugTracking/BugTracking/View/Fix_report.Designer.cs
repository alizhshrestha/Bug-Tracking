namespace BugTracking
{
    partial class Fix_report
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
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.lbl_validate = new System.Windows.Forms.Label();
            this.txt_resolved_code = new System.Windows.Forms.RichTextBox();
            this.btn_update = new LollipopButton();
            this.lollipopLabel1 = new LollipopLabel();
            this.txt_project_name = new LollipopTextBox();
            this.txt_bug = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.txt_source_file = new LollipopTextBox();
            this.lollipopLabel3 = new LollipopLabel();
            this.txt_class_name = new LollipopTextBox();
            this.lollipopLabel4 = new LollipopLabel();
            this.txt_code_line = new LollipopTextBox();
            this.lollipopLabel5 = new LollipopLabel();
            this.txt_method_line = new LollipopTextBox();
            this.lollipopLabel6 = new LollipopLabel();
            this.lollipopLabel7 = new LollipopLabel();
            this.txt_fixer = new LollipopTextBox();
            this.lollipopLabel8 = new LollipopLabel();
            this.lollipopLabel9 = new LollipopLabel();
            this.btn_back = new LollipopButton();
            this.lollipopLabel10 = new LollipopLabel();
            this.rtxt_source_code = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmb_role
            // 
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(16, 437);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(177, 21);
            this.cmb_role.TabIndex = 8;
            // 
            // lbl_validate
            // 
            this.lbl_validate.AutoSize = true;
            this.lbl_validate.Location = new System.Drawing.Point(13, 461);
            this.lbl_validate.Name = "lbl_validate";
            this.lbl_validate.Size = new System.Drawing.Size(0, 13);
            this.lbl_validate.TabIndex = 19;
            // 
            // txt_resolved_code
            // 
            this.txt_resolved_code.Location = new System.Drawing.Point(209, 218);
            this.txt_resolved_code.Name = "txt_resolved_code";
            this.txt_resolved_code.Size = new System.Drawing.Size(177, 96);
            this.txt_resolved_code.TabIndex = 6;
            this.txt_resolved_code.Text = "";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BGColor = "#508ef5";
            this.btn_update.FontColor = "#ffffff";
            this.btn_update.Location = new System.Drawing.Point(15, 500);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 41);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Submit";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(12, 76);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(132, 17);
            this.lollipopLabel1.TabIndex = 23;
            this.lollipopLabel1.Text = "Name of the project";
            // 
            // txt_project_name
            // 
            this.txt_project_name.FocusedColor = "#508ef5";
            this.txt_project_name.FontColor = "#999999";
            this.txt_project_name.IsEnabled = true;
            this.txt_project_name.Location = new System.Drawing.Point(15, 97);
            this.txt_project_name.MaxLength = 32767;
            this.txt_project_name.Multiline = false;
            this.txt_project_name.Name = "txt_project_name";
            this.txt_project_name.ReadOnly = false;
            this.txt_project_name.Size = new System.Drawing.Size(178, 24);
            this.txt_project_name.TabIndex = 0;
            this.txt_project_name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_project_name.UseSystemPasswordChar = false;
            // 
            // txt_bug
            // 
            this.txt_bug.FocusedColor = "#508ef5";
            this.txt_bug.FontColor = "#999999";
            this.txt_bug.IsEnabled = true;
            this.txt_bug.Location = new System.Drawing.Point(15, 144);
            this.txt_bug.MaxLength = 32767;
            this.txt_bug.Multiline = false;
            this.txt_bug.Name = "txt_bug";
            this.txt_bug.ReadOnly = false;
            this.txt_bug.Size = new System.Drawing.Size(178, 24);
            this.txt_bug.TabIndex = 1;
            this.txt_bug.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_bug.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(12, 124);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(103, 17);
            this.lollipopLabel2.TabIndex = 25;
            this.lollipopLabel2.Text = "Title of the bug";
            // 
            // txt_source_file
            // 
            this.txt_source_file.FocusedColor = "#508ef5";
            this.txt_source_file.FontColor = "#999999";
            this.txt_source_file.IsEnabled = true;
            this.txt_source_file.Location = new System.Drawing.Point(15, 191);
            this.txt_source_file.MaxLength = 32767;
            this.txt_source_file.Multiline = false;
            this.txt_source_file.Name = "txt_source_file";
            this.txt_source_file.ReadOnly = false;
            this.txt_source_file.Size = new System.Drawing.Size(178, 24);
            this.txt_source_file.TabIndex = 2;
            this.txt_source_file.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_source_file.UseSystemPasswordChar = false;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(12, 171);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(75, 17);
            this.lollipopLabel3.TabIndex = 27;
            this.lollipopLabel3.Text = "Source file";
            // 
            // txt_class_name
            // 
            this.txt_class_name.FocusedColor = "#508ef5";
            this.txt_class_name.FontColor = "#999999";
            this.txt_class_name.IsEnabled = true;
            this.txt_class_name.Location = new System.Drawing.Point(15, 242);
            this.txt_class_name.MaxLength = 32767;
            this.txt_class_name.Multiline = false;
            this.txt_class_name.Name = "txt_class_name";
            this.txt_class_name.ReadOnly = false;
            this.txt_class_name.Size = new System.Drawing.Size(178, 24);
            this.txt_class_name.TabIndex = 3;
            this.txt_class_name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_class_name.UseSystemPasswordChar = false;
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(12, 222);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(81, 17);
            this.lollipopLabel4.TabIndex = 29;
            this.lollipopLabel4.Text = "Class name";
            // 
            // txt_code_line
            // 
            this.txt_code_line.FocusedColor = "#508ef5";
            this.txt_code_line.FontColor = "#999999";
            this.txt_code_line.IsEnabled = true;
            this.txt_code_line.Location = new System.Drawing.Point(15, 289);
            this.txt_code_line.MaxLength = 32767;
            this.txt_code_line.Multiline = false;
            this.txt_code_line.Name = "txt_code_line";
            this.txt_code_line.ReadOnly = false;
            this.txt_code_line.Size = new System.Drawing.Size(178, 24);
            this.txt_code_line.TabIndex = 4;
            this.txt_code_line.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_code_line.UseSystemPasswordChar = false;
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(12, 269);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(67, 17);
            this.lollipopLabel5.TabIndex = 31;
            this.lollipopLabel5.Text = "Code line";
            // 
            // txt_method_line
            // 
            this.txt_method_line.FocusedColor = "#508ef5";
            this.txt_method_line.FontColor = "#999999";
            this.txt_method_line.IsEnabled = true;
            this.txt_method_line.Location = new System.Drawing.Point(15, 333);
            this.txt_method_line.MaxLength = 32767;
            this.txt_method_line.Multiline = false;
            this.txt_method_line.Name = "txt_method_line";
            this.txt_method_line.ReadOnly = false;
            this.txt_method_line.Size = new System.Drawing.Size(178, 24);
            this.txt_method_line.TabIndex = 5;
            this.txt_method_line.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_method_line.UseSystemPasswordChar = false;
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.AutoSize = true;
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel6.Location = new System.Drawing.Point(12, 316);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(81, 17);
            this.lollipopLabel6.TabIndex = 33;
            this.lollipopLabel6.Text = "Method line";
            this.lollipopLabel6.Click += new System.EventHandler(this.lollipopLabel6_Click);
            // 
            // lollipopLabel7
            // 
            this.lollipopLabel7.AutoSize = true;
            this.lollipopLabel7.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel7.Location = new System.Drawing.Point(206, 198);
            this.lollipopLabel7.Name = "lollipopLabel7";
            this.lollipopLabel7.Size = new System.Drawing.Size(102, 17);
            this.lollipopLabel7.TabIndex = 35;
            this.lollipopLabel7.Text = "Resolved code";
            // 
            // txt_fixer
            // 
            this.txt_fixer.FocusedColor = "#508ef5";
            this.txt_fixer.FontColor = "#999999";
            this.txt_fixer.IsEnabled = true;
            this.txt_fixer.Location = new System.Drawing.Point(16, 390);
            this.txt_fixer.MaxLength = 32767;
            this.txt_fixer.Multiline = false;
            this.txt_fixer.Name = "txt_fixer";
            this.txt_fixer.ReadOnly = false;
            this.txt_fixer.Size = new System.Drawing.Size(178, 24);
            this.txt_fixer.TabIndex = 7;
            this.txt_fixer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_fixer.UseSystemPasswordChar = false;
            // 
            // lollipopLabel8
            // 
            this.lollipopLabel8.AutoSize = true;
            this.lollipopLabel8.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel8.Location = new System.Drawing.Point(13, 370);
            this.lollipopLabel8.Name = "lollipopLabel8";
            this.lollipopLabel8.Size = new System.Drawing.Size(111, 17);
            this.lollipopLabel8.TabIndex = 37;
            this.lollipopLabel8.Text = "Fixed by (Name)";
            // 
            // lollipopLabel9
            // 
            this.lollipopLabel9.AutoSize = true;
            this.lollipopLabel9.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel9.Location = new System.Drawing.Point(13, 417);
            this.lollipopLabel9.Name = "lollipopLabel9";
            this.lollipopLabel9.Size = new System.Drawing.Size(37, 17);
            this.lollipopLabel9.TabIndex = 39;
            this.lollipopLabel9.Text = "Role";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BGColor = "#508ef5";
            this.btn_back.FontColor = "#ffffff";
            this.btn_back.Location = new System.Drawing.Point(115, 500);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(78, 41);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // lollipopLabel10
            // 
            this.lollipopLabel10.AutoSize = true;
            this.lollipopLabel10.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel10.Location = new System.Drawing.Point(220, 76);
            this.lollipopLabel10.Name = "lollipopLabel10";
            this.lollipopLabel10.Size = new System.Drawing.Size(88, 17);
            this.lollipopLabel10.TabIndex = 41;
            this.lollipopLabel10.Text = "Source code";
            // 
            // rtxt_source_code
            // 
            this.rtxt_source_code.Location = new System.Drawing.Point(205, 96);
            this.rtxt_source_code.Name = "rtxt_source_code";
            this.rtxt_source_code.Size = new System.Drawing.Size(177, 96);
            this.rtxt_source_code.TabIndex = 40;
            this.rtxt_source_code.Text = "";
            // 
            // Fix_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 727);
            this.Controls.Add(this.lollipopLabel10);
            this.Controls.Add(this.rtxt_source_code);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lollipopLabel9);
            this.Controls.Add(this.txt_fixer);
            this.Controls.Add(this.lollipopLabel8);
            this.Controls.Add(this.lollipopLabel7);
            this.Controls.Add(this.txt_method_line);
            this.Controls.Add(this.lollipopLabel6);
            this.Controls.Add(this.txt_code_line);
            this.Controls.Add(this.lollipopLabel5);
            this.Controls.Add(this.txt_class_name);
            this.Controls.Add(this.lollipopLabel4);
            this.Controls.Add(this.txt_source_file);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.txt_bug);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.txt_project_name);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_resolved_code);
            this.Controls.Add(this.lbl_validate);
            this.Controls.Add(this.cmb_role);
            this.Name = "Fix_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fix_report";
            this.Load += new System.EventHandler(this.Fix_report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label lbl_validate;
        private System.Windows.Forms.RichTextBox txt_resolved_code;
        private LollipopButton btn_update;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox txt_project_name;
        private LollipopTextBox txt_bug;
        private LollipopLabel lollipopLabel2;
        private LollipopTextBox txt_source_file;
        private LollipopLabel lollipopLabel3;
        private LollipopTextBox txt_class_name;
        private LollipopLabel lollipopLabel4;
        private LollipopTextBox txt_code_line;
        private LollipopLabel lollipopLabel5;
        private LollipopTextBox txt_method_line;
        private LollipopLabel lollipopLabel6;
        private LollipopLabel lollipopLabel7;
        private LollipopTextBox txt_fixer;
        private LollipopLabel lollipopLabel8;
        private LollipopLabel lollipopLabel9;
        private LollipopButton btn_back;
        private LollipopLabel lollipopLabel10;
        private System.Windows.Forms.RichTextBox rtxt_source_code;
    }
}