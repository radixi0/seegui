using System;

namespace SeeGui
{
    public class SeeGuiApp
    {
        /// <summary>
        /// Gets or sets the SG application Name
        /// </summary>
        public string AppName { get; set; } = "My SG application";

        /// <summary>
        /// Default constructor
        /// </summary>
        public SeeGuiApp()
        {
            SeeGui.SetTitle(AppName);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Set the aplication name</param>
        public SeeGuiApp(string name)
        {
            SeeGui.SetTitle(name);
            AppName = name;
        }

        public void Run()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();

            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
