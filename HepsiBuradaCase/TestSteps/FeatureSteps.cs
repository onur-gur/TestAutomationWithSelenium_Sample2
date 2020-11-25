using HepsiBuradaCase.BasePage;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace HepsiBuradaCase.TestSteps
{
    [Binding, Scope(Feature = "Hepsiburada")]
    public class FeatureSteps
    {
        public static IWebDriver WebDriver { get; set; }
        public Util.Browser browser = new Util.Browser();
        public PageModel page;

        [BeforeScenario]
        public void SetUp()
        {
            browser.SetUp();
            page = new PageModel(WebDriver);
        }

        [AfterScenario]
        public void TearDown()
        {
            WebDriver.Quit();
        }

        [StepDefinition("'(.*)' adresine gidilir")]
        public void GoToUrl(string url)
        {
            page.GoToUrl(url);
        }

        [StepDefinition("'(.*)' aratılır")]
        public void Search(string product)
        {
            page.SetProductSearch(product);
        }

        [StepDefinition("Ürün Detay Safyasına gidilir")]
        public void ProductDetail()
        {
            page.ProductDetail();
        }


        [StepDefinition("Yorumlar tabına gidilir eğer yorumlar tabında yorum yoksa test sonlandırılır")]
        public void ClickTheComment()
        {
            page.ClickTHeComment();
            if (page.CommentNumber() == 0)
            {
                WebDriver.Quit();
            }
        }

        [StepDefinition("Gelen ilk yorum içerisinde Evet butonuna basılır")]
        public void ClickTheYes()
        {
            page.ClickTheYes();
        }

        [StepDefinition("'(.*)' yazısı görülür")]
        public void CheckSuccesfullyEnd(string actual)
        {
            string expected = page.Result();
            Assert.True(expected == actual);

        }

    }
}
