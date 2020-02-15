using System;
using CoreAppHandle.Managewindow;

namespace CoreAppHandle.RemoteDesktop
{
    public class ChooseWhatToAdd : BaseWindow
    {
        public ChooseWhatToAdd()
        {
            IsScrollViewerDisplayed();
        }
        public bool IsScrollViewerDisplayed()
        {
            return appDriver.FindElementByClassName("ScrollViewer").Displayed;
        }

        public new AddADesktop ClickButtonByNameVisible(string nameButton)
        {
            appDriver.FindElementByName(nameButton).Click();
            return new AddADesktop();
        }
    }
}
