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
            this.project_list_data_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.project_list_data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // project_list_data_view
            // 
            this.project_list_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.project_list_data_view.Location = new System.Drawing.Point(12, 12);
            this.project_list_data_view.Name = "project_list_data_view";
            this.project_list_data_view.Size = new System.Drawing.Size(776, 386);
            this.project_list_data_view.TabIndex = 0;
            // 
            // List_of_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.project_list_data_view);
            this.Name = "List_of_project";
            this.Text = "List_of_project";
            ((System.ComponentModel.ISupportInitialize)(this.project_list_data_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView project_list_data_view;
    }
}