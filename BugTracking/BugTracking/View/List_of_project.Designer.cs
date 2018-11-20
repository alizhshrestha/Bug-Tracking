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
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_view_project_list)).BeginInit();
            this.SuspendLayout();
            // 
            // data_view_project_list
            // 
            this.data_view_project_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view_project_list.Location = new System.Drawing.Point(12, 12);
            this.data_view_project_list.Name = "data_view_project_list";
            this.data_view_project_list.Size = new System.Drawing.Size(776, 386);
            this.data_view_project_list.TabIndex = 0;
            this.data_view_project_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_view_project_list_CellContentClick);
            this.data_view_project_list.SelectionChanged += new System.EventHandler(this.data_view_project_list_SelectionChanged);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(279, 415);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "OPEN";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(374, 415);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // List_of_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.data_view_project_list);
            this.Name = "List_of_project";
            this.Text = "List_of_project";
            this.Load += new System.EventHandler(this.List_of_project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view_project_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view_project_list;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_update;
    }
}