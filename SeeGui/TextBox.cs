using System;
using System.Collections.Generic;
using System.Text;

namespace SeeGui
{
    public class TextBox : IComponent
    {
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public bool HasFocus { get; set; }
        public Window Parent { get; set; }
        public string Text { get; set; }

        private void SetUid() => Uid = new Guid();

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public bool IsFocusable() => true;

        public TextBox() => SetUid();
    }
}
