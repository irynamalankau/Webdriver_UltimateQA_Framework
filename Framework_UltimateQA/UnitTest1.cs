using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Framework_UltimateQA
{
    [TestClass]
    [TestCategory ("Regression")]
    public class FrameworkUltimateQA
    {
        private IWebDriver Driver {
            get; set;
        }

        [TestMethod]
        public void Submitting_Form_Redirects_To_Homepage()
        {
            //get driver
            Driver = GetChromeDriver();

            //create an instance of a sampleApplicationPage
            var sampleApplicationPage = new SampleApplicationPage(Driver);

            //go to sample application page
            sampleApplicationPage.GoTo();

            //assert it's a right page
            Assert.IsTrue(sampleApplicationPage.IsVisible);

            //fill out and submit form
            sampleApplicationPage.FillOutAndSumbitForm("Ira");

            //create instance of a Home Page
            var ultimateQAHomePage = new UltimateQAHomePage(Driver);


            //wait and assert the redirection
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleContains(ultimateQAHomePage.getTitle()));

            
            Assert.AreEqual(Driver.Title, ultimateQAHomePage.getTitle());

            //clean up
            Driver.Close();
            Driver.Quit();   

        }

        private IWebDriver GetChromeDriver()
        {
            return new ChromeDriver();
            
        }

        
    }
}
