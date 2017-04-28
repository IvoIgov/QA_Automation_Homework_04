using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_02.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public string URL
        {
            get
            {
                return base.url + "registration/";
            }
        }
    }
}
