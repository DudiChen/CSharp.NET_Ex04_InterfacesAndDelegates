using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;



namespace Ex04.Menus.Delegates
{
    public class MenuItemActionable : MenuItem
    {
        //public event Action<> ActivateOccured;
        public Action<string> ActivateOccuredDelegate;

        public MenuItemActionable(string i_Title, string i_Headline) 
            : base(i_Title, i_Headline)
        {

        }

        public override void Activate()
        {
            OnActivate();
            ////return true;
        }

        protected virtual void OnActivate()
        {
            if (ActivateOccuredDelegate != null)
            {
                ActivateOccuredDelegate.Invoke(this.Headline);
            }
        }
    }
}
