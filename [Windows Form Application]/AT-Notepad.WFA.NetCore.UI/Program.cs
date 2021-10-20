/*
    Made by the author:                 Amirreza Tabeshfard
    Created on this date:               Sunday - 2021 10 October

    Last updated by the author:         Amirreza Tabeshfard
    Last updated on this date:          Wednesday - 2021 20 October
*/
using System;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI
{
    static class Program
    {
        [STAThread]
        [Obsolete]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLoading());
        }
    }
}