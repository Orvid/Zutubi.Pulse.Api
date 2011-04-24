using System;
using System.Windows.Forms;
using Zutubi.Pulse.Api;
using Zutubi.Pulse.Api.Types;
using System.Collections.Generic;

namespace Zutubi.Pulse.Api.Example
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.ServerLogin.ShowDialog();
            foreach (string s in Interface.GetAllProjectNames()) 
            {
                ListViewItem i = ProjectListView.Items.Add(s);
                List<BuildResult> builds = Interface.GetLatestBuildsForProject(s, false, 1);
                BuildResult br = builds[0];
                i.SubItems.Add(br.ID.ToString());
                i.SubItems.Add(br.Status);
                i.SubItems.Add(br.Revision);
                i.SubItems.Add(br.StartTime.ToString());
                i.SubItems.Add("0");
                i.SubItems.Add(br.Reason);
                i.SubItems.Add(br.Tests.Total.ToString());
            }
        }

        private void qButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
   }
}