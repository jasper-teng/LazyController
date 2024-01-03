using LazyController.Properties;
using ControllerServer;
using System.Drawing;
using LazyController;
using System.Net.Sockets;
using System.Net;
using System.Runtime.CompilerServices;

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
            // netsh http add urlacl url=http://*:6969/ user=Administrator put this into psh
            try
            {
                HttpServer server = HttpServer.GetInstance();
                server.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Some title",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }


            ApplicationConfiguration.Initialize();


            Application.Run(new TaskTrayApplication());


    }
        

        public class TaskTrayApplication : ApplicationContext
        {
            private NotifyIcon trayIcon;
            private static string mutexName = "RouteEditor";
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

                HttpServer server = HttpServer.GetInstance();
                server.setIP(localIP);


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

                trayIcon.MouseDoubleClick += TrayIcon_MouseDoubleClick;

                JsonConfigHelper.ReadJson();
            }

            private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    var form = new RouteEditor();
                    form.Show();
                }
            }

            void Exit(object sender, EventArgs e)
            {
                // Hide tray icon, otherwise it will remain shown until user mouses over it
                trayIcon.Visible = false;

                Application.Exit();
            }

            public void EditProperties(object sender, EventArgs e)
            {
                //do some fucking shit open up the form lmao
                var form = new RouteEditor();
                form.Show();
            }



        }



    }
}