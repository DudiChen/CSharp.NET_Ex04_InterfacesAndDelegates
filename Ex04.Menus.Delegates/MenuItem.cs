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

        ////public void AddSubMenuItem(MenuItem i_SubMenuItem)
        ////{
        ////    m_MenuItems.Add(i_SubMenuItem);
        ////}

        ////public void RemoveSubMenuItem(MenuItem i_SubMenuItem)
        ////{
        ////    m_MenuItems.Remove(i_SubMenuItem);
        ////}

        ////public bool Equals(object i_OtherObj)
        ////{
        ////    bool result = false;

        ////    MenuItem otherMenuItem = i_OtherObj as MenuItem;
        ////    if (otherMenuItem != null)
        ////    {
        ////        result = (this.m_Title == otherMenuItem.Title
        ////                  && this.Headline == otherMenuItem.Headline);
        ////    }

        ////    return result;
        ////}


    }
}
