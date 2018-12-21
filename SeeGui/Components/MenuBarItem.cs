using System.Collections.Generic;

namespace SeeGui.Components
{
    public class MenuBarItem
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public int Left { get; set; }
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();
    }
}
