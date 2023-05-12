using System;
using TechTalk.SpecFlow;
using WebAPI.Drivers;

namespace WebAPI.StepDefinitions
{
    [Binding]
    public class DeleteStepDefinitions
    {
        HttpResponseMessage response;
        [Given(@"I check if file exists for delete")]
        public void GivenICheckIfFileExistsForDelete()
        {
            WebApiDriver webApi = new();
            webApi.IfExistsLocally(Settings.FilePath).Should().BeTrue();
        }

        [When(@"I delete file from dropbox")]
        public void WhenIDeleteFileFromDropbox()
        {
            WebApiDriver driver = new();
            response = driver.Delete(Settings.DropBoxFilePath);
        }

        [Then(@"I should get delete success status code")]
        public void ThenIShouldGetDeleteSuccessStatusCode()
        {
            response.IsSuccessStatusCode.Should().BeTrue();
        }
    }
}
