using System;
using TechTalk.SpecFlow;
using TfLJourneyPlanner.PageObjects;

namespace TfLJourneyPlanner.StepDefinitions
{
    [Binding]
    public class InvalidLocationStepDefinitions
    {
        InvalidLocationPageObjects _invalidLocationPageObjects;
        public InvalidLocationStepDefinitions(InvalidLocationPageObjects invalidLocationPageObjects)
        {
            _invalidLocationPageObjects = invalidLocationPageObjects;
        }
              
        [When(@"the user types ""([^""]*)"" in the From field and selects")]
        public void WhenTheUserTypesInTheFromFieldAndSelects(string locationBox)
        {
            _invalidLocationPageObjects.NameOfStationsContatingzzzz(locationBox);
        }

        [When(@"the user enters ""([^""]*)"" in the To field and selects")]
        public void WhenTheUserEntersInTheToFieldAndSelects(string locationBox)
        {
            _invalidLocationPageObjects.NameOfStationsContatingtttt(locationBox);
        }

    }
}
