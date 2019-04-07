Feature: Navigation
	In order to navigate between tabs
	As a user would like to click on links
	To go to respective sections

@mytag
Scenario: Navigate to About page
	Given I am in the dashboard
	When I press on About link
	Then I reach About page

Scenario: Navigate to Contact page
	Given I am in the dashboard
	When I press on Contact link
	Then I reach Contact page