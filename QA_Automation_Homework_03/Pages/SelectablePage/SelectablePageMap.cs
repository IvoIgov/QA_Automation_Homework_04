using OpenQA.Selenium;
using QA_Automation_Homework_02.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_03.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public IWebElement Item1
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[1]"));
            }
        }

        
        public IWebElement Item2
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[2]"));
            }
        }
    }
}
