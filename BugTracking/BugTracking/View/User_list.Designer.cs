namespace BugTracking
{
    partial class User_list
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_edit = new LollipopButton();
            this.btn_delete = new LollipopButton();
            this.lblInvalid = new LollipopLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1008, 373);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BGColor = "#508ef5";
            this.btn_edit.FontColor = "#ffffff";
            this.btn_edit.Location = new System.Drawing.Point(386, 490);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(143, 41);
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Text = "Edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BGColor = "#508ef5";
            this.btn_delete.FontColor = "#ffffff";
            this.btn_delete.Location = new System.Drawing.Point(554, 490);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(143, 41);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalid.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lblInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblInvalid.Location = new System.Drawing.Point(383, 469);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(0, 18);
            this.lblInvalid.TabIndex = 2;
            // 
            // User_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 543);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "User_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_list";
            this.Load += new System.EventHandler(this.User_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LollipopButton btn_edit;
        private LollipopButton btn_delete;
        private LollipopLabel lblInvalid;
    }
}