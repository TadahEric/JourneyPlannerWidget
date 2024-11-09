Feature: JourneyPlanner

As a TfL website user, I want to be able to plan a Leicester Square Underground Station” to “Covent
Garden Underground Station” while only selecting value from auto complete suggestions and not entering the complete text 
so that I can Validate the results for walking and cycling time.

@tag1 
Scenario: Verify that a valid Cycling journey can be planned using the widget
	Given that the user has navigated to TfL website journey planner
	When the user types "Leicester" in the "From" field and selects “Leicester Square Underground Station”
	And the user enters "Covent" in the "To" field and selects “Covent Garden Underground Station”
	And the User clicks on Plan my journey
	Then the journey results page should be displayed 
	And "Cycling" results option should be displayed as "1" mins
	And "Walking" results option displayed as "6" mins
