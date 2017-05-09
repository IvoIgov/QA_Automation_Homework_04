using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using QA_Automation_Homework_02.Pages.HomePage;
using QA_Automation_Homework_02.Pages.RegistrationPage;
using QA_Automation_Homework_03.Pages.DraggablePage;
using QA_Automation_Homework_03.Pages.DroppablePage;
using QA_Automation_Homework_03.Pages.ResizablePage;
using QA_Automation_Homework_03.Pages.SelectablePage;
using QA_Automation_Homework_03.Pages.SortablePage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_03
{
    [TestFixture]
    public class DemoQATests
    {
        public IWebDriver driver;

        public IWebElement DragBox { get; private set; }

        [SetUp]
        public void Init()
        {
            //Open browser
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                string path = ConfigurationManager.AppSettings["Logs"] +
                              TestContext.CurrentContext.Test.Name + ".txt";
                File.WriteAllText(path, TestContext.CurrentContext
                                                   .Test.FullName + "            " + 
                                                    TestContext.CurrentContext.TestDirectory);

                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(path + TestContext.CurrentContext.Test.Name + ".jpg",
                                                ScreenshotImageFormat.Jpeg);
            }


            //Close browser
            this.driver.Quit();
        }

        [Test]
        [Description("Verify Draggable page title")]
        public void DraggablePageTitle()
        {
            var draggablePage = new DraggablePage(driver);
            driver.Navigate().GoToUrl(draggablePage.URL);

            //Assert that Draggable page is open

            draggablePage.AssertDraggablePageIsOpen("Draggable");
        }

        [Test]
        [Description("Move DragBox 100 pixels to the right")]
        public void DraggablePageDragBox100Right()
        {
            var draggablePage = new DraggablePage(driver);
            driver.Navigate().GoToUrl(draggablePage.URL);

            //move DragBox 100 pixels to the right

            Actions builder = new Actions(driver);
            var action = builder.DragAndDropToOffset(draggablePage.DragBox, 100, 0);
            action.Perform();

            //Assert that Drag box is moved 100 to the right

            Assert.IsTrue(draggablePage.DragBox.Location.X > 240 && draggablePage.DragBox.Location.X < 400);
        }

        [Test]
        [Description("Move DragBox 100 pixels down")]
        public void DraggablePageDragBox100Down()
        {
            var draggablePage = new DraggablePage(driver);
            driver.Navigate().GoToUrl(draggablePage.URL);

            //move DragBox 100 pixels down

            Actions builder = new Actions(driver);
            var action = builder.DragAndDropToOffset(draggablePage.DragBox, 0, 100);
            action.Perform();

            //Assert that Drag box is moved 100 pixels down

            Assert.IsTrue(draggablePage.DragBox.Location.Y > 150 && draggablePage.DragBox.Location.Y < 600);
        }

        [Test]
        [Description("Move DragBox 100 pixels right and down")]
        public void DraggablePageDragBox100RightAndDown()
        {
            var draggablePage = new DraggablePage(driver);
            driver.Navigate().GoToUrl(draggablePage.URL);

            //move DragBox 100 pixels right and down

            Actions builder = new Actions(driver);
            var action = builder.DragAndDropToOffset(draggablePage.DragBox, 100, 100);
            action.Perform();

            //Assert that Drag box is moved 100 pixels right and down

            Assert.IsTrue(draggablePage.DragBox.Location.X > 240 && draggablePage.DragBox.Location.X < 400);
            Assert.IsTrue(draggablePage.DragBox.Location.Y > 150 && draggablePage.DragBox.Location.Y < 600);
        }

        [Test]
        [Description("Move DragBox 5 pixels left and up")]
        public void DraggablePageDragBox100LeftAndUp()
        {
            var draggablePage = new DraggablePage(driver);
            driver.Navigate().GoToUrl(draggablePage.URL);

            //move DragBox 100 pixels left and up

            Actions builder = new Actions(driver);
            var action = builder.DragAndDropToOffset(draggablePage.DragBox, -5, -5);
            action.Perform();

            //Assert that Drag box is moved 100 pixels left and up

            //Assert.IsTrue(draggablePage.DragBox.Location.X < 280 && draggablePage.DragBox.Location.X > -10);
            //Assert.IsTrue(draggablePage.DragBox.Location.Y < 200 && draggablePage.DragBox.Location.Y > -10);
        }

        [Test]
        [Description("Verify Droppable page title")]
        public void DroppablePageTitle()
        {
            var droppablePage = new DroppablePage(driver);
            driver.Navigate().GoToUrl(droppablePage.URL);

            //Assert that Droppable page is open

            droppablePage.AssertDroppablePageIsOpen("Droppable");
        }

        [Test]
        [Description("Drag and drop element on target")]
        public void DroppablePageDragDropElementOnTarget()
        {
            var droppablePage = new DroppablePage(driver);
            driver.Navigate().GoToUrl(droppablePage.URL);

            //Drag Source element on Target element

            Actions builder = new Actions(driver);
            var action = builder.DragAndDrop(droppablePage.Source, droppablePage.Target);
            action.Perform();

            //Assert source has been dropped on target
            droppablePage.AssertSourceDroppedOnTarget("Dropped!");
        }

        [Test]
        [Description("Drag droppable element on target")]
        public void DroppablePageAcceptDragDropElementOnTarget()
        {
            var droppablePage = new DroppablePage(driver);
            driver.Navigate().GoToUrl(droppablePage.URL);

            //Navigate to Accept menu
            droppablePage.AcceptButton.Click();

            //Drag Source not Droppable element on Target element

            Actions builder = new Actions(driver);
            var action = builder.DragAndDrop(droppablePage.AcceptSource, droppablePage.AcceptTarget);
            action.Perform();

            //Assert source has not been dropped on target
            droppablePage.AssertAcceptSourceDroppedOnTarget("Dropped!");
        }

        [Test]
        [Description("Drag not droppable element on target")]
        public void DroppablePageAcceptDragNotDropElementOnTarget()
        {
            var droppablePage = new DroppablePage(driver);
            driver.Navigate().GoToUrl(droppablePage.URL);

            //Navigate to Accept menu
            droppablePage.AcceptButton.Click();

            //Drag Source not Droppable element on Target element

            Actions builder = new Actions(driver);
            var action = builder.DragAndDrop(droppablePage.AcceptSourceNotDroppableOnTarget, droppablePage.AcceptTarget);
            action.Perform();

            //Assert source has not been dropped on target
            droppablePage.AssertAcceptSourceNotDroppedOnTarget("accept: ‘#draggableaccept’");
        }

        [Test]
        [Description("Drag droppable element on Inner droppable (not greedy) target")]
        public void DroppablePagePreventPropagationDragElementNotGreedyTarget()
        {
            var droppablePage = new DroppablePage(driver);
            driver.Navigate().GoToUrl(droppablePage.URL);

            //Navigate to Prevent Propagation menu
            droppablePage.PreventPropagationButton.Click();

            //Drag Source element on Inner droppable Not Greedy element

            Actions builder = new Actions(driver);
            var action = builder.DragAndDrop(droppablePage.PreventPropagationSource, droppablePage.PreventPropagationTarget);
            action.Perform();

            //Assert source has not been dropped on target
            droppablePage.AssertPreventPropagationSourceDroppedOnTarget("Dropped!");
        }

        [Test]
        [Description("Resize resizable element with 100 pixels")]
        public void ResizablePageResizeElementBy100Pixels()
        {
            var resizablePage = new ResizablePage(driver);
            driver.Navigate().GoToUrl(resizablePage.URL);

            int width = resizablePage.ResizeBox.Size.Width;
            int height = resizablePage.ResizeBox.Size.Height;

            //Drag Resize Box with 100 pixels

            Actions builder = new Actions(driver);
            var action = builder.DragAndDropToOffset(resizablePage.ResizeTriangle, 100, 100);
            action.Perform();

            //Assert source has been added 100 pixels
            Assert.IsTrue(resizablePage.ResizeBox.Size.Width > 230 && resizablePage.ResizeBox.Size.Width < 240);
            Assert.IsTrue(resizablePage.ResizeBox.Size.Height > 230 && resizablePage.ResizeBox.Size.Height < 240);
        }

        [Test]
        [Description("Resize animated box with 100 pixels")]
        public void ResizablePageResizeAnimatedBoxBy100Pixels()
        {
            var resizablePage = new ResizablePage(driver);
            driver.Navigate().GoToUrl(resizablePage.URL);
            resizablePage.AnimateButton.Click();

            int width = resizablePage.AnimateResizeBox.Size.Width;
            int height = resizablePage.AnimateResizeBox.Size.Height;

            //Drag Animated Resize Box with 100 pixels

            Actions builder = new Actions(driver);
            var action = builder.DragAndDropToOffset(resizablePage.AnimateResizeTriangle, 100, 100);
            action.Perform();

            //Assert source has been added 100 pixels
            Assert.IsTrue(resizablePage.AnimateResizeBox.Size.Width > 230 && resizablePage.AnimateResizeBox.Size.Width < 300);
            Assert.IsTrue(resizablePage.AnimateResizeBox.Size.Height > 230 && resizablePage.AnimateResizeBox.Size.Height < 300);
        }

        [Test]
        [Description("Resize constrain size box by 40 pixels")]
        public void ResizablePageConstrainResizeBy40Pixels()
        {
            var resizablePage = new ResizablePage(driver);
            driver.Navigate().GoToUrl(resizablePage.URL);
            resizablePage.ConstrainResizeAreaButton.Click();

            int height = resizablePage.ConstrainResizeAreaResizeBox.Size.Height;

            //Drag Animated Resize Box with 40 pixels

            Actions builder = new Actions(driver);
            var action = builder.DragAndDropToOffset(resizablePage.ConstrainResizeAreaResizeTriangle, 0, 40);
            action.Perform();

            //Assert source has been added 40 pixels
            Assert.IsTrue(resizablePage.ConstrainResizeAreaResizeBox.Size.Height > 60 && resizablePage.ConstrainResizeAreaResizeBox.Size.Height < 90);
        }

        [Test]
        [Description("Choose Item1")]
        public void SelectablePageChooseItem1()
        {
            var selectablePage = new SelectablePage(driver);
            driver.Navigate().GoToUrl(selectablePage.URL);

            //Select Item1

            Actions builder = new Actions(driver);
            var action = builder.MoveToElement(selectablePage.Item1).Click();
            action.Perform();

            //Assert Item1 has been clicked
            Assert.AreEqual(selectablePage.Item1.GetAttribute("class"), "ui-widget-content ui-corner-left ui-selectee ui-selected");
        }

        [Test]
        [Description("Choose Item1 and then Item2")]
        public void SelectablePageChooseItem1ThenItem2()
        {
            var selectablePage = new SelectablePage(driver);
            driver.Navigate().GoToUrl(selectablePage.URL);

            //Select Item1 and then Item2

            Actions builder = new Actions(driver);
            var action = builder.MoveToElement(selectablePage.Item1).Click();
            action.Perform();
            var action2 = builder.MoveToElement(selectablePage.Item2).Click();
            action2.Perform();

            //Assert Item1 has not been clicked and Item2 has been clicked
            Assert.AreEqual(selectablePage.Item1.GetAttribute("class"), "ui-widget-content ui-corner-left ui-selectee");
            Assert.AreEqual(selectablePage.Item2.GetAttribute("class"), "ui-widget-content ui-corner-left ui-selectee ui-selected");
        }

        [Test]
        [Description("Choose Item1 and then Item2 together")]
        public void SelectablePageChooseItem1ThenItem2Together()
        {
            var selectablePage = new SelectablePage(driver);
            driver.Navigate().GoToUrl(selectablePage.URL);

            //Press and hold Ctrl key, then select Item1 and then Item2

            Actions builder = new Actions(driver);
            var action = builder.MoveToElement(selectablePage.Item1).Click();
            action.Perform();
            builder.KeyDown(Keys.Control);
            var action2 = builder.MoveToElement(selectablePage.Item2).Click();
            action2.Perform();

            //Assert Item1 has not been clicked and Item2 has been clicked at the same time
            Assert.AreEqual(selectablePage.Item1.GetAttribute("class"), "ui-widget-content ui-corner-left ui-selectee ui-selected");
            Assert.AreEqual(selectablePage.Item2.GetAttribute("class"), "ui-widget-content ui-corner-left ui-selectee ui-selected");
        }

        [Test]
        [Description("Drag Item1 at the place of Item2")]
        public void SortablePageDragItem1OverItem2()
        {
            var sortablePage = new SortablePage(driver);
            driver.Navigate().GoToUrl(sortablePage.URL);

            //Place Item1 over Item2

            Actions builder = new Actions(driver);
            var action = builder.DragAndDrop(sortablePage.Item1, sortablePage.Item2);
            action.Perform();
           
            //Assert Item1 has been sorted on Item2's place
            
            Assert.IsTrue(sortablePage.Item1.Location.Y < sortablePage.Item2.Location.Y);
        }

        [Test]
        [Description("Drag Item2 at the place of Item1")]
        public void SortablePageDragItem2OverItem1()
        {
            var sortablePage = new SortablePage(driver);
            driver.Navigate().GoToUrl(sortablePage.URL);

            //Place Item1 over Item2

            Actions builder = new Actions(driver);
            var action = builder.DragAndDrop(sortablePage.Item2, sortablePage.Item1);
            action.Perform();

            //Assert Item2 has been sorted on Item1's place

            Assert.IsTrue(sortablePage.Item1.Location.Y < sortablePage.Item2.Location.Y);
        }

        [Test]
        [Description("Drag Item1 at the place of Item7")]
        public void SortablePageDragItem1OverItem7()
        {
            var sortablePage = new SortablePage(driver);
            driver.Navigate().GoToUrl(sortablePage.URL);

            //Place Item1 over Item2

            Actions builder = new Actions(driver);
            var action = builder.DragAndDrop(sortablePage.Item1, sortablePage.Item7);
            action.Perform();

            //Assert Item7 has been sorted on Item1's place

            Assert.IsTrue(sortablePage.Item7.Location.Y > sortablePage.Item2.Location.Y);
        }

        [Test]
        [Author("Ivo Igov")]
        [Description ("This test verifies whether Registration page has been opened")]

        public void NavigateToRegistrationPage()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            registrationPage.AssertRegistrationPageIsOpen("Registration");
        }

        [Test]
        [Description("This test verifies whether you can submit with empty First and Last Name")]
        public void EmptyFirstLastName()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //click submit button
            registrationPage.submitButton.Click();

            //assert that error message has appeared
            registrationPage.AssertErrorMessageEmptyFirstLastName("* This field is required");

        }

        [Test]
        [Description("This test verifies whether you can submit with empty Password / Confirm Password")]
        public void PasswordConfirmPasswordNotEmpty()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find Password and clear box
            registrationPage.password.Clear();

            //Find Confirm Password and clear box
            registrationPage.confirmPassword.Clear();

            //click submit button
            registrationPage.submitButton.Click();

            //Assert that both Error messages have appeared
            registrationPage.AssertErrorMessageEmptyPassword("* This field is required");
            registrationPage.AssertErrorMessageEmptyConfirmPassword("* This field is required");

        }

        [Test]
        [Description("Test validates whether phone number is less than 10 digits")]
        public void PhoneNumber()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find and clear Phone number. Fill in 4 random numbers
            registrationPage.phone.Clear();
            registrationPage.phone.SendKeys("1234");

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert that Error message has appeared
            registrationPage.AssertErrorMessagePhoneNumber("* Minimum 10 Digits starting with Country Code");

        }

        [Test]
        public void DemoQARegistrationPage()
        {
            //Test verifies whether user is on Registration page

            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Registration page text
            var registrationPageText = driver.FindElement(By.XPath("//*[@id=\"post-49\"]/header/h1"));

            //Assert registration page
            registrationPage.AssertRegistrationPageText("Registration");

        }

        [Test]
        [Description("Test verifies whether entering a random number as email is valid")]
        public void InvalidEmailOnlyNumbers()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find Email and enter only random numbers
            registrationPage.email.Clear();
            registrationPage.email.SendKeys("1234");

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert that Error message has appeared
            registrationPage.AssertErrorMessageInvalidEmail("* Invalid email address");

        }

        [Test]
        [Description("Test verifies whether password mismatch is caught in case Password is longer than Confirm password")]
        public void PasswordMismatchPasswordLongerThanConfirmPassword()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find Password and fill it
            registrationPage.password.Clear();
            registrationPage.password.SendKeys("123456789");

            //Find Confirm Password and fill it
            registrationPage.confirmPassword.Clear();
            registrationPage.confirmPassword.SendKeys("12345678");

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert error message
            registrationPage.AssertErrorMessagePasswordsDoNotMatch("* Fields do not match");

        }

        [Test]
        [Description("Test verifies whether you can create a phone number using letters")]
        public void PhoneNumberWithLetters()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find and clear Phone number. Fill in 4 random numbers
            registrationPage.phone.Clear();
            registrationPage.phone.SendKeys("abcdefghijk");

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert that Error message has appeared
            registrationPage.AssertErrorMessagePhoneNumber("* Minimum 10 Digits starting with Country Code");

        }

        [Test]
        [Description("Test verifies whether username is entered")]
        public void EmptyUsername()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find and clear Username
            registrationPage.username.Clear();

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert that Error message has appeared
            registrationPage.AssertErrorMessageEmptyUsername("* This field is required");

        }

        [Test]
        [Description("Test verifies whether you can submit empty email")]
        public void EmptyEmail()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find Email and enter only random numbers
            registrationPage.email.Clear();

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert that Error message has appeared
            registrationPage.AssertErrorMessageEmptyEmail("* This field is required");

        }

        [Test]
        [Description("Test verifies password is very weak")]
        public void SubmitVeryWeakPassword()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find Password and clear it, fill with values
            registrationPage.password.Clear();
            registrationPage.password.SendKeys("12345678");

            //Find Confirm Password, clear and fill it with values
            registrationPage.confirmPassword.Clear();
            registrationPage.confirmPassword.SendKeys("12345678");

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert error message
            registrationPage.AssertErrorMessagePasswordStrength("Very weak");

        }

        [Test]
        [Description("Test verifies if submitting only Confirm password gets an error message")]
        public void SubmitOnlyConfirmPassword()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find Password and clear it
            registrationPage.password.Clear();

            //Find Confirm Password and fill it
            registrationPage.confirmPassword.Clear();
            registrationPage.confirmPassword.SendKeys("12345678");

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert error message
            registrationPage.AssertErrorMessagePasswordsDoNotMatch("* Fields do not match");

        }

        [Test]
        [Description("Test verifies if submitting only password gets an error message")]
        public void SubmitOnlyPassword()

        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find Password and clear it
            registrationPage.password.Clear();
            registrationPage.password.SendKeys("12345678");

            //Find Confirm Password and fill it
            registrationPage.confirmPassword.Clear();

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert error message
            registrationPage.AssertErrorMessagePasswordsDoNotMatch("* This field is required");

        }

        [Test]
        public void VerifyPageTitle()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Assert that message has appeared
            Assert.AreEqual("Registration | Demoqa", registrationPage.Header);

        }

        [Test]
        [Description("Test verifies Hobby field is empty")]
        public void EmptyHobbyField()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert error message for empty Hobby field
            registrationPage.AssertErrorMessageEmptyHobbyField("* This field is required");

        }

        [Test]
        [Description("Test verifies that when first and last name are entered, there is no error message, even if only numbers are used")]
        public void NameFieldsFilledWithNumbers()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //click submit button
            registrationPage.submitButton.Click();

            //Find First Name and enter random value
            registrationPage.FirstName.Clear();

            //Find Last name and clear
            registrationPage.LastName.Clear();

            //Click Submit
            registrationPage.submitButton.Click();

            //Assert that message has appeared
            registrationPage.AssertErrorMessageEmptyFirstLastName(("* This field is required"));

            //Fill First name with numbers
            registrationPage.FirstName.Clear();
            registrationPage.FirstName.SendKeys("1111");

            //Fill Last Name with numbers
            registrationPage.LastName.Clear();
            registrationPage.LastName.SendKeys("1111");

            //Click Submit
            registrationPage.submitButton.Click();

            //Assert that Error message has disappeared
            Assert.Throws<NoSuchElementException>(delegate { driver.FindElement(By.XPath("//*[@id=\"post-49\"]/div/p")); });

        }

        [Test]
        [Description("Test verifies whether entering random letters as email is valid")]
        public void InvalidEmailOnlyLetters()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find Email and enter only random letters
            registrationPage.email.Clear();
            registrationPage.email.SendKeys("abcd");

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert that Error message has appeared
            registrationPage.AssertErrorMessageInvalidEmail("* Invalid email address");

        }

        [Test]
        [Description("Test verifies if only first name is allowed")]
        public void OnlyFirstName()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //click submit button
            registrationPage.submitButton.Click();

            //Find First Name and enter random value
            registrationPage.FirstName.Clear();
            registrationPage.FirstName.SendKeys("abc");

            //Find Last name and clear
            registrationPage.LastName.Clear();

            //Click Submit
            registrationPage.submitButton.Click();

            //assert that error message has appeared
            registrationPage.AssertErrorMessageEmptyFirstLastName("* This field is required");

        }

        [Test]
        [Description("Test verifies if only last name is allowed - should be possible")]
        public void OnlyLastName()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //click submit button
            registrationPage.submitButton.Click();

            //Find First Name and clear
            registrationPage.FirstName.Clear();

            //Find Last name and fill random text
            registrationPage.LastName.Clear();
            registrationPage.LastName.SendKeys("abc");

            //Click Submit
            registrationPage.submitButton.Click();

            //Assert that there is no error message
            Assert.Throws<NoSuchElementException>(delegate { driver.FindElement(By.XPath("//*[@id=\"post-49\"]/div/p")); });

        }

        [Test]
        [Description("Test verifies whether password mismatch is caught in case Password is shorter than Confirm password")]
        public void PasswordMismatchPasswordShorterThanConfirmPassword()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find Password and clear it
            registrationPage.password.Clear();
            registrationPage.password.SendKeys("123456789");

            //Find Confirm Password and fill it
            registrationPage.confirmPassword.Clear();
            registrationPage.confirmPassword.SendKeys("1234567890");

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert error message
            registrationPage.AssertErrorMessagePasswordsDoNotMatch("* Fields do not match");

        }

        [Test]
        [Description("Test verifies whether password mismatch is caught in Mismatch field")]
        public void PasswordMismatchField()
        {
            var registrationPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(registrationPage.URL);

            //Find Password and clear it
            registrationPage.password.Clear();
            registrationPage.password.SendKeys("123456789");

            //Find Confirm Password and fill it
            registrationPage.confirmPassword.Clear();
            registrationPage.confirmPassword.SendKeys("1234567890");

            //Find and Click Submit
            registrationPage.submitButton.Click();

            //Assert error message
            registrationPage.AssertErrorMessagePasswordStrength("Mismatch");

        }
    }
}
