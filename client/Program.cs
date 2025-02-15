using client.Forms;
using client.Network;
using client.Services.Auth;
using System.Diagnostics;

namespace client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            Application.Run(new Login());
        }

        private static void OnApplicationExit(object? sender, EventArgs e)
        {
            CurrentUser.Clear();
        }
    }
}