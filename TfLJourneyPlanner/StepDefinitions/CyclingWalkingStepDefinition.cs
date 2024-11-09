using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using TfLJourneyPlanner.PageObjects;

namespace TfLJourneyPlanner.StepDefinitions
{
    [Binding]
    public class CyclingWalkingStepDefinition
    {
        JourneyPlannerPageObjects _journeyPlannerObjects;
        public CyclingWalkingStepDefinition(JourneyPlannerPageObjects journeyPlannerObjects)
        {
            _journeyPlannerObjects = journeyPlannerObjects;       
        }
       
        [Then(@"""([^""]*)"" should be polutated in the From Field")]
        public void ThenShouldBePolutatedInTheFromField(string actualStation)
        {
            var expectedStationName = _journeyPlannerObjects.DisplayStationNameOnTheAddressField();
            actualStation.Should().Be(expectedStationName); 
        
        }          
        
        [Then(@"the journey results page should be displayed")]
        public void ThenTheJourneyResultsPageShouldBeDisplayed()
        {
            _journeyPlannerObjects.PageTitle().Should().Be(true);
        }

        [Then(@"""([^""]*)"" results option should be displayed as ""([^""]*)"" mins")]
        public void ThenResultsOptionShouldBeDisplayedAs(string journeyName, string time)
        {            
            _journeyPlannerObjects.GetCyclingTime().Should().Be(time);
            _journeyPlannerObjects.GetJourneyTitle(journeyName).Should().Contain(journeyName).ToString();

        }

        [Then(@"""([^""]*)"" results option displayed as ""([^""]*)"" mins")]
        public void ThenResultsOptionDisplayedAs(string journeyName, string time)
        {
            _journeyPlannerObjects.GetWalkingTime().Should().Be(time);
            _journeyPlannerObjects.GetJourneyTitle(journeyName).Should().Contain(journeyName).ToString();

        }
        [When(@"the clicks on Cycling button")]
        public void WhenTheClicksOnCyclingButton()
        {
            
        }


    }
}
