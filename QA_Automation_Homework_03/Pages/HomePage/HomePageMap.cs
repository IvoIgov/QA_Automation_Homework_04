using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_02.Pages.HomePage
{
    public partial class HomePage
    {
        public IWebElement registrationButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("menu-item-374")));
                return this.Driver.FindElement(By.Id("menu-item-374"));
            }
        }

        public IWebElement draggableButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("menu-item-140")));
                return this.Driver.FindElement(By.Id("menu-item-140"));
            }
        }

        public IWebElement droppableButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("menu-item-141")));
                return this.Driver.FindElement(By.Id("menu-item-141"));
            }
        }

        public IWebElement resizableButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("menu-item-143")));
                return this.Driver.FindElement(By.Id("menu-item-143"));
            }
        }

        public IWebElement selectableButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("menu-item-142")));
                return this.Driver.FindElement(By.Id("menu-item-142"));
            }
        }

        public IWebElement sortableButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("menu-item-151")));
                return this.Driver.FindElement(By.Id("menu-item-151"));
            }
        }
    }
}
