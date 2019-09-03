using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private readonly string r_Title;
        protected MenuItem m_BaseMenuItem;

        protected MenuItem(string i_TitleString)
        {
            r_Title = i_TitleString;
        }

        internal void SetParent(MenuItem i_ParentMenuItem)
        {
            m_BaseMenuItem = i_ParentMenuItem;
        }

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public abstract bool StartMenuItem();
    }
}
