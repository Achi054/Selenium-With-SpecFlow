# Selenium-With-SpecFlow
Behaviour Driven Development Testing using Selenium and SpecFlow.<br/>
The Specflow uses [Gherkin](https://docs.cucumber.io/gherkin/reference/) language syntax to write your feature files. A language that is more human readable and can be made as a living documentation for your project. Specflow along with [Selenium](https://www.seleniumhq.org/) can enable you to have tests automated to run on any specific browser of your choice.

## Installation guide for SpecFlow
- Install the SpecFlow Visual Studio extension method is to select Tools | Extensions and Updates from the menu in Visual Studio, switch to the Online search on the left and enter “SpecFlow” in the search field at the top right.

- Add an “Unit Test Project (.NET Framework)” to your solution.

- Remove the UnitTest1.cs file, as it is not required.

- Right-click on your solution (e.g. “MyProject”) and select Manage NuGet Packages for Solution.

- Install the following packages (use the search field to filter the search results):<br/>
SpecFlow 2.* version<br/>
MSTest.TestFramework<br/>
SpecRun.Runner 1.* version<br/>

- Microsoft .NET Test SDK 15 is also required. If you have not installed this package already, please install it as well.

## Installation guide for Selenium with Specflow

- Install the SpecFlow Visual Studio extension method is to select Tools | Extensions and Updates from the menu in Visual Studio, switch to the Online search on the left and enter “SpecFlow” in the search field at the top right.

- Add an “Unit Test Project (.NET Framework)” to your solution.

- Remove the UnitTest1.cs file, as it is not required.

- Right-click on your solution (e.g. “MyProject”) and select Manage NuGet Packages for Solution.

- Install the following packages (use the search field to filter the search results):<br/>
SpecFlow 2.* version<br/>
MSTest.TestFramework<br/>
SpecRun.Runner 1.* version<br/>
Selenium.WebDriver<br/>
Selenium.Chrome.WebDriver<br/>

- Microsoft .NET Test SDK 15 is also required. If you have not installed this package already, please install it as well.

## Living documentation using Pickles
[Pickles](http://www.picklesdoc.com/) is a Living Documentation generator: it takes your Specification (written in Gherkin, with Markdown descriptions) and turns them into an always up-to-date documentation of the current state of your software - in a variety of formats.

Installation guide:<br/>
- Install the package Pickles
- Run below command in package manager console <br/>
    ```
    Pickle-Features -FeatureDirectory .\SeleniumSpecflow.Automation\Features -OutputDirectory .\SeleniumSpecflow.Automation\Documentation -DocumentationFormat dhtml
    ```
alternative to Pickles, if you have your project hosted in any Git repository like GitLab, GitHub or GitBucket you can create a living documentation using [HipTest](https://hiptest.com/living-documentation/).