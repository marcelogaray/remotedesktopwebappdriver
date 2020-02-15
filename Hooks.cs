using CoreAppHandle.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationProject
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            DriverManager.Instance.GetAppDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverManager.Instance.GetAppDriver().Quit();
        }
    }
}
