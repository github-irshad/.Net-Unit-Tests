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
        [Test]
        public void Log_WhenCalled_SetLastErrorProp(){
            var logger = new ErrorLogger();
            logger.Log("error");

            Assert.That(logger.LastError,Is.EqualTo("error"));
        }
        
    }
}