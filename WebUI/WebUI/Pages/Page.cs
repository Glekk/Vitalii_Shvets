namespace WebUI.Pages
{
    internal class Page
    {
        protected IWebDriver _driver;
        protected Page(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
