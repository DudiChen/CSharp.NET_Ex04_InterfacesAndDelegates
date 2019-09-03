using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public interface IOnSelectedListener
    {
        void OnSelected();
    }

    public class MenuItemActionable : MenuItem
    {
        private IOnSelectedListener m_OnSelectedListener;

        public MenuItemActionable(string i_TitleNameString) : base(i_TitleNameString)
        {
        }

        public void SetOnSelectedListener(IOnSelectedListener i_OnSelectedListener)
        {
            m_OnSelectedListener = i_OnSelectedListener;
        }

        public void RemoveOnSelectedListener(IOnSelectedListener i_OnSelectedListener)
        {
            m_OnSelectedListener = null;
        }

        private void notifyOnSelectedListener()
        {
            if (m_OnSelectedListener != null)
            {
                m_OnSelectedListener.OnSelected();
            }
        }

        public override bool StartMenuItem()
        {
            notifyOnSelectedListener();
            System.Console.WriteLine("Enter any key to continue...");
            System.Console.ReadLine();

            return true;
        }
    }
}
