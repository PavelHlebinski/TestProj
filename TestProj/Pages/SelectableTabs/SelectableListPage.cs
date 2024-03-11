using OpenQA.Selenium;
using TestProj.WebElement;

namespace TestProj.Pages.SelectableTabs
{
    internal static class SelectableListPage
    {
        readonly static Element Gridtab = new(By.Id("demo-tab-grid"));

        public static void OpenGridTab() => Gridtab.Click();
    }
}