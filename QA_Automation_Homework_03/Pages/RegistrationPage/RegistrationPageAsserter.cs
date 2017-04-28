using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_02.Pages.RegistrationPage
{
    public static class RegistrationPageAsserter
    {
        public static void AssertRegistrationPageIsOpen(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.Header.Text);
        }

        public static void AssertErrorMessagePhoneNumber(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.errorMessagePhoneNumber.Displayed);
            StringAssert.Contains(text, page.errorMessagePhoneNumber.Text);
        }

        public static void AssertErrorMessageEmptyFirstLastName(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.errorMessageEmptyName.Displayed);
            StringAssert.Contains(text, page.errorMessageEmptyName.Text);
        }

        public static void AssertErrorMessageEmptyPassword(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.errorMessagePassword.Displayed);
            StringAssert.Contains(text, page.errorMessagePassword.Text);
        }

        public static void AssertErrorMessageEmptyConfirmPassword(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.errorMessagePasswordConfirm.Displayed);
            StringAssert.Contains(text, page.errorMessagePasswordConfirm.Text);
        }

        public static void AssertRegistrationPageText(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.registrationPageText.Displayed);
            StringAssert.Contains(text, page.registrationPageText.Text);
        }

        public static void AssertErrorMessageInvalidEmail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.errorMessageInvalidEmail.Displayed);
            StringAssert.Contains(text, page.errorMessageInvalidEmail.Text);
        }

        public static void AssertErrorMessageEmptyEmail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.errorMessageInvalidEmail.Displayed);
            StringAssert.Contains(text, page.errorMessageInvalidEmail.Text);
        }
        public static void AssertErrorMessagePasswordsDoNotMatch(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.errorMessagePasswordMismatch.Displayed);
            StringAssert.Contains(text, page.errorMessagePasswordMismatch.Text);
        }

        public static void AssertErrorMessagePasswordStrength(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.errorMessagePasswordStrength.Displayed);
            StringAssert.Contains(text, page.errorMessagePasswordStrength.Text);
        }

        public static void AssertErrorMessageEmptyHobbyField(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.errorMessageEmptyHobbyField.Displayed);
            StringAssert.Contains(text, page.errorMessageEmptyHobbyField.Text);
        }

        public static void AssertErrorMessageEmptyUsername(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.errorMessageEmptyUsername.Displayed);
            StringAssert.Contains(text, page.errorMessageEmptyUsername.Text);
        }

    }
}
