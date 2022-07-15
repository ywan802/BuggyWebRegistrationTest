using BuggyWebRegistrationTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BuggyWebRegistrationTest.Hooks
{
	[Binding]
	public sealed class HookInit
	{
        private readonly ScenarioContext _scenarioContext;

        public HookInit(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            SeleniumDriver seleniumDriver = new SeleniumDriver(_scenarioContext);
            _scenarioContext.Set(seleniumDriver, "SeleniumDriver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("SeleniumDriver quit");
            _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
        }
    }
}
