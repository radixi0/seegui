using System;
using System.Runtime.InteropServices;

namespace SeeGui
{
    public class SeeGui
    {
        public static void Init()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                SeeGuiWindows.SetConsoleMode();
            }
        }

        public static bool IsWindowsOS() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        public static bool IsLinuxOS() => RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

        public static bool IsMacOS() => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

        /// <summary>
        /// Set the window title
        /// </summary>
        public static void SetTitle(string title)
        {
            Console.Title = title;
        }
    };
}