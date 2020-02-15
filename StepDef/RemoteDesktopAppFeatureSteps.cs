using CoreAppHandle.RemoteDesktop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace AutomationProject.StepDef
{
    [Binding]
    public class RemoteDesktopAppFeatureSteps
    {
        Header header;
        ContentBody body;
        ChooseWhatToAdd chooseWhatToAdd;
        AddADesktop addADesktop;
        SettingsWin settingsWin;

        [Given(@"I launch Remote DesktopApp")]
        public void GivenILaunchRemoteDesktopApp()
        {
            header = LoaderApp.launchApp();
        }

        [Then(@"The title bar should be diplayed")]
        public void ThenTheTitleBarShouldBeDiplayed()
        {
            Assert.IsTrue(header.IsTitleDisplayed());
        }

        [Then(@"the ""(.*)"" title bar contains the text")]
        public void ThenTheTitleBarContainsTheText(string titleExpected)
        {
            Assert.AreEqual(titleExpected, header.GetTitle());
        }

        [Then(@"the ""(.*)"" text is displayed")]
        public void ThenTheTextIsDisplayed(string text)
        {
            body = new ContentBody();
            Assert.IsTrue(body.IsTextDisplayed(text));
        }

        [When(@"I click 'Add' button in the header")]
        public void WhenIAddClickAddButtonInTheHeader()
        {
            header.ClickButtonByNameVisible("Add");
            chooseWhatToAdd = new ChooseWhatToAdd();
        }

        [When(@"I click 'Desktop' button in the 'Choose what to add' scroll viewer")]
        public void WhenIClickButtonInTheScrollViewer()
        {
            addADesktop = chooseWhatToAdd.ClickButtonByNameVisible("Desktop");
        }

        [Then(@"the Scroll Viewer panel is displayed")]
        public void ThenTheScrollViewerPanelIsDisplayed()
        {
            Assert.IsTrue(chooseWhatToAdd.IsScrollViewerDisplayed());
        }

        [Then(@"the '(.*)' button is shown")]
        public void ThenTheButtonIsShown(string nameDisplayed)
        {
            Assert.IsTrue(chooseWhatToAdd.IsButtonDisplayedByName(nameDisplayed));
        }

        [Then(@"the PC Name input is shown")]
        public void ThenThePCNameInputIsShown()
        {
            Assert.IsTrue(addADesktop.IsPcNameTextBoxDisplayed());
        }

        [Then(@"the User account combobox  is show")]
        public void ThenTheUserAccountComboboxIsShow()
        {
            Assert.IsTrue(addADesktop.IsUserAccountComboBoxDisplayed());
        }

        [Then(@"the Display name field is show")]
        public void ThenTheDisplayNameFieldIsShow()
        {
            Assert.IsTrue(addADesktop.IsDisplayNameTextBoxDisplayed());
        }

        [When(@"I double click '(.*)' button in the header")]
        public void WhenIDoubleClickButtonInTheHeader(string p0)
        {
            header.DoubleClickButtonByNameVisible("Settings");
            settingsWin = new SettingsWin();
        }


        [When(@"I click 'Settings' button in the header")]
        public void WhenISettingsClickButtonInTheHeader()
        {
            header.ClickButtonByNameVisible("Settings");
            settingsWin = new SettingsWin();
        }

        [When(@"I click \+ icon available for User account")]
        public void WhenIClickIconAvailableForUserAccount()
        {
            settingsWin.ClickAddIconForUserAccount();
        }

        [When(@"I fill ""(.*)"" username textbox")]
        public void WhenIFillUsernameTextbox(string userName)
        {
            settingsWin.SetUserName(userName);
        }

        [When(@"I fill ""(.*)"" password textbox")]
        public void WhenIFillPasswordTextbox(string password)
        {
            settingsWin.SetPassword(password);
        }

        [When(@"I fill ""(.*)"" display name textbox")]
        public void WhenIFillDisplayNameTextbox(string displayName)
        {
            settingsWin.SetDisplayName(displayName);
        }

        [When(@"I click 'Save' button")]
        public void WhenIClickButton()
        {
            settingsWin.ClickSaveButton();
        }

        [Then(@"the ""(.*)"" should be showed in the item of 'User account' combobox")]
        public void ThenTheShouldBeShowedInTheItemOfCombobox(string valueItem)
        {
            Assert.IsTrue(settingsWin.IsNewUserNameFirstDisplayed(valueItem));
        }
    }
}
