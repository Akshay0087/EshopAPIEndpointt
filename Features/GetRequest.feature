Feature: GetRequest
As a user I want to able to get details of product(s)

@tag1
Scenario: Get details of specific product
	Given User is logged with email address "admin@microsoft.com" and password "Pass@word1" 
	And User is authenticated
	When User input item id "3"
	Then Server Response status for getting the item should be OK
	And server Response Header for getting the item should be valid
	And Server Response content for getting the item should be valid
	And Response time for getting the item is between acceptable range

Scenario: Get details of all products
	When User request all items details
	Then Server Response status for getting the items should be OK
	And Server Response content for getting the items should be valid
	And Response time for getting the items is between acceptable range