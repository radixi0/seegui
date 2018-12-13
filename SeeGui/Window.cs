using System;
using System.Collections.Generic;
using System.Text;

namespace SeeGui
{
    public enum WindowBorder
    {
        None,
        Single,
        Double,
        Dashed
    }

    public class Window
    {
        public string Title { get; set; } = "Form 1";
        public WindowBorder Border { get; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int BufferWidth { get; set; }
        public int BufferHeight { get; set; }
        private int InitialWidth { get; }
        private int InitialHeight { get; }
        private int InitialBufferWidth { get; }
        private int InitialBufferHeight { get; }
        public List<IComponent> Controls { get; set; } = new List<IComponent>();
        public MenuBar MenuBar { get; set; }

        public Window()
        {
            var info = UpdateInfo();
            InitialWidth = info.Width;
            InitialHeight = info.Height;
            InitialBufferHeight = info.BufferHeight;
            InitialBufferWidth = info.BufferWidth;

            DrawWindow();
        }

        public void Refresh()
        {
            var current = new ScreenInfo();

            if (current.Width != Width || current.Height != current.Height)
            {
                UpdateInfo();
                DrawWindow();
                DrawControls();
            }
        }

        public void AddControl(IComponent control)
        {
            control.Parent = this;

            if (control is MenuBar)
                MenuBar = (MenuBar)control;
            
            Controls.Add(control);
        }

        private void DrawControls()
        {
            foreach (IComponent control in Controls)
                control.Draw();
        }

        public void DrawWindow()
        {
            Drawing.Box(1, 0, Width - 1, Height - 1);

            DrawTitle();
            DrawControls();
        }

        private void DrawTitle()
        {
            var padTitle = $" {Title} ";
            var startPosition = (Width / 2) - (padTitle.Length / 2) + 1;
            Drawing.SetCursorAndWrite(startPosition, 0, padTitle, ConsoleColor.Yellow);
        }

        private ScreenInfo UpdateInfo()
        {
            Console.Clear();

            ScreenInfo info = new ScreenInfo();

            Width = info.Width;
            Height = info.Height;
            BufferWidth = info.BufferWidth;
            BufferHeight = info.BufferHeight;

            if (SeeGui.IsWindowsOS())
            {
                Console.BufferHeight = Console.WindowHeight;
                Console.BufferWidth = Console.WindowWidth;
                Console.WindowWidth = Width;
                Console.WindowHeight = Height;
            }

            return info;
        }
    }
}
