using System;
using System.Collections.Generic;
using System.Text;

namespace SeeGui
{
    public class MenuBarItem
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public int Left { get; set; }
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();
    }
}
