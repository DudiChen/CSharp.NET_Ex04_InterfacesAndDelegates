using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private readonly string r_Title;
        protected MenuItem m_baseMenuItem;
        protected MenuItem(string i_TitleString)
        {
            r_Title = i_TitleString;
        }

        internal void SetPerent(MenuItem i_PerentMenuItem)
        {
            m_baseMenuItem = i_PerentMenuItem;
        }

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public abstract int StartMenuAction();
    }
}
