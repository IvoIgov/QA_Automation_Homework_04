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
        public IWebElement Item1
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[1]"));
            }
        }

        public IWebElement Item2
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[2]"));
            }
        }

        public IWebElement Item7
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[7]"));
            }
        }
    }
}
