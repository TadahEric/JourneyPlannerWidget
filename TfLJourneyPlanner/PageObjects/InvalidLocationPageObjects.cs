
using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TfLJourneyPlanner.Hooks;

namespace TfLJourneyPlanner.PageObjects
{
    public class InvalidLocationPageObjects 
    {       
        IWebDriver _driver;
        public InvalidLocationPageObjects(IWebDriver driver)
        {
            _driver = driver;
                    
        }
        public void NameOfStationsContatingtttt(string locationBox)
        {
            _driver.FindElement(By.Id($"InputTo")).SendKeys(locationBox);
           
        
        }
        public void NameOfStationsContatingzzzz(string locationBox)
        {
            _driver.FindElement(By.Id($"InputFrom")).SendKeys(locationBox);

        }
    }
}
