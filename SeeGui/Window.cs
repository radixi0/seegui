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

        public Window()
        {
            var info = UpdateInfo();
            InitialWidth = info.Width;
            InitialHeight = info.Height;
            InitialBufferHeight = info.BufferHeight;
            InitialBufferWidth = info.BufferWidth;

            CreateTitle();
        }

        public void Refresh()
        {
            //var current = new ScreenInfo();

            //if (current.Width <= InitialWidth)
            //{
            //    Width = current.Width;
            //    BufferWidth = current.Width;

            //    if (current.Height <= InitialHeight)
            //    {
            //        Height = current.Height;
            //        BufferHeight = current.Height;
            //    }
            //    else
            //    {
            //        BufferHeight = current.Height;
            //        Width = current.Width;
            //        Height = current.Height;
            //    }
            //}
            //else
            //{
            //    BufferWidth = current.Width;
            //    Width = current.Width;

            //    if (current.Height <= InitialHeight)
            //    {
            //        Height = current.Height;
            //        BufferHeight = current.Height;
            //    }
            //    else
            //    {
            //        BufferHeight = current.Height;
            //        Height = current.Height;
            //    }
            //}

            //Width = current.Width;
            //Height = current.Height;
            UpdateInfo();
            CreateTitle();
        }

        private void CreateTitle()
        {
            Drawing.HorizontalLineFullBlock(0, 0, Width);
            Drawing.SetCursorAndWrite(1, 0, Title, ConsoleColor.Black, ConsoleColor.Gray);
        }

        private ScreenInfo UpdateInfo()
        {
            Console.Clear();

            ScreenInfo info = new ScreenInfo();

            Width = info.Width;
            Height = info.Height;
            BufferWidth = info.BufferWidth;
            BufferHeight = info.BufferHeight;

            return info;
        }
    }
}
