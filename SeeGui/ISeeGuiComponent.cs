using System;

namespace SeeGui.Components
{
    public interface ISeeGuiComponent
    {
        Guid Uid { get; set; }
        string Name { get; set; }
        string Text { get; set; }
        bool HasFocus { get; set; }
        Form Parent { get; set; }

        bool IsFocusable();
        int TabIndex { get; set; }
        void Render();

        // Size and location for visual components
        int Width { get; set; }
        int Height { get; set; }
        int Left { get; set; }
        int Top { get; set; }
        Anchor Anchor { get; set; }
    }
}