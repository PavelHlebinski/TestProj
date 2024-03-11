using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProj.Factories
{
    public class Wait
    {
        private static WebDriverWait? _wait;

        public static WebDriverWait GetWait(int timeOutInSeconds) => _wait ??= SetupWait(Driver.GetDriver(), timeOutInSeconds);

        public static void CloseWait() => _wait = null;

        private static WebDriverWait SetupWait(IWebDriver driver, int timeOutInSeconds) => new(driver, TimeSpan.FromSeconds(timeOutInSeconds));
    }
}