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
            //ProgramInterface test = new ProgramInterface();
            //test.InterfaceMainMenu();
            Delegates.MainMenu mainMenu = MainMenuDelegatesBuilder.Build();
            mainMenu.Show();
        }
    }
}
