using CoreAppHandle.App;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;

namespace CoreAppHandle.Managewindow
{
    public abstract class BaseWindow
    {
        protected WindowsDriver<WindowsElement> appDriver = DriverManager.Instance.GetAppDriver();

        public bool IsButtonDisplayedByName(string nameDisplayed)
        {
            return appDriver.FindElementByName(nameDisplayed).Displayed;
        }

        public void ClickButtonByNameVisible(string nameButton)
        {
            if (appDriver.FindElementByName(nameButton).Displayed)
                appDriver.FindElementByName(nameButton).Click();
        }

        public void HighlightElement(IWebElement element)
        {
            var jsDriver = (IJavaScriptExecutor)appDriver;
            string highlightJavascript = @"$(arguments[0]).css({ ""border-width"" : ""2px"", ""border-style"" : ""solid"", ""border-color"" : ""red"", ""background"" : ""yellow"" });";
            jsDriver.ExecuteScript(highlightJavascript, new object[] { element });
        }
    }
}
