namespace Zutubi.Pulse.Api.Example
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.qTabControl1 = new Qios.DevSuite.Components.QTabControl();
            this.DashboardTab = new Qios.DevSuite.Components.QTabPage();
            this.LogoutButton = new Qios.DevSuite.Components.QButton();
            this.BrowseTab = new Qios.DevSuite.Components.QTabPage();
            this.ProjectListView = new System.Windows.Forms.ListView();
            this.ProjectNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastBuildColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastBuildStatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RevisionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeBuildRanColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeToBuildColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BuildReasonColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TestsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServerTab = new Qios.DevSuite.Components.QTabPage();
            this.AgentsTab = new Qios.DevSuite.Components.QTabPage();
            this.AdministrationTab = new Qios.DevSuite.Components.QTabPage();
            this.qTabControl2 = new Qios.DevSuite.Components.QTabControl();
            this.ProjectsTab = new Qios.DevSuite.Components.QTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.UsersAdminTab = new Qios.DevSuite.Components.QTabPage();
            this.AgentAdminTab = new Qios.DevSuite.Components.QTabPage();
            this.SettingsTab = new Qios.DevSuite.Components.QTabPage();
            this.GroupAdminTab = new Qios.DevSuite.Components.QTabPage();
            this.PluginsAdminTab = new Qios.DevSuite.Components.QTabPage();
            this.qPersistenceManager1 = new Qios.DevSuite.Components.QPersistenceManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qTabControl1)).BeginInit();
            this.qTabControl1.SuspendLayout();
            this.BrowseTab.SuspendLayout();
            this.AdministrationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qTabControl2)).BeginInit();
            this.qTabControl2.SuspendLayout();
            this.ProjectsTab.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qTabControl1
            // 
            this.qTabControl1.ActiveTabPage = this.DashboardTab;
            this.qTabControl1.ColorScheme.TabButtonActiveBackground1.SetColor("Default", System.Drawing.Color.Orange, false);
            this.qTabControl1.ColorScheme.TabButtonActiveBackground2.SetColor("Default", System.Drawing.Color.OrangeRed, false);
            this.qTabControl1.ColorScheme.TabButtonBackground1.SetColor("Default", System.Drawing.Color.Orange, false);
            this.qTabControl1.ColorScheme.TabButtonBackground2.SetColor("Default", System.Drawing.Color.Chocolate, false);
            this.qTabControl1.ColorScheme.TabControlBackground1.SetColor("Default", System.Drawing.Color.Red, false);
            this.qTabControl1.ColorScheme.TabControlBackground2.SetColor("Default", System.Drawing.Color.Maroon, false);
            this.qTabControl1.ColorScheme.TabControlBorder.SetColor("Default", System.Drawing.Color.Lime, false);
            this.qTabControl1.ColorScheme.TabControlContentBackground1.SetColor("Default", System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))), false);
            this.qTabControl1.ColorScheme.TabControlContentBorder.SetColor("Default", System.Drawing.Color.Black, false);
            this.qTabControl1.ColorScheme.TabPageBackground1.SetColor("Default", System.Drawing.Color.LavenderBlush, false);
            this.qTabControl1.ColorScheme.TabPageBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.qTabControl1.ColorScheme.TabPageBorder.SetColor("Default", System.Drawing.Color.White, false);
            this.qTabControl1.ColorScheme.TabStripBackground1.SetColor("Default", System.Drawing.Color.Red, false);
            this.qTabControl1.ColorScheme.TabStripBackground2.SetColor("Default", System.Drawing.Color.DarkRed, false);
            this.qTabControl1.ColorScheme.TabStripNavigationAreaBackground1.SetColor("Default", System.Drawing.Color.OrangeRed, false);
            this.qTabControl1.ColorScheme.TabStripNavigationAreaBackground2.SetColor("Default", System.Drawing.Color.DarkRed, false);
            this.qTabControl1.Controls.Add(this.LogoutButton);
            this.qTabControl1.Controls.Add(this.DashboardTab);
            this.qTabControl1.Controls.Add(this.BrowseTab);
            this.qTabControl1.Controls.Add(this.ServerTab);
            this.qTabControl1.Controls.Add(this.AgentsTab);
            this.qTabControl1.Controls.Add(this.AdministrationTab);
            this.qTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qTabControl1.FocusTabButtons = false;
            this.qTabControl1.Location = new System.Drawing.Point(0, 0);
            this.qTabControl1.Name = "qTabControl1";
            this.qTabControl1.PersistGuid = new System.Guid("132ce42f-091d-4d75-9d44-53589b049496");
            this.qTabControl1.Size = new System.Drawing.Size(791, 547);
            this.qTabControl1.TabIndex = 0;
            this.qTabControl1.TabStripBottomConfiguration.AllowDrag = false;
            this.qTabControl1.TabStripBottomConfiguration.AllowDrop = false;
            this.qTabControl1.TabStripLeftConfiguration.AllowDrag = false;
            this.qTabControl1.TabStripLeftConfiguration.AllowDrop = false;
            this.qTabControl1.TabStripRightConfiguration.AllowDrag = false;
            this.qTabControl1.TabStripRightConfiguration.AllowDrop = false;
            this.qTabControl1.TabStripTopConfiguration.SizeBehavior = ((Qios.DevSuite.Components.QTabStripSizeBehaviors)((Qios.DevSuite.Components.QTabStripSizeBehaviors.Shrink | Qios.DevSuite.Components.QTabStripSizeBehaviors.Scroll)));
            this.qTabControl1.Text = "qTabControl1";
            // 
            // DashboardTab
            // 
            this.DashboardTab.ButtonOrder = 0;
            this.DashboardTab.Location = new System.Drawing.Point(0, 27);
            this.DashboardTab.Name = "DashboardTab";
            this.DashboardTab.PersistGuid = new System.Guid("93b1d06e-fd51-456b-8f5e-aad1c15ddcef");
            this.DashboardTab.Size = new System.Drawing.Size(789, 518);
            this.DashboardTab.Text = "Dashboard";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.ColorScheme.ButtonBackground1.SetColor("Default", System.Drawing.Color.DarkGreen, false);
            this.LogoutButton.ColorScheme.ButtonBackground2.SetColor("Default", System.Drawing.Color.Lime, false);
            this.LogoutButton.ColorScheme.ButtonFocusedInnerGlow.SetColor("Default", System.Drawing.Color.MediumSeaGreen, false);
            this.LogoutButton.ColorScheme.ButtonHotBackground1.SetColor("Default", System.Drawing.Color.MediumSeaGreen, false);
            this.LogoutButton.ColorScheme.ButtonHotBackground2.SetColor("Default", System.Drawing.Color.Lime, false);
            this.LogoutButton.ColorScheme.ButtonPressedBackground1.SetColor("Default", System.Drawing.Color.MediumSeaGreen, false);
            this.LogoutButton.ColorScheme.ButtonPressedBackground2.SetColor("Default", System.Drawing.Color.Lime, false);
            this.LogoutButton.ColorScheme.ButtonPressedBorder.SetColor("Default", System.Drawing.Color.Black, false);
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.Image = null;
            this.LogoutButton.Location = new System.Drawing.Point(709, 3);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.PaintTransparentBackground = true;
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.Click += new System.EventHandler(this.qButton1_Click);
            // 
            // BrowseTab
            // 
            this.BrowseTab.ButtonOrder = 1;
            this.BrowseTab.Controls.Add(this.ProjectListView);
            this.BrowseTab.Location = new System.Drawing.Point(0, 27);
            this.BrowseTab.Name = "BrowseTab";
            this.BrowseTab.PersistGuid = new System.Guid("35d6615e-ba40-4057-864a-89ae8497e6dc");
            this.BrowseTab.Size = new System.Drawing.Size(791, 520);
            this.BrowseTab.Text = "Browse";
            // 
            // ProjectListView
            // 
            this.ProjectListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ProjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectNameColumn,
            this.LastBuildColumn,
            this.LastBuildStatusColumn,
            this.RevisionColumn,
            this.TimeBuildRanColumn,
            this.TimeToBuildColumn,
            this.BuildReasonColumn,
            this.TestsColumn});
            this.ProjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectListView.GridLines = true;
            this.ProjectListView.Location = new System.Drawing.Point(0, 0);
            this.ProjectListView.MultiSelect = false;
            this.ProjectListView.Name = "ProjectListView";
            this.ProjectListView.ShowGroups = false;
            this.ProjectListView.Size = new System.Drawing.Size(791, 520);
            this.ProjectListView.TabIndex = 0;
            this.ProjectListView.UseCompatibleStateImageBehavior = false;
            this.ProjectListView.View = System.Windows.Forms.View.Details;
            // 
            // ProjectNameColumn
            // 
            this.ProjectNameColumn.Text = "Name";
            this.ProjectNameColumn.Width = 83;
            // 
            // LastBuildColumn
            // 
            this.LastBuildColumn.Text = "Last Build";
            // 
            // LastBuildStatusColumn
            // 
            this.LastBuildStatusColumn.Text = "Result";
            this.LastBuildStatusColumn.Width = 96;
            // 
            // RevisionColumn
            // 
            this.RevisionColumn.Text = "Revision";
            // 
            // TimeBuildRanColumn
            // 
            this.TimeBuildRanColumn.Text = "When";
            // 
            // TimeToBuildColumn
            // 
            this.TimeToBuildColumn.Text = "Time";
            // 
            // BuildReasonColumn
            // 
            this.BuildReasonColumn.Text = "Reason";
            // 
            // TestsColumn
            // 
            this.TestsColumn.Text = "Tests";
            // 
            // ServerTab
            // 
            this.ServerTab.ButtonOrder = 2;
            this.ServerTab.Location = new System.Drawing.Point(0, 27);
            this.ServerTab.Name = "ServerTab";
            this.ServerTab.PersistGuid = new System.Guid("937adc21-d9fc-4a24-beb0-a571a39dabc8");
            this.ServerTab.Size = new System.Drawing.Size(791, 520);
            this.ServerTab.Text = "Server";
            // 
            // AgentsTab
            // 
            this.AgentsTab.ButtonOrder = 3;
            this.AgentsTab.Location = new System.Drawing.Point(0, 27);
            this.AgentsTab.Name = "AgentsTab";
            this.AgentsTab.PersistGuid = new System.Guid("29d950db-efa6-4fc0-9851-ea8d3126d772");
            this.AgentsTab.Size = new System.Drawing.Size(791, 520);
            this.AgentsTab.Text = "Agents";
            // 
            // AdministrationTab
            // 
            this.AdministrationTab.ButtonOrder = 4;
            this.AdministrationTab.Controls.Add(this.qTabControl2);
            this.AdministrationTab.Location = new System.Drawing.Point(0, 27);
            this.AdministrationTab.Name = "AdministrationTab";
            this.AdministrationTab.PersistGuid = new System.Guid("b099d871-2f68-4941-9d58-34d90fc6ee06");
            this.AdministrationTab.Size = new System.Drawing.Size(791, 520);
            this.AdministrationTab.Text = "Administration";
            // 
            // qTabControl2
            // 
            this.qTabControl2.ActiveTabPage = this.ProjectsTab;
            this.qTabControl2.ColorScheme.TabButtonActiveBackground1.SetColor("Default", System.Drawing.Color.Orange, false);
            this.qTabControl2.ColorScheme.TabButtonActiveBackground2.SetColor("Default", System.Drawing.Color.OrangeRed, false);
            this.qTabControl2.ColorScheme.TabButtonBackground1.SetColor("Default", System.Drawing.Color.Orange, false);
            this.qTabControl2.ColorScheme.TabButtonBackground2.SetColor("Default", System.Drawing.Color.Chocolate, false);
            this.qTabControl2.ColorScheme.TabControlBackground1.SetColor("Default", System.Drawing.Color.Red, false);
            this.qTabControl2.ColorScheme.TabControlBackground2.SetColor("Default", System.Drawing.Color.Maroon, false);
            this.qTabControl2.ColorScheme.TabControlBorder.SetColor("Default", System.Drawing.Color.Lime, false);
            this.qTabControl2.ColorScheme.TabControlContentBackground1.SetColor("Default", System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))), false);
            this.qTabControl2.ColorScheme.TabControlContentBorder.SetColor("Default", System.Drawing.Color.Black, false);
            this.qTabControl2.ColorScheme.TabPageBackground1.SetColor("Default", System.Drawing.Color.LavenderBlush, false);
            this.qTabControl2.ColorScheme.TabPageBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.qTabControl2.ColorScheme.TabPageBorder.SetColor("Default", System.Drawing.Color.White, false);
            this.qTabControl2.ColorScheme.TabStripBackground1.SetColor("Default", System.Drawing.Color.Red, false);
            this.qTabControl2.ColorScheme.TabStripBackground2.SetColor("Default", System.Drawing.Color.DarkRed, false);
            this.qTabControl2.ColorScheme.TabStripNavigationAreaBackground1.SetColor("Default", System.Drawing.Color.OrangeRed, false);
            this.qTabControl2.ColorScheme.TabStripNavigationAreaBackground2.SetColor("Default", System.Drawing.Color.DarkRed, false);
            this.qTabControl2.Controls.Add(this.ProjectsTab);
            this.qTabControl2.Controls.Add(this.UsersAdminTab);
            this.qTabControl2.Controls.Add(this.AgentAdminTab);
            this.qTabControl2.Controls.Add(this.SettingsTab);
            this.qTabControl2.Controls.Add(this.GroupAdminTab);
            this.qTabControl2.Controls.Add(this.PluginsAdminTab);
            this.qTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qTabControl2.FocusTabButtons = false;
            this.qTabControl2.Location = new System.Drawing.Point(0, 0);
            this.qTabControl2.Name = "qTabControl2";
            this.qTabControl2.PersistGuid = new System.Guid("132ce42f-091d-4d75-9d44-53589b049496");
            this.qTabControl2.Size = new System.Drawing.Size(791, 520);
            this.qTabControl2.TabIndex = 1;
            this.qTabControl2.TabStripBottomConfiguration.AllowDrag = false;
            this.qTabControl2.TabStripBottomConfiguration.AllowDrop = false;
            this.qTabControl2.TabStripLeftConfiguration.AllowDrag = false;
            this.qTabControl2.TabStripLeftConfiguration.AllowDrop = false;
            this.qTabControl2.TabStripRightConfiguration.AllowDrag = false;
            this.qTabControl2.TabStripRightConfiguration.AllowDrop = false;
            this.qTabControl2.TabStripTopConfiguration.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.SquareTabStrip);
            this.qTabControl2.TabStripTopConfiguration.ButtonConfiguration.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedTab);
            this.qTabControl2.TabStripTopConfiguration.ButtonConfiguration.AppearanceActive.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedTab);
            this.qTabControl2.TabStripTopConfiguration.SizeBehavior = ((Qios.DevSuite.Components.QTabStripSizeBehaviors)((Qios.DevSuite.Components.QTabStripSizeBehaviors.Shrink | Qios.DevSuite.Components.QTabStripSizeBehaviors.Scroll)));
            this.qTabControl2.Text = "qTabControl2";
            // 
            // ProjectsTab
            // 
            this.ProjectsTab.ButtonOrder = 0;
            this.ProjectsTab.Controls.Add(this.splitContainer1);
            this.ProjectsTab.Location = new System.Drawing.Point(0, 27);
            this.ProjectsTab.Name = "ProjectsTab";
            this.ProjectsTab.PersistGuid = new System.Guid("93b1d06e-fd51-456b-8f5e-aad1c15ddcef");
            this.ProjectsTab.Size = new System.Drawing.Size(789, 491);
            this.ProjectsTab.Text = "Projects";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(789, 491);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.DarkSalmon;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(260, 491);
            this.treeView1.TabIndex = 0;
            // 
            // UsersAdminTab
            // 
            this.UsersAdminTab.ButtonOrder = 3;
            this.UsersAdminTab.Location = new System.Drawing.Point(0, 27);
            this.UsersAdminTab.Name = "UsersAdminTab";
            this.UsersAdminTab.PersistGuid = new System.Guid("29d950db-efa6-4fc0-9851-ea8d3126d772");
            this.UsersAdminTab.Size = new System.Drawing.Size(789, 491);
            this.UsersAdminTab.Text = "Users";
            // 
            // AgentAdminTab
            // 
            this.AgentAdminTab.ButtonOrder = 1;
            this.AgentAdminTab.Location = new System.Drawing.Point(0, 27);
            this.AgentAdminTab.Name = "AgentAdminTab";
            this.AgentAdminTab.PersistGuid = new System.Guid("35d6615e-ba40-4057-864a-89ae8497e6dc");
            this.AgentAdminTab.Size = new System.Drawing.Size(789, 491);
            this.AgentAdminTab.Text = "Agents";
            // 
            // SettingsTab
            // 
            this.SettingsTab.ButtonOrder = 2;
            this.SettingsTab.Location = new System.Drawing.Point(0, 27);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.PersistGuid = new System.Guid("937adc21-d9fc-4a24-beb0-a571a39dabc8");
            this.SettingsTab.Size = new System.Drawing.Size(789, 491);
            this.SettingsTab.Text = "Settings";
            // 
            // GroupAdminTab
            // 
            this.GroupAdminTab.ButtonOrder = 4;
            this.GroupAdminTab.Location = new System.Drawing.Point(0, 27);
            this.GroupAdminTab.Name = "GroupAdminTab";
            this.GroupAdminTab.PersistGuid = new System.Guid("b099d871-2f68-4941-9d58-34d90fc6ee06");
            this.GroupAdminTab.Size = new System.Drawing.Size(789, 491);
            this.GroupAdminTab.Text = "Groups";
            // 
            // PluginsAdminTab
            // 
            this.PluginsAdminTab.ButtonOrder = 5;
            this.PluginsAdminTab.Location = new System.Drawing.Point(0, 27);
            this.PluginsAdminTab.Name = "PluginsAdminTab";
            this.PluginsAdminTab.PersistGuid = new System.Guid("164e5e04-de30-40ce-a593-76e658a1e482");
            this.PluginsAdminTab.Size = new System.Drawing.Size(789, 491);
            this.PluginsAdminTab.Text = "Plugins";
            // 
            // qPersistenceManager1
            // 
            this.qPersistenceManager1.OwnerControl = this.qTabControl1;
            this.qPersistenceManager1.PersistGuid = new System.Guid("7ac91e4a-4298-4d42-8f81-56efe3db6ea6");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 547);
            this.Controls.Add(this.qTabControl1);
            this.Name = "MainForm";
            this.Text = "Remote Pulse Administration v1.3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qTabControl1)).EndInit();
            this.qTabControl1.ResumeLayout(false);
            this.BrowseTab.ResumeLayout(false);
            this.AdministrationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qTabControl2)).EndInit();
            this.qTabControl2.ResumeLayout(false);
            this.ProjectsTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.QTabControl qTabControl1;
        private Qios.DevSuite.Components.QTabPage DashboardTab;
        private Qios.DevSuite.Components.QTabPage BrowseTab;
        private Qios.DevSuite.Components.QTabPage ServerTab;
        private Qios.DevSuite.Components.QPersistenceManager qPersistenceManager1;
        private Qios.DevSuite.Components.QTabPage AgentsTab;
        private Qios.DevSuite.Components.QTabPage AdministrationTab;
        private Qios.DevSuite.Components.QTabControl qTabControl2;
        private Qios.DevSuite.Components.QTabPage ProjectsTab;
        private Qios.DevSuite.Components.QTabPage AgentAdminTab;
        private Qios.DevSuite.Components.QTabPage SettingsTab;
        private Qios.DevSuite.Components.QTabPage UsersAdminTab;
        private Qios.DevSuite.Components.QTabPage GroupAdminTab;
        private Qios.DevSuite.Components.QTabPage PluginsAdminTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView ProjectListView;
        private System.Windows.Forms.ColumnHeader ProjectNameColumn;
        private System.Windows.Forms.ColumnHeader LastBuildColumn;
        private System.Windows.Forms.ColumnHeader LastBuildStatusColumn;
        private System.Windows.Forms.ColumnHeader RevisionColumn;
        private System.Windows.Forms.ColumnHeader TimeBuildRanColumn;
        private System.Windows.Forms.ColumnHeader TimeToBuildColumn;
        private System.Windows.Forms.ColumnHeader BuildReasonColumn;
        private System.Windows.Forms.ColumnHeader TestsColumn;
        private Qios.DevSuite.Components.QButton LogoutButton;

    }
}