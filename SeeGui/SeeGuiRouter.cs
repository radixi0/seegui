using SeeGui.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeeGui
{
    public class SeeGuiRouter
    {
        public SeeGuiRouter() => Screens = new List<Form>();

        public void AddRoute(Form screen)
        {
            Screens.Add(screen);
            SetCurrentWindow();
        }
        
        public void AddRoute(Type screenType)
        {
            Screens.Add((Form)Activator.CreateInstance(screenType));

            ActivateScreen();
            SetCurrentWindow();
        }
        
        public Form GetRootScreen()
        {
            var screen = Screens.Where(s => s.RootScreen);

            if (screen.Count() > 1)
                throw new Exception("Only one root screen is allowed");

            if (Screens.Count() > 0)
                return Screens.First();

            return Screens.First();
        }

        private void ActivateScreen()
        {
            var p = Screens.First(s => s.Loaded == false);
            if (p!= null)
            {
                p.Loaded = true;
                p.SetLoadComplete();
            }
        }

        private void SetCurrentWindow()
        {
            if (Screens.Count == 1)
                CurrentWindow = Screens.FirstOrDefault();
            else
            {
                var rootScreen = GetRootScreen();
            }
        }

        public Form CurrentWindow { get; set; }
        public List<Form> Screens { get; set; } = new List<Form>();
    }
}
