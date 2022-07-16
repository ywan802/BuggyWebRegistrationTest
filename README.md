# BuggyWebRegistrationTest

The list of softwares need to install:
1. Visual Studio 2019
2. Postman
3. Chrome browser or Firefox browser

The list of extensions need to use:
1. SpecFlow for Visual Studio 2019
2. SpecFlow.Assist.Dynamic
3. Selenium.WebDriver

===================================================
The BDD scenarios and bug report as PDF files in repo

===============================================================================================================
To run the BDD scenarios automation test:
1. select Open a project or solution in VS2019
2. select BuggyWebRegistrationTest.sln in repo
3. open Drivers folder in Solution Explorer
4. right click on your preferred  driver:
   select chromedriver.exe for Chrome browser 
   select geckodriver.exe for Firefox browser 
4. select copy full path
5. open SeleniumDrvier.cs file
6. paste into the corresponding driver path brackets, also COMMENT OUT another driver relevant codes
---------------------------------------------------------------------------------------------------------------------------------------
NOTE: type the correct format driver path need to:                                                                                  
    a. xxxdriver.exe is not as the part of path
    b. "\" need convert to "/"
for example,the correct format: driver = new ChromeDriver("C:/Users/ywywyw/test/BuggyWebRegistrationTest/Drivers/");
the incorrect format: driver = new ChromeDriver("C:\Users\ywywyw\test\BuggyWebRegistrationTest\Drivers\chromedriver.exe");
---------------------------------------------------------------------------------------------------------------------------------------
7. save the file 
8. click Build (at the top of menu) -> click Build Solution
9.click Test(at the top of menu) -> click Test Explorer -> click Run All Tests in View
Then the system will automatically do the tests, can check the test results in Test Explorer when the whole process has finished.
======================================================================================================================


To run the API automation test:
1. click Import button in Postman -> click Upload Files 
2. select BuggyWebRegistrationTest.postman_collection.json(under apiTest-postman folder in repo) -> click Import
3. click BuggyWebRegistrationTest collection -> click View More Options -> click Run Collection
4. set 5 iterations and 2000ms Delay
5. click Select File -> select apiTestDataScript.csv file(under apiTest-postman folder in repo)
6. click the Run BuggyWebRegistrationTest button, then the tests run automatically  
----------------------------------------------------------------------------------------
NOTE: Need to change a unique username for every "register new account successful" test case if you need to run the tests multiple times. 
      Because each user account is only allowed to register once, cannot access different accounts with the same username. If still use the previous username will product the error as:

  Expected: "Registration is successful"
  But was:  "UsernameExistsException: User already exists"
