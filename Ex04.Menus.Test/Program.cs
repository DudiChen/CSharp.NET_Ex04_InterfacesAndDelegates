using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Interfaces.MainMenu mainMenuInterface= new Interfaces.MainMenu(InterfaceProgramUtils.mainMenuCreator());
            mainMenuInterface.Show();

            Delegates.MainMenu mainMenu = MainMenuDelegatesBuilder.Build();
            mainMenu.Show();
        }
    }
}
