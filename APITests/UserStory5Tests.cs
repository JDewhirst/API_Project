using NUnit.Framework;
using APITest;
using System.Threading.Tasks;
using DataModel; 

namespace UserStory5Tests
{
    public class WhenADeleteRequestIsMadeWithAValidID
    {
        public FilmService _filmService;
        [OneTimeSetUp]
        public async Task Setup()
        {
            _filmService = new FilmService(new CallManager());
            await _filmService.MakeRequestAsync("1");
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
    }

    public class WhenADeleteRequestIsMadeWithAnInvalidID
    {

        public FilmService _filmService;
        [OneTimeSetUp]
        public async Task Setup()
        {
            _filmService = new FilmService(new CallManager());
            await _filmService.MakeRequestAsync("50");
        }

        [Test]
        public void StatusIs_404()
        {
            Assert.That(_filmService.CallManager.StatusCode, Is.EqualTo(404));
        }

        [Test]
        public void StatusDescriptionIs_NotFound()
        {
            Assert.That(_filmService.CallManager.StatusDescription, Is.EqualTo("Not Found"));
        }
    }
}

namespace UserStory1Tests
{
    public class WhenUpdateRequestRequestIsMadeWithAValidID
    {
        public ICallable _filmService;
        Result _film = new Result();
        [OneTimeSetUp]
        public async Task Setup()
        {
            _filmService = new CallManager();
            _film = await _filmService.Request("Avengers: Endgame");
        }

        [Test]
        public void StatusIs_200()
        {

            Assert.That(_filmService.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void StatusDescriptionIs_OK()
        {
            Assert.That(_filmService.StatusDescription, Is.EqualTo("OK"));
        }

        [Test]
        public void RequestTitleReturnsCorrectFilm()
        {
            Assert.That(_film.result[0].title, Is.EqualTo("Avengers: Endgame"));
        }
    }

    public class WhenUpdateRequestRequestIsMadeWithInValidID
    {

        public FilmService _filmService;
        [OneTimeSetUp]
        public async Task Setup()
        {
            _filmService = new FilmService(new CallManager());
            await _filmService.MakeRequestAsync("50");
        }

        [Test]
        public void StatusIs_404()
        {
            Assert.That(_filmService.CallManager.StatusCode, Is.EqualTo(404));
        }

        [Test]
        public void StatusDescriptionIs_NotFound()
        {
            Assert.That(_filmService.CallManager.StatusDescription, Is.EqualTo("Not Found"));
        }
    }
}

namespace UserStory4Tests
{
    public class WhenUpdateRequestRequestIsMadeWithAValidID
    {
        public FilmService _filmService;
        [OneTimeSetUp]
        public async Task Setup()
        {
            _filmService = new FilmService(new CallManager());
            await _filmService.MakeRequestAsync("1");
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
    }

    public class WhenUpdateRequestRequestIsMadeWithInValidID
    {

        public FilmService _filmService;
        [OneTimeSetUp]
        public async Task Setup()
        {
            _filmService = new FilmService(new CallManager());
            await _filmService.MakeRequestAsync("50");
        }

        [Test]
        public void StatusIs_404()
        {
            Assert.That(_filmService.CallManager.StatusCode, Is.EqualTo(404));
        }

        [Test]
        public void StatusDescriptionIs_NotFound()
        {
            Assert.That(_filmService.CallManager.StatusDescription, Is.EqualTo("Not Found"));
        }
    }
}