using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using BoDi;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace TfLJourneyPlanner.Hooks
{
    [Binding]
    public class ScenarioStartAndEndHooks
    {
        protected readonly IObjectContainer _objectContainer;
        protected IWebDriver _driver;
        protected readonly WebDriverWait _webDriverWait;
        protected const int WAIT_FOR_ELEMENT_TIMEOUT = 30;
        public ScenarioStartAndEndHooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        protected IWebElement waitAndFindElement(By locator)
        {
            return _webDriverWait.Until(ExpectedConditions.ElementExists(locator));
        }

       /* protected IWebElement waitAndFindElements(By locator)
        {
            //return _webDriverWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));   
        }*/
        [BeforeScenario]
        public void StartWebDriver()
        {
            var chromeOptions = new ChromeOptions();            
            //chromeOptions.AddArgument("--incognito");
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.cookies", 2);
            _driver = new ChromeDriver(chromeOptions);
            _objectContainer.RegisterInstanceAs(_driver);
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }              



        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Quit();
        }
    }



}