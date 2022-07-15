using BuggyWebRegistrationTest.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BuggyWebRegistrationTest.Steps
{
    [Binding]
    public sealed class DuplicatedUsernameStepDef
    {
        public IWebDriver driver;

        public IWebElement itemText;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DuplicatedUsernameStepDef(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Alice is on Buggy car App Registration page")]
        public void GivenAliceIsOnBuggyCarAppRegistrationPage()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();

            driver.Url = "https://buggy.justtestit.org/";

            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.LinkText("Register")).Click();
        }

        [Given(@"fill duplicated username lee123")]
        public void GivenFillDuplicatedUsernameLee()
        {
            driver.FindElement(By.Id("username")).SendKeys("lee123");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"fill firstname Alice")]
        public void GivenFillFirstnameAlice()
        {
            driver.FindElement(By.Id("firstName")).SendKeys("Alice");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"fill lastname Lee")]
        public void GivenFillLastnameLee()
        {
            driver.FindElement(By.Id("lastName")).SendKeys("Lee");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"set password Alice123%")]
        public void GivenSetPassword()
        {
            driver.FindElement(By.Id("password")).SendKeys("Alice123%");

            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"set confirm password Alice123%")]
        public void GivenSetConfirmPassword()
        {
            driver.FindElement(By.Id("confirmPassword")).SendKeys("Alice123%");

            System.Threading.Thread.Sleep(2000);
        }

        [When(@"click Register button by duplicated username")]
        public void WhenClickRegisterButtonByDuplicatedUsername()
        {
            driver.FindElement(By.XPath("//div/div/form/button")).Click();

            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"see an error prompt message: UsernameExistsException: User already exists")]
        public void ThenSeeAnErrorPromptMessage()
        {
            itemText = driver.FindElement(By.XPath("/html/body/my-app/div/main/my-register/div/div/form/div[6]"));

            Assert.That(itemText.Text, Is.EqualTo("UsernameExistsException: User already exists"));
        }


    }
}
