Feature: allTests
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add new element
	When I add new element
	Then the first element is added to tree

#Add
@mytag
Scenario: Add  element - right son
When I add second element with smalest key
Then the second right  element is added to tree

@mytag 
Scenario: Add elementa left son
When I add second element with larger key
Then the second element is added to tree

@mytag
Scenario: Add  element whith duplicate key
When I add  elemem duplicate whith duplicate key
Then the new element 

# tests of removing

@mytag
Scenario: Remove Node Without sons
When I remove element withouts sons
Then tree will be empty

@mytag
Scenario: Remove node with right son
When I remove node with right son
Then node is removed and right son will replace he

@mytag
Scenario: Remove node with left son
When I remove node with lef son
Then node is removed and left son will replace he

@mytag
Scenario: Remove node with two sons
When I remove node with two sons
Then node is removed and minimal element from right branch will replace he

@mytag
Scenario: Find element
When I find element and element exist
Then return finding element

@mytag
Scenario: find unavailable element
When I find element and element not exist
Then return null