namespace BugTracking.View
{
    partial class User_dashboard
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
            this.MenuStripItem = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fixToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.form_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_menu_item = new System.Windows.Forms.Panel();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripItem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripItem
            // 
            this.MenuStripItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.listToolStripMenuItem,
            this.editToolStripMenuItem});
            this.MenuStripItem.Location = new System.Drawing.Point(0, 0);
            this.MenuStripItem.Name = "MenuStripItem";
            this.MenuStripItem.Size = new System.Drawing.Size(483, 24);
            this.MenuStripItem.TabIndex = 0;
            this.MenuStripItem.Text = "menuStrip1";
            this.MenuStripItem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStripItem_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listProjectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // listProjectToolStripMenuItem
            // 
            this.listProjectToolStripMenuItem.Name = "listProjectToolStripMenuItem";
            this.listProjectToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.listProjectToolStripMenuItem.Text = "List Project";
            this.listProjectToolStripMenuItem.Click += new System.EventHandler(this.listProjectToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugToolStripMenuItem1,
            this.fixToolStripMenuItem1});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.listToolStripMenuItem.Text = "List";
            // 
            // bugToolStripMenuItem1
            // 
            this.bugToolStripMenuItem1.Name = "bugToolStripMenuItem1";
            this.bugToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bugToolStripMenuItem1.Text = "Bug";
            this.bugToolStripMenuItem1.Click += new System.EventHandler(this.bugToolStripMenuItem1_Click);
            // 
            // fixToolStripMenuItem1
            // 
            this.fixToolStripMenuItem1.Name = "fixToolStripMenuItem1";
            this.fixToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fixToolStripMenuItem1.Text = "Fix";
            this.fixToolStripMenuItem1.Click += new System.EventHandler(this.fixToolStripMenuItem1_Click);
            // 
            // form_panel
            // 
            this.form_panel.AutoSize = true;
            this.form_panel.Location = new System.Drawing.Point(0, 27);
            this.form_panel.Name = "form_panel";
            this.form_panel.Size = new System.Drawing.Size(0, 0);
            this.form_panel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_menu_item);
            this.panel1.Controls.Add(this.form_panel);
            this.panel1.Controls.Add(this.MenuStripItem);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 411);
            this.panel1.TabIndex = 0;
            // 
            // pnl_menu_item
            // 
            this.pnl_menu_item.Location = new System.Drawing.Point(0, 27);
            this.pnl_menu_item.Name = "pnl_menu_item";
            this.pnl_menu_item.Size = new System.Drawing.Size(480, 381);
            this.pnl_menu_item.TabIndex = 2;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // User_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 425);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.MenuStripItem;
            this.Name = "User_dashboard";
            this.Text = "User_dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MenuStripItem.ResumeLayout(false);
            this.MenuStripItem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fixToolStripMenuItem1;
        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_menu_item;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
    }
}