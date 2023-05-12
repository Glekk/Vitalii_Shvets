using System;
using TechTalk.SpecFlow;
using WebAPI.Drivers;

namespace WebAPI.StepDefinitions
{
    [Binding]
    public class UploadStepDefinitions
    {
        HttpResponseMessage response;
        [Given(@"I check if the file exists for upload")]
        public void GivenICheckIfTheFileExistsForUpload()
        {
            WebApiDriver webApi = new();
            webApi.IfExistsLocally(Settings.FilePath).Should().BeTrue();
        }

        [When(@"I upload the file")]
        public void WhenIUploadTheFile()
        {
            WebApiDriver webApi = new();
            response = webApi.Upload(Settings.FilePath, Settings.DropBoxFilePath);
        }

        [Then(@"I should get upload success status code")]
        public void ThenIShouldGetUploadSuccessStatusCode()
        {
            response.IsSuccessStatusCode.Should().BeTrue();
        }
    }
}
