
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
        [Test]   
        public void Add_WhenCalling_ReturnSumOfArgs(){
            var math = new Math();

            var result = math.Add(1,2);

            Assert.That(result,Is.EqualTo(3));
            
        }
    }
}