using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using WebAPI.DropBox.Impl;

namespace WebAPI.StepDefinitions
{
    [Binding]
    public class DeleteStepDefinitions
    {
        private WebApiClientImpl webApiClient;
        
        [Given(@"I check if file exists for delete")]
        public void GivenICheckIfFileExistsForDelete()
        {
            webApiClient = WebApiClientImpl.GetWebApiClient();
            webApiClient.IfExist(Settings.DropBoxFolder, Settings.FileName);
        }

        [When(@"I delete file from dropbox")]
        public void WhenIDeleteFileFromDropbox()
        {
            webApiClient.Delete(Settings.DropBoxFilePath).IsSuccessStatusCode.Should().BeTrue();
        }

        [Then(@"I should not see the file in dropbox")]
        public void ThenIShouldNotSeeTheFileInDropbox()
        {
            webApiClient.IfExist(Settings.DropBoxFolder, Settings.FileName).Should().BeFalse();
        }

    }
}
