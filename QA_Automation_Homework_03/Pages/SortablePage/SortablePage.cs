using OpenQA.Selenium;
using QA_Automation_Homework_02.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_03.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver)
            : base(driver)
        {
        }

        public string URL
        {
            get
            {
                return base.url + "sortable/";
            }
        }
    }
}
