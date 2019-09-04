using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceProgramUtils
    {
        public static MenuItem MainMenuCreator()
        {
            MenuItemNonActionable mainMenuItem = new MenuItemNonActionable("Interface Main menu");
            MenuItemNonActionable dateTimeMenuItem = new MenuItemNonActionable("Show Date/Time");
            MenuItemNonActionable versionAndDigitsMenuItem = new MenuItemNonActionable("Version and digits");
            MenuItemActionable timeActionMenuItem = new MenuItemActionable("Show time");
            MenuItemActionable dateActionMenuItem = new MenuItemActionable("Show date");
            MenuItemActionable versionActionMenuItem = new MenuItemActionable("Show Version");
            MenuItemActionable spaceCounterActionMenuItem = new MenuItemActionable("Count spaces");

            spaceCounterActionMenuItem.SetOnSelectedListener((new SpaceCounter()) as IOnSelectedListener);
            versionActionMenuItem.SetOnSelectedListener((new Version()) as IOnSelectedListener);
            dateActionMenuItem.SetOnSelectedListener((new DateProvider()) as IOnSelectedListener);
            timeActionMenuItem.SetOnSelectedListener((new TimeProvider()) as IOnSelectedListener);

            mainMenuItem.AddSubMenuItem(dateTimeMenuItem);
            mainMenuItem.AddSubMenuItem(versionAndDigitsMenuItem);
            dateTimeMenuItem.AddSubMenuItem(dateActionMenuItem);
            dateTimeMenuItem.AddSubMenuItem(timeActionMenuItem);
            versionAndDigitsMenuItem.AddSubMenuItem(versionActionMenuItem);
            versionAndDigitsMenuItem.AddSubMenuItem(spaceCounterActionMenuItem);

            return mainMenuItem;
        }
    }

    internal class TimeProvider : IOnSelectedListener
    {
        private readonly DateTime r_DateTime;

        public TimeProvider()
        {
            r_DateTime = DateTime.Now;
        }

        public void OnSelected()
        {
            System.Console.WriteLine("the current time is: {0}", r_DateTime.ToString("hh:mm:ss"));
        }
    }

    internal class DateProvider : IOnSelectedListener
    {
        private readonly DateTime r_DateTime;

        public DateProvider()
        {
            r_DateTime = DateTime.Now;
        }

        public void OnSelected()
        {
            System.Console.WriteLine("the current Date is: {0}", r_DateTime.ToString("dd/mm/yyyy"));
        }
    }

    internal class Version : IOnSelectedListener
    {
        private const string k_VersionNumberStr = "19.3.4.42";

        public void OnSelected()
        {
            System.Console.WriteLine("the version is: {0}", k_VersionNumberStr);
        }
    }

    internal class SpaceCounter : IOnSelectedListener
    {
        public void OnSelected()
        {
            int spaceCounter = 0;
            string userString = RequestStringFromUser();
            foreach (char letter in userString)
            {
                if (char.IsWhiteSpace(letter))
                {
                    spaceCounter++;
                }
            }

            System.Console.WriteLine("the number of spaces in the input string are: {0}", spaceCounter);
        }

        private string RequestStringFromUser()
        {
            System.Console.WriteLine("Please enter a one line text to count spaces:");
            return System.Console.ReadLine();
        }
    }
}
