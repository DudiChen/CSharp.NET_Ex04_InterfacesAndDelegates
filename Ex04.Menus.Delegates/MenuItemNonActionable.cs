using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuItemNonActionable : MenuItem
    {
        private const int k_EscapeOptionNumber = 0;
        private const int k_FirstOptionNumber = 1;
        private const int k_IgnoreFlagDefaultValue = -1;
        private static bool s_isMainMenuItemConfigured = false;
        private string m_EscapeMenuLine = "Back";
        private List<MenuItem> m_SubMenuItems;
        private bool m_isMainMenu = false;

        public bool IsSetToMainMenu
        {
            get { return m_isMainMenu; }
            set
            {
                if (s_isMainMenuItemConfigured)
                {
                    throw new ArgumentException("A single Main Menu Item already exists!");
                }

                s_isMainMenuItemConfigured = true;
                m_isMainMenu = value;
                m_EscapeMenuLine = "Exit";
            }
        }

        public MenuItemNonActionable(string i_Title, string i_Headline)
            : base(i_Title, i_Headline)
        {
        }

        public void AddSubMenuItem(MenuItem i_SubMenuItem)
        {
            if (m_SubMenuItems == null)
            {
                m_SubMenuItems = new List<MenuItem>();
            }

            m_SubMenuItems.Add(i_SubMenuItem);
        }

        public override void Activate()
        {
            bool isMenuActivated = true;

            while (isMenuActivated)
            {
                Console.Clear();
                showMenuItems();
                int userChoice = GetUserChoice();

                if (k_EscapeOptionNumber == userChoice)
                {
                    isMenuActivated = false;
                }
                else if (userChoice != k_IgnoreFlagDefaultValue)
                {
                    m_SubMenuItems[userChoice - 1].Activate();
                }
            }
        }

        protected int GetUserChoice()
        {
            Console.Write(" > ");
            ConsoleKeyInfo userChoiceKey = Console.ReadKey();
            Console.WriteLine();
            int userChoice;
            bool isValid = parseUserInputToInt(userChoiceKey, out userChoice);

            return userChoice;
        }

        protected bool parseUserInputToInt(ConsoleKeyInfo i_UserConsoleKeyInput, out int o_UserChoice)
        {
            bool isValid = true;
            bool isIntParsed = false;
            bool shouldIgnore = i_UserConsoleKeyInput.Key == ConsoleKey.Enter || i_UserConsoleKeyInput.Key == ConsoleKey.Spacebar;
            if (!shouldIgnore)
            {
                isIntParsed = int.TryParse(i_UserConsoleKeyInput.KeyChar.ToString(), out o_UserChoice);
                if (isIntParsed)
                {
                    isValid = (o_UserChoice >= k_FirstOptionNumber && o_UserChoice <= m_SubMenuItems.Count)
                              || (o_UserChoice == k_EscapeOptionNumber);
                }

                if (!isIntParsed || !isValid)
                {
                    o_UserChoice = k_IgnoreFlagDefaultValue;
                    Console.WriteLine("Invalid input: Please choose from the menu options.");
                    promptEnterToContinue();
                }
            }
            else
            {
                o_UserChoice = k_IgnoreFlagDefaultValue;
            }

            return isValid;
        }

        private void showMenuItems()
        {
            StringBuilder menuOutput = new StringBuilder();
            menuOutput.AppendFormat("{0}{1}", m_Headline, Environment.NewLine);
            int rowCounter = 0;
            menuOutput.AppendFormat("\t{0}. {1}{2}", rowCounter++, m_EscapeMenuLine, Environment.NewLine);
            foreach (MenuItem item in m_SubMenuItems)
            {
                menuOutput.AppendFormat("\t{0}. {1}{2}", rowCounter++, item.Title, Environment.NewLine);
            }

            Console.WriteLine(menuOutput);
        }
    }
}
