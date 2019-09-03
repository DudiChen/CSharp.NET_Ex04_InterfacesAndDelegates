using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Ex04.Menus.Test
{
    public static class ProgramUtils
    {
        public static void ShowCurrentTimeString()
        {
            Console.WriteLine(DateTime.Now.ToString("t"));
        }

        public static void ShowCurrentDateString()
        {
            Console.WriteLine(DateTime.Now.ToString("d"));
        }

        public static void ShowVersion()
        {
            string m_VersionNumber = "19.3.4.42";
            Console.WriteLine(m_VersionNumber);
        }

        public static int CountSpaces()
        {
            string userInput = Console.ReadLine();
            int spaceCounter = 0;

            foreach (char letter in userInput)
            {
                if(char.IsWhiteSpace(letter))
                {
                    spaceCounter++;
                }
            }

            return spaceCounter;
        }
    }
}
