using LazyController.Properties;
using ControllerServer;
using System.Drawing;
using LazyController;
using System.Net.Sockets;
using System.Net;

namespace ArisakaController
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //start vs as admin and open the port
            HttpServer server = new HttpServer();
            server.Start();

            ApplicationConfiguration.Initialize();
            Application.Run(new TaskTrayApplication());
        }
        

        public class TaskTrayApplication : ApplicationContext
        {
            private NotifyIcon trayIcon;

            public TaskTrayApplication()
            {
                //find local IP
                string localIP;
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    socket.Connect("8.8.8.8", 65530);
                    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                    localIP = endPoint.Address.ToString();
                }


                // Initialize Tray Icon
                trayIcon = new NotifyIcon()
                {

                    ContextMenuStrip = new ContextMenuStrip()
                    {
                        Items =
                        {
                            new ToolStripMenuItem(localIP, null),
                            new ToolStripMenuItem("Properties", null, EditProperties),
                            new ToolStripMenuItem("Exit", null, Exit)
                        },
                    },

                    Icon = Resources.icon,
                    Visible = true
                };
            }

            void Exit(object sender, EventArgs e)
            {
                // Hide tray icon, otherwise it will remain shown until user mouses over it
                trayIcon.Visible = false;

                Application.Exit();
            }

            void EditProperties(object sender, EventArgs e)
            {
                //do some fucking shit open up the form lmao
                var form = new RouteEditor();
                form.Show();
            }



        }



    }
}