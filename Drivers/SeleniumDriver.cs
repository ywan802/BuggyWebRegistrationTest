using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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
			
			driver = new ChromeDriver("paste the chromedriver.exe full path here");

			//set the driver
			_scenarioContext.Set(driver, "WebDriver");

			driver.Manage().Window.Maximize();

			return driver;
			

			/*
			//Firefox 
			driver = new FirefoxDriver("paste the gekodriver.exe full path here");

			//set the driver
			_scenarioContext.Set(driver, "WebDriver");

			driver.Manage().Window.Maximize();

			return driver;
			*/
		}
	}
}
