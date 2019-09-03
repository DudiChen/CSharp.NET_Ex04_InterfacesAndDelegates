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
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }

        public static void ShowCurrentDateString()
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        }

        public static void ShowVersion()
        {
            string m_VersionNumber = "19.3.4.42";
            Console.WriteLine(m_VersionNumber);
        }

        public static void CountSpaces()
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

            Console.WriteLine("The number of spaces is: {0}", spaceCounter);
        }
    }
}
