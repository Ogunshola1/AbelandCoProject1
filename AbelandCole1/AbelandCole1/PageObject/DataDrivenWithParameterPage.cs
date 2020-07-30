using AbelandCole1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AbelandCole1.PageObject
{
    class DataDrivenWithParameterPage
    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
            //fluent Wait;
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
        }

        IWebDriver driver;

        IWebElement signUp => driver.FindElement(By.XPath("(//a[text()='Sign up'])[1]"));

        IWebElement acceptCookie => driver.FindElement(By.XPath("//*[@id='ccc-notify-accept']"));

        IWebElement searchItem => driver.FindElement(By.XPath("//*[@placeholder='Search']"));

        IWebElement searchbutton => driver.FindElement(By.XPath("//input[@type='button']"));

        IWebElement addButton => driver.FindElement(By.XPath("(//div[@class='add cta-button'])[3]"));

        IWebElement searchItems => driver.FindElement(By.XPath("//input[@placeholder='Search']"));

        IWebElement searchbuttonAgain => driver.FindElement(By.XPath("//*[@id='search-btn']"));

        IWebElement addButton1 => driver.FindElement(By.XPath("//div[@class='add cta-button']"));

        IWebElement plusAddButton => driver.FindElement(By.XPath("//*[@id='product-list']"));

        IWebElement searchItems1 => driver.FindElement(By.XPath("//*[@placeholder='Search']"));

        IWebElement addButton2 => driver.FindElement(By.XPath("//div[@class='add cta-button']"));

        IWebElement plusAdd => driver.FindElement(By.XPath("//*[@id='product-list']"));

        IWebElement basket => driver.FindElement(By.XPath("//*[@id='BasketCount']"));

        IWebElement dropdown => driver.FindElement(By.XPath("//div[@class='dropdown']"));

        IWebElement brownie => driver.FindElement(By.XPath("//div[@class='product-name']"));

        IWebElement hummusChips => driver.FindElement(By.XPath("//div[@class='product-name']"));

        IWebElement simplySaltedPopcorn => driver.FindElement(By.XPath("//div[@class='product-name']"));

        IWebElement totalPrice => driver.FindElement(By.XPath("//div[@class='total-price']"));





        public void ClickOnSignUp()
        {
            signUp.Click();
        }

        public void ClickAcceptCookie()
        {
            Thread.Sleep(5000);
            acceptCookie.Click();
        }

        public void EnterSearchItem(string item)
        {
            Thread.Sleep(5000);
            searchItem.SendKeys(item);
        }

        public void ClickSearchButton()
        {
            Thread.Sleep(7000);
            searchbutton.Click();
        }

        public void ClickOnAddButton()
        {
            addButton.Click();
        }

        public void EnterSearchItems(string items)
        {
            searchItem.SendKeys(items);
        }

        public void ClickSearchButtonAgain()
        {
            searchbuttonAgain.Click();
        }

        public void ClickOnAddButton1()
        {
            Thread.Sleep(5000);
            addButton1.Click();
        }

        public void ClickOnPlusAddButton()
        {
            plusAddButton.Click();
        }

        public void EnterSearchItems1(string items)
        {
            searchItems1.SendKeys(items);
        }

        public void ClickOnAddButton2()
        {
            Thread.Sleep(5000);
            addButton2.Click();
        }

        public void ClickOnPlusAdd()
        {
            plusAdd.Click();
        }

        public void ClickOnBasket()
        {
            basket.Click();
        }

        public void ClickOnDropdown()
        {
            Thread.Sleep(5000);
            dropdown.Click();
        }

        public bool IsBrownieDisplayed()
        {
            return brownie.Displayed;
        }

        public bool IsHummusChipsDisplayed()
        {
            return hummusChips.Displayed;
        }

        public bool IsSimplySaltedPopcornDisplayed()
        {
            return simplySaltedPopcorn.Displayed;
        }

        public bool IsTotalPriceDisplayed()
        {
            return totalPrice.Displayed;
        }


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }







    }


}

        
    

