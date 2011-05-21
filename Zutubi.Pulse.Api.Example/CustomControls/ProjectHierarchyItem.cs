using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Zutubi.Pulse.Api.Example.CustomControls
{
    public partial class ProjectHierarchyItem : UserControl, ISupportInitialize
    {
        #region Properties
        private bool showConfigure = false;
        /// <summary>
        /// Get's or sets wether the 
        /// Configure button will be shown.
        /// Setting this value only has effect if
        /// done before the EndInit function is called, 
        /// at that point all properties take effect.
        /// </summary>
        public bool ShowConfigure 
        {
            get 
            {
                return showConfigure;
            }
            set 
            {
                showConfigure = value;
            }
        }
        private bool showAddNew = false;
        /// <summary>
        /// Get's or sets wether the 
        /// Add New button will be shown.
        /// Setting this value only has effect if
        /// done before the EndInit function is called, 
        /// at that point all properties take effect.
        /// </summary>
        public bool ShowAddNew 
        {
            get
            {
                return showAddNew;
            }
            set
            {
                showAddNew = value;
            }
        }
        private bool showAddNewTemplate = false;
        /// <summary>
        /// Get's or sets wether the 
        /// Add New Template button will be shown.
        /// Setting this value only has effect if
        /// done before the EndInit function is called, 
        /// at that point all properties take effect.
        /// </summary>
        public bool ShowAddNewTemplate 
        {
            get
            { 
                return showAddNewTemplate;
            }
            set
            {
                showAddNewTemplate = value;
            }
        }
        private bool showClone = false;
        /// <summary>
        /// Get's or sets wether the 
        /// Clone button will be shown.
        /// Setting this value only has effect if
        /// done before the EndInit function is called, 
        /// at that point all properties take effect.
        /// </summary>
        public bool ShowClone 
        {
            get
            {
                return showClone;
            }
            set
            {
                showClone = value;
            }
        }
        private bool showSmartClone = false;
        /// <summary>
        /// Get's or sets wether the 
        /// Smart Clone button will be shown.
        /// Setting this value only has effect if
        /// done before the EndInit function is called, 
        /// at that point all properties take effect.
        /// </summary>
        public bool ShowSmartClone 
        {
            get
            {
                return showSmartClone;
            }
            set
            {
                showSmartClone = value;
            }
        }
        private bool showMove = false;
        /// <summary>
        /// Get's or sets wether the 
        /// Move button will be shown.
        /// Setting this value only has effect if
        /// done before the EndInit function is called, 
        /// at that point all properties take effect.
        /// </summary>
        public bool ShowMove
        {
            get
            {
                return showMove;
            }
            set
            {
                showMove = value;
            }
        }
        private bool showDelete = false;
        /// <summary>
        /// Get's or sets wether the 
        /// Delete button will be shown.
        /// Setting this value only has effect if
        /// done before the EndInit function is called, 
        /// at that point all properties take effect.
        /// </summary>
        public bool ShowDelete
        {
            get 
            { 
                return showDelete;
            }
            set
            {
                showDelete = value;
            }
        }
        #endregion

        /// <summary>
        /// The text that is displayed in the top left corner of this control.
        /// </summary>
        public override string Text
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        /// <summary>
        /// The default constructor.
        /// </summary>
        public ProjectHierarchyItem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets default properties to a Global Template's.
        /// </summary>
        public void SetGlobalTemplate()
        {
            this.ShowConfigure = true;
            this.ShowAddNew = true;
            this.ShowAddNewTemplate = true;
        }

        /// <summary>
        /// Sets the default properties to a Project View's.
        /// </summary>
        public void SetProjectView()
        {
            this.ShowConfigure = true;
            this.ShowClone = true;
            this.ShowSmartClone = true;
            this.ShowMove = true;
            this.ShowDelete = true;
        }
        
        /// <summary>
        /// Sets the default properties to a Project Template's.
        /// </summary>
        public void SetProjectTemplate()
        {
            this.ShowConfigure = true;
            this.ShowClone = true;
            this.ShowSmartClone = true;
            this.ShowMove = true;
            this.ShowAddNew = true;
            this.ShowAddNewTemplate = true;
            this.ShowDelete = true;
        }

        #region Events
        /// <summary>
        /// The enum that contains the different possible help buttons.
        /// </summary>
        public enum HelpButton
        {
            /// <summary>
            /// The help button for the Configure command.
            /// </summary>
            Configure,
            /// <summary>
            /// The help button for the Add New command.
            /// </summary>
            AddNew,
            /// <summary>
            /// The help button for the Add New Template command.
            /// </summary>
            AddNewTemplate,
            /// <summary>
            /// The help button for the Clone command.
            /// </summary>
            Clone,
            /// <summary>
            /// The help button for the Smart Clone command.
            /// </summary>
            SmartClone,
            /// <summary>
            /// The help button for the Move command.
            /// </summary>
            Move,
            /// <summary>
            /// The help button for the Delete command.
            /// </summary>
            Delete
        }
        /// <summary>
        /// This is the delegate for when a Help button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="button">The type of help button that was clicked.</param>
        public delegate void ClickHelpButton(object sender, HelpButton button);
        /// <summary>
        /// This event is triggered when any help button is clicked.
        /// </summary>
        public event ClickHelpButton HelpButtonClicked = new ClickHelpButton(Nothing);
        /// <summary>
        /// This event is triggered when the Configure button is clicked.
        /// </summary>
        public event EventHandler ConfigureButtonClicked = new EventHandler(Nothing);
        /// <summary>
        /// This event is triggered when the Add New button is clicked.
        /// </summary>
        public event EventHandler AddNewButtonClicked = new EventHandler(Nothing);
        /// <summary>
        /// This event is triggered when the Add New Template button is clicked.
        /// </summary>
        public event EventHandler AddNewTemplateButtonClicked = new EventHandler(Nothing);
        /// <summary>
        /// This event is triggered when the Clone button is clicked.
        /// </summary>
        public event EventHandler CloneButtonClicked = new EventHandler(Nothing);
        /// <summary>
        /// This event is triggered when the Smart Clone button is clicked.
        /// </summary>
        public event EventHandler SmartCloneButtonClicked = new EventHandler(Nothing);
        /// <summary>
        /// This event is triggered when the Move button is clicked.
        /// </summary>
        public event EventHandler MoveButtonClicked = new EventHandler(Nothing);
        /// <summary>
        /// This event is triggered when the Delete button is clicked.
        /// </summary>
        public event EventHandler DeleteButtonClicked = new EventHandler(Nothing);
        private static void Nothing(object sender, EventArgs e)
        {
        }
        private static void Nothing(object sender, HelpButton e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ConfigureButtonClicked.Invoke(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AddNewButtonClicked.Invoke(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HelpButtonClicked(sender, HelpButton.Configure);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HelpButtonClicked(sender, HelpButton.AddNew);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HelpButtonClicked(sender, HelpButton.AddNewTemplate);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HelpButtonClicked(sender, HelpButton.Clone);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HelpButtonClicked(sender, HelpButton.SmartClone);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            HelpButtonClicked(sender, HelpButton.Move);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            HelpButtonClicked(sender, HelpButton.Delete);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AddNewTemplateButtonClicked.Invoke(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            CloneButtonClicked.Invoke(sender, e);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            SmartCloneButtonClicked.Invoke(sender, e);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            MoveButtonClicked.Invoke(sender, e);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked.Invoke(sender, e);
        }
        #endregion

        /// <summary>
        /// Only existing to implement the ISupportInitialize interface,
        /// it doesn't actually do anything.
        /// </summary>
        public void BeginInit()
        {
        }

        /// <summary>
        /// Called once all properties are set,
        /// it removes the un-needed rows.
        /// </summary>
        public void EndInit()
        {
            int removed = 0;
            if (!ShowConfigure)
            {
                label2.Dispose();
                tableLayoutPanel1.Controls.Remove(label2);
                pictureBox1.Dispose();
                tableLayoutPanel1.Controls.Remove(pictureBox1);
                label3.Dispose();
                tableLayoutPanel1.Controls.Remove(label3);
                removed++;
            }
            if (!showAddNew)
            {
                label4.Dispose();
                tableLayoutPanel1.Controls.Remove(label4);
                pictureBox2.Dispose();
                tableLayoutPanel1.Controls.Remove(pictureBox2);
                label7.Dispose();
                tableLayoutPanel1.Controls.Remove(label7);
                removed++;
            }
            if (!showAddNewTemplate)
            {
                label5.Dispose();
                tableLayoutPanel1.Controls.Remove(label5);
                pictureBox3.Dispose();
                tableLayoutPanel1.Controls.Remove(pictureBox3);
                label8.Dispose();
                tableLayoutPanel1.Controls.Remove(label8);
                removed++;
            }
            if (!showClone)
            {
                label6.Dispose();
                tableLayoutPanel1.Controls.Remove(label6);
                pictureBox4.Dispose();
                tableLayoutPanel1.Controls.Remove(pictureBox4);
                label9.Dispose();
                tableLayoutPanel1.Controls.Remove(label9);
                removed++;
            }
            if (!showDelete)
            {
                label12.Dispose();
                tableLayoutPanel1.Controls.Remove(label12);
                pictureBox7.Dispose();
                tableLayoutPanel1.Controls.Remove(pictureBox7);
                label15.Dispose();
                tableLayoutPanel1.Controls.Remove(label15);
                removed++;
            }
            if (!showMove)
            {
                label14.Dispose();
                tableLayoutPanel1.Controls.Remove(label14);
                pictureBox6.Dispose();
                tableLayoutPanel1.Controls.Remove(pictureBox6);
                label11.Dispose();
                tableLayoutPanel1.Controls.Remove(label11);
                removed++;
            }
            if (!showSmartClone)
            {
                label10.Dispose();
                tableLayoutPanel1.Controls.Remove(label10);
                pictureBox5.Dispose();
                tableLayoutPanel1.Controls.Remove(pictureBox5);
                label13.Dispose();
                tableLayoutPanel1.Controls.Remove(label13);
                removed++;
            }

            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                if (this.tableLayoutPanel1.GetRow(c) - removed > 0)
                {
                    this.tableLayoutPanel1.SetRow(c, (this.tableLayoutPanel1.GetRow(c) - removed));
                }
            }
            tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount - removed;
            tableLayoutPanel1.Height = tableLayoutPanel1.Height - ((20 * (removed)) + (removed - 1));
        }
    }
}
