﻿namespace BugTracking
{
    partial class Bug_report
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
            this.lbl_validate = new System.Windows.Forms.Label();
            this.btn_submit = new LollipopButton();
            this.lollipopLabel1 = new LollipopLabel();
            this.txt_project_name = new LollipopTextBox();
            this.txt_bug_title = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.txt_arthur = new LollipopTextBox();
            this.lollipopLabel3 = new LollipopLabel();
            this.txt_source_file = new LollipopTextBox();
            this.lollipopLabel4 = new LollipopLabel();
            this.txt_method_line = new LollipopTextBox();
            this.lollipopLabel5 = new LollipopLabel();
            this.txt_class_name = new LollipopTextBox();
            this.lollipopLabel6 = new LollipopLabel();
            this.txt_code_line = new LollipopTextBox();
            this.lollipopLabel7 = new LollipopLabel();
            this.lollipopLabel8 = new LollipopLabel();
            this.btn_update = new LollipopButton();
            this.btn_back = new LollipopButton();
            this.SuspendLayout();
            // 
            // lbl_validate
            // 
            this.lbl_validate.AutoSize = true;
            this.lbl_validate.Location = new System.Drawing.Point(12, 440);
            this.lbl_validate.Name = "lbl_validate";
            this.lbl_validate.Size = new System.Drawing.Size(0, 13);
            this.lbl_validate.TabIndex = 18;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_submit.BGColor = "#508ef5";
            this.btn_submit.FontColor = "#ffffff";
            this.btn_submit.Location = new System.Drawing.Point(15, 467);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(83, 41);
            this.btn_submit.TabIndex = 20;
            this.btn_submit.Text = "Submit";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click_1);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(12, 68);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(134, 18);
            this.lollipopLabel1.TabIndex = 21;
            this.lollipopLabel1.Text = "Name of the project";
            // 
            // txt_project_name
            // 
            this.txt_project_name.FocusedColor = "#508ef5";
            this.txt_project_name.FontColor = "#999999";
            this.txt_project_name.IsEnabled = true;
            this.txt_project_name.Location = new System.Drawing.Point(15, 89);
            this.txt_project_name.MaxLength = 32767;
            this.txt_project_name.Multiline = false;
            this.txt_project_name.Name = "txt_project_name";
            this.txt_project_name.ReadOnly = false;
            this.txt_project_name.Size = new System.Drawing.Size(251, 24);
            this.txt_project_name.TabIndex = 22;
            this.txt_project_name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_project_name.UseSystemPasswordChar = false;
            // 
            // txt_bug_title
            // 
            this.txt_bug_title.FocusedColor = "#508ef5";
            this.txt_bug_title.FontColor = "#999999";
            this.txt_bug_title.IsEnabled = true;
            this.txt_bug_title.Location = new System.Drawing.Point(15, 135);
            this.txt_bug_title.MaxLength = 32767;
            this.txt_bug_title.Multiline = false;
            this.txt_bug_title.Name = "txt_bug_title";
            this.txt_bug_title.ReadOnly = false;
            this.txt_bug_title.Size = new System.Drawing.Size(251, 24);
            this.txt_bug_title.TabIndex = 24;
            this.txt_bug_title.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_bug_title.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(12, 117);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(79, 17);
            this.lollipopLabel2.TabIndex = 23;
            this.lollipopLabel2.Text = "Title of bug";
            // 
            // txt_arthur
            // 
            this.txt_arthur.FocusedColor = "#508ef5";
            this.txt_arthur.FontColor = "#999999";
            this.txt_arthur.IsEnabled = true;
            this.txt_arthur.Location = new System.Drawing.Point(15, 216);
            this.txt_arthur.MaxLength = 32767;
            this.txt_arthur.Multiline = false;
            this.txt_arthur.Name = "txt_arthur";
            this.txt_arthur.ReadOnly = false;
            this.txt_arthur.Size = new System.Drawing.Size(251, 24);
            this.txt_arthur.TabIndex = 26;
            this.txt_arthur.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_arthur.UseSystemPasswordChar = false;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(12, 243);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(75, 17);
            this.lollipopLabel3.TabIndex = 25;
            this.lollipopLabel3.Text = "Source file";
            // 
            // txt_source_file
            // 
            this.txt_source_file.FocusedColor = "#508ef5";
            this.txt_source_file.FontColor = "#999999";
            this.txt_source_file.IsEnabled = true;
            this.txt_source_file.Location = new System.Drawing.Point(15, 263);
            this.txt_source_file.MaxLength = 32767;
            this.txt_source_file.Multiline = false;
            this.txt_source_file.Name = "txt_source_file";
            this.txt_source_file.ReadOnly = false;
            this.txt_source_file.Size = new System.Drawing.Size(251, 24);
            this.txt_source_file.TabIndex = 28;
            this.txt_source_file.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_source_file.UseSystemPasswordChar = false;
            this.txt_source_file.TextChanged += new System.EventHandler(this.lollipopTextBox4_TextChanged);
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(12, 290);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(81, 17);
            this.lollipopLabel4.TabIndex = 27;
            this.lollipopLabel4.Text = "Class name";
            // 
            // txt_method_line
            // 
            this.txt_method_line.FocusedColor = "#508ef5";
            this.txt_method_line.FontColor = "#999999";
            this.txt_method_line.IsEnabled = true;
            this.txt_method_line.Location = new System.Drawing.Point(15, 357);
            this.txt_method_line.MaxLength = 32767;
            this.txt_method_line.Multiline = false;
            this.txt_method_line.Name = "txt_method_line";
            this.txt_method_line.ReadOnly = false;
            this.txt_method_line.Size = new System.Drawing.Size(251, 24);
            this.txt_method_line.TabIndex = 30;
            this.txt_method_line.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_method_line.UseSystemPasswordChar = false;
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(12, 384);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(67, 17);
            this.lollipopLabel5.TabIndex = 29;
            this.lollipopLabel5.Text = "Code line";
            // 
            // txt_class_name
            // 
            this.txt_class_name.FocusedColor = "#508ef5";
            this.txt_class_name.FontColor = "#999999";
            this.txt_class_name.IsEnabled = true;
            this.txt_class_name.Location = new System.Drawing.Point(15, 310);
            this.txt_class_name.MaxLength = 32767;
            this.txt_class_name.Multiline = false;
            this.txt_class_name.Name = "txt_class_name";
            this.txt_class_name.ReadOnly = false;
            this.txt_class_name.Size = new System.Drawing.Size(251, 24);
            this.txt_class_name.TabIndex = 32;
            this.txt_class_name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_class_name.UseSystemPasswordChar = false;
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.AutoSize = true;
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel6.Location = new System.Drawing.Point(12, 196);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(86, 17);
            this.lollipopLabel6.TabIndex = 31;
            this.lollipopLabel6.Text = "Arthur name";
            this.lollipopLabel6.Click += new System.EventHandler(this.lollipopLabel6_Click);
            // 
            // txt_code_line
            // 
            this.txt_code_line.FocusedColor = "#508ef5";
            this.txt_code_line.FontColor = "#999999";
            this.txt_code_line.IsEnabled = true;
            this.txt_code_line.Location = new System.Drawing.Point(15, 404);
            this.txt_code_line.MaxLength = 32767;
            this.txt_code_line.Multiline = false;
            this.txt_code_line.Name = "txt_code_line";
            this.txt_code_line.ReadOnly = false;
            this.txt_code_line.Size = new System.Drawing.Size(251, 24);
            this.txt_code_line.TabIndex = 34;
            this.txt_code_line.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_code_line.UseSystemPasswordChar = false;
            // 
            // lollipopLabel7
            // 
            this.lollipopLabel7.AutoSize = true;
            this.lollipopLabel7.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel7.Location = new System.Drawing.Point(12, 173);
            this.lollipopLabel7.Name = "lollipopLabel7";
            this.lollipopLabel7.Size = new System.Drawing.Size(137, 17);
            this.lollipopLabel7.TabIndex = 33;
            this.lollipopLabel7.Text = "BUG INFORMATION";
            // 
            // lollipopLabel8
            // 
            this.lollipopLabel8.AutoSize = true;
            this.lollipopLabel8.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel8.Location = new System.Drawing.Point(12, 337);
            this.lollipopLabel8.Name = "lollipopLabel8";
            this.lollipopLabel8.Size = new System.Drawing.Size(81, 17);
            this.lollipopLabel8.TabIndex = 35;
            this.lollipopLabel8.Text = "Method line";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BGColor = "#508ef5";
            this.btn_update.FontColor = "#ffffff";
            this.btn_update.Location = new System.Drawing.Point(104, 467);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(80, 41);
            this.btn_update.TabIndex = 36;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BGColor = "#508ef5";
            this.btn_back.FontColor = "#ffffff";
            this.btn_back.Location = new System.Drawing.Point(190, 467);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(76, 41);
            this.btn_back.TabIndex = 37;
            this.btn_back.Text = "Back";
            // 
            // Bug_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 547);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lollipopLabel8);
            this.Controls.Add(this.txt_code_line);
            this.Controls.Add(this.lollipopLabel7);
            this.Controls.Add(this.txt_class_name);
            this.Controls.Add(this.lollipopLabel6);
            this.Controls.Add(this.txt_method_line);
            this.Controls.Add(this.lollipopLabel5);
            this.Controls.Add(this.txt_source_file);
            this.Controls.Add(this.lollipopLabel4);
            this.Controls.Add(this.txt_arthur);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.txt_bug_title);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.txt_project_name);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_validate);
            this.Name = "Bug_report";
            this.Text = "Bug_report";
            this.Load += new System.EventHandler(this.Bug_report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_validate;
        private LollipopButton btn_submit;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox txt_project_name;
        private LollipopTextBox txt_bug_title;
        private LollipopLabel lollipopLabel2;
        private LollipopTextBox txt_arthur;
        private LollipopLabel lollipopLabel3;
        private LollipopTextBox txt_source_file;
        private LollipopLabel lollipopLabel4;
        private LollipopTextBox txt_method_line;
        private LollipopLabel lollipopLabel5;
        private LollipopTextBox txt_class_name;
        private LollipopLabel lollipopLabel6;
        private LollipopTextBox txt_code_line;
        private LollipopLabel lollipopLabel7;
        private LollipopLabel lollipopLabel8;
        private LollipopButton btn_update;
        private LollipopButton btn_back;
    }
}