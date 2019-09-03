using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private const string k_MainMenuTitle = "#### Interface main menu ###";
        private readonly MenuItem r_MainMenuItem;

        public MainMenu(MenuItem i_MainMenuItem)
        {
            r_MainMenuItem = i_MainMenuItem;
        }

        public void Show()
        {
            while(!r_MainMenuItem.StartMenuItem())
            {
            }
        }
    }
}
