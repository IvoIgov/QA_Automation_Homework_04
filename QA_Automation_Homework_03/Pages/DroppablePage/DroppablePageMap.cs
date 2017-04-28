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

        public IWebElement Header
        {
            get
            {
                return this.Driver.FindElement(By.ClassName("entry-title"));
            }
        }

        public IWebElement Source
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"draggableview\"]/p"));
            }
        }

        public IWebElement Target
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableview"));
            }
        }

        public IWebElement SourceDroppedOnTarget
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"droppableview\"]"));
            }
        }

        public IWebElement AcceptButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));
            }
        }

        public IWebElement AcceptSource
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggableaccept"));
            }
        }

        public IWebElement AcceptTarget
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableaccept"));
            }
        }

        public IWebElement AcceptSourceDroppedOnTarget
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"droppableaccept\"]"));
            }
        }

        public IWebElement AcceptSourceNotDroppableOnTarget
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggable-nonvalid"));
            }
        }

        public IWebElement PreventPropagationButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-3"));
            }
        }

        public IWebElement PreventPropagationSource
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggableprop"));
            }
        }

        public IWebElement PreventPropagationTarget
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppable-inner"));
            }
        }

        public IWebElement PreventPropagationSourceDroppedOnTarget
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"droppable-inner\"]"));
            }
        }
    }
}
