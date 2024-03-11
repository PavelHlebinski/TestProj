using NUnit.Framework;
using TestProj.Factories;
using TestProj.Pages;
using TestProj.Settings;

namespace TestProj.Tests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp() => BasePage.OprnURL(AppSettings.ReadSettings("URL"));

        [TearDown]
        public void OneTimeTearDown() => Driver.QuitDriver();
    }
}