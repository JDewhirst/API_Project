using NUnit.Framework;
 
namespace UserStory1Test
{
    public class WhenAFilmWithAValidFilmIdIsRequested
    {
        //temp variabless
        private string _placeholderString200 = "200";
        private string _placeholderString200Description = "OK";

        [Test]
        public void StatusIs_200()
        {
            Assert.That(_placeholderString200, Is.EqualTo("200"));
            Assert.That(_placeholderString200Description, Is.EqualTo("OK"));
        }
        
        [Test]
        public void StatusDescriptionIs_OK()
        {
            Assert.That(_placeholderString200, Is.EqualTo("200"));
            Assert.That(_placeholderString200Description, Is.EqualTo("OK"));
        }
    }

    public class WhenAFilmWithAInvalidFilmIdOrStringIsRequested
    {
        //temp variabless
        private string _placeholderString404 = "400";
        private string _placeholderString404Description = "Not Found";

        [Test]
        public void StatusIs_400()
        {
            Assert.That(_placeholderString404, Is.EqualTo("200"));
        }

        [Test]
        public void StatusDescriptionIs_OK()
        {
            Assert.That(_placeholderString404Description, Is.EqualTo("OK"));
        }
    }
}