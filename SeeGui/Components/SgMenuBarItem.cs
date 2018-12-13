using System.Collections.Generic;

namespace SeeGui.Components
{
    public class SgMenuBarItem
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public int Left { get; set; }
        public List<SgMenuItem> Items { get; set; } = new List<SgMenuItem>();
    }
}
