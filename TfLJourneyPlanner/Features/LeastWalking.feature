Feature: LeastWalking

As a TfL website user, I want to use the  “Edit preferences”, to select routes
with the least walking time, and update the journey so I can Validate the journey time" of the feature

@tag2
Scenario: Verify that a journey can be updated by selecting the least walking time
	Given that the user has navigated to TfL website journey planner
	When the user types "Leicester" in the "From" field and selects “Leicester Square Underground Station”
	When the user enters "Covent" in the "To" field and selects “Covent Garden Underground Station”
	And the User clicks on Plan my journey
	Then the journey results page should be displayed 
	And "Cycling" results option should be displayed as "1" mins
	And "Walking" results option displayed as "6" mins
	When the User clicks on Edit Preferences
	And the User Checks the Routes with Least walking
	And the User clicks on update journey
	Then the journey results page should be displayed 
	And the journey results showing least walking route time of "11mins" should be displayed
