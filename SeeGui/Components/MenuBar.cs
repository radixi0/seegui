using System;
using System.Collections.Generic;
using System.Linq;

namespace SeeGui.Components
{
    public class MenuBar : ISeeGuiComponent
    {
        public List<MenuBarItem> Items { get; set; } = new List<MenuBarItem>();
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public bool HasFocus { get; set; }
        public Form Parent { get; set; }
        public string Text { get; set; }
        public int MenuLevel { get; set; } = 0;
        public int TabIndex { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Anchor Anchor { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }

        public void SetFocus() => DrawMenu(true);

        public void OpenMenu(char Key)
        {
            var menu = Items.FirstOrDefault(m => m.Text.ToUpper().IndexOf($"&{Key.ToString().ToUpper()}") >= 0);

            if (menu == null) return;

            MenuLevel += 1;
            DrawMenuItem(menu);
        }

        public void Render() => DrawMenu(true);

        private void DrawMenu(bool selected = false)
        {
            var startPos = 3;

            Draw.HorizontalLineFullBlock(2, 1, Console.WindowWidth - 4);

            foreach (var menuItem in Items)
            {
                menuItem.Left = startPos;

                Draw.SetCursorAndWrite(startPos, 1, menuItem.Name, ConsoleColor.Black, ConsoleColor.Yellow);

                if (selected)
                {
                    Draw.SetCursorAndWrite(startPos, 1, menuItem.Name[0].ToString(), ConsoleColor.Red, ConsoleColor.Yellow);
                }
                startPos += menuItem.Name.Length + 1;
            }
        }

        private void DrawMenuItem(MenuBarItem menu)
        {
            int startLine = 2;
            int maxSize = menu.Items.Max(x => x.Text.Length);

            foreach (var item in menu.Items)
            {
                Draw.SetCursorAndWrite(menu.Left - 1, startLine++, $"│ {item.Text.PadRight(maxSize) } │");
            }

            Draw.SetCursorAndWrite(menu.Left - 1, startLine, $"└{new string('─', maxSize + 2)}┘");
        }

        public bool IsFocusable()
        {
            return false;
        }
    }
}