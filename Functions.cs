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
        private static Dictionary<FunctionType, Action<String>> FunctionList =
            new Dictionary<FunctionType, Action<String>>()
            {
                {FunctionType.LaunchProgram, new Action<String>(OpenProgram) },
                {FunctionType.ToggleVolume, new Action<String>(ToggleVolume) }
            };

        public static void PerformFunction(FunctionType type, string var)
        {
            FunctionList[type](var); // this is actually so swag
            return;
        }



        //macro functions

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

            return;

        }
        public static void ToggleVolume(string lol)//scuffed as fuck dude
        {
            KeyboardInputSimulation.ToggleVolume();

            return;
        }

    }
}