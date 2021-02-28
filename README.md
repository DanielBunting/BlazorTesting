# BlazorTesting

## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [How to run the tests](#How-to-run-the-tests)

## General info
This project contains a collection of samples to help you get started with testing a Blazor application by extending the template Blazor application with tests.
	
## Technologies
Project is created with:
* C# .net core 3.1
* Blazor
* Selenium (Chrome)
* NUnit
* BlazorMe.Testhost - a wrapper around the Steve Sanderson component testing project [here](https://blog.stevensanderson.com/2019/08/29/blazor-unit-testing-prototype/).
	
## How to run the tests
There are two sets of tests, that are specific to testing Blazor here, the component tests and the Selenium tests.

### Component tests
For the component tests, you should just be able to run theim in your preferred test runner. 

In Visual studio, you can do this by expanding the `Tests` folder -> Right click the `BlazorTesting.Client.Tests` project -> Click the Run Tests button. 

### Selenium Tests
For the Selenium Tests, you will need to run the application before running the tests. 

This can be done in Powershell: 
```
cd <BlazorTesting>/BlazorTesting/Client
dotnet run
```

After this, you will be able to run the Selenium tests from your preferred test runner. 

In Visual Studio, you can run these tests by expanding the `Tests` folder -> Right click the `BlazorTesting.Selenium` project -> Click the Run Tests button. 
