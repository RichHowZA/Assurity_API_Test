Feature: Classifieds
	My feature to validate classified listings

Scenario: Confirm classified listing for Carbon credits
	Given I have called the following api: 
	|	endpoint																	|
	|	https://api.tmsandbox.co.nz/v1/Categories/6327/Details.json?catalogue=false |
	Then the response should contain the field Name with the value set to Carbon credits
	Then the response should contain the field CanRelist with the value set to true
	Then the Promotions element with the Name Gallery, should have a child Description field that contains the text 2x larger image