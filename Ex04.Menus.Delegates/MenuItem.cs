using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        protected string m_HeadlineSeparator;
        protected string m_HeadlineSeparatorCharacter = "-";
        protected string m_HeadlineStylingEdge = " :: ";
        protected string m_Title;
        protected string m_Headline;

        protected MenuItem(string i_Title, string i_Headline)
        {
            m_Title = i_Title;
            StringBuilder headlineBuilder = new StringBuilder();
            headlineBuilder.AppendFormat("{0}{1}{0}{2}", m_HeadlineStylingEdge, i_Headline, Environment.NewLine);
            int headlineLength = headlineBuilder.Length;
            for (int i = 0; i < headlineLength; i++)
            {
                headlineBuilder.AppendFormat("{0}", m_HeadlineSeparatorCharacter);
            }

            m_Headline = headlineBuilder.ToString();
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public string Headline
        {
            get { return m_Headline; }
            set { m_Headline = value; }
        }

        public abstract void Activate();

        protected void promptEnterToContinue()
        {
            Console.WriteLine("{0}Press any key to continue...",Environment.NewLine);
            Console.ReadKey(true);
        }
    }
}
