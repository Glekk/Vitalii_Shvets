namespace WebUI.Pages
{
    internal class LoginPageObject : Page
    {
        private By _usernameField = By.XPath("//input[@name='username']");
        private By _passwordField = By.XPath("//input[@name='password']");
        private By _loginButton = By.XPath("//button[@type='submit']");

        public LoginPageObject(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void EnterLogin(string username)
        {
            WaitHelper.Wait(_driver, _usernameField);
            _driver.FindElement(_usernameField).SendKeys(username);
        }
        
        public void EnterPassword(string password)
        {
            _driver.FindElement(_passwordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(_loginButton).Click();
        }
    }
}
