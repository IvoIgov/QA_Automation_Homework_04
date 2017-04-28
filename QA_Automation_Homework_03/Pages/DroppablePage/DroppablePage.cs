using OpenQA.Selenium;
using QA_Automation_Homework_02.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_03.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver)
            : base(driver)
        {
        }

        public string URL
        {
            get
            {
                return base.url + "droppable/";
            }
        }
    }
}
