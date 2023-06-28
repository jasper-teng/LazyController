using LazyController.Properties;
using ControllerServer;
using System.Drawing;
using LazyController;


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

                // Initialize Tray Icon
                trayIcon = new NotifyIcon()
                {

                    ContextMenuStrip = new ContextMenuStrip()
                    {
                        Items =
                        {
                            new ToolStripMenuItem("Exit", null, Exit),
                            new ToolStripMenuItem("Properties", null, EditProperties)
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