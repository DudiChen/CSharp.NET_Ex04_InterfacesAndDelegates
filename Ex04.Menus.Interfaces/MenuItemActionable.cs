using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public interface IActionListener
    {
        void DoAction();
    }
    public class MenuItemActionable : MenuItem
    {
        private IActionListener m_ActionListener;

        public MenuItemActionable(string i_TitleNameString) : base(i_TitleNameString)
        {
            
        }

        public void SetActionListener(IActionListener i_ActionListener)
        {
            m_ActionListener = i_ActionListener;
        }

        public void RemoveActionListener(IActionListener i_ActionListener)
        {
            m_ActionListener = null;
        }

        private void notifyActionListener()
        {
            if (m_ActionListener != null)
            {
                m_ActionListener.DoAction();
            }
        }

        public override int StartMenuAction()
        {
            notifyActionListener();
            System.Console.ReadLine();
            return 1;
        }
    }
}
