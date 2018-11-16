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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_project_name = new System.Windows.Forms.TextBox();
            this.txt_arthur = new System.Windows.Forms.TextBox();
            this.dtme_start = new System.Windows.Forms.DateTimePicker();
            this.dtme_end = new System.Windows.Forms.DateTimePicker();
            this.btn_submit = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.lbl_validate = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the project: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arthur:";
            // 
            // txt_project_name
            // 
            this.txt_project_name.Location = new System.Drawing.Point(167, 20);
            this.txt_project_name.Name = "txt_project_name";
            this.txt_project_name.Size = new System.Drawing.Size(200, 20);
            this.txt_project_name.TabIndex = 4;
            // 
            // txt_arthur
            // 
            this.txt_arthur.Location = new System.Drawing.Point(167, 143);
            this.txt_arthur.Name = "txt_arthur";
            this.txt_arthur.Size = new System.Drawing.Size(200, 20);
            this.txt_arthur.TabIndex = 7;
            // 
            // dtme_start
            // 
            this.dtme_start.Location = new System.Drawing.Point(167, 62);
            this.dtme_start.Name = "dtme_start";
            this.dtme_start.Size = new System.Drawing.Size(200, 20);
            this.dtme_start.TabIndex = 8;
            // 
            // dtme_end
            // 
            this.dtme_end.Location = new System.Drawing.Point(167, 103);
            this.dtme_end.Name = "dtme_end";
            this.dtme_end.Size = new System.Drawing.Size(200, 20);
            this.dtme_end.TabIndex = 9;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(167, 207);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(84, 34);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // lbl_validate
            // 
            this.lbl_validate.AutoSize = true;
            this.lbl_validate.Location = new System.Drawing.Point(164, 177);
            this.lbl_validate.Name = "lbl_validate";
            this.lbl_validate.Size = new System.Drawing.Size(0, 13);
            this.lbl_validate.TabIndex = 11;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(257, 207);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(84, 34);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 253);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_validate);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.dtme_end);
            this.Controls.Add(this.dtme_start);
            this.Controls.Add(this.txt_arthur);
            this.Controls.Add(this.txt_project_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Project";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_project_name;
        private System.Windows.Forms.TextBox txt_arthur;
        private System.Windows.Forms.DateTimePicker dtme_start;
        private System.Windows.Forms.DateTimePicker dtme_end;
        private System.Windows.Forms.Button btn_submit;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label lbl_validate;
        private System.Windows.Forms.Button btn_update;
    }
}