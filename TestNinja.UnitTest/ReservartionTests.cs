
using NUnit.Framework;
using TestNinja5.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            var reservationObject = new Reservation();
            var result = reservationObject.CanBeCancelledBy(new User { IsAdmin = true});
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_SameUser_ReturnsTrue()
        {
            var user = new User();
            var reservationObject = new Reservation(){
                MadeBy = user
            };
            var result = reservationObject.CanBeCancelledBy(user);
            
            Assert.That(result,Is.True);
        }

        [Test]
        public void CanBeCancelledBy_OtherUser_ReturnsFalse()
        {
            var user = new User();
            var reservationObject = new Reservation(){MadeBy = new User()};

            var result = reservationObject.CanBeCancelledBy(user);

            Assert.IsFalse(result);
        }
    }
}
