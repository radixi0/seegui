using System;

namespace SeeGui.Components
{
    public class TextBox : ISeeGuiComponent
    {
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public bool HasFocus { get; set; }
        public Form Parent { get; set; }
        public string Text { get; set; }
        public int TabIndex { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Anchor Anchor { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }

        private void SetUid() => Uid = new Guid();

        public void Render()
        {
            throw new NotImplementedException();
        }

        public bool IsFocusable() => true;

        public TextBox() => SetUid();
    }
}