using AbelandCole1.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AbelandCole1.StepDefinition
{
    [Binding]
    public class DataDrivenWithParametersSteps
    {
        DataDrivenWithParameterPage datadrivenwithparameterPage;

        public DataDrivenWithParametersSteps()
        {
            datadrivenwithparameterPage = new DataDrivenWithParameterPage();
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            datadrivenwithparameterPage.NavigateToWebsite(url); 
        }
        
        [When(@"I click on sign up")]
        public void WhenIClickOnSignUp()
        {
            datadrivenwithparameterPage.ClickOnSignUp();
        }

        [Given(@"I click on Accept cookies")]
        public void GivenIClickOnAcceptCookies()
        {
            datadrivenwithparameterPage.ClickAcceptCookie();
        }

        [When(@"I enter my search item in the in the search ""(.*)""")]
        public void WhenIEnterMySearchItemInTheInTheSearch(string item)
        {
            datadrivenwithparameterPage.EnterSearchItem(item);
        }

        [When(@"I click on Search")]
        public void WhenIClickOnSearch()
        {
            datadrivenwithparameterPage.ClickSearchButton();
        }

        [When(@"I click on Add for Brownie Tray")]
        public void WhenIClickOnAddForBrownieTray()
        {
            datadrivenwithparameterPage.ClickOnAddButton();
        }

        [When(@"I enter my search items in the search ""(.*)""")]
        public void WhenIEnterMySearchItemsInTheSearch(string items)
        {
            datadrivenwithparameterPage.EnterSearchItems(items);
        }

        [When(@"I click on Search again")]
        public void WhenIClickOnSearchAgain()
        {
            datadrivenwithparameterPage.ClickSearchButtonAgain();
        }

        [When(@"I click on Add for Hummus Chips")]
        public void WhenIClickOnAddForHummusChips()
        {
            datadrivenwithparameterPage.ClickOnAddButton1();
        }

        [When(@"I click on plus to add two more to the basket")]
        public void WhenIClickOnPlusToAddTwoMoreToTheBasket()
        {
            datadrivenwithparameterPage.ClickOnPlusAddButton();
        }

        [When(@"I enter a search items in the search ""(.*)""")]
        public void WhenIEnterASearchItemsInTheSearch(string items)
        {
            datadrivenwithparameterPage.EnterSearchItems1(items);
        }

        [When(@"I click on Add for Simply Salted Popcorn")]
        public void WhenIClickOnAddForSimplySaltedPopcorn()
        {
            datadrivenwithparameterPage.ClickOnAddButton2();
        }

        [When(@"I click on plus to add another to the basket")]
        public void WhenIClickOnPlusToAddAnotherToTheBasket()
        {
            datadrivenwithparameterPage.ClickOnPlusAdd();
        }

        [When(@"I click on the basket")]
        public void WhenIClickOnTheBasket()
        {
            datadrivenwithparameterPage.ClickOnBasket();
        }

        [When(@"I click on dropwdown to take one popcorn out of the basket")]
        public void WhenIClickOnDropwdownToTakeOnePopcornOutOfTheBasket()
        {
            datadrivenwithparameterPage.ClickOnDropdown();
        }

        [Then(@"I have Brownie displayed")]
        public void ThenIHaveBrownieDisplayed()
        {
            Assert.That(datadrivenwithparameterPage.IsBrownieDisplayed);
        }

        [Then(@"I have Hummus Chips displayed")]
        public void ThenIHaveHummusChipsDisplayed()
        {
            Assert.That(datadrivenwithparameterPage.IsHummusChipsDisplayed);
        }

        [Then(@"I have Simply Salted Popcorn displayed")]
        public void ThenIHaveSimplySaltedPopcornDisplayed()
        {
            Assert.That(datadrivenwithparameterPage.IsSimplySaltedPopcornDisplayed);
        }

        [Then(@"I have total price displayed")]
        public void ThenIHaveTotalPriceDisplayed()
        {
            Assert.That(datadrivenwithparameterPage.IsTotalPriceDisplayed);
        }



































    }
}
