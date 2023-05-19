
namespace WebUI.Pages
{
    internal class AdminPageObject : Page
    {
        private By _jobButton = By.XPath("//span[text()='Job ']");
        private By _jobTitlesButton = By.XPath("//a[text()='Job Titles']");
        public AdminPageObject(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void ClickJobButton()
        {
            WaitHelper.Wait(_driver, _jobButton);
            _driver.FindElement(_jobButton).Click();
        }

        public void ClickJobTitlesButton()
        {
            WaitHelper.Wait(_driver, _jobTitlesButton);
            _driver.FindElement(_jobTitlesButton).Click();
        }
    }
}
