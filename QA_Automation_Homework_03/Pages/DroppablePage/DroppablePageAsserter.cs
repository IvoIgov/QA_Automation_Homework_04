using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_03.Pages.DroppablePage
{
    public static class DroppablePageAsserter
    {
        public static void AssertDroppablePageIsOpen(this DroppablePage page, string text)
        {
            Assert.AreEqual(text, page.Header.Text);
        }

        public static void AssertSourceDroppedOnTarget(this DroppablePage page, string text)
        {
            Assert.IsTrue(page.SourceDroppedOnTarget.Displayed);
            StringAssert.Contains(text, page.SourceDroppedOnTarget.Text);
        }

        public static void AssertAcceptSourceDroppedOnTarget(this DroppablePage page, string text)
        {
            Assert.IsTrue(page.AcceptSourceDroppedOnTarget.Displayed);
            StringAssert.Contains(text, page.AcceptSourceDroppedOnTarget.Text);
        }

        public static void AssertAcceptSourceNotDroppedOnTarget(this DroppablePage page, string text)
        {
            Assert.IsTrue(page.AcceptSourceDroppedOnTarget.Displayed);
            StringAssert.Contains(text, page.AcceptSourceDroppedOnTarget.Text);
        }

        public static void AssertPreventPropagationSourceDroppedOnTarget(this DroppablePage page, string text)
        {
            Assert.IsTrue(page.PreventPropagationSourceDroppedOnTarget.Displayed);
            StringAssert.Contains(text, page.PreventPropagationSourceDroppedOnTarget.Text);
        }
    }
}
