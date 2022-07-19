using Application.Interfaces;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace ProFind.Lib.Global.Controllers
{
    public class ClientNavigationController : IViewNavigator<Type, Frame>
    {
        private static Stack<Type> pagesStack = new Stack<Type>();
        private static Frame BaseFrame;

        public bool GoBack()
        {
            // Verify if 
            if (pagesStack.Pop() == null) return false;

            NavigateTo(pagesStack.Pop());
            return true;
        }


        public void Init(Frame centralController)
        {
            BaseFrame = centralController;
        }

        public void NavigateTo(Type view)
        {
            BaseFrame.Navigate(view, null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight});
        }
    }

}
