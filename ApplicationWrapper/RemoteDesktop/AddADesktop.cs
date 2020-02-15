using CoreAppHandle.Managewindow;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAppHandle.RemoteDesktop
{
    public class AddADesktop : BaseWindow
    {
        public bool IsPcNameTextBoxDisplayed()
        {
            return appDriver.FindElementByClassName("TextBox").FindElementByName("Formal name or IP address").Displayed;
        }
        public bool IsUserAccountComboBoxDisplayed()
        {
            return appDriver.FindElementByClassName("ComboBoxItem").FindElementByName("Ask me every time").Displayed;
        }
        public bool IsDisplayNameTextBoxDisplayed()
        {
            return appDriver.FindElementByName("Connection nickname").Displayed;
        }
    }
}
