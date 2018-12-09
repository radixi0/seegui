using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SeeGui
{
    public class SeeGuiApp: IDisposable
    {
        Timer Timer = null;
        
        /// <summary>
        /// Gets or sets the SG application Name
        /// </summary>
        public string AppName { get; set; } = "My SG application";

        public List<Window> Forms { get; set; } = new List<Window>();

        public Window CurrentWindow { get; set; }


        /// <summary>
        /// Default constructor
        /// </summary>
        public SeeGuiApp()
        {
            SeeGui.SetTitle(AppName);

            SetCurrentWindow();
            Timer = new Timer(new TimerCallback(UpdateWindow), null, 500, 500);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Set the aplication name</param>
        public SeeGuiApp(string name)
        {
            SeeGui.SetTitle(name);
            AppName = name;

            SetCurrentWindow();
            Timer = new Timer(new TimerCallback(UpdateWindow), null, 500, 250);
        }

        public void SetCurrentWindow() => CurrentWindow = Forms.FirstOrDefault();

        private void UpdateWindow(object state) => CurrentWindow.Refresh();

        public void Run()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();

            } while (keyInfo.Key != ConsoleKey.Escape);
        }

        public void Dispose()
        {
            Timer.Change(Timeout.Infinite, Timeout.Infinite);
            Timer.Dispose();
        }
    }
}
