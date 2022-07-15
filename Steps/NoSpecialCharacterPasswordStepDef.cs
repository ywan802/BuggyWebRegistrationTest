using BuggyWebRegistrationTest.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BuggyWebRegistrationTest.Steps
{
    [Binding]
    public sealed class NoSpecialCharacterPasswordStepDef
    {
        public IWebElement itemText;

        public IWebElement enteredText;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        public IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public NoSpecialCharacterPasswordStepDef(ScenarioContext scenarioContext)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            _scenarioContext = scenarioContext;
        }


        //NoSpecialCharacterPasswrod
        [Given(@"Jay is on Buggy car App Registration page")]
        public void GivenAliceIsOnBuggyCarAppRegistrationPage()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();

            driver.Url = "https://buggy.justtestit.org/";

            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.LinkText("Register")).Click();
        }

        [Given(@"fill username jay007")]
        public void GivenFillUsernamejay007()
        {
            driver.FindElement(By.Id("username")).SendKeys("jay007");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"fill firstname Jay")]
        public void GivenFillFirstnameJay()
        {
            driver.FindElement(By.Id("firstName")).SendKeys("Jay");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"fill lastname Blue")]
        public void GivenFillLastnameLee()
        {
            driver.FindElement(By.Id("lastName")).SendKeys("Blue");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"set password JAYjay123")]
        public void GivenSetPasswordNoSpecialCharacter()
        {
            driver.FindElement(By.Id("password")).SendKeys("Jayjay123");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"set confirm password JAYjay123")]
        public void GivenSetConfirmPasswordNoSpecialCharacter()
        {
            driver.FindElement(By.Id("confirmPassword")).SendKeys("Jayjay123");

            System.Threading.Thread.Sleep(2000);
        }

        [When(@"click Register button by valid password")]
        public void WhenClickRegisterButtonByInvalidPassword()
        {
            driver.FindElement(By.XPath("//div/div/form/button")).Click();

            System.Threading.Thread.Sleep(2000);
            
        }


        [Then(@"see an error message: InvalidPasswordException")]
        public void ThenSeeAnErrorPromptMessageShouldIncludeOneSpecialCharacter()
        {
            itemText = driver.FindElement(By.XPath("//div[6]"));

            Assert.That(itemText.Text, Is.EqualTo("InvalidPasswordException: Password did not conform with policy: Password must have symbol characters"));
        }

    }
}
