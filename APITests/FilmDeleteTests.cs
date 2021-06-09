using NUnit.Framework;
 
namespace APITests
{
    public class WhenADeleteRequestIsMadeWithAValidID
    {
        [OneTimeSetUp]
        public void Setup()
        {
        }

        [Test]
        public void StatusIs_200()
        {
            Assert.Fail();
        }

        [Test]
        public void StatusDescriptionIs_OK()
        {
            Assert.Fail();
        }
    }

    public class WhenADeleteRequestIsMadeWithAnInvalidID
    { 
        [Test]
        public void StatusIs_404()
        {
            Assert.Fail();
        }

        [Test]
        public void StatusDescriptionIs_NotFound()
        {
            Assert.Fail();
        }
    }
}