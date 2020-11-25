using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBuradaCase.BasePage
{
    public class BasePage
    {
        IWebDriver _webDriver;
        WebDriverWait _wait;

        public BasePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(60));
            PageFactory.InitElements(_webDriver, this);
        }

        /// <summary>
        /// Dynamic Wait
        /// </summary>
        /// <param name="by"></param>
        public void WaitElement(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        /// <summary>
        /// Hover Element
        /// </summary>
        /// <param name="IWebElement"></param>
        public void Hover(IWebElement element)
        {
            Actions action = new Actions(_webDriver);
            action.MoveToElement(element).Build().Perform();
        }

        /// <summary>
        /// Click Element
        /// </summary>
        /// <param name="IWebElement"></param>
        public void ClickElement(IWebElement element)
        {
            element.Click();
        }

        /// <summary>
        /// Send Text
        /// </summary>
        /// <param name="IWebElement"></param>
        /// <param name="text"></param>
        public void SendKeys(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        /// <summary>
        /// Get Text Element
        /// </summary>
        /// <param name="IWebElement"></param>
        /// <returns></returns>
        public string GetText(IWebElement element)
        {
            return element.Text;
        }

        /// <summary>
        /// Assertion 
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public void AssertEqual(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Go to Url
        /// </summary>
        /// <param name="url"></param>
        public void GoToUrl(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Get Url
        /// </summary>
        /// <returns></returns>
        public string GetCurrentUrl()
        {
            return _webDriver.Url;
        }

        /// <summary>
        /// Back Page(previous page)
        /// </summary>
        public void BackPage()
        {
            _webDriver.Navigate().Back();
        }
    }
}
