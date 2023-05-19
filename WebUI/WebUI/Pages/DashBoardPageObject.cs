
namespace WebUI.Pages
{
    internal class DashBoardPageObject : Page
    {
        private By _adminButton = By.XPath("//a[@href='/web/index.php/admin/viewAdminModule']");

        public DashBoardPageObject(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void ClickAdminLink()
        {
            WaitHelper.Wait(_driver, _adminButton);
            _driver.FindElement(_adminButton).Click();
        }
    }
}
