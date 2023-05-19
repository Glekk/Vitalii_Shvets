namespace WebUI.Pages
{
    internal class JobTitlesPageObject : Page
    {
        private By _addJobButton = By.XPath("//button[text()=' Add ']");
        private By _deleteJobConfirmButton = By.XPath("//button[text()=' Yes, Delete ']");
        public JobTitlesPageObject(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void ClickAddJobButton()
        {
            Thread.Sleep(1000);
            _driver.FindElement(_addJobButton).Click();
        }

        public void ClickDeleteJobButton(string jobTitle)
        {
            By deleteJobButton = By.XPath($"//div[text()='{jobTitle}']/parent::div/parent::div//button[@class='oxd-icon-button oxd-table-cell-action-space']/i[@class='oxd-icon bi-trash']");
            WaitHelper.Wait(_driver, deleteJobButton);
            _driver.FindElement(deleteJobButton).Click();
        }

        public void ClickDeleteJobConfirmButton()
        {
            WaitHelper.Wait(_driver, _deleteJobConfirmButton);
            _driver.FindElement(_deleteJobConfirmButton).Click();
        }
        
        public bool CheckJobTitle(string jobTitle)
        {   
            By job = By.XPath($"//div[text()='{jobTitle}']");
            try
            {
                WaitHelper.Wait(_driver, job);
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}
