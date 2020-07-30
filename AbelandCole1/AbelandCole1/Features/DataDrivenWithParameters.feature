Feature: DataDrivenWithParameters
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Data Driven With Parameters
	Given I navigate to "https://www.abelandcole.co.uk/"
	#When I click on sign up
	And I click on Accept cookies
	When I enter my search item in the in the search "Brownie"
	And I click on Search
	And I click on Add for Brownie Tray
	And I enter my search items in the search "Hummus Chips"
	And I click on Search again
	And I click on Add for Hummus Chips
	And I click on plus to add two more to the basket
	And I enter a search items in the search "Simply Salted Popcorn"
	And I click on Search
	And I click on Add for Simply Salted Popcorn
	And I click on plus to add another to the basket
	And I click on the basket
	And I click on dropwdown to take one popcorn out of the basket
	Then I have Brownie displayed
	Then I have Hummus Chips displayed
	Then I have Simply Salted Popcorn displayed
	Then I have total price displayed
	

	
	
