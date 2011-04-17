using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Zutubi.Pulse.Api.Example
{
    public partial class ServerLoginForm : Form
    {
        public ServerLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Zutubi.Pulse.Api.Interface.SetServer(textBox1.Text);
                try
                {
                    Zutubi.Pulse.Api.Interface.Login(textBox3.Text, textBox4.Text);
                    this.Close();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}