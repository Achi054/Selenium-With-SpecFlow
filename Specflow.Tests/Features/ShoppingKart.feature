Feature: ShoppingKart
	In order to buy goods
	As a shopper I need to perform shopping
	And products to purchase is maintained in shopping kart

Scenario: Empty shopping kart
	Given I start shopping 
	Then the shopping kart should be empty

Scenario: Adding new item
	Given I start shopping
	When I add new product
	Then the shopping kart should not be empty

Scenario: Deleting item
	Given I start shopping
	When there is an item
	Then the shopping kart should be empty
