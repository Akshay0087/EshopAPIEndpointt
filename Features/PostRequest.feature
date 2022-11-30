Feature: PostRequest
As a user I want to able to create a product

@tag1
Scenario: Create catalogue Item with authorisation
	Given User is logged with email address "admin@microsoft.com" and password "Pass@word1" 
	And User is authenticated
	When User add item
	| catalogBrandId | catalogTypeId | description       | name          | pictureUri | pictureBase64  | pictureName      | price |
	| 2              | 2             | Town - Green Shirt | Town-Blue Shirt | shirt.com/ | shirt_category | Multicolor shirt | 900   |
	Then Server Response status should be Created
	And Response time for authentication is between acceptable range
	And Response time for creating item is between acceptable range

Scenario: Create catalogue Item without authorisation
	When User add item
	| catalogBrandId | catalogTypeId | description       | name          | pictureUri | pictureBase64  | pictureName      | price |
	| 2              | 2             | Red - Green Shirt | RedBlue Shirt | shirt.com/ | shirt_category | Multicolor shirt | 900   |
	Then Server Response status should be Unauthorized