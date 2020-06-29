using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AudenPraticalTest
{
    [Binding]
    public sealed class Hooks1

        
    {
        IWebDriver driver;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
           PropertiesCollection.driver = new ChromeDriver();
           PropertiesCollection.driver.Navigate().GoToUrl("https://www.auden.co.uk/credit/shorttermloan");
           PropertiesCollection.driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // driver.Close();
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
