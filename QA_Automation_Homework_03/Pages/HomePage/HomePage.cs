using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_02.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Manage().Window.Maximize();
            this.Driver.Navigate().GoToUrl("http://www.demoqa.com");
        }
    }
}
