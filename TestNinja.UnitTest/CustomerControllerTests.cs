using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja5.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_idIsZero_ReturnsNotFound(){
            var customer = new CustomerController();

            var result = customer.GetCustomer(0);

            Assert.That(result,Is.TypeOf<NotFound>());
            Assert.That(result,Is.InstanceOf<NotFound>());
        } 

        [Test]
        public void GetCustomer_idIsNotZero_ReturnsOk(){
            var customer = new CustomerController();

            var result = customer.GetCustomer(1);

            Assert.That(result,Is.InstanceOf<Ok>());
            Assert.That(result,Is.TypeOf<Ok>());
        }
    }
}