using Application.Interfaces;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace ProFind.Lib.Admin.Controllers
{
    public class InAppNavigationController : IViewNavigator<Type, Frame>
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

        public bool GoBack(object parameter)
        {
            // Verify if 
            if (pagesStack.Pop() == null) return false;

            NavigateTo(pagesStack.Pop(), parameter);
            return true;
        }

        public void Init(Frame centralController)
        {
            BaseFrame = centralController;
        }

        public void NavigateTo(Type view)
        {
            pagesStack.Push(view);
            BaseFrame.Navigate(view);
        }

        public void NavigateTo(Type view, object parameter)
        {
            pagesStack.Push(view);
            BaseFrame.Navigate(view, parameter);
        }
    }
}
