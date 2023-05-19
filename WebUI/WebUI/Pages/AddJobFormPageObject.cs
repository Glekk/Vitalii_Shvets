namespace WebUI.Pages
{
    internal class AddJobFormPageObject : Page
    {
        private By _jobTitleField = By.XPath("//form[@class='oxd-form']//input[contains(@class,'oxd-input')]");
        private By _jobDescriptionField = By.XPath("//textarea[@placeholder='Type description here']");
        private By _jobNoteField = By.XPath("//textarea[@placeholder='Add note']");
        private By _jobSaveButton = By.XPath("//button[text()=' Save ']");
        public AddJobFormPageObject(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void EnterJobTitle(string jobTitle)
        {
            WaitHelper.Wait(_driver, _jobTitleField);
            _driver.FindElement(_jobTitleField).SendKeys(jobTitle);
        }

        public void EnterJobDescription(string jobDescription)
        {
            _driver.FindElement(_jobDescriptionField).SendKeys(jobDescription);
        }

        public void EnterJobNote(string jobNote)
        {
            _driver.FindElement(_jobNoteField).SendKeys(jobNote);
        }

        public void ClickSaveButton()
        {
            _driver.FindElement(_jobSaveButton).Click();
        }
    }
}
