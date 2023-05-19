using System;
using TechTalk.SpecFlow;
using WebAPI.DropBox.Impl;

namespace WebAPI.StepDefinitions
{
    [Binding]
    public class GetMetaDataStepDefinitions
    {
        private WebApiClientImpl webApiClient;
        private string metadata;
        [Given(@"I check if file exists to get metadata")]
        public void GivenICheckIfFileExistsToGetMetadata()
        {
            webApiClient = WebApiClientImpl.GetWebApiClient();
            webApiClient.IfExist(Settings.DropBoxFolder, Settings.FileName).Should().BeTrue();
          
        }

        [When(@"I get the file metadata")]
        public void WhenIGetTheFileMetadata()
        {
            metadata = string.Empty;
            HttpResponseMessage response = webApiClient.GetMetaData(Settings.DropBoxFilePath);
            response.IsSuccessStatusCode.Should().BeTrue();
            metadata = response.Content.ReadAsStringAsync().Result;
        }

        [Then(@"I should get metadata")]
        public void ThenIShouldGetMetadata()
        {
             metadata.Should().Contain(Settings.FileName);
        }

    }
}
