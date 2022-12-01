Feature: PostRequest
As a user I want to able to create a product

@tag1
Scenario: Create catalogue Item with authorisation
	Given User is logged with email address "admin@microsoft.com" and password "Pass@word1" 
	And User is authenticated
	When User add item
	| catalogBrandId | catalogTypeId | description  | name         | pictureUri | pictureBase64 | pictureName | price |
	| 2              | 2             | Black laptop | Black laptop | shirt.com/ | watch         | watch shirt | 900   |
	Then Server Response status should be Created
	And Response time for authentication is between acceptable range
	And Response time for creating item is between acceptable range

Scenario: Create catalogue Item without authorisation
	When User add item
	| catalogBrandId | catalogTypeId | description         | name            | pictureUri | pictureBase64  | pictureName      | price |
	| 2              | 2             | Creme - Green Shirt | CremeBlue Shirt | shirt.com/ | shirt_category | Multicolor shirt | 900   |
	Then Server Response status should be Unauthorized

Scenario: Create existing catalogue Item with authorisation
	Given User is logged with email address "admin@microsoft.com" and password "Pass@word1" 
	And User is authenticated
	When User add item
	| catalogBrandId | catalogTypeId | description        | name            | pictureUri | pictureBase64  | pictureName      | price |
	| 2              | 2             | City - Green Shirt | City-Blue Shirt | shirt.com/ | shirt_category | Multicolor shirt | 900   |
	Then Server Response status should be Conflict