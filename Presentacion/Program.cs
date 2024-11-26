using System;
using System.Windows.Forms;
using GUI;

namespace Presentacion
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeDprb());
        }
    }
}
