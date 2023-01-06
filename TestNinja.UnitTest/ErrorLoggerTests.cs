using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja5.Fundamentals;

namespace TestNinja.UnitTest
{


    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger errorLogger;

        [SetUp]
        public void SetUp()
        {
            errorLogger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetLastErrorProp()
        {
           
            errorLogger.Log("error");

            Assert.That(errorLogger.LastError, Is.EqualTo("error"));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        [TestCase(" ")]
        public void Log_InvalidInput_ExcceptionThrows(string error)
        {
            

            Assert.That(() => errorLogger.Log(error), Throws.ArgumentNullException);

        }

    }
}