Feature: UpdateRequest
As a user I want to able to update details of specific product

@tag1
Scenario: Update details of specific valid product with authorisation
	Given User is logged with email address "admin@microsoft.com" and password "Pass@word1" 
	And User is authenticated
	When User input product detail
	| id | catalogBrandId | catalogTypeId | description        | name            | pictureUri | pictureBase64  | pictureName      | price |
	| 3  | 2              | 2             | Town - Green Shirt | Town-Blue Shirt | shirt.com/ | shirt_category | Multicolor shirt | 900   |
	Then Server Response status for updating the item should be OK
	And Server Response content for updating the item should be valid
	And Response time for updating the item is between acceptable range


	Scenario: Update details of an invalid product with authorisation
	Given User is logged with email address "admin@microsoft.com" and password "Pass@word1" 
	And User is authenticated
	When User input product detail
	| id | catalogBrandId | catalogTypeId | description        | name            | pictureUri | pictureBase64  | pictureName      | price |
	| 1  | 2              | 2             | Town - Green Shirt | Town-Blue Shirt | shirt.com/ | shirt_category | Multicolor shirt | 900   |
	Then Server Response status for updating the item should be Internal Server Error

Scenario: Update details of specific valid product without authorisation
	When User input product detail
	| id | catalogBrandId | catalogTypeId | description        | name            | pictureUri | pictureBase64  | pictureName      | price |
	| 3  | 2              | 2             | Town - Green Shirt | Town-Blue Shirt | shirt.com/ | shirt_category | Multicolor shirt | 900   |
	Then Server Response status for updating the item should be Unauthorised