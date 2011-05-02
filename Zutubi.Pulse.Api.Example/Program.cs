using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Zutubi.Pulse.Api.Example
{
    public class Program
    {
        public static ServerLoginForm ServerLogin = new ServerLoginForm();
        public static MainForm MainForm = new MainForm();

        [STAThread]
        public static void Main()
        {
            Application.Run(MainForm);
        }
    }
}
