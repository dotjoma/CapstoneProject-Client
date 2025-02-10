using client.Forms;
using client.Network;
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

            // Handle application domain unhandled exceptions
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            // Handle UI thread exceptions
            Application.ThreadException += Application_ThreadException;

            // Handle process exit
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

            // Handle console control events (like Ctrl+C)
            Console.CancelKeyPress += Console_CancelKeyPress;

            Application.Run(new Login());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                DisconnectClient();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during unhandled exception cleanup: {ex.Message}");
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                DisconnectClient();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during thread exception cleanup: {ex.Message}");
            }
        }

        private static void CurrentDomain_ProcessExit(object? sender, EventArgs e)
        {
            try
            {
                DisconnectClient();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during process exit cleanup: {ex.Message}");
            }
        }

        private static void Console_CancelKeyPress(object? sender, ConsoleCancelEventArgs e)
        {
            try
            {
                DisconnectClient();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during cancel key cleanup: {ex.Message}");
            }
        }

        private static void DisconnectClient()
        {
            try
            {
                if (Client.Instance.IsConnected)
                {
                    var packet = new Packet
                    {
                        Type = PacketType.Logout,
                        Data = new Dictionary<string, string>()
                    };
                    Client.Instance.SendToServer(packet);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during disconnect: {ex.Message}");
            }
        }
    }
}