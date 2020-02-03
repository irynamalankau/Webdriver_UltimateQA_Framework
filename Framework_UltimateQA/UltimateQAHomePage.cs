using System;
using OpenQA.Selenium;

namespace Framework_UltimateQA
{
    internal class UltimateQAHomePage : BaseSampleApplicationPage
    {
        private string xpath = ".//*[@class = 'et_pb_button et_pb_custom_button_icon et_pb_button_0 et_hover_enabled et_pb_bg_layout_light']";

        
        private IWebElement ButtonViewAllCourses => Driver.FindElement(By.XPath(xpath));

        public UltimateQAHomePage(IWebDriver driver) : base(driver){}
        

        public bool IsVisible => ButtonViewAllCourses.Displayed;

        public Func<string> getTitle = () => "Home - Ultimate QA";

        
    }
}