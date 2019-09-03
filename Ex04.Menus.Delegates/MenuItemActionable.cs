using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Ex04.Menus.Delegates
{
    class MenuItemActionable : MenuItem
    {
        public event Action<MenuItem> ActivateOccured;

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
            if(ActivateOccured != null)
            {
                ActivateOccured.Invoke(this);
            }
        }
    }
}
