using System;
using CoreAppHandle.Managewindow;

namespace CoreAppHandle.RemoteDesktop
{
    public class Header : BaseWindow
    {
        public bool IsTitleDisplayed()
        {
            return appDriver.FindElementByName("Remote Desktop").Displayed;
        }

        public string GetTitle()
        {
            return appDriver.Title;
        }

        public void DoubleClickButtonByNameVisible(string nameButton)
        {
            ClickButtonByNameVisible(nameButton);
            ClickButtonByNameVisible(nameButton);
        }
    }
}
