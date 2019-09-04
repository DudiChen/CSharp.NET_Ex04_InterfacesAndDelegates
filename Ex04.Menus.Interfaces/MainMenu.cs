using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly MenuItem r_MainMenuItem;

        public MainMenu(MenuItem i_MainMenuItem)
        {
            r_MainMenuItem = i_MainMenuItem;
        }

        public void Show()
        {
            bool closeMenuBoolean = false;
            while(!closeMenuBoolean)
            {
                closeMenuBoolean = r_MainMenuItem.StartMenuItem();
            }
        }
    }
}
