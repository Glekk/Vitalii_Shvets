using System;
using TechTalk.SpecFlow;
using WebAPI.DropBox.Impl;

namespace WebAPI.StepDefinitions
{
    [Binding]
    public class UploadStepDefinitions
    {
        private WebApiClientImpl webApiClient;
        [When(@"I upload the file")]
        public void WhenIUploadTheFile()
        {   
            webApiClient = WebApiClientImpl.GetWebApiClient();
            webApiClient.Upload(Settings.FilePath, Settings.DropBoxFilePath).IsSuccessStatusCode.Should().BeTrue();
        }
        [Then(@"I should see the file in the dropbox")]
        public void ThenIShouldSeeTheFileInTheDropbox()
        {
            webApiClient.IfExist(Settings.DropBoxFolder, Settings.FileName).Should().BeTrue();
        }
    }
}
