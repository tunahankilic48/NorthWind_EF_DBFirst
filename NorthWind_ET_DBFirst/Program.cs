using NorthWind_EF_DBFirst.Forms;
using NorthWind_ET_DBFirst.Forms;

namespace NorthWind_ET_DBFirst
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmHomePage());
        }
    }
}