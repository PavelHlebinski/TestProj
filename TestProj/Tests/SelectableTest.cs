using NUnit.Framework;
using TestProj.Constants;
using TestProj.Pages;
using TestProj.Pages.SelectableTabs;

namespace TestProj.Tests
{
    internal class SelectableTest : BaseTest
    {
        [Test]
        public static void SelectFirstElement()
        {
            BasePage.OpenPage(Page.Interactions);
            BasePage.OpenPage(Page.Selectable);
            SelectableListPage.OpenGridTab();
            SelectableGridPage.SelectElement(TestElement.One);
            var elementClass = SelectableGridPage.GetSelectedElementCLass(TestElement.One);
            Assert.That(elementClass, Does.Contain("active"));
        }
    }
}