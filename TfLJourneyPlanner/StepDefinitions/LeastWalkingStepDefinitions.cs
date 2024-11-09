using FluentAssertions;
using System;
using TechTalk.SpecFlow;
using TfLJourneyPlanner.PageObjects;

namespace TfLJourneyPlanner.StepDefinitions
{
    [Binding]
    public class LeastWalkingStepDefinitions
    {
        LeastWalkingPageObjects _leastWalkingPageObjects;
        public LeastWalkingStepDefinitions(LeastWalkingPageObjects leastWalkingPageObjects)
        {
            _leastWalkingPageObjects = leastWalkingPageObjects;
        }
               
        [When(@"the User clicks on Edit Preferences")]
        public void WhenTheUserClicksOnEditPreferences()
        {
            _leastWalkingPageObjects.ClickOnEditPreference();
        }


        [When(@"the User Checks the Routes with Least walking")]
        public void WhenTheUserChecksTheRoutesWithLeastWalking()
        {
            _leastWalkingPageObjects.ClickOnLeastWalkingButton();
        }


        [Then(@"the journey results showing least walking route time of ""([^""]*)"" should be displayed")]
        public void ThenTheJourneyResultsShowingLeastWalkingTimeOptionsShouldBeDisplayed(string time)
        {
            _leastWalkingPageObjects.GetRoutesWithLeastWalkingTime().Should().Be(time);
        }

        [When(@"the User clicks on update journey")]
        public void WhenTheUserClicksOnUpdateJouney()
        {
            _leastWalkingPageObjects.ClickOnUpdateJourneyPlannerButton();
        }

       

    }
}
