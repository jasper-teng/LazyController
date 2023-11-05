using LazyController.Properties;
using System.Drawing;
using System;
using System.Net;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LazyController;
using System.Diagnostics;

namespace Functions
{
    static class AppFunctions
    {
        public static void OpenProgram(string filepath) {
            try
            {
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(filepath)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }
        public static void ToggleVolume()
        {
            KeyboardInputSimulation.ToggleVolume();
        }

    }
}