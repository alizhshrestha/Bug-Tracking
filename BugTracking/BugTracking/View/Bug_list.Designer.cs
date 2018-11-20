namespace BugTracking.View
{
    partial class Bug_list
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
            this.btn_update_fix = new LollipopButton();
            this.btn_fix = new LollipopButton();
            this.btn_update = new LollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_update_fix
            // 
            this.btn_update_fix.BackColor = System.Drawing.Color.Transparent;
            this.btn_update_fix.BGColor = "#508ef5";
            this.btn_update_fix.FontColor = "#ffffff";
            this.btn_update_fix.Location = new System.Drawing.Point(558, 381);
            this.btn_update_fix.Name = "btn_update_fix";
            this.btn_update_fix.Size = new System.Drawing.Size(143, 41);
            this.btn_update_fix.TabIndex = 6;
            this.btn_update_fix.Text = "Update fix";
            this.btn_update_fix.Click += new System.EventHandler(this.btn_update_fix_Click_1);
            // 
            // btn_fix
            // 
            this.btn_fix.BackColor = System.Drawing.Color.Transparent;
            this.btn_fix.BGColor = "#508ef5";
            this.btn_fix.FontColor = "#ffffff";
            this.btn_fix.Location = new System.Drawing.Point(217, 381);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(143, 41);
            this.btn_fix.TabIndex = 5;
            this.btn_fix.Text = "Fix";
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BGColor = "#508ef5";
            this.btn_update.FontColor = "#ffffff";
            this.btn_update.Location = new System.Drawing.Point(390, 381);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(143, 41);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // Bug_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 451);
            this.Controls.Add(this.btn_update_fix);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bug_list";
            this.Text = "Bug_list";
            this.Load += new System.EventHandler(this.Bug_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LollipopButton btn_update;
        private LollipopButton btn_fix;
        private LollipopButton btn_update_fix;
    }
}