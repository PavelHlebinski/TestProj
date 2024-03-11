using OpenQA.Selenium;
using TestProj.WebElement;

namespace TestProj.Pages.SelectableTabs
{
    internal static class SelectableGridPage
    {
        private static readonly string elementForSelectLocator = "//*[text()='{0}']";
        public static Element SelectableElement(string elementName) => new(By.XPath(string.Format(elementForSelectLocator, elementName)));

        public static void SelectElement(string elementName) => SelectableElement(elementName).Click();

        public static string GetSelectedElementCLass(string elementName) => SelectableElement(elementName).GetElementAttribute("class");
    }
}