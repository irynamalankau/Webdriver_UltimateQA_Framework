using OpenQA.Selenium;

namespace Framework_UltimateQA
{
    internal class BaseSampleApplicationPage
    {
        protected IWebDriver Driver { get; set; }

        public BaseSampleApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }
    
    }
}