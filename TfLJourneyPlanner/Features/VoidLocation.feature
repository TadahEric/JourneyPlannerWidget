Feature: VoidLocation

As a TfL website user, I want to verify that the widget does not provide results when no location is typed in the widget


@tag5
Scenario: Verify that a user cannot plan a journey by not entering locations in the journey planner
	Given that the user has navigated to TfL website journey planner
	When the User clicks on Plan my journey
	Then error messages should be displayed beneath the From and the To field "The To field is required." 