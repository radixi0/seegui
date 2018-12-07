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

        #region Private
        private static string BoxUpperLine(int size) => $"┌{new string('─', size)}┐";

        private static string BoxHorizontalLine(int size) => $"│{new string(' ', size)}│";

        private static string BoxBottomLine(int size) => $"└{new string('─', size)}┘";

        private static string DoubleBoxUpperLine(int size) => $"╔{new string('═', size)}╗";

        private static string DoubleBoxHorizontalLine(int size) => $"║{new string(' ', size)}║";

        private static string DoubleBoxBottomLine(int size) => $"╚{new string('═', size)}╝";
        #endregion

        /// <summary>
        /// Draw a simple line
        /// </summary>
        /// <param name="xPos">X coordinate</param>
        /// <param name="yPos">Y coordinate</param>
        /// <param name="size">Size (columns) of line</param>
        public static void HorizontalLine(int xPos, int yPos, int size)
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.Write(new string('_', size));
        }

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