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
            // 
            // List_of_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_view_project_list);
            this.Name = "List_of_project";
            this.Text = "List_of_project";
            this.Load += new System.EventHandler(this.List_of_project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view_project_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view_project_list;
    }
}