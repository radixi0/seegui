using SeeGui.Composer;
using System;

namespace SeeGui.Components
{
    public class Button : ISeeGuiComponent
    {
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public bool HasFocus { get; set; }
        public Form Parent { get; set; }
        public int TabIndex { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Anchor Anchor { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }

        public bool IsFocusable() => true;

        public void Render()
        {
            SgComposer.CreateButton(this);
        }

        public Button()
        {
            Left = 3;
            Top = 1;
            Width = 10;
            Height = 2;
            Text = "Button";
        }
    }
}
