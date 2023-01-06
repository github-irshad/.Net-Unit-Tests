
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja5.Fundamentals;


namespace TestNinja.UnitTest
{
    [TestFixture]

    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp(){
            _math = new Math();
        }

        [Test]
        [Ignore("Add method Ignored")]   
        public void Add_WhenCalling_ReturnSumOfArgs(){            

            var result = _math.Add(1,2);

            Assert.That(result,Is.EqualTo(3));        
        }

        [Test]
        [TestCase(1,2,2)]
        [TestCase(2,1,2)]
        [TestCase(1,1,1)]
        
        public void Max_WhenCalled_ReturnGreaterArgs(int a , int b, int expected){
            

            var result = _math.Max(a,b);

            Assert.That(result,Is.EqualTo(expected));
        }

        [Test]
        public void GetOddNumbers_limitGreaterthanzero_OddNumbersReturns(){
            var result =_math.GetOddNumbers(5);

            Assert.That(result.Count,Is.EqualTo(3));

            Assert.That(result,Is.Not.Empty);

            Assert.That(result,Does.Contain(1));
            Assert.That(result,Does.Contain(3));
            Assert.That(result,Does.Contain(5));

            Assert.That(result,Is.EquivalentTo(new [] {1,3,5}));
        }
    }
}