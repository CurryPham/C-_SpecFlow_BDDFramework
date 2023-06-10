using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowBDDFramwork.StepDefinitions
{
    [Binding]
    public sealed class FeatureStepDefinition
    {
        private IWebDriver? driver;

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://demo.nopcommerce.com/login?returnUrl=%2F";
            Thread.Sleep(1000);
        }

        [Then(@"Search for the F(.*)")]
        public void ThenSearchForTheF(int p0)
        {
            driver.FindElement(By.Id("Email")).SendKeys("test@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("123456");
            driver.FindElement(By.XPath("//button[text()='Log in']")).Click();
            Thread.Sleep(1000);

            driver.Quit();


        }

    }
}