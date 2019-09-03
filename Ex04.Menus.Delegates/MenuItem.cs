using System;
using System.Collections.Generic;
using System.Text;



namespace Ex04.Menus.Delegates
{
    
    public abstract class MenuItem
    {
        protected string m_Title;
        protected string m_Headline;

        protected MenuItem(string i_Title, string i_Headline)
        {
            m_Title = i_Title;
            m_Headline = i_Headline;
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
            Console.WriteLine("{0}Please press Enter to continue...", Environment.NewLine);
            Console.ReadLine();
        }
    }
}
