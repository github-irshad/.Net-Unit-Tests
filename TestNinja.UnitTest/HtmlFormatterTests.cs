using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja5.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void HtmlFormatter_WhenCalled_ReturnBoldString()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("Aabc");

            Assert.That(result,Is.EqualTo($"<strong>aabc</strong>").IgnoreCase);

            Assert.That(result,Does.StartWith($"<strong>").IgnoreCase);
            Assert.That(result,Does.EndWith($"</strong>").IgnoreCase);
            Assert.That(result,Does.Contain("aabc").IgnoreCase);
        }
        
    }
}