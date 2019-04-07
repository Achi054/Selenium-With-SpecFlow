using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumSpecflow.Automation
{
    [Binding]
    public class NavigationSteps
    {
        IWebDriver driver;
        [Given(@"I am in the dashboard")]
        public void GivenIAmInTheDashboard()
        {
            driver = new ChromeDriver();
            driver.Url = $"http://localhost:12881/";
        }
        
        [When(@"I press on About link")]
        public void WhenIPressOnAboutLink()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul/li[2]/a")).Click();
        }

        [When(@"I press on Contact link")]
        public void WhenIPressOnContactLink()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul/li[3]/a")).Click();
        }

        [Then(@"I reach Contact page")]
        public void ThenIReachContactPage()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/h2")).Displayed);
            driver.Close();
            driver.Quit();
        }

        [Then(@"I reach About page")]
        public void ThenIReachAboutPage()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/h2")).Displayed);
            driver.Close();
            driver.Quit();
        }
    }
}
