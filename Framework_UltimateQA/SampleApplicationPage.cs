using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework_UltimateQA
{
    internal class SampleApplicationPage : BaseSampleApplicationPage
    {
        public bool IsVisible => Driver.Title.Contains("Sample Application Lifecycle - Sprint 1 - Ultimate QA");
        public IWebElement FirstNameField => Driver.FindElement(By.Name("firstname"));
        public IWebElement SubmitButton => Driver.FindElement(By.Id("submitForm"));

        public SampleApplicationPage(IWebDriver driver) : base(driver) { }
        
        public void FillOutAndSumbitForm(string input)
        {
            //fill out form
            FirstNameField.SendKeys(input);
            //submit form
            SubmitButton.Submit();
        }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl("https://ultimateqa.com/sample-application-lifecycle-sprint-1/");
        }
    }
}