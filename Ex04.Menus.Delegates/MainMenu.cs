using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private MenuItem m_MainMenuItem;

        public MainMenu(MenuItem i_MainMenuItem)
        {
            m_MainMenuItem = i_MainMenuItem;
        }

        public void Show()
        {
            m_MainMenuItem.Activate();
        }

        ////public bool MenuItems_Chosen()
        ////{

        ////}
    }
}
