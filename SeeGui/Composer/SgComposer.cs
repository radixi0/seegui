using SeeGui.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeeGui.Composer
{
    public enum SgTheme
    {
        Modern,
        Classic
    }

    public static class SgComposer
    {
        public static void CreateButton(Button button)
        {
            // Draw the box of button
            Draw.Box(button.Left, button.Top, button.Left + button.Width, button.Top + button.Height);

            // Calculate the size available for inner text
            // -2 for two borders sum
            // -2 for spaces before and after text
            if (button?.Text.Length <= button.Width - 2)
            {
                var padText = $" {button?.Text} ";
                var startPosition = (button.Width / 2) - (padText.Length / 2) + 1;

                Draw.SetCursorAndWrite(startPosition + button.Left, button.Top + 1, button?.Text);

                return;
            }

            // -4 (sum of spaces and borders)
            Draw.SetCursorAndWrite(button.Left + 2, button.Top + 1, button?.Text.Substring(0, button.Width - 4));
        }
    }
}
