﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking.View
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            project.ShowDialog();
        }

        private void listProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_of_project list_of_project = new List_of_project();
            list_of_project.ShowDialog();
        }

        private void bugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bug_report bug_report = new Bug_report();
            bug_report.ShowDialog();
        }

        private void fixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fix_report fix_report = new Fix_report();
            fix_report.ShowDialog();
        }

        private void bugToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bug_list bug_list = new Bug_list();
            bug_list.ShowDialog();
        }

        private void fixToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bug_fix_list bug_fix_list = new Bug_fix_list();
            bug_fix_list.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        //panel_item.Refresh();
        //Project project = new Project();
        //project.TopLevel = false;
        //panel_item.Controls.Add(project);
        //project.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //project.Dock = DockStyle.Fill;
        //project.Show();
    }
}