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