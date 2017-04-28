using OpenQA.Selenium;
using QA_Automation_Homework_02.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_03.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public IWebElement Title
        {
            get
            {
                return this.Driver.FindElement(By.TagName("title"));
            }
        }

        public IWebElement Header
        {
            get
            {
                return this.Driver.FindElement(By.ClassName("entry-title"));
            }
        }

        public IWebElement ResizeTriangle
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"resizable\"]/div[3]"));
            }
        }

        public IWebElement ResizeBox
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizable"));
            }
        }

        public IWebElement AnimateButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));
            }
        }

        public IWebElement AnimateResizeTriangle
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"resizableani\"]/div[3]"));
            }
        }

        public IWebElement AnimateResizeBox
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizableani"));
            }
        }

        public IWebElement ConstrainResizeAreaButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-3"));
            }
        }

        public IWebElement ConstrainResizeAreaResizeTriangle
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"resizableconstrain\"]/div[3]"));
            }
        }

        public IWebElement ConstrainResizeAreaResizeBox
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizableconstrain"));
            }
        }
    }
}
