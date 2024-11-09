Feature: AccessibilityInformation

As a TfL website user, I want to be able to see complete accesibility information for Covent Garden
Underground Station when planning my journey

@tag3
Scenario: Verify that a user can view complete accesibility Information for Covent Garden underground 
	Given that the user has navigated to TfL website journey planner
	When the user types "Leicester" in the "From" field and selects “Leicester Square Underground Station”
	When the user enters "Covent" in the "To" field and selects “Covent Garden Underground Station”
	And the User clicks on Plan my journey
	Then the journey results page should be displayed 
	When the clicks on Cycling button 
	When the User clicks on Edit Preferences
	And the User Checks the Routes with Least walking
	And the User clicks on update journey
	Then the journey results page should be displayed 
	And the journey results showing least walking route time of "11mins" should be displayed
	#And the user clicks on View details
	#And the User Clicks on Acessibility details
	#Then the accessibility details should be displayed (Walking Time, Number of Stairs and direction of stairs(up/down)
	