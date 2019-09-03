using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;



namespace Ex04.Menus.Delegates
{
    public class MenuItemActionable : MenuItem
    {
        public Action<string> m_ActivateOccuredDelegate;

        public MenuItemActionable(string i_Title, string i_Headline) 
            : base(i_Title, i_Headline)
        {

        }

        public override void Activate()
        {
            Console.Clear();
            OnActivate();
        }

        protected virtual void OnActivate()
        {
            if (m_ActivateOccuredDelegate != null)
            {
                m_ActivateOccuredDelegate.Invoke(this.Headline);
                promptEnterToContinue();
            }
        }
    }
}
