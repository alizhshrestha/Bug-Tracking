namespace BugTracking.View
{
    partial class Dashboard
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
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fixToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.form_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_menu_item = new System.Windows.Forms.Panel();
            this.MenuStripItem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripItem
            // 
            this.MenuStripItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.listToolStripMenuItem});
            this.MenuStripItem.Location = new System.Drawing.Point(0, 0);
            this.MenuStripItem.Name = "MenuStripItem";
            this.MenuStripItem.Size = new System.Drawing.Size(483, 24);
            this.MenuStripItem.TabIndex = 0;
            this.MenuStripItem.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.listProjectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // listProjectToolStripMenuItem
            // 
            this.listProjectToolStripMenuItem.Name = "listProjectToolStripMenuItem";
            this.listProjectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.listProjectToolStripMenuItem.Text = "List Project";
            this.listProjectToolStripMenuItem.Click += new System.EventHandler(this.listProjectToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugToolStripMenuItem,
            this.fixToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // bugToolStripMenuItem
            // 
            this.bugToolStripMenuItem.Name = "bugToolStripMenuItem";
            this.bugToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.bugToolStripMenuItem.Text = "Bug";
            this.bugToolStripMenuItem.Click += new System.EventHandler(this.bugToolStripMenuItem_Click);
            // 
            // fixToolStripMenuItem
            // 
            this.fixToolStripMenuItem.Name = "fixToolStripMenuItem";
            this.fixToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.fixToolStripMenuItem.Text = "Fix";
            this.fixToolStripMenuItem.Click += new System.EventHandler(this.fixToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.bugToolStripMenuItem1,
            this.fixToolStripMenuItem1});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.listToolStripMenuItem.Text = "List";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // bugToolStripMenuItem1
            // 
            this.bugToolStripMenuItem1.Name = "bugToolStripMenuItem1";
            this.bugToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.bugToolStripMenuItem1.Text = "Bug";
            this.bugToolStripMenuItem1.Click += new System.EventHandler(this.bugToolStripMenuItem1_Click);
            // 
            // fixToolStripMenuItem1
            // 
            this.fixToolStripMenuItem1.Name = "fixToolStripMenuItem1";
            this.fixToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 425);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.MenuStripItem;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
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
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fixToolStripMenuItem1;
        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_menu_item;
    }
}