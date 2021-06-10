using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APITest;
using DataModel;
using NUnit.Framework;

namespace UserTest1Test
{
    public class WhenAFilmWithAValidFilmIdIsRequested
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
        public void StatusDescription200Is_OK()
        {
            Assert.That(_filmService.CallManager.StatusDescription, Is.EqualTo("OK"));
        }
    }

    public class WhenAFilmWithAInvalidFilmIdOrStringIsRequested
    {
        public FilmService _filmService;
        [OneTimeSetUp]
        public async Task Setup()
        {
            _filmService = new FilmService(new CallManager());
            await _filmService.MakeRequestAsync("10");
        }

        [Test]
        public void StatusIs_404()
        {
            Assert.That(_filmService.CallManager.StatusCode, Is.EqualTo(404));
        }

        [Test]
        public void StatusDescription404Is_OK()
        {
            Assert.That(_filmService.CallManager.StatusDescription, Is.EqualTo("Not Found"));
        }
    }

    public class WhenAFilmIsRequestedCorrectDataIsPresented
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
        public void GetCorrectFilmTitle()
        {
            Assert.That(_film.result[0].title, Is.EqualTo("Avengers: Endgame"));
        }

        [Test]
        public void GetCorrectFilmDirector()
        {
            Assert.That(_film.result[0].directors, Is.EqualTo("Anthony Russo"));
        }

        [Test]
        public void GetCorrectFilmActors()
        {
            int i = 0;
            string[] actors = { "Robert Downey Jr.", "Chris Evans", "Chris Hemsworth", "Mark Ruffalo" };
            foreach (var item in _film.result[0].actors)
            {
                Assert.That(item, Is.EqualTo(actors[i]));
                i++;
            }
        }
    }

    public class WhenAnAlternativeFilmIsRequestedCorrectDataIsPresented
    {
        public ICallable _filmService;
        Result _film = new Result();
        [OneTimeSetUp]
        public async Task Setup()
        {
            _filmService = new CallManager();
            _film = await _filmService.Request("The Conjuring 3: The Devil Made Me Do It");
        }

        [Test]
        public void GetCorrectFilmTitle()
        {
            Assert.That(_film.result[0].title, Is.EqualTo("The Conjuring 3: The Devil Made Me Do It"));
        }

        [Test]
        public void GetCorrectFilmDirector()
        {
            Assert.That(_film.result[0].directors, Is.EqualTo("Michael Chaves"));
        }

        [Test]
        public void GetCorrectFilmActors()
        {
            int i = 0;
            string[] actors = { "Patrick Wilson", "Vera Farmiga", "Ruairi O'Connor", "Sarah Catherine Hook" };
            foreach (var item in _film.result[0].actors)
            {
                Assert.That(item, Is.EqualTo(actors[i]));
                i++;
            }
        }
    }

}
