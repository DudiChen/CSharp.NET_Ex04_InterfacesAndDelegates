using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public static class MainMenuDelegatesBuilder
    {
        public static Delegates.MainMenu Build()
        {
            MenuItemActionable showTimeMenu = new MenuItemActionable("Show Time", "The current time is");
            showTimeMenu.m_ActivateOccuredDelegate += menuItem_ShowTimeActivated;

            MenuItemActionable showDateMenu = new MenuItemActionable("Show Date", "Today's Date");
            showDateMenu.m_ActivateOccuredDelegate += menuItem_ShowDateActivated;

            MenuItemActionable showVersionMenu = new MenuItemActionable("Show Version", "Version");
            showVersionMenu.m_ActivateOccuredDelegate += menuItem_ShowVersioActivated;

            MenuItemActionable countSpacesMenu = new MenuItemActionable("Count Spaces", "Please provide input for the Space Counter");
            countSpacesMenu.m_ActivateOccuredDelegate += menuItem_CountSpacesActivated;

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

            return new Delegates.MainMenu(mainMenuItem);
        }

        private static void menuItem_ShowTimeActivated(string i_MenuHeadline)
        {
            Console.WriteLine("{0}{1}", i_MenuHeadline, Environment.NewLine);
            //DateTime currentTime = GetCurrentTime();
            ProgramUtils.ShowCurrentTimeString();
        }

        private static void menuItem_ShowDateActivated(string i_MenuHeadline)
        {
            Console.WriteLine("{0}{1}", i_MenuHeadline, Environment.NewLine);
            //DateTime currentDate = GetCurrentDate();
            ProgramUtils.ShowCurrentDateString();
        }

        private static void menuItem_ShowVersioActivated(string i_MenuHeadline)
        {

            Console.WriteLine("{0}{1}", i_MenuHeadline, Environment.NewLine);
            //string version = GetVersion();
            ProgramUtils.ShowVersion();
        }

        private static void menuItem_CountSpacesActivated(string i_MenuHeadline)
        {
            Console.WriteLine("{0}{1}", i_MenuHeadline, Environment.NewLine);
            ProgramUtils.CountSpaces();
        }
    }
}
