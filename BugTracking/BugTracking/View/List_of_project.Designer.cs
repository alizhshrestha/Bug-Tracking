namespace BugTracking
{
    partial class List_of_project
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
            this.data_view_project_list = new System.Windows.Forms.DataGridView();
            this.btn_update = new LollipopButton();
            this.btn_open = new LollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.data_view_project_list)).BeginInit();
            this.SuspendLayout();
            // 
            // data_view_project_list
            // 
            this.data_view_project_list.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_view_project_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view_project_list.Location = new System.Drawing.Point(12, 69);
            this.data_view_project_list.Name = "data_view_project_list";
            this.data_view_project_list.Size = new System.Drawing.Size(1008, 373);
            this.data_view_project_list.TabIndex = 0;
            this.data_view_project_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_view_project_list_CellContentClick);
            this.data_view_project_list.SelectionChanged += new System.EventHandler(this.data_view_project_list_SelectionChanged);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BGColor = "#508ef5";
            this.btn_update.FontColor = "#ffffff";
            this.btn_update.Location = new System.Drawing.Point(409, 461);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(143, 41);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Transparent;
            this.btn_open.BGColor = "#508ef5";
            this.btn_open.FontColor = "#ffffff";
            this.btn_open.Location = new System.Drawing.Point(247, 461);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(143, 41);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Add";
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click_1);
            // 
            // List_of_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 516);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.data_view_project_list);
            this.Name = "List_of_project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_of_project";
            this.Load += new System.EventHandler(this.List_of_project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view_project_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view_project_list;
        private LollipopButton btn_update;
        private LollipopButton btn_open;
    }
}