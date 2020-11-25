using HepsiBuradaCase.TestSteps;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace HepsiBuradaCase.BasePage
{
    public class PageModel : BasePage
    {
        public PageModel(IWebDriver _driver) : base(_driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//*[@id='SearchBoxOld']/div/div/div[1]/div[2]/input")]
        public IWebElement txtSearch;

        [FindsBy(How = How.XPath, Using = "//*[@id='SearchBoxOld']/div/div/div[2]")]
        public IWebElement btnSearch;

        [FindsBy(How = How.XPath, Using = "//a[@data-productid='HB00000NSBZ4']")]
        public IWebElement imgIphone;

        [FindsBy(How = How.XPath, Using = "//*[@id='comments-container']/a")]
        public IWebElement comment;

        [FindsBy(How = How.XPath, Using = "//div[@class='paginationContentHolder']/div")]
        public IList<IWebElement> comments;

        [FindsBy(How = How.XPath, Using = "//*[@id='hermes-voltran-comments']/div[3]/div[3]/div/div[1]/div[2]/div[4]/div[1]/div/div[1]/div[1]")]
        public IWebElement btnYes;

        [FindsBy(How = How.XPath, Using = "//*[@class='hermes-ReviewCard-module-1ZiTv']")]
        public IList<IWebElement> txtResult;

        public void SetProductSearch(string product)
        {
            SendKeys(txtSearch, product);
            ClickElement(btnSearch);
        }

        public void ProductDetail()
        {
            WaitElement(imgIphone);
            ClickElement(imgIphone);
        }

        public void ClickTHeComment()
        {
            WaitElement(comment);
            ClickElement(comment);
        }

        public int CommentNumber()
        {
            return comments.Count;
        }

        public void ClickTheYes()
        {
            Actions actions = new Actions(FeatureSteps.WebDriver);
            actions.MoveToElement(btnYes);
            actions.Perform();
            WaitElement(btnYes);
            ClickElement(btnYes);
        }

        public string Result()
        {
            WaitElement(txtResult[0]);
            return GetText(txtResult[0]);
        }



    }
}
