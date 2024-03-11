using OpenQA.Selenium;
using System;
using TestProj.Factories;
using TestProj.WebElement;

namespace TestProj.Pages
{
    internal static class BasePage
    {
        public static void OprnURL(string url)
        {
            try
            {
                Driver.GetDriver().Navigate().GoToUrl(url);
            }
            catch
            {
                Console.WriteLine("URL not found");
            }
        }

        public static void OpenPage(string pageName) => new Element(By.XPath($"//*[text()='{pageName}']")).Click();
    }
}