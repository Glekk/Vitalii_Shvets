using TechTalk.SpecFlow;
using WebAPI.DropBox;
using WebAPI.DropBox.Impl;

namespace WebAPI.StepDefinitions
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario("@delete", "@getmetadata")]
        public static void BeforeScenarioWithTag()
        {
            WebApiClientImpl webApiClient = WebApiClientImpl.GetWebApiClient();
            webApiClient.Upload(Settings.FilePath, Settings.DropBoxFilePath).IsSuccessStatusCode.Should().BeTrue();
        }

    }
}