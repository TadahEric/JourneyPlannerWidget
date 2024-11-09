Feature: InvalidLocation

As a TfL website user, I want to verify that the widget does not provide results when an invalid
journey is planned by entering 1 or more invalid locations

@tag4
Scenario: Verify that a user cannot plan a journey by entering 1 or more invalid locations
	Given that the user has navigated to TfL website journey planner
	When the user types "zzzz" in the From field and selects
	When the user enters "tttt" in the To field and selects 
	And the User clicks on Plan my journey
	Then the journey results page should be displayed
