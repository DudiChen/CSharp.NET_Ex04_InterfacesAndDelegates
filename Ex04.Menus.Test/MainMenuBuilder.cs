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
            MenuItemActionable showTimeMenu = new MenuItemActionable("Show Time", "The current time is:");
            showTimeMenu.ActivateOccuredDelegate += MenuItem_ShowTimeActivated;

            MenuItemActionable showDateMenu = new MenuItemActionable("Show Date", "Today's Date:");
            showDateMenu.ActivateOccuredDelegate += MenuItem_ShowDateActivated;

            MenuItemActionable showVersionMenu = new MenuItemActionable("Show Version", "Version:");
            showTimeMenu.ActivateOccuredDelegate += MenuItem_ShowVersioActivated;

            MenuItemActionable countSpacesMenu = new MenuItemActionable("Count Spaces", "");
            showDateMenu.ActivateOccuredDelegate += MenuItem_CountSpacesActivated;

            MenuItemNonActionable dateTimeMenu = new MenuItemNonActionable(
                "Show Date/Time", "Date/Time");
            MenuItemNonActionable versionsAndDigitsMenu = new MenuItemNonActionable(
                "Version and Digits", "Version and Digits");

            dateTimeMenu.AddSubMenuItem(showDateMenu);
            dateTimeMenu.AddSubMenuItem(showTimeMenu);

            versionsAndDigitsMenu.AddSubMenuItem(showVersionMenu);
            versionsAndDigitsMenu.AddSubMenuItem(countSpacesMenu);

            MenuItemNonActionable mainMenuItem = new MenuItemNonActionable(
                "Main Menu", "Main Menu");
            mainMenuItem.IsSetToMainMenu = true;

            mainMenuItem.AddSubMenuItem(dateTimeMenu);
            mainMenuItem.AddSubMenuItem(versionsAndDigitsMenu);

            return new MainMenu(mainMenuItem);
        }

        public static void MenuItem_ShowTimeActivated(string i_MenuHeadline)
        {
            Console.WriteLine("{0}:{1}", i_MenuHeadline, Environment.NewLine);
            ProgramUtils.ShowCurrentTimeString();
        }

        public static void MenuItem_ShowDateActivated(string i_MenuHeadline)
        {
            Console.WriteLine("{0}:{1}", i_MenuHeadline, Environment.NewLine);
            ProgramUtils.ShowCurrentDateString();
        }

        public static void MenuItem_ShowVersioActivated(string i_MenuHeadline)
        {
            Console.WriteLine("{0}:{1}", i_MenuHeadline, Environment.NewLine);
            ProgramUtils.ShowVersion();
        }

        public static void MenuItem_CountSpacesActivated(string i_MenuHeadline)
        {
            Console.WriteLine("{0}:{1}", i_MenuHeadline, Environment.NewLine);
            ProgramUtils.CountSpaces();
        }
    }
}
