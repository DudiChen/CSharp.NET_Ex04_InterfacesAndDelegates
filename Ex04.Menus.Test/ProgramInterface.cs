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

            SpaceCounterActionMenuItem.SetActionListener(new SpaceCounter());
            VersionActionMenuItem.SetActionListener(new Version());
            dateActionMenuItem.SetActionListener(new DateProvider());
            TimeActionMenuItem.SetActionListener(new TimeProvider());
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
            r_DateTime = new DateTime();
        }

        public void DoAction()
        {
            System.Console.WriteLine("the current time is: {0}:{1}:{2}",r_DateTime.Hour,r_DateTime.Minute,r_DateTime.Second);
        }
    }

    class DateProvider : IActionListener
    {
        private readonly DateTime r_DateTime;

        public DateProvider()
        {
            r_DateTime = new DateTime();
        }

        public void DoAction()
        {
            System.Console.WriteLine("the current Date is: {0}/{1}/{2}", r_DateTime.Day, r_DateTime.Month, r_DateTime.Year);
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
