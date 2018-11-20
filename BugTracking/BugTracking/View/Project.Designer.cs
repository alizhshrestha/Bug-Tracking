namespace BugTracking
{
    partial class Project
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
            this.dtme_start = new System.Windows.Forms.DateTimePicker();
            this.dtme_end = new System.Windows.Forms.DateTimePicker();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.lbl_validate = new System.Windows.Forms.Label();
            this.btn_submit = new LollipopButton();
            this.lollipopLabel1 = new LollipopLabel();
            this.txt_project_name = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel3 = new LollipopLabel();
            this.txt_arthur = new LollipopTextBox();
            this.lollipopLabel4 = new LollipopLabel();
            this.btn_update = new LollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtme_start
            // 
            this.dtme_start.Location = new System.Drawing.Point(20, 149);
            this.dtme_start.Name = "dtme_start";
            this.dtme_start.Size = new System.Drawing.Size(209, 20);
            this.dtme_start.TabIndex = 8;
            // 
            // dtme_end
            // 
            this.dtme_end.Location = new System.Drawing.Point(20, 192);
            this.dtme_end.Name = "dtme_end";
            this.dtme_end.Size = new System.Drawing.Size(209, 20);
            this.dtme_end.TabIndex = 9;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // lbl_validate
            // 
            this.lbl_validate.AutoSize = true;
            this.lbl_validate.Location = new System.Drawing.Point(17, 262);
            this.lbl_validate.Name = "lbl_validate";
            this.lbl_validate.Size = new System.Drawing.Size(0, 13);
            this.lbl_validate.TabIndex = 11;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_submit.BGColor = "#508ef5";
            this.btn_submit.FontColor = "#ffffff";
            this.btn_submit.Location = new System.Drawing.Point(20, 294);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 41);
            this.btn_submit.TabIndex = 13;
            this.btn_submit.Text = "Submit";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click_1);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(17, 81);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(110, 18);
            this.lollipopLabel1.TabIndex = 14;
            this.lollipopLabel1.Text = "Name of project";
            // 
            // txt_project_name
            // 
            this.txt_project_name.FocusedColor = "#508ef5";
            this.txt_project_name.FontColor = "#999999";
            this.txt_project_name.IsEnabled = true;
            this.txt_project_name.Location = new System.Drawing.Point(20, 102);
            this.txt_project_name.MaxLength = 32767;
            this.txt_project_name.Multiline = false;
            this.txt_project_name.Name = "txt_project_name";
            this.txt_project_name.ReadOnly = false;
            this.txt_project_name.Size = new System.Drawing.Size(209, 24);
            this.txt_project_name.TabIndex = 15;
            this.txt_project_name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_project_name.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(17, 129);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(70, 17);
            this.lollipopLabel2.TabIndex = 17;
            this.lollipopLabel2.Text = "Start date";
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(17, 172);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(65, 17);
            this.lollipopLabel3.TabIndex = 19;
            this.lollipopLabel3.Text = "End date";
            // 
            // txt_arthur
            // 
            this.txt_arthur.FocusedColor = "#508ef5";
            this.txt_arthur.FontColor = "#999999";
            this.txt_arthur.IsEnabled = true;
            this.txt_arthur.Location = new System.Drawing.Point(20, 235);
            this.txt_arthur.MaxLength = 32767;
            this.txt_arthur.Multiline = false;
            this.txt_arthur.Name = "txt_arthur";
            this.txt_arthur.ReadOnly = false;
            this.txt_arthur.Size = new System.Drawing.Size(209, 24);
            this.txt_arthur.TabIndex = 22;
            this.txt_arthur.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_arthur.UseSystemPasswordChar = false;
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(17, 215);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(50, 17);
            this.lollipopLabel4.TabIndex = 21;
            this.lollipopLabel4.Text = "Authur";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BGColor = "#508ef5";
            this.btn_update.FontColor = "#ffffff";
            this.btn_update.Location = new System.Drawing.Point(140, 294);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 41);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 353);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_arthur);
            this.Controls.Add(this.lollipopLabel4);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.txt_project_name);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_validate);
            this.Controls.Add(this.dtme_end);
            this.Controls.Add(this.dtme_start);
            this.Name = "Project";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtme_start;
        private System.Windows.Forms.DateTimePicker dtme_end;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label lbl_validate;
        private LollipopTextBox txt_arthur;
        private LollipopLabel lollipopLabel4;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel2;
        private LollipopTextBox txt_project_name;
        private LollipopLabel lollipopLabel1;
        private LollipopButton btn_submit;
        private LollipopButton btn_update;
    }
}