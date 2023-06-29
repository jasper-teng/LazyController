using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LazyController
{
    static public class KeyboardInputSimulation
    {
        const int VK_MEDIA_PLAY_PAUSE = 0xB3;
        const int VK_MEDIA_NEXT_TRACK = 0xB0;
        const int VK_MEDIA_PREV_TRACK = 0xB1;
        const int VK_VOLUME_UP = 0xAF;
        const int VK_VOLUME_DOWN = 0xAE;
        const int VK_VOLUME_MUTE = 0xAD;

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        static public void ToggleVolume()
        {
            // press key mute babey
            keybd_event(VK_VOLUME_MUTE, 0, 0, 0);
        }


    }
}
