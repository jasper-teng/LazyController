using LazyController.Properties;
using System.Drawing;
using System;
using System.Net;
using System.IO;
using System.Text;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;
using System.Runtime.InteropServices;
using LazyController;

namespace Functions
{
    static class AppFunctions
    {
        static void OpenProgram() { 
            
        }

        public static void ToggleVolume()
        {
            KeyboardInputSimulation.ToggleVolume();
        }
    }
}