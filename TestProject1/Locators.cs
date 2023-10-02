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
        readonly string test_url = "https://www.bbc.com/sport";
        readonly string expectedCricket = "Cricket";
        readonly string expectedFootball = "Football";
        readonly string expectedFormula1 = "Formula 1";
        readonly string expectedHomeButton = "Home";
        readonly string expectedSigninButton = "Sign in";
        readonly string expectedMore = "More";

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();
            IWebElement cricketLink = driver.FindElement(By.XPath("//a[@href='/sport/cricket']//child::span[@class = 'ssrcss-1yycgk3-LinkTextContainer eis6szr1']"));
            IWebElement footballLink = driver.FindElement(By.XPath("//a[@href='/sport/football']//self::span[@class = 'ssrcss-1yycgk3-LinkTextContainer eis6szr1']"));
            IWebElement formula1Link = driver.FindElement(By.XPath("//li[@class = 'ssrcss-1hqd1wy-StyledMenuItem eis6szr3']//child::*//span[text() = 'Formula 1']"));
            IWebElement homeOnTopButton = driver.FindElement(By.XPath("//ul[@role='list']//descendant::span[text()='Home' and @class='ssrcss-12ta03h-NavItemHoverState e1gviwgp19']"));
            IWebElement signInButton = driver.FindElement(By.XPath("//span[@class='ssrcss-qtp2tt-NavItemHoverState e1gviwgp19' and text()='Future']//preceding::span[contains (text(),'Sign')]"));
            IWebElement moreButton = driver.FindElement(By.XPath("//a[text()='More']"));

            Assert.AreEqual(expectedCricket, cricketLink.Text);
            Assert.AreEqual(expectedFootball, footballLink.Text);
            Assert.AreEqual(expectedFormula1, formula1Link.Text);
            Assert.AreEqual(expectedHomeButton, homeOnTopButton.Text);
            Assert.AreEqual(expectedSigninButton, signInButton.Text);
            Assert.AreEqual(expectedMore, moreButton.Text);
        }
    }
}