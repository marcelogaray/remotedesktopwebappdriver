using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;

namespace CoreAppHandle.App
{
    public sealed class DriverManager
    {
        public static readonly DriverManager instance = new DriverManager();
        public static WindowsDriver<WindowsElement> appDriver;

        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string RemoteDesktopApp = "Microsoft.RemoteDesktop_8wekyb3d8bbwe!App";

        private DriverManager()
        {
            if (instance == null)
            {
                DesiredCapabilities appCapabilities = new DesiredCapabilities();
                appCapabilities.SetCapability("app", RemoteDesktopApp);
                appCapabilities.SetCapability("deviceName", "WindowsPC");
                appDriver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);


                // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
                appDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
            }
        }

        public static DriverManager Instance { get { return instance; } }

        public WindowsDriver<WindowsElement> GetAppDriver() {
            return appDriver;
        }
    }
}
