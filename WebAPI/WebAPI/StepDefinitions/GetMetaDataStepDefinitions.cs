using System;
using TechTalk.SpecFlow;
using WebAPI.Drivers;

namespace WebAPI.StepDefinitions
{
    [Binding]
    public class GetMetaDataStepDefinitions
    {
        HttpResponseMessage response;
        [Given(@"I check if file exists to get metadata")]
        public void GivenICheckIfFileExistsToGetMetadata()
        {
            WebApiDriver webApi = new();
            webApi.IfExist(Settings.DropBoxFolder, Settings.FileName).Should().BeTrue();
          
        }

        [When(@"I get the file metadata")]
        public void WhenIGetTheFileMetadata()
        {
            WebApiDriver webApi = new();
            response = webApi.GetMetaData(Settings.DropBoxFilePath);
              
        }

        [Then(@"I should get metadata success status code")]
        public void ThenIShouldGetMetadataSuccessStatusCode()
        {
            response.IsSuccessStatusCode.Should().BeTrue();
        }
    }
}
