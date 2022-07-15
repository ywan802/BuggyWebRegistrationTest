using BuggyWebRegistrationTest.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BuggyWebRegistrationTest.Steps
{
	[Binding]
	public sealed class RegistrationStepDef
    {
        private IWebElement itemText;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        public IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public RegistrationStepDef(ScenarioContext scenarioContext)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		{
			_scenarioContext = scenarioContext;
		}

        [Given(@"Elsa is on Buggy car App Registration page")]
        public void GivenElsaIsOnBuggyCarAppRegistrationPage()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();

            driver.Url = "https://buggy.justtestit.org/";

            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.LinkText("Register")).Click();
        }

        [Given(@"fill username lui0")]
        public void GivenFillUsernameLui0()
        {
            driver.FindElement(By.Id("username")).SendKeys("lui0");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"fill firstname Elsa")]
        public void GivenFillFirstnameElsa()
        {
            driver.FindElement(By.Id("firstName")).SendKeys("Elsa");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"fill lastname Lui")]
        public void GivenFillLastnameLui()
        {
            driver.FindElement(By.Id("lastName")).SendKeys("Lui");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"set password Elsa1234%")]
        public void GivenSetPassword()
        {
            driver.FindElement(By.Id("password")).SendKeys("Elsa1234%");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"set confirm password Elsa1234%")]
        public void GivenSetConfirmPassword()
        {
            driver.FindElement(By.Id("confirmPassword")).SendKeys("Elsa1234%");

            System.Threading.Thread.Sleep(2000);
        }

        [When(@"click on Register button")]
        public void WhenClickOnRegisterButton()
        {
            driver.FindElement(By.XPath("//div/div/form/button")).Click();

            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"see prompt message: Registration is successful")]
        public void ThenSeePromptMessage()
        {
            itemText = driver.FindElement(By.XPath("/html/body/my-app/div/main/my-register/div/div/form/div[6]"));

            Assert.That(itemText.Text, Is.EqualTo("Registration is successful"));
        }
        
    }
}
