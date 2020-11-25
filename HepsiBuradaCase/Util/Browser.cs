using HepsiBuradaCase.TestSteps;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBuradaCase.Util
{
    public class Browser
    {
        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArguments("start-maximized");
            //options.AddArguments("test-type");
            //options.AddArguments("--disable-infobars");
            //options.AddArguments("--disable-notifications");
            //options.AddArguments("enable-automation");
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            options.AddArguments("disable-popup-blocking");
            options.AddArguments("ignore-certificate-errors");
            options.AddArguments("disable-translate");
            options.AddArguments("disable-automatic-password-saving");
            options.AddArguments("allow-silent-push");
            options.AddArguments("disable-infobars");
            options.AddAdditionalCapability("useAutomationExtension", false);
            FeatureSteps.WebDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            FeatureSteps.WebDriver.Navigate().GoToUrl("https://www.google.com/");
        }
    }
}
