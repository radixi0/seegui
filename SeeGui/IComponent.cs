using System;
using System.Collections.Generic;
using System.Text;

namespace SeeGui
{
    public interface IComponent
    {
        Guid Uid { get; set; }
        string Name { get; set; }
        string Text { get; set; }
        bool HasFocus { get; set; }
        Window Parent { get; set; }
        bool IsFocusable();

        void Draw();
    }
}
