# JobAdderAssignment

**Repository URL:** https://github.com/cgholap/JobAdderAssignment.git 

**Automation tools used:**

1. Selenium with C# language.
2. NUnit framework.

**Steps to run the tests:**

1. Clone repository on local – “JobAdderAssignment”
2. Install Visual Studio Community 2022 on local machine.
3. Open 'Solution Explorer' -> Right click on assembly 'JobAdderAssignment' -> Select 'Load Direct Dependencies'.
4. In Visual Studio -> Go to 'Build' -> 'Rebuild Solution'.
5. In Visual Studio -> Go to 'Test Explorer'.
6. Right Click on 'SwagLabsTests' -> Select 'Run'. 
It will run 2 tests, 'ValidateErrorMessage' and 'AddItemToCart'.
To run any single test, right click on either 'ValidateErrorMessage' or 'AddItemToCart' -> Select 'Run'. 

**Framework Structure:**

- There are 2 folders in framework: 'PageObjects' and 'Tests'.
- 'PageObjects' folder contain all the web pages used in an application along with the web elements and methods to access to those web elements.
- 'Tests' folder contain actual test cases where we are validating functionality.
- 'BrowserManager' class contain methods which will do initial setup of browser, launch an application and close application.
