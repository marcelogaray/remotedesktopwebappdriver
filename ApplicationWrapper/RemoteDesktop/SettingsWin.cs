using CoreAppHandle.Managewindow;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAppHandle.RemoteDesktop
{
    public class SettingsWin : BaseWindow
    {
        public void ClickAddIconForUserAccount()
        {
            appDriver.FindElementByXPath("//Button[@AutomationId='AddComboboxEntryButton']").Click();
        }

        public void SetUserName(String text)
        {
            appDriver.FindElementByName("Username").Click();
            appDriver.FindElementByName("Username").SendKeys(text);
        }

        public void SetPassword(String text)
        {
            //appDriver.FindElementByName("Password").Click();
            appDriver.FindElementByXPath("//Edit[@AutomationId='PasswordBox'][@Name='Password']").Click();
            appDriver.FindElementByXPath("//Edit[@AutomationId='PasswordBox'][@Name='Password']").SendKeys(text);
        }

        public void SetDisplayName(String text)
        {
            appDriver.FindElementByXPath("//Edit[@AutomationId='txtFriendlyNameEntry'][@Name='Account nickname']").Click();
            appDriver.FindElementByXPath("//Edit[@AutomationId='txtFriendlyNameEntry'][@Name='Account nickname']").SendKeys(text);
        }

        public void ClickSaveButton()
        {
            appDriver.FindElementByName("Save").Click();
        }

        public bool IsNewUserNameFirstDisplayed(string value)
        {
            string userAccountComboxItem = "//ComboBox[@AutomationId='AddOrEditCombobox']/ListItem[@Name='{0}'][@ClassName='ComboBoxItem']";
            return appDriver.FindElementByXPath(string.Format(userAccountComboxItem, value)).Displayed;
        }
    }
}
