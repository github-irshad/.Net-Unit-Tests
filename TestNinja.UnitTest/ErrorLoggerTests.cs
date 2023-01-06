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

        [Test]
        public void Log_ValidException_ErrorLogging(){
            var id = Guid.Empty;
            errorLogger.ErrorLogged += (sender,args) => {id = args;};

            errorLogger.Log("error");

            Assert.That(id,Is.Not.EqualTo(Guid.Empty));
        }

    }
}