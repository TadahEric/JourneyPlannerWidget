using Google.Protobuf.WellKnownTypes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TfLJourneyPlanner.PageObjects
{
     
    public class LeastWalkingPageObjects
    {
        private readonly IWebDriver _driver;
        public LeastWalkingPageObjects(IWebDriver driver)
        {
            _driver = driver;       
        }

        public void ClickOnEditPreference()
        {
            _driver.FindElement(By.CssSelector("div.edit-preferences.clearfix > button")).Click();
        }

        public void ClickOnLeastWalkingButton()
        {
            Thread.Sleep(4000);
            var element = _driver.FindElement(By.CssSelector("input[type='radio'][value='leastwalking']"));
          
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("arguments[0].click();", element);
        }

        public void ClickOnUpdateJourneyPlannerButton()
        {
            var journayPlanButton = _driver.FindElements(By.CssSelector("input[type='submit'][value='Update journey']"));

            if (journayPlanButton.Count > 1)
            {
                // Get the second element (index 1)
                IWebElement elementToClick = journayPlanButton.ElementAt(0);

                IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
                js.ExecuteScript("arguments[0].click();", elementToClick);

            }
            else
            {
                Console.WriteLine("The element at index 0 was not found.");
            }

        }

        public string GetRoutesWithLeastWalkingTime()
        {
            Thread.Sleep(5000);
            //var elements = _driver.FindElements(By.CssSelector("div.journey-time.no-map"));
            var elements = _driver.FindElement(By.CssSelector("#option-1-heading > div.clearfix.time-boxes.time-boxes-override > div.journey-time.no-map"));
            return elements.Text;
        }

        public bool PageTitle()
        {
            return _driver.FindElement(By.XPath("//*[@id=\"full-width-content\"]/div/div[2]/div/h1/span")).Displayed;
        }
    }
    
}
