using System;
using System.Windows.Forms;

namespace PocketComputerTutorial.Forms
{
    static class Program
    {
        const string appUrl = "http://computerguide.somee.com/";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ComputerHardwareGuide.API.APIContext.SetApiUrl(appUrl);
            Application.Run(new MainForm());
        }
    }
}
