using NUnit.Framework;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using APITest;
using DataModel;
using System.Configuration;

namespace UserStory2Tests
{
    [TestFixture]
    public class WhenUserRequestsADirectorsFilmography_WithAValidDirector
    {
        public FilmService _filmService;
        Result _films = new Result();
        [OneTimeSetUp]
        public async Task Setup()
        {
            _filmService = new FilmService(new CallManager());
            _films = await _filmService.CallManager.RequestFilmography("Anthony Russo");
        }

        [Test]
        public void StatusIs_200()
        {
            Assert.That(_filmService.CallManager.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void StatusDescriptionIs_OK()
        {
            Assert.That(_filmService.CallManager.StatusDescription, Is.EqualTo("OK"));
        }

        [Test]
        public void ReturnedFilmsHaveCorrectDirector()
        {
            var test = _films.result;
            Assert.That(_films.result[0].directors, Is.EqualTo("Anthony Russo"));
        }
    }

    [TestFixture]
    public class WhenUserRequestsADirectorsFilmography_WithAnInValidDirector
    {
        public FilmService _filmService;
        Result _films = new Result();
        [OneTimeSetUp]
        public async Task Setup()
        {
            _filmService = new FilmService(new CallManager());
            _films = await _filmService.CallManager.RequestFilmography("Nobody");
        }

        [Test]
        public void StatusIs_200()
        {
            Assert.That(_filmService.CallManager.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void StatusDescriptionIs_OK()
        {
            Assert.That(_filmService.CallManager.StatusDescription, Is.EqualTo("OK"));
        }

        [Test]
        public void ReturnsEmptyObject()
        {
            Assert.That(_films.result, Is.Empty);
        }
    }
}