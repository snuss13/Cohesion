# Cohesion
Test for SDET position in Cohesion

<<<<<<< HEAD
##User story : 
.An user navigates to www.amazon.com,
.Open the first item from the results list and Verifies the item's title contains 'Jenga'
.Use Selenium WebDriver
.Use Page Objects Model
.Locate elements using css locators


##BDD case including a successful execution and a second one failling.

Feature: Amazon Search
Test Search functionality in Amazon

Scenario Outline: Validate Search
	Given user navigates to <Site>
	And search for <Word>
	When Open the first item from the results list
	Then the item's title must contains <Result>
Examples: 
	| Site           | Word  | Result |
	| www.amazon.com | Jenga | Jenga  |
	| www.amazon.com | Jenga | Chenga  |


Notes:
This is running in headless mode.  If you need to see the execution in your Chrome browser, please remove/comment line 14  (opt.AddArgument("headless");) from file ~/Drivers/BrowserDrivers.cs 
=======
### User story : 
- An user navigates to www.amazon.com,
- Open the first item from the results list and Verifies the item's title contains 'Jenga'
- Use Selenium WebDriver
- Use Page Objects Model
- Locate elements using css locators


### BDD case including a successful execution and a second one failling.

      Feature: Amazon Search  
      Test Search functionality in Amazon  

      Scenario Outline: Validate Search  
        Given user navigates to <Site>  
        And search for <Word> 
        When Open the first item from the results list  
        Then the item's title must contains <Result>  
      Examples:  
        | Site           | Word  | Result  | 
        | www.amazon.com | Jenga | Jenga   |  
        | www.amazon.com | Jenga | Chenga  |  
  
>  
>**Notes:**
>This is running in headless mode.  If you need to see the execution in your Chrome browser, please remove/comment line 14  (opt.AddArgument("headless");) from file  ~/Drivers/BrowserDrivers.cs 
>
>>>>>>> d46325e8d831625077342d1dfa939f2bd9ab577f
