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
            textBox1.Text = "iab-md.co.cc:8080";
            textBox3.Text = "Orvid";
            textBox4.Text = "1ron11";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox3.Text != "")
                {
                    if (textBox4.Text != "")
                    {
                        string srvloc = textBox1.Text;
                        if (srvloc.Substring(srvloc.Length - 1) != "/")
                        {
                            srvloc = srvloc + "/";
                        }
                        if (srvloc.Length > 7 && srvloc.Substring(srvloc.Length - 6) != "xmlrpc")
                        {
                            srvloc = srvloc + "xmlrpc";
                        }
                        if (!srvloc.Contains("http://") && !srvloc.Contains("https://"))
                        {
                            srvloc = "http://" + srvloc;
                        }
                        try
                        {
                            Zutubi.Pulse.Api.Interface.SetServer(srvloc);
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
                    else
                    {
                        MessageBox.Show("You must specify a password!");
                    }
                }
                else
                {
                    MessageBox.Show("You must specify a username!");
                }
            }
            else
            {
                MessageBox.Show("You must enter a server to connect to!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                button1_Click(sender, e);
            }
        }
    }
}