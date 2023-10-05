using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Net;
using System.Security.AccessControl;

namespace LocatorsTesting

{
    [TestClass]
    public class Locators
    {

        // Arrange
        readonly string test_url = "https://www.bbc.com/sport";

        [TestMethod]
        [DataRow("Cricket", "//a[@href='/sport/cricket']//child::span[@class = 'ssrcss-1yycgk3-LinkTextContainer eis6szr1']")]
        [DataRow("Football", "//a[@href='/sport/football']//self::span[@class = 'ssrcss-1yycgk3-LinkTextContainer eis6szr1']")]
        [DataRow("Formula 1", "//li[@class = 'ssrcss-1hqd1wy-StyledMenuItem eis6szr3']//child::*//span[text() = 'Formula 1']")]
        [DataRow("Home", "//ul[@role='list']//descendant::span[text()='Home' and @class='ssrcss-12ta03h-NavItemHoverState e1gviwgp19']")]
        [DataRow("Sign in", "//span[@class='ssrcss-qtp2tt-NavItemHoverState e1gviwgp19' and text()='Future']//preceding::span[contains (text(),'Sign')]")]
        [DataRow("More", "//a[text()='More']")]
        public void TestMethod1(string s, string locator)
        {
            //Act
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(test_url);

            IWebElement actualLink = driver.FindElement(By.XPath(locator));


            //Assert
            Assert.AreEqual(s, actualLink.Text);

            driver.Quit();

        }
    }
}