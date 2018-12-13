using System;

namespace SeeGui
{
    /// <summary>
    /// Basic drawing routines
    /// </summary>
    public static class Drawing
    {
        public static void SetCursorAndWrite(int xPos, int yPos, string text)
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.Write(text);
        }

        public static void SetCursorAndWrite(int xPos, int yPos, string text, 
            ConsoleColor Foreground = ConsoleColor.Gray)
        {
            Console.ForegroundColor = Foreground;

            Console.SetCursorPosition(xPos, yPos);
            Console.Write(text);
        }

        public static void SetCursorAndWrite(int xPos, int yPos, string text,
            ConsoleColor Foreground = ConsoleColor.Gray,
            ConsoleColor Background = ConsoleColor.Black)
        {
            ConsoleColor oldForeground = Console.ForegroundColor;
            ConsoleColor oldBackground = Console.BackgroundColor;

            Console.ForegroundColor = Foreground;
            Console.BackgroundColor = Background;

            Console.SetCursorPosition(xPos, yPos);
            Console.Write(text);

            Console.ForegroundColor = oldForeground;
            Console.BackgroundColor = oldBackground;
        }

        #region Private
        private static string BoxUpperLine(int size) => $"┌{new string('─', size)}┐";

        private static string BoxHorizontalLine(int size) => $"│{new string(' ', size)}│";

        private static string BoxBottomLine(int size) => $"└{new string('─', size)}┘";

        private static string DoubleBoxUpperLine(int size) => $"╔{new string('═', size)}╗";

        private static string DoubleBoxHorizontalLine(int size) => $"║{new string(' ', size)}║";

        private static string DoubleBoxBottomLine(int size) => $"╚{new string('═', size)}╝";
        #endregion

        public static ConsoleColor GetBackGroundColor(int xPos, int yPos)
        {
            Console.SetCursorPosition(xPos, yPos);
            return Console.BackgroundColor;
        }

        /// <summary>
        /// Draw a simple line
        /// </summary>
        /// <param name="xPos">X coordinate</param>
        /// <param name="yPos">Y coordinate</param>
        /// <param name="size">Size (columns) of line</param>
        public static void HorizontalLine(int xPos, int yPos, int size) => SetCursorAndWrite(xPos, yPos, new string('_', size));

        public static void HorizontalLineFullBlock(int xPos, int yPos, int size) => SetCursorAndWrite(xPos, yPos, new string('█', size));

        public static void Box(int xStartPos, int yStartPos, int xEndPos, int yEndPos)
        {
            SetCursorAndWrite(xStartPos, yStartPos++, BoxUpperLine(xEndPos - xStartPos - 2));

            while (yStartPos < yEndPos)
                SetCursorAndWrite(xStartPos, yStartPos++, BoxHorizontalLine(xEndPos - xStartPos - 2));

            SetCursorAndWrite(xStartPos, yEndPos, BoxBottomLine(xEndPos - xStartPos - 2));
        }

        public static void DoubleBox(int xStartPos, int yStartPos, int xEndPos, int yEndPos)
        {
            SetCursorAndWrite(xStartPos, yStartPos++, DoubleBoxUpperLine(xEndPos - xStartPos - 2));

            while (yStartPos < yEndPos)
                SetCursorAndWrite(xStartPos, yStartPos++, DoubleBoxHorizontalLine(xEndPos - xStartPos - 2));

            SetCursorAndWrite(xStartPos, yEndPos, DoubleBoxBottomLine(xEndPos - xStartPos - 2));
        }
    }
}