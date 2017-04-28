using OpenQA.Selenium;
using QA_Automation_Homework_02.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_03.Pages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver)
            : base(driver)
        {
        }

        public string URL
        {
            get
            {
                return base.url + "draggable/";
            }
        }
    }
}
