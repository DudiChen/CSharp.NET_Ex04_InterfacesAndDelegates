using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public static class MainMenuDelegatesBuilder
    {
        public static MainMenu Build()
        {
            MenuItemActionable showTimeMenu = new MenuItemActionable("Show Time", "The current time is");
            showTimeMenu.ActivateOccuredDelegate += menuItemActionable_ActivateOccuredDelegate_ShowTime;

            MenuItemActionable showDateMenu = new MenuItemActionable("Show Date", "Today's Date");
            showDateMenu.ActivateOccuredDelegate += menuItemActionable_ActivateOccuredDelegate_ShowDate;

            MenuItemActionable showVersionMenu = new MenuItemActionable("Show Version", "Version");
            showVersionMenu.ActivateOccuredDelegate += menuItemActionable_ActivateOccuredDelegate_ShowVersion;

            MenuItemActionable countSpacesMenu = new MenuItemActionable("Count Spaces", "Please provide input for the Space Counter");
            countSpacesMenu.ActivateOccuredDelegate += menuItemActionable_ActivateOccuredDelegate_CountSpaces;

            MenuItemNonActionable dateTimeMenu = new MenuItemNonActionable(
                "Show Date/Time", "Date/Time");
            MenuItemNonActionable versionsAndDigitsMenu = new MenuItemNonActionable(
                "Version and Digits", "Version and Digits");

            dateTimeMenu.AddSubMenuItem(showDateMenu);
            dateTimeMenu.AddSubMenuItem(showTimeMenu);

            versionsAndDigitsMenu.AddSubMenuItem(showVersionMenu);
            versionsAndDigitsMenu.AddSubMenuItem(countSpacesMenu);

            MenuItemNonActionable mainMenuItem = new MenuItemNonActionable(
                "Main Menu", "Delegates - Main Menu");
            mainMenuItem.IsSetToMainMenu = true;

            mainMenuItem.AddSubMenuItem(dateTimeMenu);
            mainMenuItem.AddSubMenuItem(versionsAndDigitsMenu);

            return new MainMenu(mainMenuItem);
        }

        private static void menuItemActionable_ActivateOccuredDelegate_ShowTime(string i_MenuHeadline)
        {
            Console.WriteLine("{0}{1}", i_MenuHeadline, Environment.NewLine);
            ProgramUtils.ShowCurrentTimeString();
        }

        private static void menuItemActionable_ActivateOccuredDelegate_ShowDate(string i_MenuHeadline)
        {
            Console.WriteLine("{0}{1}", i_MenuHeadline, Environment.NewLine);
            ProgramUtils.ShowCurrentDateString();
        }

        private static void menuItemActionable_ActivateOccuredDelegate_ShowVersion(string i_MenuHeadline)
        {
            Console.WriteLine("{0}{1}", i_MenuHeadline, Environment.NewLine);
            ProgramUtils.ShowVersion();
        }

        private static void menuItemActionable_ActivateOccuredDelegate_CountSpaces(string i_MenuHeadline)
        {
            Console.WriteLine("{0}{1}", i_MenuHeadline, Environment.NewLine);
            ProgramUtils.CountSpaces();
        }
    }
}
