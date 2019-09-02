using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ProgramInterface
    {
        public void InterfaceMainMenu()
        {

            MainMenu mainMenu = new MainMenu(mainMenuCreator());
            mainMenu.Show();
        }

        private MenuItem mainMenuCreator()
        {
            MenuItemNonActionable mainMenuItem =  new MenuItemNonActionable("Main menu");
            MenuItemNonActionable DateTimeMenuItem = new MenuItemNonActionable("Show Date/Time");
            MenuItemNonActionable VersionAndDigitsMenuItem = new MenuItemNonActionable("Version and digits");
            MenuItemActionable TimeActionMenuItem = new MenuItemActionable("Show time");
            MenuItemActionable dateActionMenuItem = new MenuItemActionable("Show date");
            MenuItemActionable VersionActionMenuItem = new MenuItemActionable("Show Version");
            MenuItemActionable SpaceCounterActionMenuItem = new MenuItemActionable("Count spaces");

            SpaceCounterActionMenuItem.SetActionListener((new SpaceCounter()) as IActionListener);
            VersionActionMenuItem.SetActionListener((new Version()) as IActionListener);
            dateActionMenuItem.SetActionListener(((new DateProvider()) as IActionListener));
            TimeActionMenuItem.SetActionListener((new TimeProvider()) as IActionListener);

            mainMenuItem.AddSubMenuItem(DateTimeMenuItem);
            mainMenuItem.AddSubMenuItem(VersionAndDigitsMenuItem);
            DateTimeMenuItem.AddSubMenuItem(dateActionMenuItem);
            DateTimeMenuItem.AddSubMenuItem(TimeActionMenuItem);
            VersionAndDigitsMenuItem.AddSubMenuItem(VersionActionMenuItem);
            VersionAndDigitsMenuItem.AddSubMenuItem(SpaceCounterActionMenuItem);

            return mainMenuItem;
        }
        

    }

    class TimeProvider : IActionListener
    {
        private readonly DateTime r_DateTime;
        public TimeProvider()
        {
            r_DateTime = DateTime.Now;
            
        }

        public void DoAction()
        {
            System.Console.WriteLine("the current time is: {0}",r_DateTime.ToString("hh:mm:ss"));
        }
    }

    class DateProvider : IActionListener
    {
        private readonly DateTime r_DateTime;

        public DateProvider()
        {
            r_DateTime = DateTime.Now;
        }

        public void DoAction()
        {
            System.Console.WriteLine("the current Date is: {0}", r_DateTime.ToString("dd/mm/yyyy"));
        }
    }

    class Version : IActionListener
    {
        public void DoAction()
        {
            System.Console.WriteLine("the version is: 1.0.0.21");
        }
    }

    class SpaceCounter : IActionListener
    {

        public void DoAction()
        {
            int spaceCounter = 0;
            string userString = RequestStringFromUser();
            foreach(char letter in userString)
            {
                if(char.IsWhiteSpace(letter))
                {
                    spaceCounter++;
                }
            }
            System.Console.WriteLine("the number of spaces in the input string are: {0}",spaceCounter);
        }

        private string RequestStringFromUser()
        {
            System.Console.WriteLine("Please enter a one line text to count spaces:");
            return System.Console.ReadLine();
        }
    }
}
