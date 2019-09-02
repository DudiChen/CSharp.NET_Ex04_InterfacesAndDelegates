using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private const string k_MainMenuTitle = "#### Interface main menu ###";
        private readonly MenuItem r_mainMenuItem;
        public MainMenu(MenuItem i_MainMenuItem)
        {
            r_mainMenuItem = i_MainMenuItem;
        }

        public void Show()
        {
            int userChoice = r_mainMenuItem.StartMenuAction();

            while (userChoice != 0)
            {
                userChoice = r_mainMenuItem.StartMenuAction();
            }
        }
    }
}
