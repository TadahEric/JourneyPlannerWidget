using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TfLJourneyPlanner.Hooks;
using TfLJourneyPlanner.PageObjects;

namespace TfLJourneyPlanner.StepDefinitions
{
    [Binding]
    public class CommonStepDefinition
    {
        
        JourneyPlannerPageObjects _journeyPlannerPageObjects;
        public CommonStepDefinition(JourneyPlannerPageObjects journeyPlannerPageObjects)
        {
            _journeyPlannerPageObjects = journeyPlannerPageObjects;
            
        }
       
        [Given(@"that the user has navigated to TfL website journey planner")]
        public void GivenThatTheUserHasNavigatedToTfLWebsiteJourneyPlanner()
        {
            _journeyPlannerPageObjects.NavigateToTflWebSite();            

        }

        [When(@"the user types ""([^""]*)"" in the ""([^""]*)"" field and selects “Leicester Square Underground Station”")]
        public void WhenTheUserTypesInTheFieldAndSelectsLeicesterSquareUndergroundStation(string locationPrompt, string locationBox)
        {
            _journeyPlannerPageObjects.NameOfStationsContatingLeicester(locationPrompt, locationBox);
        }
        [When(@"the user enters ""([^""]*)"" in the ""([^""]*)"" field and selects “Covent Garden Underground Station”")]
        public void WhenTheUserEntersInTheFieldAndSelectsLeicesterSquareUndergroundStation(string locationPrompt, string locationBox)
        {
            _journeyPlannerPageObjects.NameOfStationsContatingCovent(locationPrompt, locationBox);
        }

        [When(@"the User clicks on Plan my journey")]
        public void WhenTheUserClicksOnPlanMyJourney()
        {
            _journeyPlannerPageObjects.ClickPlanMyJourney();
        }

        [Then(@"error messages should be displayed beneath the From and the To field ""([^""]*)""")]
        public void ThenErrorMessagesShouldBeDisplayedBeneathTheFromAndTheToField(string locationToBox)
        {
            _journeyPlannerPageObjects.ToFieldErrorMessage().Should().Be(locationToBox);
        }
              
    }
}
