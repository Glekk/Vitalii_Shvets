using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WebUI.Support
{
    internal static class WaitHelper
    {
        public static void Wait(IWebDriver driver, By element, int timeout = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
