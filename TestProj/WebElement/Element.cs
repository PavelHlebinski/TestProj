using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestProj.Factories;
using TestProj.Settings;

namespace TestProj.WebElement
{
    internal class Element
    {
        private readonly By? _locator;
        private readonly IWebDriver _driver = Driver.GetDriver();
        private readonly WebDriverWait _wait = Wait.GetWait(Convert.ToInt16(AppSettings.ReadSettings("Wait")));

        public Element(By locator) => _locator = locator;

        public IWebElement WebElement
        {
            get
            {
                WaitForElementIsPresent();
                return _driver.FindElement(_locator);
            }
        }

        public void WaitForElementIsPresent() => _wait.Until(drv => drv.FindElements(_locator).Count > 0);

        public void Click()
        {
            ScrollToElement();
            WebElement.Click();
        }

        public void ScrollToElement() => ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", WebElement);

        public string GetElementAttribute(string attributeName) => WebElement.GetAttribute(attributeName);
    }
}