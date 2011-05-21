using System;
using System.Windows.Forms;
using Zutubi.Pulse.Api;
using Zutubi.Pulse.Api.Types;
using System.Collections.Generic;

namespace Zutubi.Pulse.Api.Example
{
    public partial class MainForm : Form
    {
        internal static ProjectList Projects = new ProjectList();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.ServerLogin.ShowDialog();
            ReloadProjectList();
        }

        private static void ReloadProjectList()
        {
            Projects.Clear();
            foreach (string s in Interface.GetAllProjectNames())
            {
                TreeNode tn = Program.MainForm.ProjectAdminHierarchyTreeView.Nodes[0];
                TreeNode projectNode = tn.Nodes.Add(s);
                projectNode.ImageIndex = 1;
                projectNode.SelectedImageIndex = 1;
                Project p = new Project(s);
                ListViewItem i = Program.MainForm.ProjectListView.Items.Add(s);
                List<BuildResult> builds = Interface.GetLatestBuildsForProject(s, false, 20);
                ProjectStatus status = new List<ProjectStatus>(Interface.GetStatusForProjects(new string[] { s },true).Projects)[0];
                p.Builds = builds;
                p.ProjectStatus = status;
                p.ProjectHealth = status.Health;
                BuildResult br = builds[0];
                i.SubItems.Add(br.ID.ToString());
                i.SubItems.Add(br.Status.ToString());
                i.SubItems.Add(br.Revision);
                i.SubItems.Add(br.StartTime.ToString());
                if (br.Completed)
                {
                    int time = (Int32)((Int64.Parse(br.EndTimeMillis) - Int64.Parse(br.StartTimeMillis)) / 1000);
                    i.SubItems.Add(time.ToString() + " Seconds");
                }
                else
                {
                    i.SubItems.Add("N/A");
                }
                i.SubItems.Add(br.Reason);
                i.SubItems.Add(br.Tests.Total.ToString());
                Projects.Add(p);
            }
        }

        private void qButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ProjectAdminHierarchyCollapseAllButton_Click(object sender, EventArgs e)
        {
            this.ProjectAdminHierarchyTreeView.CollapseAll();
        }

        private void ProjectAdminHierarchyExpandAllButton_Click(object sender, EventArgs e)
        {
            this.ProjectAdminHierarchyTreeView.ExpandAll();
        }
   }
}