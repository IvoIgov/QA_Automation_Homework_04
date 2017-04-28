using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_02.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
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

        public IWebElement FirstName
        {
            get
            {
                return Driver.FindElement(By.Id("name_3_firstname"));
            }
        }

        public IWebElement LastName
        {
            get
            {
                return Driver.FindElement(By.Id("name_3_lastname"));
            }
        }

        public IWebElement phone
        {
            get
            {
                return Driver.FindElement(By.Id("phone_9"));
            }
        }

        public IWebElement password
        {
            get
            {
                return Driver.FindElement(By.Id("password_2"));
            }
        }

        public IWebElement confirmPassword
        {
            get
            {
                return Driver.FindElement(By.Id("confirm_password_password_2"));
            }
        }

        public IWebElement email
        {
            get
            {
                return Driver.FindElement(By.Id("email_1"));
            }
        }

        public IWebElement username
        {
            get
            {
                return Driver.FindElement(By.Id("username"));
            }
        }

        public IWebElement hobby
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[3]/div/label"));
            }
        }

        public IWebElement submitButton
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[14]/div/input"));
            }
        }

        public IWebElement errorMessageEmptyName
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span"));
            }
        }

        public IWebElement errorMessagePassword
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[11]/div/div/span"));
            }
        }

        public IWebElement errorMessagePasswordConfirm
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[12]/div/div/span"));
            }
        }

        public IWebElement errorMessagePhoneNumber
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
            }
        }

        public IWebElement errorMessagePasswordMismatch
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[12]/div/div/span"));
            }
        }

        public IWebElement errorMessageInvalidEmail
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span"));
            }
        }

        public IWebElement errorMessageEmptyEmail
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span"));
            }
        }

        public IWebElement errorMessagePasswordStrength
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"piereg_passwordStrength\"]"));
            }
        }

        public IWebElement errorMessageEmptyHobbyField
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[3]/div/div[2]/span"));
            }
        }

        public IWebElement registrationPageText
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"post-49\"]/header/h1"));
            }
        }

        public IWebElement errorMessageEmptyUsername
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[7]/div/div/span"));
            }
        }
    }
}
