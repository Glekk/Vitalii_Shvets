using OpenQA.Selenium.Firefox;
using WebUI.Pages;
using WebUI.Support;

namespace WebUI.StepDefinitions
{
    [Binding]
    public class TaskStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"I am logging in")]
        public void GivenIAmLoggingIn()
        {
            _driver = new FirefoxDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

            LoginPageObject loginPage = new LoginPageObject(_driver);
            loginPage.EnterLogin(Settings.Username);
            loginPage.EnterPassword(Settings.Password);
            loginPage.ClickLoginButton();
        }

        [Given(@"I go to Admin page")]
        public void GivenIGoToAdminPage()
        {
            DashBoardPageObject dashBoardPage = new DashBoardPageObject(_driver);
            dashBoardPage.ClickAdminLink();
        }

        [Given(@"I go to Job Titles page")]
        public void GivenIGoToJobTitlesPage()
        {
            AdminPageObject adminPage = new AdminPageObject(_driver);
            adminPage.ClickJobButton();
            adminPage.ClickJobTitlesButton();
        }

        [When(@"I clck on the Add button")]
        public void WhenIClckOnTheAddButton()
        {
            JobTitlesPageObject jobTitlesPage = new JobTitlesPageObject(_driver);
            jobTitlesPage.ClickAddJobButton();
        }

        [When(@"I fill out the form")]
        public void WhenIFillOutTheForm()
        {
            AddJobFormPageObject formPage = new AddJobFormPageObject(_driver);
            formPage.EnterJobTitle(Settings.JobTitle);
            formPage.EnterJobDescription(Settings.JobDescription);
            formPage.EnterJobNote(Settings.JobNote);
            formPage.ClickSaveButton();
        }

        [Then(@"I see the job is added")]
        public void ThenISeeTheJobIsAdded()
        {
            JobTitlesPageObject jobTitlesPage = new JobTitlesPageObject(_driver);
            jobTitlesPage.CheckJobTitle(Settings.JobTitle).Should().BeTrue();
        }

        [Then(@"I click on the delete button")]
        public void ThenIClickOnTheDeleteButton()
        {
            JobTitlesPageObject jobTitlesPage = new JobTitlesPageObject(_driver);
            jobTitlesPage.ClickDeleteJobButton(Settings.JobTitle);
            jobTitlesPage.ClickDeleteJobConfirmButton();
        }

        [Then(@"I see the job is deleted")]
        public void ThenISeeTheJobIsDeleted()
        {
            JobTitlesPageObject jobTitlesPage = new JobTitlesPageObject(_driver);
            jobTitlesPage.CheckJobTitle(Settings.JobTitle).Should().BeFalse();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}
