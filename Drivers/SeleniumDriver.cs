using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BuggyWebRegistrationTest.Drivers
{
	public class SeleniumDriver
	{
		private IWebDriver driver;

		private readonly ScenarioContext _scenarioContext;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public SeleniumDriver(ScenarioContext scenarioContext)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		{
			_scenarioContext = scenarioContext;
		}

		public IWebDriver Setup()
		{
			driver = new ChromeDriver("C:/Users/ywan802/OneDrive - The University of Auckland/Desktop/technique test/BuggyWebRegistrationTest/Drivers/");

			//set the driver
			_scenarioContext.Set(driver, "WebDriver");

			driver.Manage().Window.Maximize();

			return driver;
		}
	}
}
