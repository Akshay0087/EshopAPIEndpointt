Feature: DeleteRequest
As a user I want to able to remove a specific product

@tag1
Scenario: Delete specific product with authorisation
	Given User is logged with email address "admin@microsoft.com" and password "Pass@word1" 
	And User is authenticated
	When User enters item id "5"
	Then Server Response status for deleting an item should be OK
	And Server Response content for deleting an item should be valid
	And server Response Header for deleting an item should be valid
	And Response time for authentication is between acceptable range
	And Response time for deleting item is between acceptable range

Scenario: Delete specific product without authorisation
	When User enters item id "9"
	Then Server Response status should be unauthorised

Scenario: Delete an invalid product with authorisation
	Given User is logged with email address "admin@microsoft.com" and password "Pass@word1" 
	And User is authenticated
	When User enters item id "1"
	Then Server Response status for deleting an item should be Not Found



