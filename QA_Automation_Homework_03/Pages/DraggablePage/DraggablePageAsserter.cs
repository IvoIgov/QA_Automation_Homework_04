using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Automation_Homework_03.Pages.DraggablePage
{
    public static class DraggablePageAsserter
    {
        public static void AssertDraggablePageIsOpen(this DraggablePage page, string text)
        {
            Assert.AreEqual(text, page.Header.Text);
        }

        public static void AssertDragBoxMovedRight(this DraggablePage page, string text)
        {
            Assert.AreEqual(text, page.Header.Text);
        }
    }
}
